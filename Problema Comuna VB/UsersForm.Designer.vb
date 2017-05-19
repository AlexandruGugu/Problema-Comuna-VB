<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersForm
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Nume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Parola = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nivel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nume, Me.Parola, Me.Nivel})
        Me.dgv.Location = New System.Drawing.Point(430, 23)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(343, 408)
        Me.dgv.TabIndex = 0
        '
        'Nume
        '
        Me.Nume.HeaderText = "Nume"
        Me.Nume.Name = "Nume"
        '
        'Parola
        '
        Me.Parola.HeaderText = "Parola"
        Me.Parola.Name = "Parola"
        Me.Parola.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Nivel
        '
        Me.Nivel.HeaderText = "Nivel"
        Me.Nivel.Items.AddRange(New Object() {"Admin", "User", "Guest"})
        Me.Nivel.Name = "Nivel"
        Me.Nivel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Nivel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'UsersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 525)
        Me.Controls.Add(Me.dgv)
        Me.Name = "UsersForm"
        Me.Text = "UsersForm"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Nume As DataGridViewTextBoxColumn
    Friend WithEvents Parola As DataGridViewTextBoxColumn
    Friend WithEvents Nivel As DataGridViewComboBoxColumn
End Class
