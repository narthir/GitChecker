<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Branches
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Branches))
        Me.P_Main = New System.Windows.Forms.Panel()
        Me.TLP_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.LB_Branches = New System.Windows.Forms.ListBox()
        Me.P_Header = New System.Windows.Forms.Panel()
        Me.TB_Filter = New System.Windows.Forms.TextBox()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.P_Main.SuspendLayout()
        Me.TLP_Main.SuspendLayout()
        Me.P_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Main
        '
        Me.P_Main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.P_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_Main.Controls.Add(Me.TLP_Main)
        Me.P_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Main.Location = New System.Drawing.Point(0, 0)
        Me.P_Main.Name = "P_Main"
        Me.P_Main.Size = New System.Drawing.Size(214, 337)
        Me.P_Main.TabIndex = 6
        '
        'TLP_Main
        '
        Me.TLP_Main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLP_Main.ColumnCount = 1
        Me.TLP_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.Controls.Add(Me.LB_Branches, 0, 1)
        Me.TLP_Main.Controls.Add(Me.P_Header, 0, 0)
        Me.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Main.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TLP_Main.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Main.Name = "TLP_Main"
        Me.TLP_Main.RowCount = 2
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TLP_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Main.Size = New System.Drawing.Size(212, 335)
        Me.TLP_Main.TabIndex = 4
        '
        'LB_Branches
        '
        Me.LB_Branches.DisplayMember = "Name"
        Me.LB_Branches.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB_Branches.FormattingEnabled = True
        Me.LB_Branches.Location = New System.Drawing.Point(3, 38)
        Me.LB_Branches.Name = "LB_Branches"
        Me.LB_Branches.Size = New System.Drawing.Size(206, 294)
        Me.LB_Branches.TabIndex = 0
        Me.LB_Branches.ValueMember = "Name"
        '
        'P_Header
        '
        Me.P_Header.BackColor = System.Drawing.Color.Gainsboro
        Me.P_Header.Controls.Add(Me.TB_Filter)
        Me.P_Header.Controls.Add(Me.B_Close)
        Me.P_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Header.Location = New System.Drawing.Point(0, 0)
        Me.P_Header.Margin = New System.Windows.Forms.Padding(0)
        Me.P_Header.Name = "P_Header"
        Me.P_Header.Size = New System.Drawing.Size(212, 35)
        Me.P_Header.TabIndex = 0
        '
        'TB_Filter
        '
        Me.TB_Filter.Location = New System.Drawing.Point(3, 7)
        Me.TB_Filter.Name = "TB_Filter"
        Me.TB_Filter.Size = New System.Drawing.Size(167, 20)
        Me.TB_Filter.TabIndex = 0
        '
        'B_Close
        '
        Me.B_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Close.BackgroundImage = CType(resources.GetObject("B_Close.BackgroundImage"), System.Drawing.Image)
        Me.B_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.B_Close.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Close.Location = New System.Drawing.Point(176, 3)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(32, 29)
        Me.B_Close.TabIndex = 0
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'F_Branches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 337)
        Me.Controls.Add(Me.P_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Branches"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "F_Branches"
        Me.TopMost = True
        Me.P_Main.ResumeLayout(False)
        Me.TLP_Main.ResumeLayout(False)
        Me.P_Header.ResumeLayout(False)
        Me.P_Header.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_Main As Panel
    Friend WithEvents TLP_Main As TableLayoutPanel
    Friend WithEvents P_Header As Panel
    Friend WithEvents B_Close As Button
    Friend WithEvents LB_Branches As ListBox
    Friend WithEvents TB_Filter As TextBox
End Class
