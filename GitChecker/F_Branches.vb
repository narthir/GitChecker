Public Class F_Branches

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer
    Private branches As List(Of String)
    Public ReadOnly Property SelectedBranchName As String

    Public Sub New(branches As IEnumerable(Of Branch))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.branches = branches.Select(Function(x) x.Name).Distinct.ToList

        LB_Branches.DataSource = Me.branches
    End Sub

    Private Sub F_Branches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_Filter.Select()
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

    Private Sub TB_Filter_TextChanged(sender As Object, e As EventArgs) Handles TB_Filter.TextChanged
        Try
            If TB_Filter.Text.Trim.Length > 0 Then
                LB_Branches.DataSource = branches.Where(Function(x) x.ToLower Like "*" & TB_Filter.Text.ToLower & "*").ToList
            Else
                LB_Branches.DataSource = branches
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LB_Branches_DoubleClick(sender As Object, e As EventArgs) Handles LB_Branches.DoubleClick
        SelectAndClose()
    End Sub

    Private Sub LB_Branches_KeyUp(sender As Object, e As KeyEventArgs) Handles LB_Branches.KeyUp, TB_Filter.KeyUp
        If e.KeyCode = Keys.Enter Then
            SelectAndClose()
        End If
    End Sub

    Private Sub SelectAndClose()
        If LB_Branches.SelectedItem IsNot Nothing AndAlso CStr(LB_Branches.SelectedItem).Length > 0 Then
            Me._SelectedBranchName = LB_Branches.SelectedItem
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub B_Close_Click(sender As Object, e As EventArgs) Handles B_Close.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub F_Branches_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp, LB_Branches.KeyUp, TB_Filter.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

End Class