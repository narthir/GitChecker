Public Class F_RepositoryList

    Private repoItems As New List(Of UC_RepositoryItem)
    Private isPinned As Boolean = False
    Private filterOnlyChanged As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.isPinned = My.Settings.IsPinned
        Me.filterOnlyChanged = My.Settings.FilterOnlyChanged
        setPinned(False)
        setFilterChanged(False)

        Dim s As Screen = Screen.FromPoint(New Point(Cursor.Position.X, Cursor.Position.Y))
        Me.Height = s.WorkingArea.Height - 20
        Me.Location = New Point(s.Bounds.Width - Me.Width - 10, s.WorkingArea.Height - Me.Height - 10)

        AddHandler Me.Deactivate, Sub()
                                      If isPinned = False Then Me.Hide()
                                  End Sub

    End Sub

    Public Sub SetRepositories(repos As List(Of Repository))
        For Each repoItem In repoItems
            FLP_RepositoryList.Controls.Remove(repoItem)
            repoItem.Dispose()
        Next
        Dim isTopItem As Boolean = True
        For Each repo In repos.OrderBy(Function(x) x.Name)
            Dim uc As New UC_RepositoryItem(repo, isTopItem)
            uc.Width = FLP_RepositoryList.Width - 20
            repoItems.Add(uc)
            isTopItem = False
            AddHandler repo.UpdateFinished, Sub(r)
                                                If uc.IsAlive Then
                                                    uc.Invoke(Sub() uc.Visible = isRepoItemVisible(uc))
                                                End If
                                            End Sub
        Next
        repoItems.ForEach(Sub(x)
                              If FLP_RepositoryList.InvokeRequired Then
                                  FLP_RepositoryList.Invoke(Sub() FLP_RepositoryList.Controls.Add(x))
                              Else
                                  FLP_RepositoryList.Controls.Add(x)
                              End If
                          End Sub)
        filter()
    End Sub

    Private Sub F_RepoList_Shown(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Dim s As Screen = Screen.FromPoint(New Point(Cursor.Position.X, Cursor.Position.Y))
            Me.Height = s.WorkingArea.Height - 20
            Me.Location = New Point(s.Bounds.Width - Me.Width - 10, s.WorkingArea.Height - Me.Height - 10)
            filter()
        End If
    End Sub

    Private Sub setPinned(toggle As Boolean)
        If toggle = True Then Me.isPinned = Not Me.isPinned
        If Me.isPinned Then
            Me.TopMost = True
            B_Pin.BackgroundImage = My.Resources.unpin_2_16
        Else
            Me.TopMost = False
            B_Pin.BackgroundImage = My.Resources.pin_3_16
        End If
        My.Settings.IsPinned = Me.isPinned
        My.Settings.Save()
    End Sub

    Private Sub setFilterChanged(toggle As Boolean)
        If toggle = True Then Me.filterOnlyChanged = Not Me.filterOnlyChanged
        If Me.filterOnlyChanged Then
            B_FilterOnlyChanged.BackgroundImage = My.Resources.star_27_16
        Else
            B_FilterOnlyChanged.BackgroundImage = My.Resources.edit_12_16
        End If
        My.Settings.FilterOnlyChanged = Me.filterOnlyChanged
        My.Settings.Save()
        filter()
    End Sub

    Private Sub B_Settings_Click(sender As Object, e As EventArgs) Handles B_Settings.Click
        F_Settings.ShowDialog()
        F_Settings.Activate()
    End Sub

    Private Sub B_Close_Click(sender As Object, e As EventArgs) Handles B_Close.Click
        Me.Hide()
    End Sub

    Private Sub B_Pin_Click_1(sender As Object, e As EventArgs) Handles B_Pin.Click
        setPinned(True)
    End Sub

    Private Sub B_Refresh_Click(sender As Object, e As EventArgs) Handles B_Refresh.Click
        Task.Run(Sub() MainController.I.ReloadRepos())
    End Sub

    Private Sub TE_Filter_TextChanged(sender As Object, e As EventArgs) Handles TE_Filter.TextChanged
        filter()
    End Sub

    Private Sub filter()
        Me.SuspendLayout()
        FLP_RepositoryList.SuspendLayout()
        repoItems.ForEach(Sub(repoItm)
                              repoItm.Visible = isRepoItemVisible(repoItm)
                          End Sub)
        FLP_RepositoryList.ResumeLayout()
        Me.ResumeLayout()
    End Sub

    Private Function isRepoItemVisible(repoItm As UC_RepositoryItem) As Boolean
        Dim visible As Boolean = True
        If TE_Filter.Text <> String.Empty Then
            If Not repoItm.Repository.Name.ToLower Like String.Format("*{0}*", TE_Filter.Text) Then
                visible = False
            End If
        End If

        If Me.filterOnlyChanged AndAlso repoItm.Repository.AnyChanges = False Then
            visible = False
        End If
        Return visible
    End Function

    Private Sub B_FilterWithChanges_Click(sender As Object, e As EventArgs) Handles B_FilterOnlyChanged.Click
        setFilterChanged(True)
    End Sub
End Class