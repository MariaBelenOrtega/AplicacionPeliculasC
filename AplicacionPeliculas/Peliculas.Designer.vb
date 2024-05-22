<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Peliculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Peliculas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.comboGenero = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboPais = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicAgregar = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label1.Location = New System.Drawing.Point(462, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Genero:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 112)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1222, 590)
        Me.DataGridView1.TabIndex = 2
        '
        'comboGenero
        '
        Me.comboGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.comboGenero.FormattingEnabled = True
        Me.comboGenero.Location = New System.Drawing.Point(559, 39)
        Me.comboGenero.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboGenero.Name = "comboGenero"
        Me.comboGenero.Size = New System.Drawing.Size(373, 33)
        Me.comboGenero.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label2.Location = New System.Drawing.Point(37, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pais:"
        '
        'comboPais
        '
        Me.comboPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.comboPais.FormattingEnabled = True
        Me.comboPais.Location = New System.Drawing.Point(105, 39)
        Me.comboPais.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboPais.Name = "comboPais"
        Me.comboPais.Size = New System.Drawing.Size(325, 33)
        Me.comboPais.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplicacionPeliculas.My.Resources.Resources._3643769_building_home_house_main_menu_start_113416
        Me.PictureBox1.Location = New System.Drawing.Point(1053, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'PicAgregar
        '
        Me.PicAgregar.Image = Global.AplicacionPeliculas.My.Resources.Resources.Add_Image_icon_icons_com_54218
        Me.PicAgregar.Location = New System.Drawing.Point(1170, 13)
        Me.PicAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PicAgregar.Name = "PicAgregar"
        Me.PicAgregar.Size = New System.Drawing.Size(94, 89)
        Me.PicAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAgregar.TabIndex = 29
        Me.PicAgregar.TabStop = False
        '
        'Peliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 727)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicAgregar)
        Me.Controls.Add(Me.comboPais)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboGenero)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Peliculas"
        Me.Text = "Peliculas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents comboGenero As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comboPais As ComboBox
    Friend WithEvents PicAgregar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
