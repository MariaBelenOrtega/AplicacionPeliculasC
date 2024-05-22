<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarPais))
        Me.txtidPais = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomPais = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataModPais = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dataModPais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidPais
        '
        Me.txtidPais.Location = New System.Drawing.Point(149, 123)
        Me.txtidPais.Name = "txtidPais"
        Me.txtidPais.Size = New System.Drawing.Size(242, 20)
        Me.txtidPais.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(63, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Id:"
        '
        'txtNomPais
        '
        Me.txtNomPais.Location = New System.Drawing.Point(149, 93)
        Me.txtNomPais.Name = "txtNomPais"
        Me.txtNomPais.Size = New System.Drawing.Size(242, 20)
        Me.txtNomPais.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(63, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre:"
        '
        'dataModPais
        '
        Me.dataModPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataModPais.Location = New System.Drawing.Point(67, 158)
        Me.dataModPais.Name = "dataModPais"
        Me.dataModPais.Size = New System.Drawing.Size(324, 280)
        Me.dataModPais.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 67)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Modifica Idioma"
        '
        'ModificarPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidPais)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomPais)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dataModPais)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarPais"
        Me.Text = "ModificarPais"
        CType(Me.dataModPais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidPais As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomPais As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dataModPais As DataGridView
    Friend WithEvents Label1 As Label
End Class
