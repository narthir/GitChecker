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

    Public ReadOnly Property Ahead As Integer
    Public ReadOnly Property Behind As Integer
    Public ReadOnly Property IsCurrent As Boolean


    Public ReadOnly Property AnyChanges() As Boolean
        Get
            Return Ahead > 0 OrElse Behind > 0
        End Get
    End Property

End Class