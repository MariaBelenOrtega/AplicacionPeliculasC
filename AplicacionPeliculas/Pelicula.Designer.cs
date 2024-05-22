using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Pelicula : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Pelicula));
            ToolStrip1 = new ToolStrip();
            PictureBox5 = new PictureBox();
            PictureBox5.Click += new EventHandler(PictureBox5_Click);
            PictureBox4 = new PictureBox();
            PictureBox4.Click += new EventHandler(PictureBox4_Click);
            PictureBox3 = new PictureBox();
            PictureBox3.Click += new EventHandler(PictureBox3_Click);
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click);
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PictureBox7 = new PictureBox();
            PictureBox7.Click += new EventHandler(PictureBox7_Click);
            txtId = new TextBox();
            Label7 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
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
            Label11 = new Label();
            txtpais = new TextBox();
            Label12 = new Label();
            comboAdult = new ComboBox();
            txtno = new TextBox();
            txtIdiomaOriginal = new TextBox();
            Label13 = new Label();
            PictureBox6 = new PictureBox();
            PictureBox6.Click += new EventHandler(PictureBox6_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox6).BeginInit();
            SuspendLayout();
            // 
            // ToolStrip1
            // 
            ToolStrip1.Location = new Point(0, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.Size = new Size(1078, 25);
            ToolStrip1.TabIndex = 69;
            ToolStrip1.Text = "ToolStrip1";
            // 
            // PictureBox5
            // 
            PictureBox5.Image = My.Resources.Resources.vote_counting_magnifier_icon_154141;
            PictureBox5.Location = new Point(931, 156);
            PictureBox5.Name = "PictureBox5";
            PictureBox5.Size = new Size(38, 31);
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox5.TabIndex = 70;
            PictureBox5.TabStop = false;
            // 
            // PictureBox4
            // 
            PictureBox4.Image = My.Resources.Resources._27_Edit_Text_256x256_35395;
            PictureBox4.Location = new Point(994, 264);
            PictureBox4.Name = "PictureBox4";
            PictureBox4.Size = new Size(72, 74);
            PictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox4.TabIndex = 68;
            PictureBox4.TabStop = false;
            // 
            // PictureBox3
            // 
            PictureBox3.Image = My.Resources.Resources.garbage_trash_bin_delete_icon_219499;
            PictureBox3.Location = new Point(994, 186);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(72, 72);
            PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox3.TabIndex = 67;
            PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            PictureBox2.Location = new Point(994, 108);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(72, 72);
            PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBox2.TabIndex = 66;
            PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources._1_83_icon_icons_com_68859;
            PictureBox1.Location = new Point(930, 196);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(38, 31);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 57;
            PictureBox1.TabStop = false;
            // 
            // PictureBox7
            // 
            PictureBox7.Image = My.Resources.Resources.vote_counting_magnifier_icon_154141;
            PictureBox7.Location = new Point(934, 270);
            PictureBox7.Name = "PictureBox7";
            PictureBox7.Size = new Size(35, 29);
            PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox7.TabIndex = 72;
            PictureBox7.TabStop = false;
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtId.Location = new Point(942, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(112, 31);
            txtId.TabIndex = 74;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label7.Location = new Point(733, 37);
            Label7.Name = "Label7";
            Label7.Size = new Size(198, 25);
            Label7.TabIndex = 73;
            Label7.Text = "Codigo de Pelicula:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 25.25f);
            Label1.Location = new Point(15, 33);
            Label1.Name = "Label1";
            Label1.Size = new Size(155, 39);
            Label1.TabIndex = 32;
            Label1.Text = "Peliculas";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label2.Location = new Point(17, 77);
            Label2.Name = "Label2";
            Label2.Size = new Size(93, 25);
            Label2.TabIndex = 33;
            Label2.Text = "Nombre:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label3.Location = new Point(17, 119);
            Label3.Name = "Label3";
            Label3.Size = new Size(173, 25);
            Label3.TabIndex = 34;
            Label3.Text = "Nombre Original:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label4.Location = new Point(17, 159);
            Label4.Name = "Label4";
            Label4.Size = new Size(104, 25);
            Label4.TabIndex = 35;
            Label4.Text = "Duracion:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label5.Location = new Point(17, 202);
            Label5.Name = "Label5";
            Label5.Size = new Size(237, 25);
            Label5.TabIndex = 36;
            Label5.Text = "Fecha de Lanzamiento:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label6.Location = new Point(17, 401);
            Label6.Name = "Label6";
            Label6.Size = new Size(131, 25);
            Label6.TabIndex = 37;
            Label6.Text = "Descripcion:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label8.Location = new Point(12, 264);
            Label8.Name = "Label8";
            Label8.Size = new Size(89, 25);
            Label8.TabIndex = 39;
            Label8.Text = "Genero:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label9.Location = new Point(549, 270);
            Label9.Name = "Label9";
            Label9.Size = new Size(115, 25);
            Label9.TabIndex = 40;
            Label9.Text = "Compañia:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label10.Location = new Point(563, 162);
            Label10.Name = "Label10";
            Label10.Size = new Size(81, 25);
            Label10.TabIndex = 41;
            Label10.Text = "Idioma:";
            // 
            // txtNombreOriginal
            // 
            txtNombreOriginal.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtNombreOriginal.Location = new Point(196, 116);
            txtNombreOriginal.Name = "txtNombreOriginal";
            txtNombreOriginal.Size = new Size(361, 31);
            txtNombreOriginal.TabIndex = 42;
            // 
            // txtFechaLanzamiento
            // 
            txtFechaLanzamiento.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtFechaLanzamiento.Location = new Point(251, 199);
            txtFechaLanzamiento.Name = "txtFechaLanzamiento";
            txtFechaLanzamiento.Size = new Size(306, 31);
            txtFechaLanzamiento.TabIndex = 43;
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtGenero.Location = new Point(116, 264);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(381, 31);
            txtGenero.TabIndex = 44;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtDescripcion.Location = new Point(154, 401);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(900, 31);
            txtDescripcion.TabIndex = 45;
            // 
            // txtIdioma
            // 
            txtIdioma.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtIdioma.Location = new Point(670, 156);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(255, 31);
            txtIdioma.TabIndex = 46;
            // 
            // txtCompania
            // 
            txtCompania.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtCompania.Location = new Point(670, 270);
            txtCompania.Name = "txtCompania";
            txtCompania.Size = new Size(255, 31);
            txtCompania.TabIndex = 47;
            // 
            // txtDuracion
            // 
            txtDuracion.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtDuracion.Location = new Point(127, 156);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(430, 31);
            txtDuracion.TabIndex = 48;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label11.Location = new Point(570, 205);
            Label11.Name = "Label11";
            Label11.Size = new Size(60, 25);
            Label11.TabIndex = 50;
            Label11.Text = "Pais:";
            // 
            // txtpais
            // 
            txtpais.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtpais.Location = new Point(670, 199);
            txtpais.Name = "txtpais";
            txtpais.Size = new Size(255, 31);
            txtpais.TabIndex = 51;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label12.Location = new Point(563, 119);
            Label12.Name = "Label12";
            Label12.Size = new Size(67, 25);
            Label12.TabIndex = 52;
            Label12.Text = "Adult:";
            // 
            // comboAdult
            // 
            comboAdult.Font = new Font("Microsoft Sans Serif", 15.25f);
            comboAdult.FormattingEnabled = true;
            comboAdult.Items.AddRange(new object[] { "True", "False" });
            comboAdult.Location = new Point(670, 119);
            comboAdult.Name = "comboAdult";
            comboAdult.Size = new Size(116, 33);
            comboAdult.TabIndex = 53;
            // 
            // txtno
            // 
            txtno.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtno.Location = new Point(119, 79);
            txtno.Name = "txtno";
            txtno.Size = new Size(438, 31);
            txtno.TabIndex = 54;
            // 
            // txtIdiomaOriginal
            // 
            txtIdiomaOriginal.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtIdiomaOriginal.Location = new Point(182, 310);
            txtIdiomaOriginal.Name = "txtIdiomaOriginal";
            txtIdiomaOriginal.Size = new Size(375, 31);
            txtIdiomaOriginal.TabIndex = 55;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label13.Location = new Point(17, 313);
            Label13.Name = "Label13";
            Label13.Size = new Size(161, 25);
            Label13.TabIndex = 56;
            Label13.Text = "Idioma Original:";
            // 
            // PictureBox6
            // 
            PictureBox6.Image = My.Resources.Resources.vote_counting_magnifier_icon_154141;
            PictureBox6.Location = new Point(503, 264);
            PictureBox6.Name = "PictureBox6";
            PictureBox6.Size = new Size(45, 34);
            PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox6.TabIndex = 71;
            PictureBox6.TabStop = false;
            // 
            // Pelicula
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 520);
            Controls.Add(txtId);
            Controls.Add(Label7);
            Controls.Add(PictureBox7);
            Controls.Add(PictureBox6);
            Controls.Add(PictureBox5);
            Controls.Add(ToolStrip1);
            Controls.Add(PictureBox4);
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
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pelicula";
            ((System.ComponentModel.ISupportInitialize)PictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox6).EndInit();
            Load += new EventHandler(Pelicula_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal PictureBox PictureBox1;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox3;
        internal PictureBox PictureBox4;
        internal ToolStrip ToolStrip1;
        internal PictureBox PictureBox5;
        internal PictureBox PictureBox7;
        internal TextBox txtId;
        internal Label Label7;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
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
        internal Label Label11;
        internal TextBox txtpais;
        internal Label Label12;
        internal ComboBox comboAdult;
        internal TextBox txtno;
        internal TextBox txtIdiomaOriginal;
        internal Label Label13;
        internal PictureBox PictureBox6;
    }
}