Public Class Form1
    Public txt As String
    Public dicCaractere As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Public dicCuvinte As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Public dicFraze As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim sr As New IO.StreamReader(OpenFileDialog1.FileName)
            txt = sr.ReadToEnd
        End If
        Caractere()
        Cuvinte()
        Fraze()
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

    'Public Sub Fraze()
    '    Dim i As Integer = txt.IndexOf(vbNewLine, 0)
    '    Dim j As Integer = 0
    '    Dim substr As String
    '    While i <> -1
    '        substr = txt.Substring(j, i - j)
    '        If dicFraze.ContainsKey(substr) Then
    '            dicFraze.Item(substr) += 1
    '        Else
    '            dicFraze.Add(substr, 1)
    '        End If
    '        j = i + 1
    '        i = txt.IndexOf(vbNewLine, j)
    '    End While
    'End Sub

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)
            sw.WriteLine("----- FRAZE -----")
            WriteToFile(sw, dicFraze)
            sw.WriteLine("----- CUVINTE -----")
            WriteToFile(sw, dicCuvinte)
            sw.WriteLine("----- CARACTERE -----")
            WriteToFile(sw, dicCaractere)
            sw.Close()
        End If
    End Sub
    Public Sub WriteToFile(file As IO.StreamWriter, dic As Dictionary(Of String, Integer))
        Dim keys As List(Of String) = dic.Keys.ToList
        keys.Sort()
        For Each key As String In keys
            file.WriteLine(key + ": " + dic(key).ToString())
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
