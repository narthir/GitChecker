Public Class FormDragHelper

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer
    Private form As Form

    Public Sub New(c As Control, f As Form)
        form = f
        AddHandler c.MouseDown, AddressOf DragStart
        AddHandler c.MouseMove, AddressOf DragMove
        AddHandler c.MouseUp, AddressOf DragStop
    End Sub

    Private Sub DragStart(sender As Object, e As MouseEventArgs)
        drag = True
        mousex = Cursor.Position.X - form.Left
        mousey = Cursor.Position.Y - form.Top
    End Sub

    Private Sub DragMove(sender As Object, e As MouseEventArgs)
        If drag Then
            form.Top = Cursor.Position.Y - mousey
            form.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub DragStop(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub
End Class
