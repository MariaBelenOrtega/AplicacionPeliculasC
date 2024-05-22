<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNombreOriginal = New System.Windows.Forms.TextBox()
        Me.txtFechaLanzamiento = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIdioma = New System.Windows.Forms.TextBox()
        Me.txtCompania = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtpais = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.comboAdult = New System.Windows.Forms.ComboBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.txtIdiomaOriginal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Peliculas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label2.Location = New System.Drawing.Point(30, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label3.Location = New System.Drawing.Point(30, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Original:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label4.Location = New System.Drawing.Point(30, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Duracion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label5.Location = New System.Drawing.Point(30, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Lanzamiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label6.Location = New System.Drawing.Point(30, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripcion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label7.Location = New System.Drawing.Point(440, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Codigo de Pelicula:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label8.Location = New System.Drawing.Point(30, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Genero:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label9.Location = New System.Drawing.Point(440, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Compañia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label10.Location = New System.Drawing.Point(440, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Idioma:"
        '
        'txtNombreOriginal
        '
        Me.txtNombreOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtNombreOriginal.Location = New System.Drawing.Point(209, 127)
        Me.txtNombreOriginal.Name = "txtNombreOriginal"
        Me.txtNombreOriginal.Size = New System.Drawing.Size(361, 31)
        Me.txtNombreOriginal.TabIndex = 11
        '
        'txtFechaLanzamiento
        '
        Me.txtFechaLanzamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtFechaLanzamiento.Location = New System.Drawing.Point(264, 210)
        Me.txtFechaLanzamiento.Name = "txtFechaLanzamiento"
        Me.txtFechaLanzamiento.Size = New System.Drawing.Size(177, 31)
        Me.txtFechaLanzamiento.TabIndex = 12
        '
        'txtGenero
        '
        Me.txtGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtGenero.Location = New System.Drawing.Point(113, 260)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(328, 31)
        Me.txtGenero.TabIndex = 13
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtDescripcion.Location = New System.Drawing.Point(167, 360)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(602, 31)
        Me.txtDescripcion.TabIndex = 14
        '
        'txtIdioma
        '
        Me.txtIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtIdioma.Location = New System.Drawing.Point(514, 167)
        Me.txtIdioma.Name = "txtIdioma"
        Me.txtIdioma.Size = New System.Drawing.Size(255, 31)
        Me.txtIdioma.TabIndex = 15
        '
        'txtCompania
        '
        Me.txtCompania.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtCompania.Location = New System.Drawing.Point(548, 260)
        Me.txtCompania.Name = "txtCompania"
        Me.txtCompania.Size = New System.Drawing.Size(221, 31)
        Me.txtCompania.TabIndex = 16
        '
        'txtDuracion
        '
        Me.txtDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtDuracion.Location = New System.Drawing.Point(140, 167)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(301, 31)
        Me.txtDuracion.TabIndex = 17
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtId.Location = New System.Drawing.Point(649, 31)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(112, 31)
        Me.txtId.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label11.Location = New System.Drawing.Point(448, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 25)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Pais:"
        '
        'txtpais
        '
        Me.txtpais.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtpais.Location = New System.Drawing.Point(514, 207)
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Size = New System.Drawing.Size(255, 31)
        Me.txtpais.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label12.Location = New System.Drawing.Point(576, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 25)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Adult:"
        '
        'comboAdult
        '
        Me.comboAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.comboAdult.FormattingEnabled = True
        Me.comboAdult.Items.AddRange(New Object() {"True", "False"})
        Me.comboAdult.Location = New System.Drawing.Point(649, 127)
        Me.comboAdult.Name = "comboAdult"
        Me.comboAdult.Size = New System.Drawing.Size(116, 33)
        Me.comboAdult.TabIndex = 24
        '
        'txtno
        '
        Me.txtno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtno.Location = New System.Drawing.Point(129, 82)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(361, 31)
        Me.txtno.TabIndex = 25
        '
        'txtIdiomaOriginal
        '
        Me.txtIdiomaOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.txtIdiomaOriginal.Location = New System.Drawing.Point(197, 309)
        Me.txtIdiomaOriginal.Name = "txtIdiomaOriginal"
        Me.txtIdiomaOriginal.Size = New System.Drawing.Size(244, 31)
        Me.txtIdiomaOriginal.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label13.Location = New System.Drawing.Point(30, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 25)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Idioma Original:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplicacionPeliculas.My.Resources.Resources.Add_Image_icon_icons_com_54218
        Me.PictureBox1.Location = New System.Drawing.Point(790, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AplicacionPeliculas.My.Resources.Resources.garbage_trash_bin_delete_icon_219499
        Me.PictureBox2.Location = New System.Drawing.Point(790, 148)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AplicacionPeliculas.My.Resources.Resources._17_104874
        Me.PictureBox3.Location = New System.Drawing.Point(790, 210)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 51)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 437)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtIdiomaOriginal)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.comboAdult)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtpais)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtCompania)
        Me.Controls.Add(Me.txtIdioma)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.txtFechaLanzamiento)
        Me.Controls.Add(Me.txtNombreOriginal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Buscar Pelicula"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNombreOriginal As TextBox
    Friend WithEvents txtFechaLanzamiento As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtIdioma As TextBox
    Friend WithEvents txtCompania As TextBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtpais As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents comboAdult As ComboBox
    Friend WithEvents txtno As TextBox
    Friend WithEvents txtIdiomaOriginal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
