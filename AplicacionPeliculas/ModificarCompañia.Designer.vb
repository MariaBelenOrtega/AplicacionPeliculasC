<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCompañia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarCompañia))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidCom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomCom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataModCom = New System.Windows.Forms.DataGridView()
        CType(Me.dataModCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 67)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Modifica Compañia"
        '
        'txtidCom
        '
        Me.txtidCom.Location = New System.Drawing.Point(156, 110)
        Me.txtidCom.Name = "txtidCom"
        Me.txtidCom.Size = New System.Drawing.Size(242, 20)
        Me.txtidCom.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(70, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Id:"
        '
        'txtNomCom
        '
        Me.txtNomCom.Location = New System.Drawing.Point(156, 80)
        Me.txtNomCom.Name = "txtNomCom"
        Me.txtNomCom.Size = New System.Drawing.Size(242, 20)
        Me.txtNomCom.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(70, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre:"
        '
        'dataModCom
        '
        Me.dataModCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataModCom.Location = New System.Drawing.Point(74, 145)
        Me.dataModCom.Name = "dataModCom"
        Me.dataModCom.Size = New System.Drawing.Size(324, 280)
        Me.dataModCom.TabIndex = 23
        '
        'ModificarCompañia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidCom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomCom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dataModCom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarCompañia"
        Me.Text = "ModificarCompañia"
        CType(Me.dataModCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtidCom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomCom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dataModCom As DataGridView
End Class
