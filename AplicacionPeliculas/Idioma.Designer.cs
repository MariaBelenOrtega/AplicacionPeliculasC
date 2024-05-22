using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Idioma : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Idioma));
            txtidIdioma = new TextBox();
            Label4 = new Label();
            txtNomIdioma = new TextBox();
            Label2 = new Label();
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PicActualizar = new PictureBox();
            PicActualizar.Click += new EventHandler(PicActualizar_Click);
            PicBorrar = new PictureBox();
            PicBorrar.Click += new EventHandler(PicBorrar_Click);
            picAgregar = new PictureBox();
            picAgregar.Click += new EventHandler(picAgregar_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicActualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBorrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAgregar).BeginInit();
            SuspendLayout();
            // 
            // txtidIdioma
            // 
            txtidIdioma.Font = new Font("Microsoft Sans Serif", 12.25f);
            txtidIdioma.Location = new Point(126, 74);
            txtidIdioma.Name = "txtidIdioma";
            txtidIdioma.Size = new Size(177, 26);
            txtidIdioma.TabIndex = 85;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label4.Location = new Point(39, 77);
            Label4.Name = "Label4";
            Label4.Size = new Size(27, 20);
            Label4.TabIndex = 84;
            Label4.Text = "Id:";
            // 
            // txtNomIdioma
            // 
            txtNomIdioma.Font = new Font("Microsoft Sans Serif", 12.25f);
            txtNomIdioma.Location = new Point(126, 113);
            txtNomIdioma.Name = "txtNomIdioma";
            txtNomIdioma.Size = new Size(177, 26);
            txtNomIdioma.TabIndex = 77;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(30, 116);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 76;
            Label2.Text = "Nombre:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 25.25f);
            Label1.Location = new Point(27, 23);
            Label1.Name = "Label1";
            Label1.Size = new Size(120, 39);
            Label1.TabIndex = 75;
            Label1.Text = "Idioma";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.vote_counting_magnifier_icon_154141;
            PictureBox1.Location = new Point(248, 16);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(55, 46);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 83;
            PictureBox1.TabStop = false;
            // 
            // PicActualizar
            // 
            PicActualizar.Image = My.Resources.Resources._27_Edit_Text_256x256_35395;
            PicActualizar.Location = new Point(31, 211);
            PicActualizar.Name = "PicActualizar";
            PicActualizar.Size = new Size(72, 74);
            PicActualizar.SizeMode = PictureBoxSizeMode.CenterImage;
            PicActualizar.TabIndex = 82;
            PicActualizar.TabStop = false;
            // 
            // PicBorrar
            // 
            PicBorrar.Image = My.Resources.Resources.garbage_trash_bin_delete_icon_219499;
            PicBorrar.Location = new Point(126, 211);
            PicBorrar.Name = "PicBorrar";
            PicBorrar.Size = new Size(72, 72);
            PicBorrar.SizeMode = PictureBoxSizeMode.CenterImage;
            PicBorrar.TabIndex = 81;
            PicBorrar.TabStop = false;
            // 
            // picAgregar
            // 
            picAgregar.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            picAgregar.Location = new Point(231, 213);
            picAgregar.Name = "picAgregar";
            picAgregar.Size = new Size(72, 72);
            picAgregar.SizeMode = PictureBoxSizeMode.AutoSize;
            picAgregar.TabIndex = 80;
            picAgregar.TabStop = false;
            // 
            // Idioma
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 411);
            Controls.Add(txtidIdioma);
            Controls.Add(Label4);
            Controls.Add(PictureBox1);
            Controls.Add(PicActualizar);
            Controls.Add(PicBorrar);
            Controls.Add(picAgregar);
            Controls.Add(txtNomIdioma);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Idioma";
            Text = "Idioma";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicActualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBorrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox txtidIdioma;
        internal Label Label4;
        internal PictureBox PictureBox1;
        internal PictureBox PicActualizar;
        internal PictureBox PicBorrar;
        internal PictureBox picAgregar;
        internal TextBox txtNomIdioma;
        internal Label Label2;
        internal Label Label1;
    }
}