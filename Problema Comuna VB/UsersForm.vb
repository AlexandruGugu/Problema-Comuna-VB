Public Class UsersForm
    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each utilizator As User In LogInForm.listaUtilizatori
            Dim index As Integer = dgv.NewRowIndex
            Dim combo As DataGridViewComboBoxColumn = CType(dgv.Columns(2), DataGridViewComboBoxColumn)
            If utilizator.access = User.accessLevel.Owner Then
                Continue For
            ElseIf utilizator.access = User.accessLevel.Admin And LogInForm.nivel <> User.accessLevel.Owner Then
                dgv.Item(0, index).Value = utilizator.nume
                dgv.Item(2, index).Value = combo.Items(0)
            Else
                dgv.Item(0, index).Value = utilizator.nume
                dgv.Item(1, index).Value = utilizator.pwd
                If utilizator.access = User.accessLevel.Admin Then
                    dgv.Item(2, index).Value = combo.Items(0)
                ElseIf utilizator.access = User.accessLevel.User Then
                    dgv.Item(2, index).Value = combo.Items(1)
                ElseIf utilizator.access = User.accessLevel.Guest Then
                    dgv.Item(2, index).Value = combo.Items(2)
                End If
            End If
            'dgv.Rows.Add()
            'dgv.BeginEdit(False)
            'dgv.EndEdit()
        Next
    End Sub
End Class