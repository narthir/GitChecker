Imports System.IO
Imports System.Reflection

Module Main
    Sub Main()
        Application.Run(New MainController)
    End Sub

    Public Sub LogError(ex As Exception)
        MsgBox(ex.ToString)
    End Sub
End Module


Public Class MainController
    Inherits ApplicationContext

    Private ni As NotifyIcon
    Private parentDirectories As New List(Of DirectoryInfo)
    Private repositories As New List(Of Repository)
    Private repoList As New F_RepositoryList
    Private WithEvents remoteRefreshTimer As New Timer

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
        ni.Icon = New Icon(Assembly.GetEntryAssembly().GetManifestResourceStream("GitChecker.Git-Icon-White.ico"))
        ni.Visible = True


        setRepositories()
        repoList.ShowInTaskbar = My.Settings.ShowInTaskbar
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
                                                SyncAllRemoteRepositories()
                                            End Sub
        Task.Run(Sub() SyncAllRemoteRepositories())

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

    End Sub

    Private Sub setRepositories()
        parentDirectories.Clear()
        repositories.ForEach(Sub(x) x.Dispose())
        repositories.Clear()

        Dim paths As List(Of String) = My.Settings.ParentDirectories.Split("|", options:=StringSplitOptions.RemoveEmptyEntries).ToList
        paths.ForEach(Sub(path)
                          Dim di As New DirectoryInfo(path)
                          If di.Exists Then parentDirectories.Add(di)
                      End Sub)
        parentDirectories.ForEach(Sub(parent) repositories.AddRange(getRepositories(parent)))
        repoList.SetRepositories(repositories)

        For Each repo In repositories
            AddHandler repo.Changed, Sub()
                                         UpdateIcon()
                                     End Sub
            repo.UpdateLocalData()
        Next
    End Sub

    Public Sub UpdateIcon()
        If repositories.Where(Function(x) x.AnyChanges).Any Then
            ni.Icon = New Icon(Assembly.GetEntryAssembly().GetManifestResourceStream("GitChecker.Git-Icon-Orange.ico"))
        Else
            ni.Icon = New Icon(Assembly.GetEntryAssembly().GetManifestResourceStream("GitChecker.Git-Icon-White.ico"))
        End If
    End Sub

    Friend Sub ReloadRepos()
        setRepositories()
    End Sub

    Public Sub SyncAllRemoteRepositories()
        Dim reposToSync = repositories.ToList
        While reposToSync.Any
            Dim batch = reposToSync.TakeAndRemove(1)
            Dim tasks As New List(Of Task)
            batch.ForEach(Sub(repo)
                              tasks.Add(Task.Run(Sub()
                                                     repo.UpdateRemoteData()
                                                 End Sub))
                          End Sub)
            Task.WaitAll(tasks.ToArray)
        End While
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

End Class
