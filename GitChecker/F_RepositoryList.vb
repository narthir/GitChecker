Public Class F_RepositoryList

    Private repoItems As New List(Of UC_RepositoryItem)
    Private isPinned As Boolean = False
    Private filterOnlyChanged As Boolean = False
    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer

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

    Public Sub SetRepositories(repos As List(Of Repository), removedRepos As List(Of Repository), newRepos As List(Of Repository))
        FLP_RepositoryList.InvokeGUI(Sub() FLP_RepositoryList.SuspendLayout())
        For Each repoItem In repoItems
            FLP_RepositoryList.InvokeGUI(Sub()
                                             FLP_RepositoryList.Controls.Remove(repoItem)
                                             repoItem.Dispose()
                                         End Sub)
        Next
        For Each repo In repos.OrderBy(Function(x) x.Name)
            Dim uc As New UC_RepositoryItem(repo)
            uc.Width = FLP_RepositoryList.Width - 20
            repoItems.Add(uc)
            AddHandler repo.UpdateFinished, Sub(r)
                                                If uc.IsAlive Then
                                                    uc.InvokeGUI(Sub() uc.Visible = isRepoItemVisible(uc))
                                                End If
                                            End Sub
        Next
        repoItems.ForEach(Sub(x)
                              FLP_RepositoryList.InvokeGUI(Sub() FLP_RepositoryList.Controls.Add(x))
                          End Sub)
        FLP_RepositoryList.InvokeGUI(Sub() FLP_RepositoryList.ResumeLayout())
        filter()
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

    Private Async Sub B_Refresh_Click(sender As Object, e As EventArgs) Handles B_Refresh.Click
        Try
            ToggleRefreshButton(False)
            Await MainController.I.ReloadRepos
        Catch ex As Exception
            Log(ex)
        Finally
            ToggleRefreshButton(True)
        End Try
    End Sub

    Public Sub ToggleRefreshButton(Enabled As Boolean)
        Me.InvokeGUI(Sub()
                         If Enabled Then
                             B_Refresh.Enabled = True
                             B_Refresh.BackColor = Color.Transparent
                         Else
                             B_Refresh.BackColor = Color.Orange
                             B_Refresh.Enabled = False
                         End If
                     End Sub)
    End Sub

    Private Sub TE_Filter_TextChanged(sender As Object, e As EventArgs) Handles TE_Filter.TextChanged
        filter()
    End Sub

    Private Sub filter()
        Me.SuspendLayout()
        FLP_RepositoryList.InvokeGUI(Sub() FLP_RepositoryList.SuspendLayout())
        repoItems.ForEach(Sub(repoItm)
                              If repoItm.IsAlive Then
                                  repoItm.InvokeGUI(Sub() repoItm.Visible = isRepoItemVisible(repoItm))
                              End If
                          End Sub)
        FLP_RepositoryList.InvokeGUI(Sub() FLP_RepositoryList.ResumeLayout())
        Me.ResumeLayout()
    End Sub

    Private Function isRepoItemVisible(repoItm As UC_RepositoryItem) As Boolean
        Dim visible As Boolean = True
        If TE_Filter.Text <> String.Empty Then
            If Not repoItm.Repository.Name.ToLower Like String.Format("*{0}*", TE_Filter.Text) Then
                visible = False
            End If
        Else
            If Me.filterOnlyChanged AndAlso repoItm.Repository.AnyChanges = False Then
                visible = False
            End If
        End If
        Return visible
    End Function

    Private Sub B_FilterWithChanges_Click(sender As Object, e As EventArgs) Handles B_FilterOnlyChanged.Click
        setFilterChanged(True)
    End Sub

    Private Sub DragStart(sender As Object, e As MouseEventArgs) Handles P_Header.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub DragMove(sender As Object, e As MouseEventArgs) Handles P_Header.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub DragStop(sender As Object, e As MouseEventArgs) Handles P_Header.MouseUp
        drag = False
    End Sub

    Private Async Sub B_PullAll_Click(sender As Object, e As EventArgs) Handles B_PullAll.Click
        Dim tmpTopMost = Me.TopMost
        Dim tmpIsPinned = Me.isPinned
        Me.TopMost = True
        Me.isPinned = True

        If MsgBox("Pull all branches for all repositories?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each repo In repoItems.Select(Function(x) x.Repository)
                If repo.UncommitedStates.Any = False AndAlso repo.LocalBranches.Select(Function(x) x.Behind).Sum > 0 Then
                    Await repo.PullAll()
                End If
            Next
        End If

        Me.TopMost = tmpTopMost
        Me.isPinned = tmpIsPinned
    End Sub

    Private Sub FLP_RepositoryList_VisibleChanged(sender As Object, e As EventArgs) Handles FLP_RepositoryList.VisibleChanged
        filter()
        My.Settings.ListLocation = Me.Location
        My.Settings.Save()
    End Sub

    Private Sub F_RepositoryList_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        My.Settings.ListLocation = Me.Location
        My.Settings.Save()
    End Sub
End Class