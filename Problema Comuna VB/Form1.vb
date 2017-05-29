Public Class Form1
    Public txt As String
    Public dicCaractere As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Public dicCuvinte As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Public dicFraze As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles read.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim sr As New IO.StreamReader(OpenFileDialog1.FileName)
            txt = sr.ReadToEnd
        End If
        TextBox1.Text = txt
    End Sub

    Public Sub Caractere()
        For Each caracter As Char In txt
            If dicCaractere.ContainsKey(caracter.ToString()) Then
                dicCaractere.Item(caracter.ToString()) += 1
            Else
                dicCaractere.Add(caracter.ToString(), 1)
            End If
        Next
    End Sub
    Public Sub Cuvinte()
        Dim cuvinte() As String = txt.Split((" ,.!?()[]{}=+<>/" + vbNewLine + vbCr + vbLf).ToCharArray, StringSplitOptions.RemoveEmptyEntries)
        For Each cuvant As String In cuvinte
            If IsNumeric(cuvant) Then
                Continue For
            End If
            If dicCuvinte.ContainsKey(cuvant) Then
                dicCuvinte.Item(cuvant) += 1
            Else
                dicCuvinte.Add(cuvant, 1)
            End If
        Next
    End Sub

    Public Sub Fraze()
        Dim fraze() As String = txt.Split((vbNewLine + vbCr + vbLf).ToCharArray, StringSplitOptions.RemoveEmptyEntries)
        For Each fraza As String In fraze
            If IsNumeric(fraza) Then
                Continue For
            End If
            If dicFraze.ContainsKey(fraza) Then
                dicFraze.Item(fraza) += 1
            Else
                dicFraze.Add(fraza, 1)
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles save.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Caractere()
            Cuvinte()
            Fraze()
            Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)
            sw.WriteLine("----- FRAZE -----")
            WriteToFile(sw, dicFraze)
            sw.WriteLine("----- CUVINTE -----")
            WriteToFile(sw, dicCuvinte)
            sw.WriteLine("----- CARACTERE -----")
            WriteToFile(sw, dicCaractere)
            sw.Close()
            dicCaractere.Clear()
            dicCuvinte.Clear()
            dicFraze.Clear()
        End If
    End Sub
    Public Sub WriteToFile(file As IO.StreamWriter, dic As Dictionary(Of String, Integer))
        Dim keys As List(Of String) = dic.Keys.ToList
        keys.Sort()
        For Each key As String In keys
            file.WriteLine(key + ": " + dic(key).ToString())
        Next
    End Sub
    Public Sub WriteToTextbox(dic As Dictionary(Of String, Integer))
        Dim keys As List(Of String) = dic.Keys.ToList()
        keys.Sort()
        For Each key As String In keys
            ResultForm.TextBox1.Text += key + ": " + dic(key).ToString() + vbNewLine
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles editUsers.Click
        UsersForm.ShowDialog()
        While UsersForm.redeschide = True
            UsersForm.redeschide = False
            UsersForm.ShowDialog()
        End While
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles analiza.Click
        txt = TextBox1.Text
        Caractere()
        Cuvinte()
        Fraze()
        ResultForm.TextBox1.Clear()

        ResultForm.TextBox1.Text += "----- CARACTERE -----" + vbNewLine
        WriteToTextbox(dicCaractere)
        ResultForm.TextBox1.Text += "----- CUVINTE -----" + vbNewLine
        WriteToTextbox(dicCuvinte)
        ResultForm.TextBox1.Text += "----- FRAZE -----" + vbNewLine
        WriteToTextbox(dicFraze)

        ResultForm.ShowDialog()

        dicCaractere.Clear()
        dicCuvinte.Clear()
        dicFraze.Clear()
    End Sub
End Class
