Imports System.IO
Imports System.Threading

Public Class Repository
    Implements IDisposable

    Private watcherEventQueHandler As New EventQueueHandler(TimeSpan.FromMilliseconds(1500))

    Public Sub New(location As DirectoryInfo)
        Me.Location = location

        watcher = New FileSystemWatcher()
        watcher.IncludeSubdirectories = True
        watcher.Path = Me.Location.FullName
        watcher.NotifyFilter = NotifyFilters.LastWrite + NotifyFilters.CreationTime + NotifyFilters.FileName
        watcher.Filter = "*.*"

        AddHandler watcherEventQueHandler.TimeoutReached, AddressOf UpdateLocalData
        Dim ulcSub = Sub() watcherEventQueHandler.AppendAndResetTimer(Nothing, Nothing)

        AddHandler watcher.Changed, ulcSub
        AddHandler watcher.Deleted, ulcSub
        AddHandler watcher.Renamed, ulcSub
        AddHandler watcher.Created, ulcSub

        watcher.EnableRaisingEvents = True
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Name
    End Function

    Public Enum CommitState
        Unknown = 0
        HasChanges = 1
        HasUntracked = 2
    End Enum

    Public ReadOnly Property UncommitedStates As New List(Of CommitState)
    Public ReadOnly Property LocalBranches As New List(Of LocalBranch)
    Public ReadOnly Property Location As DirectoryInfo

    Public ReadOnly Property Name As String
        Get
            Return Location.Name
        End Get
    End Property

    Public ReadOnly Property AnyChanges As Boolean
        Get
            If UncommitedStates.Contains(CommitState.HasChanges) Then Return True
            If UncommitedStates.Contains(CommitState.HasUntracked) Then Return True
            If LocalBranches.Select(Function(x) x.Ahead + x.Behind).Sum > 0 Then Return True
            Return False
        End Get
    End Property

    Private WithEvents watcher As FileSystemWatcher

    Public Event UpdateFinished(sender As Repository)
    Public Event UpdateStarted(sender As Repository)

    Async Function UpdateLocalData() As Task
        Try
            RaiseEvent UpdateStarted(Me)
            watcher.EnableRaisingEvents = False
            Await UpdateLocalBranches()
            Await UpdateUncommitedState()
        Finally
            watcher.EnableRaisingEvents = True
            RaiseEvent UpdateFinished(Me)
        End Try
    End Function
    Private Async Function UpdateUncommitedState() As Task
        Try
            Dim proc = getGitProc()
            proc.StartInfo.Arguments &= "diff --shortstat"
            Dim shortStatsResults As New List(Of String)
            Using cc As New ConsoleController(proc, Sub(x)
                                                        shortStatsResults.Add(x)
                                                    End Sub)
                Await cc.Run
            End Using
            shortStatsResults.DebugWriteLineAll(Me.Name & " : Uncommited: {0}")

            proc = getGitProc()
            proc.StartInfo.Arguments &= "ls-files --others --exclude-standard"
            Dim otherResults As New List(Of String)
            Using cc = New ConsoleController(proc, Sub(x)
                                                       otherResults.Add(x)
                                                   End Sub)
                Await cc.Run
            End Using
            otherResults.DebugWriteLineAll(Me.Name & " : Untracked: {0}")

            UncommitedStates.Clear()

            If shortStatsResults.Any Then
                UncommitedStates.Add(CommitState.HasChanges)
            End If
            If otherResults.Any Then
                UncommitedStates.Add(CommitState.HasUntracked)
            End If
        Catch ex As Exception
            UncommitedStates.Clear()
            UncommitedStates.Add(CommitState.Unknown)
            Log(ex)
        End Try
    End Function

    Public Async Function PullAll() As Task
        Try
            RaiseEvent UpdateStarted(Me)
            Dim results As New List(Of String)
            Dim proc = getGitProc()
            proc.StartInfo.Arguments &= "pull --all"
            Using cc As New ConsoleController(proc, Sub(x)
                                                        results.Add(x)
                                                    End Sub)
                Await cc.Run
            End Using
            results.DebugWriteLineAll(Me.Name & " : PulledAll : {0}")
            RaiseEvent UpdateFinished(Me)
            Await UpdateLocalBranches()
        Catch ex As Exception
            Log(ex)
            Throw
        End Try
    End Function

    Private Async Function UpdateLocalBranches() As Task
        RaiseEvent UpdateStarted(Me)
        Try
            Dim proc = getGitProc()
            proc.StartInfo.Arguments &= "for-each-ref --format=""%(HEAD)|%(refname:short)|%(upstream:track)"" refs/heads"
            Dim branchesResults As New List(Of String)
            Using cc = New ConsoleController(proc, Sub(x)
                                                       branchesResults.Add(x)
                                                   End Sub)
                Await cc.Run
            End Using
            branchesResults.DebugWriteLineAll(Me.Name & " : Branches : {0}")

            Dim branches As New List(Of LocalBranch)
            branchesResults.ForEach(Sub(x)
                                        'output example  *|master|[ahead 2, behind 1]
                                        Try
                                            Dim parts = x.Split("|", options:=StringSplitOptions.None)
                                            Dim locBranch As LocalBranch = Nothing
                                            Dim isCurrent = (parts(0) = "*")
                                            Dim name = parts(1)
                                            Dim ahead As Integer = 0
                                            Dim behind As Integer = 0
                                            If parts(2).Contains("ahead") AndAlso parts(2).Contains("behind") Then
                                                parts(2) = parts(2).Replace("[", "").Replace("]", "")
                                                parts(2) = parts(2).Replace("ahead", "").Replace("behind", "")
                                                Dim subParts = parts(2).Split(",")
                                                ahead = CInt(Trim(subParts(0)))
                                                behind = CInt(Trim(subParts(1)))
                                            Else
                                                If parts(2).Contains("ahead") Then
                                                    ahead = CInt(Trim(parts(2).Replace("[ahead ", "").Replace("]", "")))
                                                End If
                                                If parts(2).Contains("behind") Then
                                                    behind = CInt(Trim(parts(2).Replace("[behind ", "").Replace("]", "")))
                                                End If
                                            End If
                                            locBranch = New LocalBranch(name, isCurrent, ahead, behind)
                                            branches.Add(locBranch)
                                        Catch ex As Exception
                                            Log(ex)
                                        End Try
                                    End Sub)
            Me._LocalBranches = branches
        Catch ex As Exception
            Log(ex)
        End Try
        RaiseEvent UpdateFinished(Me)
    End Function
    Async Function UpdateRemoteData() As Task
        Try
            RaiseEvent UpdateStarted(Me)
            Dim results As New List(Of String)
            Dim proc = getGitProc()
            proc.StartInfo.Arguments &= "remote -v update"
            Using cc As New ConsoleController(proc, Sub(x)
                                                        results.Add(x)
                                                    End Sub)
                Await cc.Run
            End Using
            results.DebugWriteLineAll(Me.Name & " : UpdateRemoteData : {0}")
            RaiseEvent UpdateFinished(Me)
            Await UpdateLocalBranches()
        Catch ex As Exception
            Log(ex)
            Throw
        End Try
    End Function

    Private Function getGitProc() As Process
        Dim procInfo As New ProcessStartInfo
        procInfo.FileName = Environment.ExpandEnvironmentVariables(My.Settings.GitLocation)
        procInfo.Arguments = String.Format("--git-dir=""{0}\.git"" --work-tree=""{0}"" ", Me.Location.FullName)
        Dim proc As New Process() With {.StartInfo = procInfo}
        Return proc
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                watcher.EnableRaisingEvents = False
                watcher.Dispose()
            End If
        End If
        disposedValue = True
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub
#End Region


End Class
