Imports System.Runtime.CompilerServices

Public Module Extensions
    <Extension> Public Function IsAlive(this As Control) As Boolean
        If this Is Nothing OrElse this.IsDisposed OrElse this.Disposing OrElse this.IsHandleCreated = False Then
            Return False
        Else
            Return True
        End If
    End Function

    <Extension> Public Sub DebugWriteLineAll(this As List(Of String), Optional formatString As String = "")
        If Len(formatString) = 0 Then
            this.ForEach(Sub(x) Debug.WriteLine(x))
        Else
            this.ForEach(Sub(x) Debug.WriteLine(String.Format(formatString, x)))
        End If
    End Sub

    <Extension> Public Function TakeAndRemove(Of T)(this As List(Of T), Count As Integer) As List(Of T)
        Dim tL As New List(Of T)
        Dim remaining As Integer = Count
        While remaining > 0 AndAlso this.Count > 0
            tL.Add(this(0))
            this.RemoveAt(0)
            remaining -= 1
        End While
        Return tL
    End Function

    <Extension> Public Function TakeAndRemove(Of T)(this As List(Of T)) As T
        Return TakeAndRemove(Of T)(this, 1).SingleOrDefault
    End Function

    <Extension> Public Sub InvokeGUI(this As Control, Action As Action)
        If this.InvokeRequired Then
            this.Invoke(Action)
        Else
            Action()
        End If
    End Sub
End Module
