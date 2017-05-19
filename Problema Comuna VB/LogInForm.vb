Public Class LogInForm
    Public Shared listaUtilizatori As List(Of User) = New List(Of User)
    Public Shadows nivel As User.accessLevel = User.accessLevel.Unautherized
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IO.File.Exists(Application.StartupPath + "\\Users.bin") Then
            Dim bytes As Byte() = IO.File.ReadAllBytes(Application.StartupPath + "\\Users.bin")
            listaUtilizatori = Deserialize(Of List(Of User))(bytes)
        Else
            listaUtilizatori.Add(New User("Alex", "1234", User.accessLevel.Owner))
        End If
        Dim index As Integer = listaUtilizatori.FindIndex(Function(p) p.nume = nume.Text And p.pwd = pwd.Text)
        If index <> -1 Then
            nivel = listaUtilizatori(index).access
            Form1.Show()
            Form1.AddOwnedForm(Me)
            If nivel = User.accessLevel.Owner Or nivel = User.accessLevel.Admin Then
                Form1.editUsers.Show()
            End If
            Hide()
        End If
    End Sub

    Shared Function Serialize(ByVal data As Object) As Byte()

        If TypeOf data Is Byte() Then Return data

        Using M As New IO.MemoryStream : Dim F As New Runtime.Serialization.Formatters.Binary.BinaryFormatter : F.Serialize(M, data) : Return M.ToArray() : End Using

    End Function

    Shared Function Deserialize(Of T)(ByVal data As Byte()) As T

        Using M As New IO.MemoryStream(data, False) : Return CType((New Runtime.Serialization.Formatters.Binary.BinaryFormatter).Deserialize(M), T) : End Using

    End Function

    Private Sub LogInForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim bytes As Byte() = Serialize(listaUtilizatori)
        IO.File.WriteAllBytes(Application.StartupPath + "\\Users.bin", bytes)
    End Sub

End Class