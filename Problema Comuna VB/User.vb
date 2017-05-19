<Serializable()> Public Class User
    Public nume As String
    Public pwd As String
    Enum accessLevel
        Owner
        Admin
        User
        Guest
        Unautherized
    End Enum
    Public access As accessLevel = accessLevel.Unautherized
    Public Sub New(Nume As String, Pwd As String, Access As accessLevel)
        Me.nume = Nume
        Me.pwd = Pwd
        Me.access = Access
    End Sub
End Class
