<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreU = New System.Windows.Forms.TextBox()
        Me.txtUsernameU = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.PicBuscar = New System.Windows.Forms.PictureBox()
        Me.PicActualizar = New System.Windows.Forms.PictureBox()
        Me.PicBorrar = New System.Windows.Forms.PictureBox()
        Me.picAgregar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PicBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBorrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'txtNombreU
        '
        Me.txtNombreU.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreU.Location = New System.Drawing.Point(112, 162)
        Me.txtNombreU.Name = "txtNombreU"
        Me.txtNombreU.Size = New System.Drawing.Size(272, 29)
        Me.txtNombreU.TabIndex = 3
        '
        'txtUsernameU
        '
        Me.txtUsernameU.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameU.Location = New System.Drawing.Point(112, 197)
        Me.txtUsernameU.Name = "txtUsernameU"
        Me.txtUsernameU.Size = New System.Drawing.Size(272, 29)
        Me.txtUsernameU.TabIndex = 7
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(112, 232)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(272, 29)
        Me.txtContraseña.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Username:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Id:"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(112, 127)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(272, 29)
        Me.txtId.TabIndex = 13
        '
        'PicBuscar
        '
        Me.PicBuscar.Image = Global.AplicacionPeliculas.My.Resources.Resources.loupe_79257
        Me.PicBuscar.Location = New System.Drawing.Point(318, 12)
        Me.PicBuscar.Name = "PicBuscar"
        Me.PicBuscar.Size = New System.Drawing.Size(83, 75)
        Me.PicBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBuscar.TabIndex = 12
        Me.PicBuscar.TabStop = False
        '
        'PicActualizar
        '
        Me.PicActualizar.Image = Global.AplicacionPeliculas.My.Resources.Resources.UserEdit_40958
        Me.PicActualizar.Location = New System.Drawing.Point(16, 287)
        Me.PicActualizar.Name = "PicActualizar"
        Me.PicActualizar.Size = New System.Drawing.Size(83, 66)
        Me.PicActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicActualizar.TabIndex = 6
        Me.PicActualizar.TabStop = False
        '
        'PicBorrar
        '
        Me.PicBorrar.Image = Global.AplicacionPeliculas.My.Resources.Resources.UserRemove_40959
        Me.PicBorrar.Location = New System.Drawing.Point(294, 287)
        Me.PicBorrar.Name = "PicBorrar"
        Me.PicBorrar.Size = New System.Drawing.Size(90, 66)
        Me.PicBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBorrar.TabIndex = 5
        Me.PicBorrar.TabStop = False
        '
        'picAgregar
        '
        Me.picAgregar.Image = Global.AplicacionPeliculas.My.Resources.Resources.UserAdd_40960
        Me.picAgregar.Location = New System.Drawing.Point(154, 287)
        Me.picAgregar.Name = "picAgregar"
        Me.picAgregar.Size = New System.Drawing.Size(82, 66)
        Me.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAgregar.TabIndex = 4
        Me.picAgregar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplicacionPeliculas.My.Resources.Resources.administrator_3552
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 102)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 391)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.PicBuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsernameU)
        Me.Controls.Add(Me.PicActualizar)
        Me.Controls.Add(Me.PicBorrar)
        Me.Controls.Add(Me.picAgregar)
        Me.Controls.Add(Me.txtNombreU)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        CType(Me.PicBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicActualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBorrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreU As TextBox
    Friend WithEvents picAgregar As PictureBox
    Friend WithEvents PicBorrar As PictureBox
    Friend WithEvents PicActualizar As PictureBox
    Friend WithEvents txtUsernameU As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PicBuscar As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtId As TextBox
End Class
