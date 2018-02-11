<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Settings))
        Me.CB_ShowInTaskbar = New System.Windows.Forms.CheckBox()
        Me.CB_ShowOnStartup = New System.Windows.Forms.CheckBox()
        Me.B_Save = New System.Windows.Forms.Button()
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.P_Options = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TE_ExtToolArguments = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TE_ExtToolPath = New System.Windows.Forms.TextBox()
        Me.L_GitPath = New System.Windows.Forms.Label()
        Me.TE_GitPath = New System.Windows.Forms.TextBox()
        Me.L_Minutes = New System.Windows.Forms.Label()
        Me.NUD_RemoteRefreshInterval = New System.Windows.Forms.NumericUpDown()
        Me.L_RemoteRefreshInterval = New System.Windows.Forms.Label()
        Me.P_Main = New System.Windows.Forms.Panel()
        Me.LB_Parents = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.B_RemoveParent = New System.Windows.Forms.Button()
        Me.B_AddParent = New System.Windows.Forms.Button()
        Me.B_SelectExtToolPath = New System.Windows.Forms.Button()
        Me.B_SelectGitPath = New System.Windows.Forms.Button()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.TLP_Main.SuspendLayout()
        Me.P_Options.SuspendLayout()
        CType(Me.NUD_RemoteRefreshInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'CB_ShowInTaskbar
        '
        Me.CB_ShowInTaskbar.AutoSize = True
        Me.CB_ShowInTaskbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ShowInTaskbar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.CB_ShowInTaskbar.Location = New System.Drawing.Point(9, 9)
        Me.CB_ShowInTaskbar.Name = "CB_ShowInTaskbar"
        Me.CB_ShowInTaskbar.Size = New System.Drawing.Size(109, 19)
        Me.CB_ShowInTaskbar.TabIndex = 1
        Me.CB_ShowInTaskbar.Text = "Show in Taskbar"
        Me.CB_ShowInTaskbar.UseVisualStyleBackColor = True
        '
        'CB_ShowOnStartup
        '
        Me.CB_ShowOnStartup.AutoSize = True
        Me.CB_ShowOnStartup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ShowOnStartup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.CB_ShowOnStartup.Location = New System.Drawing.Point(9, 34)
        Me.CB_ShowOnStartup.Name = "CB_ShowOnStartup"
        Me.CB_ShowOnStartup.Size = New System.Drawing.Size(112, 19)
        Me.CB_ShowOnStartup.TabIndex = 2
        Me.CB_ShowOnStartup.Text = "Show on Startup"
        Me.CB_ShowOnStartup.UseVisualStyleBackColor = True
        '
        'B_Save
        '
        Me.B_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Save.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.B_Save.Location = New System.Drawing.Point(333, 288)
        Me.B_Save.Name = "B_Save"
        Me.B_Save.Size = New System.Drawing.Size(114, 46)
        Me.B_Save.TabIndex = 3
        Me.B_Save.Text = "Save"
        Me.B_Save.UseVisualStyleBackColor = True
        '
        'TLP_Main
        '
        Me.TLP_Main.BackColor = System.Drawing.Color.White
        Me.TLP_Main.ColumnCount = 2
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Main.Controls.Add(Me.P_Options, 0, 0)
        Me.TLP_Main.Controls.Add(Me.B_Save, 1, 1)
        Me.TLP_Main.Controls.Add(Me.B_Close, 1, 0)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 2
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Main.Size = New System.Drawing.Size(450, 337)
        Me.TLP_Main.TabIndex = 4
        '
        'P_Options
        '
        Me.P_Options.Controls.Add(Me.B_RemoveParent)
        Me.P_Options.Controls.Add(Me.B_AddParent)
        Me.P_Options.Controls.Add(Me.Label3)
        Me.P_Options.Controls.Add(Me.LB_Parents)
        Me.P_Options.Controls.Add(Me.Label2)
        Me.P_Options.Controls.Add(Me.TE_ExtToolArguments)
        Me.P_Options.Controls.Add(Me.B_SelectExtToolPath)
        Me.P_Options.Controls.Add(Me.Label1)
        Me.P_Options.Controls.Add(Me.TE_ExtToolPath)
        Me.P_Options.Controls.Add(Me.B_SelectGitPath)
        Me.P_Options.Controls.Add(Me.L_GitPath)
        Me.P_Options.Controls.Add(Me.TE_GitPath)
        Me.P_Options.Controls.Add(Me.L_Minutes)
        Me.P_Options.Controls.Add(Me.NUD_RemoteRefreshInterval)
        Me.P_Options.Controls.Add(Me.L_RemoteRefreshInterval)
        Me.P_Options.Controls.Add(Me.CB_ShowOnStartup)
        Me.P_Options.Controls.Add(Me.CB_ShowInTaskbar)
        Me.P_Options.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Options.Location = New System.Drawing.Point(3, 3)
        Me.P_Options.Name = "P_Options"
        Me.P_Options.Size = New System.Drawing.Size(324, 279)
        Me.P_Options.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ext. Args:"
        '
        'TE_ExtToolArguments
        '
        Me.TE_ExtToolArguments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TE_ExtToolArguments.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.TE_ExtToolArguments.Location = New System.Drawing.Point(64, 150)
        Me.TE_ExtToolArguments.Name = "TE_ExtToolArguments"
        Me.TE_ExtToolArguments.Size = New System.Drawing.Size(167, 23)
        Me.TE_ExtToolArguments.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ext. Tool:"
        '
        'TE_ExtToolPath
        '
        Me.TE_ExtToolPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TE_ExtToolPath.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.TE_ExtToolPath.Location = New System.Drawing.Point(64, 121)
        Me.TE_ExtToolPath.Name = "TE_ExtToolPath"
        Me.TE_ExtToolPath.Size = New System.Drawing.Size(167, 23)
        Me.TE_ExtToolPath.TabIndex = 9
        '
        'L_GitPath
        '
        Me.L_GitPath.AutoSize = True
        Me.L_GitPath.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.L_GitPath.Location = New System.Drawing.Point(6, 95)
        Me.L_GitPath.Name = "L_GitPath"
        Me.L_GitPath.Size = New System.Drawing.Size(52, 15)
        Me.L_GitPath.TabIndex = 7
        Me.L_GitPath.Text = "Git Path:"
        '
        'TE_GitPath
        '
        Me.TE_GitPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TE_GitPath.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.TE_GitPath.Location = New System.Drawing.Point(64, 92)
        Me.TE_GitPath.Name = "TE_GitPath"
        Me.TE_GitPath.Size = New System.Drawing.Size(167, 23)
        Me.TE_GitPath.TabIndex = 6
        '
        'L_Minutes
        '
        Me.L_Minutes.AutoSize = True
        Me.L_Minutes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.L_Minutes.Location = New System.Drawing.Point(212, 60)
        Me.L_Minutes.Name = "L_Minutes"
        Me.L_Minutes.Size = New System.Drawing.Size(50, 15)
        Me.L_Minutes.TabIndex = 5
        Me.L_Minutes.Text = "Minutes"
        '
        'NUD_RemoteRefreshInterval
        '
        Me.NUD_RemoteRefreshInterval.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.NUD_RemoteRefreshInterval.Location = New System.Drawing.Point(144, 56)
        Me.NUD_RemoteRefreshInterval.Maximum = New Decimal(New Integer() {10080, 0, 0, 0})
        Me.NUD_RemoteRefreshInterval.Name = "NUD_RemoteRefreshInterval"
        Me.NUD_RemoteRefreshInterval.Size = New System.Drawing.Size(64, 23)
        Me.NUD_RemoteRefreshInterval.TabIndex = 4
        '
        'L_RemoteRefreshInterval
        '
        Me.L_RemoteRefreshInterval.AutoSize = True
        Me.L_RemoteRefreshInterval.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.L_RemoteRefreshInterval.Location = New System.Drawing.Point(6, 60)
        Me.L_RemoteRefreshInterval.Name = "L_RemoteRefreshInterval"
        Me.L_RemoteRefreshInterval.Size = New System.Drawing.Size(132, 15)
        Me.L_RemoteRefreshInterval.TabIndex = 3
        Me.L_RemoteRefreshInterval.Text = "RemoteRefresh interval:"
        '
        'P_Main
        '
        Me.P_Main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.P_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_Main.Controls.Add(Me.TLP_Main)
        Me.P_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Main.Location = New System.Drawing.Point(0, 0)
        Me.P_Main.Name = "P_Main"
        Me.P_Main.Size = New System.Drawing.Size(452, 339)
        Me.P_Main.TabIndex = 5
        '
        'LB_Parents
        '
        Me.LB_Parents.FormattingEnabled = True
        Me.LB_Parents.ItemHeight = 15
        Me.LB_Parents.Location = New System.Drawing.Point(9, 204)
        Me.LB_Parents.Name = "LB_Parents"
        Me.LB_Parents.Size = New System.Drawing.Size(255, 64)
        Me.LB_Parents.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Parent directories::"
        '
        'B_RemoveParent
        '
        Me.B_RemoveParent.BackgroundImage = Global.GitChecker.My.Resources.Resources.minus_16
        Me.B_RemoveParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_RemoveParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_RemoveParent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.B_RemoveParent.Location = New System.Drawing.Point(270, 243)
        Me.B_RemoveParent.Name = "B_RemoveParent"
        Me.B_RemoveParent.Size = New System.Drawing.Size(23, 23)
        Me.B_RemoveParent.TabIndex = 17
        Me.B_RemoveParent.UseVisualStyleBackColor = True
        '
        'B_AddParent
        '
        Me.B_AddParent.BackgroundImage = Global.GitChecker.My.Resources.Resources.plus_16
        Me.B_AddParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_AddParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_AddParent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.B_AddParent.Location = New System.Drawing.Point(270, 206)
        Me.B_AddParent.Name = "B_AddParent"
        Me.B_AddParent.Size = New System.Drawing.Size(23, 23)
        Me.B_AddParent.TabIndex = 16
        Me.B_AddParent.UseVisualStyleBackColor = True
        '
        'B_SelectExtToolPath
        '
        Me.B_SelectExtToolPath.BackgroundImage = Global.GitChecker.My.Resources.Resources.exe_16
        Me.B_SelectExtToolPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_SelectExtToolPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_SelectExtToolPath.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.B_SelectExtToolPath.Location = New System.Drawing.Point(234, 121)
        Me.B_SelectExtToolPath.Name = "B_SelectExtToolPath"
        Me.B_SelectExtToolPath.Size = New System.Drawing.Size(23, 23)
        Me.B_SelectExtToolPath.TabIndex = 11
        Me.B_SelectExtToolPath.UseVisualStyleBackColor = True
        '
        'B_SelectGitPath
        '
        Me.B_SelectGitPath.BackgroundImage = Global.GitChecker.My.Resources.Resources.exe_16
        Me.B_SelectGitPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_SelectGitPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_SelectGitPath.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.B_SelectGitPath.Location = New System.Drawing.Point(234, 92)
        Me.B_SelectGitPath.Name = "B_SelectGitPath"
        Me.B_SelectGitPath.Size = New System.Drawing.Size(23, 23)
        Me.B_SelectGitPath.TabIndex = 8
        Me.B_SelectGitPath.UseVisualStyleBackColor = True
        '
        'B_Close
        '
        Me.B_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Close.BackgroundImage = CType(resources.GetObject("B_Close.BackgroundImage"), System.Drawing.Image)
        Me.B_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Close.Location = New System.Drawing.Point(395, 3)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(52, 46)
        Me.B_Close.TabIndex = 0
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'F_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 339)
        Me.Controls.Add(Me.P_Main)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Settings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Settings"
        Me.TLP_Main.ResumeLayout(False)
        Me.P_Options.ResumeLayout(False)
        Me.P_Options.PerformLayout()
        CType(Me.NUD_RemoteRefreshInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_Main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents B_Close As Button
    Friend WithEvents CB_ShowInTaskbar As CheckBox
    Friend WithEvents CB_ShowOnStartup As CheckBox
    Friend WithEvents B_Save As Button
    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents P_Options As Panel
    Friend WithEvents P_Main As Panel
    Friend WithEvents NUD_RemoteRefreshInterval As NumericUpDown
    Friend WithEvents L_RemoteRefreshInterval As Label
    Friend WithEvents L_Minutes As Label
    Friend WithEvents L_GitPath As Label
    Friend WithEvents TE_GitPath As TextBox
    Friend WithEvents B_SelectGitPath As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TE_ExtToolArguments As TextBox
    Friend WithEvents B_SelectExtToolPath As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TE_ExtToolPath As TextBox
    Friend WithEvents LB_Parents As ListBox
    Friend WithEvents B_RemoveParent As Button
    Friend WithEvents B_AddParent As Button
    Friend WithEvents Label3 As Label
End Class
