<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaPais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaPais))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataBuscaPais = New System.Windows.Forms.DataGridView()
        Me.txtidPais = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomPais = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataBuscaPais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busca Pais"
        '
        'DataBuscaPais
        '
        Me.DataBuscaPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataBuscaPais.Location = New System.Drawing.Point(24, 135)
        Me.DataBuscaPais.Name = "DataBuscaPais"
        Me.DataBuscaPais.Size = New System.Drawing.Size(320, 239)
        Me.DataBuscaPais.TabIndex = 1
        '
        'txtidPais
        '
        Me.txtidPais.Location = New System.Drawing.Point(106, 109)
        Me.txtidPais.Name = "txtidPais"
        Me.txtidPais.Size = New System.Drawing.Size(238, 20)
        Me.txtidPais.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(27, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Id:"
        '
        'txtNomPais
        '
        Me.txtNomPais.Location = New System.Drawing.Point(106, 79)
        Me.txtNomPais.Name = "txtNomPais"
        Me.txtNomPais.Size = New System.Drawing.Size(238, 20)
        Me.txtNomPais.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(27, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplicacionPeliculas.My.Resources.Resources.Add_Image_icon_icons_com_54218
        Me.PictureBox1.Location = New System.Drawing.Point(272, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BusquedaPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 402)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtidPais)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomPais)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataBuscaPais)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BusquedaPais"
        Me.Text = "BusquedaPais"
        CType(Me.DataBuscaPais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataBuscaPais As DataGridView
    Friend WithEvents txtidPais As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomPais As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
