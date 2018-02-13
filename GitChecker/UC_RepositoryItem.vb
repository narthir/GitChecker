Public Class UC_RepositoryItem

    Public ReadOnly Repository As Repository
    Private isTopItem As Boolean = False

    Public Sub New(repository As Repository, isTopItem As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.isTopItem = isTopItem
        P_Line.Visible = Not isTopItem
        Me.Repository = repository
        L_RepositoryName.Text = String.Format("{0}", repository.Name)

        AddHandler Me.Repository.UpdateStarted, Sub(r As Repository)
                                                    B_SyncWithRemote.BackColor = Color.Orange
                                                End Sub

        AddHandler Me.Repository.UpdateFinished, Sub(r As Repository)
                                                     If Me.IsAlive Then
                                                         Me.InvokeGUI(Sub()
                                                                          RefreshControlData()
                                                                          B_SyncWithRemote.BackColor = Color.White
                                                                      End Sub)
                                                     End If
                                                 End Sub
        RefreshControlData()
    End Sub

    Sub RefreshControlData()
        Dim hasUncommited = Repository.UncommitedStates.Contains(Repository.CommitState.HasChanges)
        PB_HasUncommited.Visible = hasUncommited
        L_HasUncommitedMark.Text = If(hasUncommited, "✓", "")


        Dim hasUntracked = Repository.UncommitedStates.Contains(Repository.CommitState.HasUntracked)
        PB_HasUntracked.Visible = hasUntracked
        L_HasUntrackedMark.Text = If(hasUntracked, "✓", "")

        Dim pullCount = Repository.LocalBranches.Select(Function(x) x.Behind).Sum
        PB_PullCount.Visible = (pullCount > 0)
        L_PullCount.Text = If(pullCount > 0, pullCount, "")

        Dim pushCount = Repository.LocalBranches.Select(Function(x) x.Ahead).Sum
        PB_PushCount.Visible = (pushCount > 0)
        L_PushCount.Text = If(pushCount > 0, pushCount, "")
    End Sub



    Private Sub L_RepositoryName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles L_RepositoryName.LinkClicked
        Try
            Dim procInfo As New ProcessStartInfo(Environment.ExpandEnvironmentVariables(My.Settings.ExternalToolPath), My.Settings.ExternalToolArguments.Replace("{path}", String.Format("""{0}""", Environment.ExpandEnvironmentVariables(Me.Repository.Location.FullName))))
            procInfo.UseShellExecute = False
            procInfo.CreateNoWindow = True
            Dim proc As New Process With {.StartInfo = procInfo}
            proc.Start()
        Catch ex As Exception
            LogError(ex)
        End Try
    End Sub

    Private Async Sub B_SyncWithRemote_Click(sender As Object, e As EventArgs) Handles B_SyncWithRemote.Click
        Await Repository.UpdateRemoteData()
    End Sub

    Private Sub TLP_Main_VisibleChanged(sender As Object, e As EventArgs) Handles TLP_Main.VisibleChanged
        If Me.IsAlive AndAlso Me.Visible Then
            Me.InvokeGUI(Sub()
                             RefreshControlData()
                             B_SyncWithRemote.BackColor = Color.White
                         End Sub)
        End If
    End Sub
End Class
