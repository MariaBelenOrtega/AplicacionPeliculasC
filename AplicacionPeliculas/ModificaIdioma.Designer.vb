<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaIdioma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificaIdioma))
        Me.txtidIdioma = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomIdioma = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataModIdioma = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataModIdioma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidIdioma
        '
        Me.txtidIdioma.Location = New System.Drawing.Point(119, 115)
        Me.txtidIdioma.Name = "txtidIdioma"
        Me.txtidIdioma.Size = New System.Drawing.Size(252, 20)
        Me.txtidIdioma.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(40, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Id:"
        '
        'txtNomIdioma
        '
        Me.txtNomIdioma.Location = New System.Drawing.Point(119, 85)
        Me.txtNomIdioma.Name = "txtNomIdioma"
        Me.txtNomIdioma.Size = New System.Drawing.Size(252, 20)
        Me.txtNomIdioma.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(40, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre:"
        '
        'DataModIdioma
        '
        Me.DataModIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataModIdioma.Location = New System.Drawing.Point(44, 152)
        Me.DataModIdioma.Name = "DataModIdioma"
        Me.DataModIdioma.Size = New System.Drawing.Size(328, 354)
        Me.DataModIdioma.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 67)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Modifica Idioma"
        '
        'ModificaIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 517)
        Me.Controls.Add(Me.txtidIdioma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomIdioma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataModIdioma)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificaIdioma"
        Me.Text = "ModificaIdioma"
        CType(Me.DataModIdioma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidIdioma As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomIdioma As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataModIdioma As DataGridView
    Friend WithEvents Label1 As Label
End Class
