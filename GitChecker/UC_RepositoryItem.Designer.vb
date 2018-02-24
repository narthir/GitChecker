<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_RepositoryItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.L_RepositoryName = New System.Windows.Forms.LinkLabel()
        Me.TLP_Status = New System.Windows.Forms.TableLayoutPanel()
        Me.L_HasUncommitedMark = New System.Windows.Forms.Label()
        Me.PB_HasUncommited = New System.Windows.Forms.PictureBox()
        Me.PB_HasUntracked = New System.Windows.Forms.PictureBox()
        Me.L_HasUntrackedMark = New System.Windows.Forms.Label()
        Me.PB_PushCount = New System.Windows.Forms.PictureBox()
        Me.PB_PullCount = New System.Windows.Forms.PictureBox()
        Me.L_PushCount = New System.Windows.Forms.Label()
        Me.L_PullCount = New System.Windows.Forms.Label()
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.B_SyncWithRemote = New System.Windows.Forms.Button()
        Me.P_Line = New System.Windows.Forms.Panel()
        Me.TLP_Status.SuspendLayout()
        CType(Me.PB_HasUncommited, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_HasUntracked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PushCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PullCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_RepositoryName
        '
        Me.L_RepositoryName.AutoSize = True
        Me.L_RepositoryName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.L_RepositoryName.LinkColor = System.Drawing.Color.Black
        Me.L_RepositoryName.Location = New System.Drawing.Point(6, 6)
        Me.L_RepositoryName.Margin = New System.Windows.Forms.Padding(6)
        Me.L_RepositoryName.Name = "L_RepositoryName"
        Me.L_RepositoryName.Size = New System.Drawing.Size(172, 25)
        Me.L_RepositoryName.TabIndex = 3
        Me.L_RepositoryName.TabStop = True
        Me.L_RepositoryName.Text = "-RepositoryName-"
        '
        'TLP_Status
        '
        Me.TLP_Status.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TLP_Status.ColumnCount = 4
        Me.TLP_Status.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Status.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Status.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Status.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Status.Controls.Add(Me.L_HasUncommitedMark, 1, 0)
        Me.TLP_Status.Controls.Add(Me.PB_HasUncommited, 0, 0)
        Me.TLP_Status.Controls.Add(Me.PB_HasUntracked, 2, 0)
        Me.TLP_Status.Controls.Add(Me.L_HasUntrackedMark, 3, 0)
        Me.TLP_Status.Controls.Add(Me.PB_PushCount, 0, 1)
        Me.TLP_Status.Controls.Add(Me.PB_PullCount, 2, 1)
        Me.TLP_Status.Controls.Add(Me.L_PushCount, 1, 1)
        Me.TLP_Status.Controls.Add(Me.L_PullCount, 3, 1)
        Me.TLP_Status.Location = New System.Drawing.Point(517, 5)
        Me.TLP_Status.Margin = New System.Windows.Forms.Padding(3, 3, 33, 3)
        Me.TLP_Status.Name = "TLP_Status"
        Me.TLP_Status.RowCount = 2
        Me.TLP_Status.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Status.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Status.Size = New System.Drawing.Size(150, 74)
        Me.TLP_Status.TabIndex = 8
        '
        'L_HasUncommitedMark
        '
        Me.L_HasUncommitedMark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.L_HasUncommitedMark.AutoSize = True
        Me.L_HasUncommitedMark.Location = New System.Drawing.Point(49, 11)
        Me.L_HasUncommitedMark.Name = "L_HasUncommitedMark"
        Me.L_HasUncommitedMark.Size = New System.Drawing.Size(12, 15)
        Me.L_HasUncommitedMark.TabIndex = 15
        Me.L_HasUncommitedMark.Text = "-"
        '
        'PB_HasUncommited
        '
        Me.PB_HasUncommited.BackgroundImage = Global.GitChecker.My.Resources.Resources.list_rich_16
        Me.PB_HasUncommited.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_HasUncommited.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB_HasUncommited.Location = New System.Drawing.Point(3, 3)
        Me.PB_HasUncommited.Name = "PB_HasUncommited"
        Me.PB_HasUncommited.Size = New System.Drawing.Size(31, 31)
        Me.PB_HasUncommited.TabIndex = 12
        Me.PB_HasUncommited.TabStop = False
        '
        'PB_HasUntracked
        '
        Me.PB_HasUntracked.BackgroundImage = Global.GitChecker.My.Resources.Resources.new_16
        Me.PB_HasUntracked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_HasUntracked.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB_HasUntracked.Location = New System.Drawing.Point(77, 3)
        Me.PB_HasUntracked.Name = "PB_HasUntracked"
        Me.PB_HasUntracked.Size = New System.Drawing.Size(31, 31)
        Me.PB_HasUntracked.TabIndex = 9
        Me.PB_HasUntracked.TabStop = False
        '
        'L_HasUntrackedMark
        '
        Me.L_HasUntrackedMark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.L_HasUntrackedMark.AutoSize = True
        Me.L_HasUntrackedMark.Location = New System.Drawing.Point(124, 11)
        Me.L_HasUntrackedMark.Name = "L_HasUntrackedMark"
        Me.L_HasUntrackedMark.Size = New System.Drawing.Size(12, 15)
        Me.L_HasUntrackedMark.TabIndex = 13
        Me.L_HasUntrackedMark.Text = "-"
        '
        'PB_PushCount
        '
        Me.PB_PushCount.BackgroundImage = Global.GitChecker.My.Resources.Resources.upload_3_16
        Me.PB_PushCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_PushCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB_PushCount.Location = New System.Drawing.Point(3, 40)
        Me.PB_PushCount.Name = "PB_PushCount"
        Me.PB_PushCount.Size = New System.Drawing.Size(31, 31)
        Me.PB_PushCount.TabIndex = 11
        Me.PB_PushCount.TabStop = False
        '
        'PB_PullCount
        '
        Me.PB_PullCount.BackgroundImage = Global.GitChecker.My.Resources.Resources.download_2_16
        Me.PB_PullCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_PullCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB_PullCount.Location = New System.Drawing.Point(77, 40)
        Me.PB_PullCount.Name = "PB_PullCount"
        Me.PB_PullCount.Size = New System.Drawing.Size(31, 31)
        Me.PB_PullCount.TabIndex = 10
        Me.PB_PullCount.TabStop = False
        '
        'L_PushCount
        '
        Me.L_PushCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.L_PushCount.AutoSize = True
        Me.L_PushCount.Location = New System.Drawing.Point(49, 48)
        Me.L_PushCount.Name = "L_PushCount"
        Me.L_PushCount.Size = New System.Drawing.Size(12, 15)
        Me.L_PushCount.TabIndex = 14
        Me.L_PushCount.Text = "-"
        '
        'L_PullCount
        '
        Me.L_PullCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.L_PullCount.AutoSize = True
        Me.L_PullCount.Location = New System.Drawing.Point(124, 48)
        Me.L_PullCount.Name = "L_PullCount"
        Me.L_PullCount.Size = New System.Drawing.Size(12, 15)
        Me.L_PullCount.TabIndex = 16
        Me.L_PullCount.Text = "-"
        '
        'TLP_Main
        '
        Me.TLP_Main.ColumnCount = 3
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Main.Controls.Add(Me.B_SyncWithRemote, 2, 0)
        Me.TLP_Main.Controls.Add(Me.L_RepositoryName, 0, 0)
        Me.TLP_Main.Controls.Add(Me.TLP_Status, 1, 0)
        Me.TLP_Main.Controls.Add(Me.P_Line, 0, 1)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.Location = New System.Drawing.Point(0, 5)
        Me.TLP_Main.Margin = New System.Windows.Forms.Padding(0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 2
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Main.Size = New System.Drawing.Size(732, 91)
        Me.TLP_Main.TabIndex = 9
        '
        'B_SyncWithRemote
        '
        Me.B_SyncWithRemote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_SyncWithRemote.BackColor = System.Drawing.Color.White
        Me.B_SyncWithRemote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_SyncWithRemote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_SyncWithRemote.Image = Global.GitChecker.My.Resources.Resources.sinchronize_16
        Me.B_SyncWithRemote.Location = New System.Drawing.Point(703, 3)
        Me.B_SyncWithRemote.Name = "B_SyncWithRemote"
        Me.B_SyncWithRemote.Size = New System.Drawing.Size(26, 26)
        Me.B_SyncWithRemote.TabIndex = 4
        Me.B_SyncWithRemote.UseVisualStyleBackColor = False
        '
        'P_Line
        '
        Me.P_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TLP_Main.SetColumnSpan(Me.P_Line, 3)
        Me.P_Line.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Line.Location = New System.Drawing.Point(13, 87)
        Me.P_Line.Margin = New System.Windows.Forms.Padding(13, 3, 13, 3)
        Me.P_Line.Name = "P_Line"
        Me.P_Line.Size = New System.Drawing.Size(706, 1)
        Me.P_Line.TabIndex = 11
        '
        'UC_RepositoryItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TLP_Main)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UC_RepositoryItem"
        Me.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Size = New System.Drawing.Size(732, 96)
        Me.TLP_Status.ResumeLayout(False)
        Me.TLP_Status.PerformLayout()
        CType(Me.PB_HasUncommited, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_HasUntracked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PushCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PullCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Main.ResumeLayout(False)
        Me.TLP_Main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents L_RepositoryName As LinkLabel
    Friend WithEvents B_SyncWithRemote As Button
    Friend WithEvents TLP_Status As TableLayoutPanel
    Friend WithEvents PB_HasUntracked As PictureBox
    Friend WithEvents PB_PullCount As PictureBox
    Friend WithEvents PB_PushCount As PictureBox
    Friend WithEvents PB_HasUncommited As PictureBox
    Friend WithEvents L_HasUncommitedMark As Label
    Friend WithEvents L_HasUntrackedMark As Label
    Friend WithEvents L_PushCount As Label
    Friend WithEvents L_PullCount As Label
    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents P_Line As Panel
End Class
