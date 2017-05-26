Public Class UsersForm
    Public redeschide As Boolean = False
    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If dgv.DataSource IsNot Nothing Then
            Exit Sub
        End If

        dgv.AutoSize = True
        dgv.AutoGenerateColumns = False
        dgv.DataSource = LogInForm.listaUtilizatori

        Dim col As DataGridViewColumn = New DataGridViewTextBoxColumn
        col.DataPropertyName = "nume"
        col.Name = "nume"
        dgv.Columns.Add(col)

        col = New DataGridViewTextBoxColumn
        col.DataPropertyName = "pwd"
        col.Name = "parola"
        dgv.Columns.Add(col)

        Dim combo As New DataGridViewComboBoxColumn()
        combo.DataSource = [Enum].GetValues(GetType(User.accessLevel))
        combo.DataPropertyName = "access"
        combo.Name = "nivel"
        dgv.Columns.Add(combo)





        'For Each utilizator As User In LogInForm.listaUtilizatori
        '    Dim index As Integer = dgv.NewRowIndex
        '    Dim combo As DataGridViewComboBoxColumn = CType(dgv.Columns(2), DataGridViewComboBoxColumn)
        '    If utilizator.access = User.accessLevel.Owner Then
        '        Continue For
        '    ElseIf utilizator.access = User.accessLevel.Admin And LogInForm.nivel <> User.accessLevel.Owner Then
        '        dgv.Item(0, index).Value = utilizator.nume
        '        dgv.Item(2, index).Value = combo.Items(0)
        '    Else
        '        dgv.Item(0, index).Value = utilizator.nume
        '        dgv.Item(1, index).Value = utilizator.pwd
        '        If utilizator.access = User.accessLevel.Admin Then
        '            dgv.Item(2, index).Value = combo.Items(0)
        '        ElseIf utilizator.access = User.accessLevel.User Then
        '            dgv.Item(2, index).Value = combo.Items(1)
        '        ElseIf utilizator.access = User.accessLevel.Guest Then
        '            dgv.Item(2, index).Value = combo.Items(2)
        '        End If
        '    End If
        'Next
    End Sub

    Private Sub addUser_Click(sender As Object, e As EventArgs) Handles addUser.Click
        LogInForm.listaUtilizatori.Add(New User("", "", User.accessLevel.Unautherized))
        Close()
        redeschide = True
    End Sub

    Private Sub delUser_Click(sender As Object, e As EventArgs) Handles delUser.Click
        LogInForm.listaUtilizatori.RemoveAt(dgv.CurrentRow.Index)
        redeschide = True
        Close()
    End Sub
End Class