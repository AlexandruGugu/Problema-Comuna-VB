Public Class LogInForm
    Public Shared listaUtilizatori As List(Of User) = New List(Of User)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If listaUtilizatori.Count = 0 Then
            Form1.Show()
            UsersForm.Show()
        End If
    End Sub
    Shared Function Serialize(ByVal data As Object) As Byte()

        If TypeOf data Is Byte() Then Return data

        Using M As New IO.MemoryStream : Dim F As New Runtime.Serialization.Formatters.Binary.BinaryFormatter : F.Serialize(M, data) : Return M.ToArray() : End Using

    End Function

    Shared Function Deserialize(Of T)(ByVal data As Byte()) As T

        Using M As New IO.MemoryStream(data, False) : Return CType((New Runtime.Serialization.Formatters.Binary.BinaryFormatter).Deserialize(M), T) : End Using

    End Function

End Class