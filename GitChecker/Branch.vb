Public MustInherit Class Branch

    Public Name As String

    Public Sub New(name As String)
        Me.Name = name
    End Sub

End Class

Public Class LocalBranch
    Inherits Branch

    Public Sub New(name As String, isCurrent As Boolean, ahead As Integer, behind As Integer)
        MyBase.New(name)
        Me.IsCurrent = isCurrent
        Me.Ahead = ahead
        Me.Behind = behind
    End Sub

    Public Ahead As Integer
    Public Behind As Integer
    Public IsCurrent As Boolean

End Class