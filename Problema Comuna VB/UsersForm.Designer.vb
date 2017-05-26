<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.addUser = New System.Windows.Forms.Button()
        Me.delUser = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(136, 24)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(821, 408)
        Me.dgv.TabIndex = 0
        '
        'addUser
        '
        Me.addUser.Location = New System.Drawing.Point(1069, 171)
        Me.addUser.Name = "addUser"
        Me.addUser.Size = New System.Drawing.Size(75, 23)
        Me.addUser.TabIndex = 1
        Me.addUser.Text = "Adauga"
        Me.addUser.UseVisualStyleBackColor = True
        '
        'delUser
        '
        Me.delUser.Location = New System.Drawing.Point(1069, 233)
        Me.delUser.Name = "delUser"
        Me.delUser.Size = New System.Drawing.Size(75, 23)
        Me.delUser.TabIndex = 2
        Me.delUser.Text = "Sterge"
        Me.delUser.UseVisualStyleBackColor = True
        '
        'UsersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 525)
        Me.Controls.Add(Me.delUser)
        Me.Controls.Add(Me.addUser)
        Me.Controls.Add(Me.dgv)
        Me.Name = "UsersForm"
        Me.Text = "UsersForm"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents addUser As Button
    Friend WithEvents delUser As Button
End Class
