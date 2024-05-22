<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaGenero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificaGenero))
        Me.txtidGen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomGen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataModgenero = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataModgenero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidGen
        '
        Me.txtidGen.Location = New System.Drawing.Point(122, 116)
        Me.txtidGen.Name = "txtidGen"
        Me.txtidGen.Size = New System.Drawing.Size(252, 20)
        Me.txtidGen.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(43, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Id:"
        '
        'txtNomGen
        '
        Me.txtNomGen.Location = New System.Drawing.Point(122, 86)
        Me.txtNomGen.Name = "txtNomGen"
        Me.txtNomGen.Size = New System.Drawing.Size(252, 20)
        Me.txtNomGen.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(43, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre:"
        '
        'DataModgenero
        '
        Me.DataModgenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataModgenero.Location = New System.Drawing.Point(47, 153)
        Me.DataModgenero.Name = "DataModgenero"
        Me.DataModgenero.Size = New System.Drawing.Size(328, 354)
        Me.DataModgenero.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 67)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Modifica Genero"
        '
        'ModificaGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 519)
        Me.Controls.Add(Me.txtidGen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomGen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataModgenero)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificaGenero"
        Me.Text = "ModificaGenero"
        CType(Me.DataModgenero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidGen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomGen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataModgenero As DataGridView
    Friend WithEvents Label1 As Label
End Class
