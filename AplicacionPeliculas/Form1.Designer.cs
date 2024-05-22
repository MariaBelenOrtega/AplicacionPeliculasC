using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            txtNombreOriginal = new TextBox();
            txtFechaLanzamiento = new TextBox();
            txtGenero = new TextBox();
            txtDescripcion = new TextBox();
            txtIdioma = new TextBox();
            txtCompania = new TextBox();
            txtDuracion = new TextBox();
            txtId = new TextBox();
            Label11 = new Label();
            txtpais = new TextBox();
            Label12 = new Label();
            comboAdult = new ComboBox();
            txtno = new TextBox();
            txtIdiomaOriginal = new TextBox();
            Label13 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click);
            PictureBox3 = new PictureBox();
            PictureBox3.Click += new EventHandler(PictureBox3_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 25.25f);
            Label1.Location = new Point(28, 23);
            Label1.Name = "Label1";
            Label1.Size = new Size(155, 39);
            Label1.TabIndex = 0;
            Label1.Text = "Peliculas";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label2.Location = new Point(30, 88);
            Label2.Name = "Label2";
            Label2.Size = new Size(93, 25);
            Label2.TabIndex = 1;
            Label2.Text = "Nombre:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label3.Location = new Point(30, 130);
            Label3.Name = "Label3";
            Label3.Size = new Size(173, 25);
            Label3.TabIndex = 2;
            Label3.Text = "Nombre Original:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label4.Location = new Point(30, 170);
            Label4.Name = "Label4";
            Label4.Size = new Size(104, 25);
            Label4.TabIndex = 3;
            Label4.Text = "Duracion:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label5.Location = new Point(30, 213);
            Label5.Name = "Label5";
            Label5.Size = new Size(237, 25);
            Label5.TabIndex = 4;
            Label5.Text = "Fecha de Lanzamiento:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label6.Location = new Point(30, 363);
            Label6.Name = "Label6";
            Label6.Size = new Size(131, 25);
            Label6.TabIndex = 5;
            Label6.Text = "Descripcion:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label7.Location = new Point(440, 35);
            Label7.Name = "Label7";
            Label7.Size = new Size(198, 25);
            Label7.TabIndex = 6;
            Label7.Text = "Codigo de Pelicula:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label8.Location = new Point(30, 263);
            Label8.Name = "Label8";
            Label8.Size = new Size(89, 25);
            Label8.TabIndex = 7;
            Label8.Text = "Genero:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label9.Location = new Point(440, 263);
            Label9.Name = "Label9";
            Label9.Size = new Size(115, 25);
            Label9.TabIndex = 8;
            Label9.Text = "Compañia:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label10.Location = new Point(440, 170);
            Label10.Name = "Label10";
            Label10.Size = new Size(81, 25);
            Label10.TabIndex = 9;
            Label10.Text = "Idioma:";
            // 
            // txtNombreOriginal
            // 
            txtNombreOriginal.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtNombreOriginal.Location = new Point(209, 127);
            txtNombreOriginal.Name = "txtNombreOriginal";
            txtNombreOriginal.Size = new Size(361, 31);
            txtNombreOriginal.TabIndex = 11;
            // 
            // txtFechaLanzamiento
            // 
            txtFechaLanzamiento.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtFechaLanzamiento.Location = new Point(264, 210);
            txtFechaLanzamiento.Name = "txtFechaLanzamiento";
            txtFechaLanzamiento.Size = new Size(177, 31);
            txtFechaLanzamiento.TabIndex = 12;
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtGenero.Location = new Point(113, 260);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(328, 31);
            txtGenero.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtDescripcion.Location = new Point(167, 360);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(602, 31);
            txtDescripcion.TabIndex = 14;
            // 
            // txtIdioma
            // 
            txtIdioma.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtIdioma.Location = new Point(514, 167);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(255, 31);
            txtIdioma.TabIndex = 15;
            // 
            // txtCompania
            // 
            txtCompania.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtCompania.Location = new Point(548, 260);
            txtCompania.Name = "txtCompania";
            txtCompania.Size = new Size(221, 31);
            txtCompania.TabIndex = 16;
            // 
            // txtDuracion
            // 
            txtDuracion.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtDuracion.Location = new Point(140, 167);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(301, 31);
            txtDuracion.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtId.Location = new Point(649, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(112, 31);
            txtId.TabIndex = 19;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label11.Location = new Point(448, 213);
            Label11.Name = "Label11";
            Label11.Size = new Size(60, 25);
            Label11.TabIndex = 21;
            Label11.Text = "Pais:";
            // 
            // txtpais
            // 
            txtpais.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtpais.Location = new Point(514, 207);
            txtpais.Name = "txtpais";
            txtpais.Size = new Size(255, 31);
            txtpais.TabIndex = 22;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label12.Location = new Point(576, 130);
            Label12.Name = "Label12";
            Label12.Size = new Size(67, 25);
            Label12.TabIndex = 23;
            Label12.Text = "Adult:";
            // 
            // comboAdult
            // 
            comboAdult.Font = new Font("Microsoft Sans Serif", 15.25f);
            comboAdult.FormattingEnabled = true;
            comboAdult.Items.AddRange(new object[] { "True", "False" });
            comboAdult.Location = new Point(649, 127);
            comboAdult.Name = "comboAdult";
            comboAdult.Size = new Size(116, 33);
            comboAdult.TabIndex = 24;
            // 
            // txtno
            // 
            txtno.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtno.Location = new Point(129, 82);
            txtno.Name = "txtno";
            txtno.Size = new Size(361, 31);
            txtno.TabIndex = 25;
            // 
            // txtIdiomaOriginal
            // 
            txtIdiomaOriginal.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtIdiomaOriginal.Location = new Point(197, 309);
            txtIdiomaOriginal.Name = "txtIdiomaOriginal";
            txtIdiomaOriginal.Size = new Size(244, 31);
            txtIdiomaOriginal.TabIndex = 29;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label13.Location = new Point(30, 309);
            Label13.Name = "Label13";
            Label13.Size = new Size(161, 25);
            Label13.TabIndex = 30;
            Label13.Text = "Idioma Original:";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            PictureBox1.Location = new Point(790, 82);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(65, 50);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 31;
            PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = My.Resources.Resources.garbage_trash_bin_delete_icon_219499;
            PictureBox2.Location = new Point(790, 148);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(65, 50);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 32;
            PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            PictureBox3.Image = My.Resources.Resources._17_104874;
            PictureBox3.Location = new Point(790, 210);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(65, 51);
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox3.TabIndex = 33;
            PictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 437);
            Controls.Add(PictureBox3);
            Controls.Add(PictureBox2);
            Controls.Add(PictureBox1);
            Controls.Add(Label13);
            Controls.Add(txtIdiomaOriginal);
            Controls.Add(txtno);
            Controls.Add(comboAdult);
            Controls.Add(Label12);
            Controls.Add(txtpais);
            Controls.Add(Label11);
            Controls.Add(txtId);
            Controls.Add(txtDuracion);
            Controls.Add(txtCompania);
            Controls.Add(txtIdioma);
            Controls.Add(txtDescripcion);
            Controls.Add(txtGenero);
            Controls.Add(txtFechaLanzamiento);
            Controls.Add(txtNombreOriginal);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Buscar Pelicula";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
        internal TextBox txtNombreOriginal;
        internal TextBox txtFechaLanzamiento;
        internal TextBox txtGenero;
        internal TextBox txtDescripcion;
        internal TextBox txtIdioma;
        internal TextBox txtCompania;
        internal TextBox txtDuracion;
        internal TextBox txtId;
        internal Label Label11;
        internal TextBox txtpais;
        internal Label Label12;
        internal ComboBox comboAdult;
        internal TextBox txtno;
        internal TextBox txtIdiomaOriginal;
        internal Label Label13;
        internal PictureBox PictureBox1;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox3;
    }
}