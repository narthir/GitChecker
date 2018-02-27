Public Class F_Log

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        B_Refresh.PerformClick()
    End Sub
    Private Sub B_OK_Click(sender As Object, e As EventArgs) Handles B_OK.Click
        Me.Close()
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

    Private Sub B_Close_Click(sender As Object, e As EventArgs) Handles B_Close.Click
        Me.Close()
    End Sub

    Private Sub B_Refresh_Click(sender As Object, e As EventArgs) Handles B_Refresh.Click
        ME_Logs.Lines = Main.LogEntries.ToArray
        ME_Logs.SelectionStart = ME_Logs.Text.Length
        ME_Logs.ScrollToCaret()
    End Sub
End Class