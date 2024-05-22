<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TablasIntermedias
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPelicula = New System.Windows.Forms.TextBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picActualizar = New System.Windows.Forms.PictureBox()
        Me.PicAgregar = New System.Windows.Forms.PictureBox()
        Me.PicEliminar = New System.Windows.Forms.PictureBox()
        Me.PicBuscaPeli = New System.Windows.Forms.PictureBox()
        Me.PicBusca = New System.Windows.Forms.PictureBox()
        CType(Me.picActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBuscaPeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 67)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Agregar"
        '
        'txtPelicula
        '
        Me.txtPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPelicula.Location = New System.Drawing.Point(145, 124)
        Me.txtPelicula.Name = "txtPelicula"
        Me.txtPelicula.Size = New System.Drawing.Size(234, 26)
        Me.txtPelicula.TabIndex = 15
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(145, 174)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(234, 26)
        Me.txt.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Pelicula:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Label3"
        '
        'picActualizar
        '
        Me.picActualizar.Image = Global.AplicacionPeliculas.My.Resources.Resources._27_Edit_Text_256x256_35395
        Me.picActualizar.Location = New System.Drawing.Point(63, 240)
        Me.picActualizar.Name = "picActualizar"
        Me.picActualizar.Size = New System.Drawing.Size(77, 73)
        Me.picActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picActualizar.TabIndex = 19
        Me.picActualizar.TabStop = False
        '
        'PicAgregar
        '
        Me.PicAgregar.Image = Global.AplicacionPeliculas.My.Resources.Resources.Add_Image_icon_icons_com_54218
        Me.PicAgregar.Location = New System.Drawing.Point(182, 240)
        Me.PicAgregar.Name = "PicAgregar"
        Me.PicAgregar.Size = New System.Drawing.Size(77, 74)
        Me.PicAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAgregar.TabIndex = 20
        Me.PicAgregar.TabStop = False
        '
        'PicEliminar
        '
        Me.PicEliminar.Image = Global.AplicacionPeliculas.My.Resources.Resources.garbage_trash_bin_delete_icon_219499
        Me.PicEliminar.Location = New System.Drawing.Point(302, 239)
        Me.PicEliminar.Name = "PicEliminar"
        Me.PicEliminar.Size = New System.Drawing.Size(77, 74)
        Me.PicEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicEliminar.TabIndex = 21
        Me.PicEliminar.TabStop = False
        '
        'PicBuscaPeli
        '
        Me.PicBuscaPeli.Image = Global.AplicacionPeliculas.My.Resources.Resources.loupe_79257
        Me.PicBuscaPeli.Location = New System.Drawing.Point(385, 124)
        Me.PicBuscaPeli.Name = "PicBuscaPeli"
        Me.PicBuscaPeli.Size = New System.Drawing.Size(41, 26)
        Me.PicBuscaPeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBuscaPeli.TabIndex = 22
        Me.PicBuscaPeli.TabStop = False
        '
        'PicBusca
        '
        Me.PicBusca.Image = Global.AplicacionPeliculas.My.Resources.Resources.loupe_79257
        Me.PicBusca.Location = New System.Drawing.Point(385, 174)
        Me.PicBusca.Name = "PicBusca"
        Me.PicBusca.Size = New System.Drawing.Size(41, 26)
        Me.PicBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBusca.TabIndex = 23
        Me.PicBusca.TabStop = False
        '
        'TablasIntermedias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 354)
        Me.Controls.Add(Me.PicBusca)
        Me.Controls.Add(Me.PicBuscaPeli)
        Me.Controls.Add(Me.PicEliminar)
        Me.Controls.Add(Me.PicAgregar)
        Me.Controls.Add(Me.picActualizar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.txtPelicula)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TablasIntermedias"
        Me.Text = "TablasIntermedias"
        CType(Me.picActualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBuscaPeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBusca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPelicula As TextBox
    Friend WithEvents txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents picActualizar As PictureBox
    Friend WithEvents PicAgregar As PictureBox
    Friend WithEvents PicEliminar As PictureBox
    Friend WithEvents PicBuscaPeli As PictureBox
    Friend WithEvents PicBusca As PictureBox
End Class
