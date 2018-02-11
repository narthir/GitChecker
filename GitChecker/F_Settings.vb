Public Class F_Settings

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CB_ShowInTaskbar.Checked = My.Settings.ShowInTaskbar
        CB_ShowOnStartup.Checked = My.Settings.ShowOnStartup
        NUD_RemoteRefreshInterval.Value = My.Settings.RemoteRefreshInterval.TotalMinutes

        TE_GitPath.Text = My.Settings.GitLocation
        TE_ExtToolPath.Text = My.Settings.ExternalToolPath
        TE_ExtToolArguments.Text = My.Settings.ExternalToolArguments

        LB_Parents.Items.Clear()
        Dim parents = My.Settings.ParentDirectories.Split("|", options:=StringSplitOptions.RemoveEmptyEntries)
        LB_Parents.Items.AddRange(parents)

        CB_ShowInTaskbar.Focus()
    End Sub
    Private Sub B_Close_Click(sender As Object, e As EventArgs) Handles B_Close.Click
        Me.Close()
    End Sub

    Private Sub B_Save_Click(sender As Object, e As EventArgs) Handles B_Save.Click
        My.Settings.ShowInTaskbar = CB_ShowInTaskbar.Checked
        MainController.I.SetShowInTaskbar(My.Settings.ShowInTaskbar)

        My.Settings.RemoteRefreshInterval = TimeSpan.FromMinutes(NUD_RemoteRefreshInterval.Value)
        MainController.I.SetRemoteRefreshInterval(My.Settings.RemoteRefreshInterval)

        My.Settings.GitLocation = TE_GitPath.Text
        My.Settings.ExternalToolPath = TE_ExtToolPath.Text
        My.Settings.ExternalToolArguments = TE_ExtToolArguments.Text

        My.Settings.ShowOnStartup = CB_ShowOnStartup.Checked
        My.Settings.ParentDirectories = String.Join("|", LB_Parents.Items.Cast(Of String).ToList)
        My.Settings.Save()
        Me.Hide()
    End Sub

    Private Sub B_SelectGitPath_Click(sender As Object, e As EventArgs) Handles B_SelectGitPath.Click
        Using d As New OpenFileDialog
            d.CheckFileExists = True
            d.CheckPathExists = True
            d.Multiselect = False
            If d.ShowDialog(Me) = DialogResult.OK Then
                TE_GitPath.Text = d.FileName
            End If
        End Using
    End Sub

    Private Sub B_SelectExtToolPath_Click(sender As Object, e As EventArgs) Handles B_SelectExtToolPath.Click
        Using d As New OpenFileDialog
            d.CheckFileExists = True
            d.CheckPathExists = True
            d.Multiselect = False
            If d.ShowDialog(Me) = DialogResult.OK Then
                TE_ExtToolPath.Text = d.FileName
            End If
        End Using
    End Sub

    Private Sub B_RemoveParent_Click(sender As Object, e As EventArgs) Handles B_RemoveParent.Click
        LB_Parents.Items.Remove(LB_Parents.SelectedItem)
    End Sub

    Private Sub B_AddParent_Click(sender As Object, e As EventArgs) Handles B_AddParent.Click
        Using d As New FolderBrowserDialog
            d.ShowNewFolderButton = False
            If d.ShowDialog = DialogResult.OK Then
                LB_Parents.Items.Add(d.SelectedPath)
            End If
        End Using
    End Sub
End Class