<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Log
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Log))
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.B_Refresh = New System.Windows.Forms.Button()
        Me.B_OK = New System.Windows.Forms.Button()
        Me.P_Header = New System.Windows.Forms.Panel()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.P_Separator = New System.Windows.Forms.Panel()
        Me.P_Main = New System.Windows.Forms.Panel()
        Me.TE_Logs = New System.Windows.Forms.TextBox()
        Me.TLP_Main.SuspendLayout()
        Me.P_Header.SuspendLayout()
        Me.P_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP_Main
        '
        Me.TLP_Main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLP_Main.ColumnCount = 2
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP_Main.Controls.Add(Me.B_Refresh, 0, 3)
        Me.TLP_Main.Controls.Add(Me.B_OK, 1, 3)
        Me.TLP_Main.Controls.Add(Me.P_Header, 0, 0)
        Me.TLP_Main.Controls.Add(Me.P_Separator, 0, 1)
        Me.TLP_Main.Controls.Add(Me.TE_Logs, 0, 2)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TLP_Main.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 4
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLP_Main.Size = New System.Drawing.Size(947, 586)
        Me.TLP_Main.TabIndex = 0
        '
        'B_Refresh
        '
        Me.B_Refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.B_Refresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.B_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.B_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Refresh.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.B_Refresh.Location = New System.Drawing.Point(8, 543)
        Me.B_Refresh.Margin = New System.Windows.Forms.Padding(8)
        Me.B_Refresh.Name = "B_Refresh"
        Me.B_Refresh.Size = New System.Drawing.Size(91, 35)
        Me.B_Refresh.TabIndex = 8
        Me.B_Refresh.Text = "Refresh"
        Me.B_Refresh.UseVisualStyleBackColor = False
        '
        'B_OK
        '
        Me.B_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_OK.BackColor = System.Drawing.Color.WhiteSmoke
        Me.B_OK.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.B_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_OK.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.B_OK.Location = New System.Drawing.Point(848, 543)
        Me.B_OK.Margin = New System.Windows.Forms.Padding(8)
        Me.B_OK.Name = "B_OK"
        Me.B_OK.Size = New System.Drawing.Size(91, 35)
        Me.B_OK.TabIndex = 3
        Me.B_OK.Text = "OK"
        Me.B_OK.UseVisualStyleBackColor = False
        '
        'P_Header
        '
        Me.P_Header.BackColor = System.Drawing.Color.Gainsboro
        Me.TLP_Main.SetColumnSpan(Me.P_Header, 2)
        Me.P_Header.Controls.Add(Me.B_Close)
        Me.P_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Header.Location = New System.Drawing.Point(0, 0)
        Me.P_Header.Margin = New System.Windows.Forms.Padding(0)
        Me.P_Header.Name = "P_Header"
        Me.P_Header.Size = New System.Drawing.Size(947, 37)
        Me.P_Header.TabIndex = 6
        '
        'B_Close
        '
        Me.B_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Close.BackgroundImage = CType(resources.GetObject("B_Close.BackgroundImage"), System.Drawing.Image)
        Me.B_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_Close.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Close.Location = New System.Drawing.Point(911, 3)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(32, 29)
        Me.B_Close.TabIndex = 0
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'P_Separator
        '
        Me.P_Separator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TLP_Main.SetColumnSpan(Me.P_Separator, 2)
        Me.P_Separator.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Separator.Location = New System.Drawing.Point(0, 37)
        Me.P_Separator.Margin = New System.Windows.Forms.Padding(0)
        Me.P_Separator.Name = "P_Separator"
        Me.P_Separator.Size = New System.Drawing.Size(947, 1)
        Me.P_Separator.TabIndex = 7
        '
        'P_Main
        '
        Me.P_Main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.P_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_Main.Controls.Add(Me.TLP_Main)
        Me.P_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Main.Location = New System.Drawing.Point(0, 0)
        Me.P_Main.Name = "P_Main"
        Me.P_Main.Size = New System.Drawing.Size(949, 588)
        Me.P_Main.TabIndex = 6
        '
        'TE_Logs
        '
        Me.TLP_Main.SetColumnSpan(Me.TE_Logs, 2)
        Me.TE_Logs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TE_Logs.Location = New System.Drawing.Point(3, 41)
        Me.TE_Logs.Multiline = True
        Me.TE_Logs.Name = "TE_Logs"
        Me.TE_Logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TE_Logs.Size = New System.Drawing.Size(941, 491)
        Me.TE_Logs.TabIndex = 9
        '
        'F_Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 588)
        Me.Controls.Add(Me.P_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Log"
        Me.TLP_Main.ResumeLayout(False)
        Me.TLP_Main.PerformLayout()
        Me.P_Header.ResumeLayout(False)
        Me.P_Main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents B_OK As Button
    Friend WithEvents P_Header As Panel
    Friend WithEvents B_Close As Button
    Friend WithEvents P_Separator As Panel
    Friend WithEvents P_Main As Panel
    Friend WithEvents B_Refresh As Button
    Friend WithEvents TE_Logs As TextBox
End Class
