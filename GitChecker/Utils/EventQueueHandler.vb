Public Class EventQueueHandler

    Private appendLock As New Object
    Private timer As Timers.Timer
    Private lastEventData As Tuple(Of Object, EventArgs)

    Public Event TimeoutReached(sender As Object, ea As EventArgs)

    Public Sub New(timeout As TimeSpan)
        timer = New Timers.Timer(timeout.TotalMilliseconds)
        timer.AutoReset = False
        AddHandler timer.Elapsed, AddressOf fireAndReset
    End Sub

    Public Sub AppendAndResetTimer(sender As Object, ea As EventArgs)
        SyncLock appendLock
            timer.Stop()
            timer.Start()
            lastEventData = New Tuple(Of Object, EventArgs)(sender, ea)
        End SyncLock
    End Sub

    Private Sub fireAndReset()
        SyncLock appendLock
            timer.Stop()
            RaiseEvent TimeoutReached(lastEventData.Item1, lastEventData.Item2)
            lastEventData = Nothing
        End SyncLock
    End Sub

End Class
