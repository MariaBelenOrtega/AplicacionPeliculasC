<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compañia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compañia))
        Me.txtidCom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomCom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicActualizar = New System.Windows.Forms.PictureBox()
        Me.PicBorrar = New System.Windows.Forms.PictureBox()
        Me.picAgregar = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBorrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidCom
        '
        Me.txtidCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtidCom.Location = New System.Drawing.Point(126, 79)
        Me.txtidCom.Name = "txtidCom"
        Me.txtidCom.Size = New System.Drawing.Size(177, 26)
        Me.txtidCom.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(27, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 20)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Id:"
        '
        'txtNomCom
        '
        Me.txtNomCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtNomCom.Location = New System.Drawing.Point(126, 118)
        Me.txtNomCom.Name = "txtNomCom"
        Me.txtNomCom.Size = New System.Drawing.Size(177, 26)
        Me.txtNomCom.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(30, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 39)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Compañia"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplicacionPeliculas.My.Resources.Resources.vote_counting_magnifier_icon_154141
        Me.PictureBox1.Location = New System.Drawing.Point(248, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'PicActualizar
        '
        Me.PicActualizar.Image = Global.AplicacionPeliculas.My.Resources.Resources._27_Edit_Text_256x256_35395
        Me.PicActualizar.Location = New System.Drawing.Point(31, 216)
        Me.PicActualizar.Name = "PicActualizar"
        Me.PicActualizar.Size = New System.Drawing.Size(72, 74)
        Me.PicActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicActualizar.TabIndex = 104
        Me.PicActualizar.TabStop = False
        '
        'PicBorrar
        '
        Me.PicBorrar.Image = Global.AplicacionPeliculas.My.Resources.Resources.garbage_trash_bin_delete_icon_219499
        Me.PicBorrar.Location = New System.Drawing.Point(135, 218)
        Me.PicBorrar.Name = "PicBorrar"
        Me.PicBorrar.Size = New System.Drawing.Size(72, 72)
        Me.PicBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicBorrar.TabIndex = 103
        Me.PicBorrar.TabStop = False
        '
        'picAgregar
        '
        Me.picAgregar.Image = Global.AplicacionPeliculas.My.Resources.Resources.Add_Image_icon_icons_com_54218
        Me.picAgregar.Location = New System.Drawing.Point(231, 218)
        Me.picAgregar.Name = "picAgregar"
        Me.picAgregar.Size = New System.Drawing.Size(72, 72)
        Me.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picAgregar.TabIndex = 102
        Me.picAgregar.TabStop = False
        '
        'Compañia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 391)
        Me.Controls.Add(Me.txtidCom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicActualizar)
        Me.Controls.Add(Me.PicBorrar)
        Me.Controls.Add(Me.picAgregar)
        Me.Controls.Add(Me.txtNomCom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Compañia"
        Me.Text = "Compañia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicActualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBorrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidCom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PicActualizar As PictureBox
    Friend WithEvents PicBorrar As PictureBox
    Friend WithEvents picAgregar As PictureBox
    Friend WithEvents txtNomCom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
