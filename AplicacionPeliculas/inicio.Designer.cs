using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class inicio : Form
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
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Button6 = new Button();
            Button6.Click += new EventHandler(Button6_Click);
            Button7 = new Button();
            Button7.Click += new EventHandler(Button7_Click);
            Button8 = new Button();
            Button8.Click += new EventHandler(Button8_Click);
            Button9 = new Button();
            Button9.Click += new EventHandler(Button9_Click);
            Button10 = new Button();
            Button10.Click += new EventHandler(Button10_Click);
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 15.25f);
            Button2.Location = new Point(24, 171);
            Button2.Name = "Button2";
            Button2.Size = new Size(332, 90);
            Button2.TabIndex = 1;
            Button2.Text = "Pelicula";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Font = new Font("Microsoft Sans Serif", 15.25f);
            Button3.Location = new Point(24, 267);
            Button3.Name = "Button3";
            Button3.Size = new Size(332, 90);
            Button3.TabIndex = 2;
            Button3.Text = "Genero";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.Font = new Font("Microsoft Sans Serif", 15.25f);
            Button4.Location = new Point(384, 171);
            Button4.Name = "Button4";
            Button4.Size = new Size(332, 90);
            Button4.TabIndex = 3;
            Button4.Text = "BuscaPais";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            Button5.Font = new Font("Microsoft Sans Serif", 13.25f);
            Button5.Location = new Point(384, 267);
            Button5.Name = "Button5";
            Button5.Size = new Size(332, 90);
            Button5.TabIndex = 4;
            Button5.Text = "BuscaGenero";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.Font = new Font("Microsoft Sans Serif", 15.25f);
            Button6.Location = new Point(384, 363);
            Button6.Name = "Button6";
            Button6.Size = new Size(332, 90);
            Button6.TabIndex = 5;
            Button6.Text = "BuscaCompañia";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            Button7.Font = new Font("Microsoft Sans Serif", 15.25f);
            Button7.Location = new Point(384, 459);
            Button7.Name = "Button7";
            Button7.Size = new Size(332, 90);
            Button7.TabIndex = 6;
            Button7.Text = "BuscaIdioma";
            Button7.UseVisualStyleBackColor = true;
            // 
            // Button8
            // 
            Button8.Font = new Font("Microsoft Sans Serif", 15.25f);
            Button8.Location = new Point(24, 363);
            Button8.Name = "Button8";
            Button8.Size = new Size(332, 90);
            Button8.TabIndex = 7;
            Button8.Text = "Idioma";
            Button8.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            Button9.Font = new Font("Microsoft Sans Serif", 15.25f);
            Button9.Location = new Point(24, 459);
            Button9.Name = "Button9";
            Button9.Size = new Size(332, 90);
            Button9.TabIndex = 8;
            Button9.Text = "Pais";
            Button9.UseVisualStyleBackColor = true;
            // 
            // Button10
            // 
            Button10.Font = new Font("Microsoft Sans Serif", 15.25f);
            Button10.Location = new Point(24, 555);
            Button10.Name = "Button10";
            Button10.Size = new Size(332, 90);
            Button10.TabIndex = 9;
            Button10.Text = "Compañia";
            Button10.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Wide Latin", 80.25f, FontStyle.Bold | FontStyle.Italic);
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(241, 18);
            Label1.Name = "Label1";
            Label1.Size = new Size(908, 132);
            Label1.TabIndex = 11;
            Label1.Text = "Peliculas";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.choose_2_102347;
            PictureBox1.Location = new Point(24, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(211, 142);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 12;
            PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = My.Resources.Resources.loupe_79257;
            PictureBox2.Location = new Point(1205, 18);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(153, 136);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 13;
            PictureBox2.TabStop = false;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(PictureBox2);
            Controls.Add(PictureBox1);
            Controls.Add(Label1);
            Controls.Add(Button10);
            Controls.Add(Button9);
            Controls.Add(Button8);
            Controls.Add(Button7);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Name = "inicio";
            Text = "inicio";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            Load += new EventHandler(inicio_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button Button2;
        internal Button Button3;
        internal Button Button4;
        internal Button Button5;
        internal Button Button6;
        internal Button Button7;
        internal Button Button8;
        internal Button Button9;
        internal Button Button10;
        internal Label Label1;
        internal PictureBox PictureBox1;
        internal PictureBox PictureBox2;
    }
}