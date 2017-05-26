<Serializable()> Public Class User
    Private name As String
    Private password As String
    Private accessLvl As accessLevel = accessLevel.Unautherized

    Enum accessLevel
        Owner
        Admin
        User
        Guest
        Unautherized
    End Enum


    Public Sub New(Nume As String, Pwd As String, Access As accessLevel)
        name = Nume
        password = Pwd
        accessLvl = Access
    End Sub

    Public Property nume() As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property pwd() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property access() As accessLevel
        Get
            Return accessLvl
        End Get
        Set(value As accessLevel)
            accessLvl = value
        End Set
    End Property
End Class
