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
        Me.read = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.editUsers = New System.Windows.Forms.Button()
        Me.analiza = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'read
        '
        Me.read.Location = New System.Drawing.Point(42, 66)
        Me.read.Name = "read"
        Me.read.Size = New System.Drawing.Size(94, 39)
        Me.read.TabIndex = 0
        Me.read.Text = "Incarca din fisier"
        Me.read.UseVisualStyleBackColor = True
        Me.read.Visible = False
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(42, 129)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(95, 42)
        Me.save.TabIndex = 2
        Me.save.Text = "Salvare in fisier"
        Me.save.UseVisualStyleBackColor = True
        Me.save.Visible = False
        '
        'editUsers
        '
        Me.editUsers.Location = New System.Drawing.Point(41, 240)
        Me.editUsers.Name = "editUsers"
        Me.editUsers.Size = New System.Drawing.Size(95, 39)
        Me.editUsers.TabIndex = 3
        Me.editUsers.Text = "Modificare utilizatori"
        Me.editUsers.UseVisualStyleBackColor = True
        Me.editUsers.Visible = False
        '
        'analiza
        '
        Me.analiza.Location = New System.Drawing.Point(41, 332)
        Me.analiza.Name = "analiza"
        Me.analiza.Size = New System.Drawing.Size(95, 34)
        Me.analiza.TabIndex = 4
        Me.analiza.Text = "Analiza text"
        Me.analiza.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(311, 66)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(465, 300)
        Me.TextBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 465)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.analiza)
        Me.Controls.Add(Me.editUsers)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.read)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents read As Button
    Friend WithEvents save As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents editUsers As Button
    Friend WithEvents analiza As Button
    Friend WithEvents TextBox1 As TextBox
End Class
