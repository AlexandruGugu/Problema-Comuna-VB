<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.editUsers = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Selectare Fisier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 97)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 42)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Salvare rezultat"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'editUsers
        '
        Me.editUsers.Location = New System.Drawing.Point(32, 160)
        Me.editUsers.Name = "editUsers"
        Me.editUsers.Size = New System.Drawing.Size(95, 39)
        Me.editUsers.TabIndex = 3
        Me.editUsers.Text = "Modificare utilizatori"
        Me.editUsers.UseVisualStyleBackColor = True
        Me.editUsers.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(32, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 34)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 465)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.editUsers)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents editUsers As Button
    Friend WithEvents Button4 As Button
End Class
