Imports System.Threading.Tasks

Public Class ConsoleController
    Implements IDisposable

    Private _proc As Process
    Delegate Sub OnDataRecievedDelegate(Data As String)

    Public ReadOnly Property ExitCode As Integer?

    Public ReadOnly Property Process As Process
        Get
            Return _proc
        End Get
    End Property


    Public Sub New(process As Process, onDataRec As OnDataRecievedDelegate, Optional recievingControl As Control = Nothing)
        _proc = process
        Dim procInf = process.StartInfo
        procInf.RedirectStandardOutput = True
        procInf.RedirectStandardError = True
        procInf.UseShellExecute = False
        procInf.CreateNoWindow = True


        Dim handleEvent = Sub(s1 As Object, e1 As DataReceivedEventArgs)
                              If recievingControl IsNot Nothing AndAlso recievingControl.InvokeRequired Then
                                  recievingControl.Invoke(Sub()
                                                              If e1.Data IsNot Nothing Then onDataRec(e1.Data)
                                                          End Sub)
                              Else
                                  If e1.Data IsNot Nothing Then onDataRec(e1.Data)
                              End If
                          End Sub

        AddHandler process.OutputDataReceived, handleEvent
        AddHandler process.ErrorDataReceived, handleEvent

        Threading.Thread.Sleep(100)
    End Sub

    Public Async Function Run() As Task
        Await Task.Run(Sub()
                           _proc.Start()
                           _proc.BeginOutputReadLine()
                           _proc.WaitForExit()
                           Me._ExitCode = _proc.ExitCode
                       End Sub)
        Await Task.Delay(100)
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                _proc.Dispose()
            End If
        End If
        disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub
#End Region
End Class
