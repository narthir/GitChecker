<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_RepositoryList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_RepositoryList))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.FLP_RepositoryList = New System.Windows.Forms.FlowLayoutPanel()
        Me.TLP_Options = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_Filter = New System.Windows.Forms.TableLayoutPanel()
        Me.TE_Filter = New System.Windows.Forms.TextBox()
        Me.P_Header = New System.Windows.Forms.Panel()
        Me.B_Refresh = New System.Windows.Forms.Button()
        Me.B_Settings = New System.Windows.Forms.Button()
        Me.B_Pin = New System.Windows.Forms.Button()
        Me.B_FilterOnlyChanged = New System.Windows.Forms.Button()
        Me.PB_Filter = New System.Windows.Forms.PictureBox()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.MainPanel.SuspendLayout()
        Me.TLP_Main.SuspendLayout()
        Me.TLP_Options.SuspendLayout()
        Me.TLP_Filter.SuspendLayout()
        Me.P_Header.SuspendLayout()
        CType(Me.PB_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.TLP_Main)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(462, 561)
        Me.MainPanel.TabIndex = 0
        '
        'TLP_Main
        '
        Me.TLP_Main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLP_Main.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TLP_Main.ColumnCount = 1
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.Controls.Add(Me.FLP_RepositoryList, 0, 1)
        Me.TLP_Main.Controls.Add(Me.TLP_Options, 0, 2)
        Me.TLP_Main.Controls.Add(Me.P_Header, 0, 0)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TLP_Main.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 3
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Main.Size = New System.Drawing.Size(460, 559)
        Me.TLP_Main.TabIndex = 3
        '
        'FLP_RepositoryList
        '
        Me.FLP_RepositoryList.AutoScroll = True
        Me.FLP_RepositoryList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_RepositoryList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_RepositoryList.Location = New System.Drawing.Point(1, 40)
        Me.FLP_RepositoryList.Margin = New System.Windows.Forms.Padding(0)
        Me.FLP_RepositoryList.Name = "FLP_RepositoryList"
        Me.FLP_RepositoryList.Size = New System.Drawing.Size(458, 479)
        Me.FLP_RepositoryList.TabIndex = 2
        Me.FLP_RepositoryList.WrapContents = False
        '
        'TLP_Options
        '
        Me.TLP_Options.ColumnCount = 4
        Me.TLP_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Options.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP_Options.Controls.Add(Me.B_Refresh, 2, 0)
        Me.TLP_Options.Controls.Add(Me.B_Settings, 3, 0)
        Me.TLP_Options.Controls.Add(Me.B_Pin, 1, 0)
        Me.TLP_Options.Controls.Add(Me.TLP_Filter, 0, 0)
        Me.TLP_Options.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TLP_Options.Location = New System.Drawing.Point(4, 523)
        Me.TLP_Options.Name = "TLP_Options"
        Me.TLP_Options.RowCount = 1
        Me.TLP_Options.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Options.Size = New System.Drawing.Size(452, 32)
        Me.TLP_Options.TabIndex = 3
        '
        'TLP_Filter
        '
        Me.TLP_Filter.ColumnCount = 3
        Me.TLP_Filter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Filter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Filter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TLP_Filter.Controls.Add(Me.B_FilterOnlyChanged, 2, 0)
        Me.TLP_Filter.Controls.Add(Me.TE_Filter, 1, 0)
        Me.TLP_Filter.Controls.Add(Me.PB_Filter, 0, 0)
        Me.TLP_Filter.Location = New System.Drawing.Point(3, 0)
        Me.TLP_Filter.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TLP_Filter.Name = "TLP_Filter"
        Me.TLP_Filter.RowCount = 1
        Me.TLP_Filter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Filter.Size = New System.Drawing.Size(231, 32)
        Me.TLP_Filter.TabIndex = 2
        '
        'TE_Filter
        '
        Me.TE_Filter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TE_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TE_Filter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TE_Filter.Location = New System.Drawing.Point(37, 4)
        Me.TE_Filter.Margin = New System.Windows.Forms.Padding(0)
        Me.TE_Filter.Name = "TE_Filter"
        Me.TE_Filter.Size = New System.Drawing.Size(147, 23)
        Me.TE_Filter.TabIndex = 0
        '
        'P_Header
        '
        Me.P_Header.BackColor = System.Drawing.Color.Gainsboro
        Me.P_Header.Controls.Add(Me.B_Close)
        Me.P_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Header.Location = New System.Drawing.Point(1, 1)
        Me.P_Header.Margin = New System.Windows.Forms.Padding(0)
        Me.P_Header.Name = "P_Header"
        Me.P_Header.Size = New System.Drawing.Size(458, 38)
        Me.P_Header.TabIndex = 4
        '
        'B_Refresh
        '
        Me.B_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.B_Refresh.BackgroundImage = Global.GitChecker.My.Resources.Resources.sinchronize_16
        Me.B_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.B_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Refresh.Location = New System.Drawing.Point(361, 3)
        Me.B_Refresh.Margin = New System.Windows.Forms.Padding(13, 3, 13, 3)
        Me.B_Refresh.Name = "B_Refresh"
        Me.B_Refresh.Size = New System.Drawing.Size(26, 26)
        Me.B_Refresh.TabIndex = 1
        Me.B_Refresh.UseVisualStyleBackColor = True
        '
        'B_Settings
        '
        Me.B_Settings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.B_Settings.BackgroundImage = Global.GitChecker.My.Resources.Resources.settings_5_16
        Me.B_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_Settings.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.B_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Settings.Location = New System.Drawing.Point(413, 3)
        Me.B_Settings.Margin = New System.Windows.Forms.Padding(13, 3, 13, 3)
        Me.B_Settings.Name = "B_Settings"
        Me.B_Settings.Size = New System.Drawing.Size(26, 26)
        Me.B_Settings.TabIndex = 0
        Me.B_Settings.UseVisualStyleBackColor = True
        '
        'B_Pin
        '
        Me.B_Pin.BackgroundImage = Global.GitChecker.My.Resources.Resources.pin_3_16
        Me.B_Pin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_Pin.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.B_Pin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Pin.Location = New System.Drawing.Point(309, 3)
        Me.B_Pin.Margin = New System.Windows.Forms.Padding(13, 3, 13, 3)
        Me.B_Pin.Name = "B_Pin"
        Me.B_Pin.Size = New System.Drawing.Size(26, 26)
        Me.B_Pin.TabIndex = 0
        Me.B_Pin.UseVisualStyleBackColor = True
        '
        'B_FilterOnlyChanged
        '
        Me.B_FilterOnlyChanged.BackgroundImage = Global.GitChecker.My.Resources.Resources.edit_12_16
        Me.B_FilterOnlyChanged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_FilterOnlyChanged.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.B_FilterOnlyChanged.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_FilterOnlyChanged.Location = New System.Drawing.Point(185, 3)
        Me.B_FilterOnlyChanged.Margin = New System.Windows.Forms.Padding(1, 3, 13, 3)
        Me.B_FilterOnlyChanged.Name = "B_FilterOnlyChanged"
        Me.B_FilterOnlyChanged.Size = New System.Drawing.Size(33, 26)
        Me.B_FilterOnlyChanged.TabIndex = 3
        Me.B_FilterOnlyChanged.UseVisualStyleBackColor = True
        '
        'PB_Filter
        '
        Me.PB_Filter.BackgroundImage = Global.GitChecker.My.Resources.Resources.search_15_16
        Me.PB_Filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_Filter.Location = New System.Drawing.Point(3, 3)
        Me.PB_Filter.Name = "PB_Filter"
        Me.PB_Filter.Size = New System.Drawing.Size(31, 26)
        Me.PB_Filter.TabIndex = 1
        Me.PB_Filter.TabStop = False
        '
        'B_Close
        '
        Me.B_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Close.BackgroundImage = CType(resources.GetObject("B_Close.BackgroundImage"), System.Drawing.Image)
        Me.B_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_Close.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Close.Location = New System.Drawing.Point(418, 5)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(34, 28)
        Me.B_Close.TabIndex = 4
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'F_RepositoryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(462, 561)
        Me.Controls.Add(Me.MainPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_RepositoryList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RepoList"
        Me.MainPanel.ResumeLayout(False)
        Me.TLP_Main.ResumeLayout(False)
        Me.TLP_Options.ResumeLayout(False)
        Me.TLP_Filter.ResumeLayout(False)
        Me.TLP_Filter.PerformLayout()
        Me.P_Header.ResumeLayout(False)
        CType(Me.PB_Filter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents FLP_RepositoryList As FlowLayoutPanel
    Friend WithEvents TLP_Options As TableLayoutPanel
    Friend WithEvents B_Refresh As Button
    Friend WithEvents B_Settings As Button
    Friend WithEvents B_Close As Button
    Friend WithEvents B_Pin As Button
    Friend WithEvents TLP_Filter As TableLayoutPanel
    Friend WithEvents TE_Filter As TextBox
    Friend WithEvents PB_Filter As PictureBox
    Friend WithEvents B_FilterOnlyChanged As Button
    Friend WithEvents P_Header As Panel
End Class
