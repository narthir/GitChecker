Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Reflection

Module Main
    Sub Main()
        Application.Run(New MainController)
    End Sub

    Public ReadOnly Property LogEntries As New List(Of String)

    Public Sub Log(ex As Exception)
        Log(ex.ToString)
        MsgBox(ex.ToString)
    End Sub

    Public Sub Log(text As String)
        _LogEntries.Add(String.Concat(Now.ToShortDateString, " ", Now.ToShortTimeString, " - ", text))
    End Sub
End Module


Public Class MainController
    Inherits ApplicationContext

    Private ni As NotifyIcon
    Private parentDirectories As New List(Of DirectoryInfo)
    Private repositories As New List(Of Repository)
    Private repoList As New F_RepositoryList
    Private WithEvents remoteRefreshTimer As New Timer

    Private hasChangedReposIco = New Icon(Assembly.GetEntryAssembly().GetManifestResourceStream("GitChecker.Git-Icon-Orange.ico"))
    Private noChangedReposIco = New Icon(Assembly.GetEntryAssembly().GetManifestResourceStream("GitChecker.Git-Icon-White.ico"))



    Private Shared _instance As MainController
    Public Shared ReadOnly Property I As MainController
        Get
            Return _instance
        End Get
    End Property

    Friend Sub SetShowInTaskbar(showInTaskbar As Boolean)
        repoList.ShowInTaskbar = showInTaskbar
    End Sub

    Friend Sub SetRemoteRefreshInterval(interval As TimeSpan)
        If interval.TotalMilliseconds = 0 Then
            remoteRefreshTimer.Stop()
        Else
            remoteRefreshTimer.Interval = interval.TotalMilliseconds
            remoteRefreshTimer.Start()
        End If
    End Sub

    Public Sub New()
        _instance = Me
        ni = New NotifyIcon()
        ni.Icon = noChangedReposIco

        setRepositories().Wait()

        repoList.ShowInTaskbar = My.Settings.ShowInTaskbar


        Dim s As Screen = Screen.FromPoint(New Point(Cursor.Position.X, Cursor.Position.Y))
        With repoList
            If My.Settings.ListLocation = Point.Empty Then
                My.Settings.ListLocation = New Point(s.Bounds.Width - .Width - 10, s.WorkingArea.Height - .Height - 10)
            End If
            .Height = s.WorkingArea.Height - 20
            .Location = My.Settings.ListLocation
        End With



        If My.Settings.ShowOnStartup Then repoList.Show()

        AddHandler ni.MouseClick, Sub(sender As Object, e As MouseEventArgs)
                                      If e.Button = MouseButtons.Left Then
                                          If repoList.Visible = True Then
                                              repoList.Hide()
                                          Else
                                              repoList.Show()
                                              repoList.Activate()
                                          End If
                                      End If
                                  End Sub


        AddHandler remoteRefreshTimer.Tick, Sub()
                                                Task.Run(Sub()
                                                             SyncAllRemoteRepositories()
                                                         End Sub)
                                            End Sub
        Task.Run(Sub()
                     Threading.Thread.Sleep(10000)
                     SyncAllRemoteRepositories()
                 End Sub)

        SetRemoteRefreshInterval(My.Settings.RemoteRefreshInterval)

        ni.ContextMenuStrip = New ContextMenuStrip

        Dim openItem As New ToolStripMenuItem("Open")
        ni.ContextMenuStrip.Items.Add(openItem)
        AddHandler openItem.Click, Sub()
                                       repoList.Show()
                                   End Sub

        Dim exitItm As New ToolStripMenuItem("Exit")
        ni.ContextMenuStrip.Items.Add(exitItm)
        AddHandler exitItm.Click, AddressOf [Exit]

        ni.Visible = True
    End Sub

    Private Async Function setRepositories() As Task
        parentDirectories.Clear()

        Dim paths As List(Of String) = My.Settings.ParentDirectories.Split("|", options:=StringSplitOptions.RemoveEmptyEntries).ToList
        paths.ForEach(Sub(path)
                          Dim di As New DirectoryInfo(path)
                          If di.Exists Then parentDirectories.Add(di)
                      End Sub)

        Dim tmpRepositories As New List(Of Repository)
        parentDirectories.ForEach(Sub(parent) tmpRepositories.AddRange(getRepositories(parent)))

        Dim remRepositories As New List(Of Repository)
        For Each repoOld In repositories
            If tmpRepositories.Select(Function(x) x.Location.FullName).Contains(repoOld.Location.FullName) = False Then
                remRepositories.Add(repoOld)
            End If
        Next
        remRepositories.ForEach(Sub(repo)
                                    repositories.Remove(repo)
                                    repo.Dispose()
                                End Sub)

        Dim newRepositories As New List(Of Repository)
        For Each repoNew In tmpRepositories
            If repositories.Select(Function(x) x.Location.FullName).Contains(repoNew.Location.FullName) = False Then
                newRepositories.Add(repoNew)
            End If
        Next
        repositories.AddRange(newRepositories)

        For Each repo In newRepositories
            AddHandler repo.UpdateFinished, Sub()
                                                UpdateIcon()
                                            End Sub
            repo.UpdateLocalData()
        Next


        repoList.SetRepositories(repositories, remRepositories, newRepositories)
    End Function


    Public Sub UpdateIcon()
        Dim anyChanges = repositories.Where(Function(x) x.AnyChanges).Any
        If anyChanges AndAlso ni.Icon Is noChangedReposIco Then
            ni.Icon = hasChangedReposIco
        ElseIf anyChanges = False AndAlso ni.Icon Is hasChangedReposIco Then
            ni.Icon = noChangedReposIco
        End If
    End Sub

    Friend Async Function ReloadRepos() As Task
        Await setRepositories()
        Await Task.Run(Sub()
                           SyncAllRemoteRepositories()
                       End Sub)
    End Function

    Public Sub SyncAllRemoteRepositories()
        Try
            repoList.ToggleRefreshButton(False)
            Debug.WriteLine("----  Starting  SyncAllRemoteRepositories   -----")
            Dim reposToSync = repositories.ToList
            While reposToSync.Any
                Dim batch = reposToSync.TakeAndRemove(3)
                Dim tasks As New List(Of Task)
                tasks.Add(Task.Delay(3000))
                batch.ForEach(Async Sub(repo)
                                  Await repo.UpdateRemoteData()
                              End Sub)
                Task.WaitAll(tasks.ToArray)
            End While
            Debug.WriteLine("----  Finished  SyncAllRemoteRepositories   -----")
        Catch ex As Exception
            Log(ex)
        Finally
            repoList.ToggleRefreshButton(True)
        End Try
    End Sub

    Private Function getRepositories(parent As DirectoryInfo) As List(Of Repository)
        Dim l As New List(Of Repository)
        For Each subDir In parent.GetDirectories
            If subDir.GetDirectories.Where(Function(x) x.Name = ".git").Any Then
                l.Add(New Repository(subDir))
            End If
        Next
        Return l
    End Function

    Public Sub [Exit]()
        My.Settings.Save()
        ni.Visible = False
        ni.Icon.Dispose()
        ni.Dispose()
        Environment.Exit(0)
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        MyBase.Dispose(disposing)
        Task.Run(Sub()
                     Threading.Thread.Sleep(2000)
                     Environment.Exit(0)
                 End Sub)
    End Sub

End Class
