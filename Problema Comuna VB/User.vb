Public Class User
    Public nume As String
    Public pwd As String
    Enum accessLevel
        Admin
        User
        Guest
    End Enum
    Public access As accessLevel
End Class
