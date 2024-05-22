using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Genero : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Genero));
            Label1 = new Label();
            Label2 = new Label();
            txtNomGenero = new TextBox();
            PicActualizar = new PictureBox();
            PicActualizar.Click += new EventHandler(PicActualizar_Click);
            PicBorrar = new PictureBox();
            PicBorrar.Click += new EventHandler(PicBorrar_Click);
            picAgregar = new PictureBox();
            picAgregar.Click += new EventHandler(picAgregar_Click);
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            Label4 = new Label();
            txtidgen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PicActualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBorrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 25.25f);
            Label1.Location = new Point(24, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(130, 39);
            Label1.TabIndex = 0;
            Label1.Text = "Genero";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(27, 112);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 1;
            Label2.Text = "Nombre:";
            // 
            // txtNomGenero
            // 
            txtNomGenero.Font = new Font("Microsoft Sans Serif", 12.25f);
            txtNomGenero.Location = new Point(123, 109);
            txtNomGenero.Name = "txtNomGenero";
            txtNomGenero.Size = new Size(177, 26);
            txtNomGenero.TabIndex = 2;
            // 
            // PicActualizar
            // 
            PicActualizar.Image = My.Resources.Resources._27_Edit_Text_256x256_35395;
            PicActualizar.Location = new Point(28, 207);
            PicActualizar.Name = "PicActualizar";
            PicActualizar.Size = new Size(72, 74);
            PicActualizar.SizeMode = PictureBoxSizeMode.CenterImage;
            PicActualizar.TabIndex = 71;
            PicActualizar.TabStop = false;
            // 
            // PicBorrar
            // 
            PicBorrar.Image = My.Resources.Resources.garbage_trash_bin_delete_icon_219499;
            PicBorrar.Location = new Point(133, 209);
            PicBorrar.Name = "PicBorrar";
            PicBorrar.Size = new Size(72, 72);
            PicBorrar.SizeMode = PictureBoxSizeMode.CenterImage;
            PicBorrar.TabIndex = 70;
            PicBorrar.TabStop = false;
            // 
            // picAgregar
            // 
            picAgregar.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            picAgregar.Location = new Point(227, 209);
            picAgregar.Name = "picAgregar";
            picAgregar.Size = new Size(72, 72);
            picAgregar.SizeMode = PictureBoxSizeMode.AutoSize;
            picAgregar.TabIndex = 69;
            picAgregar.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.vote_counting_magnifier_icon_154141;
            PictureBox1.Location = new Point(273, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(55, 46);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 72;
            PictureBox1.TabStop = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label4.Location = new Point(36, 73);
            Label4.Name = "Label4";
            Label4.Size = new Size(27, 20);
            Label4.TabIndex = 73;
            Label4.Text = "Id:";
            // 
            // txtidgen
            // 
            txtidgen.Font = new Font("Microsoft Sans Serif", 12.25f);
            txtidgen.Location = new Point(123, 70);
            txtidgen.Name = "txtidgen";
            txtidgen.Size = new Size(177, 26);
            txtidgen.TabIndex = 74;
            // 
            // Genero
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 406);
            Controls.Add(txtidgen);
            Controls.Add(Label4);
            Controls.Add(PictureBox1);
            Controls.Add(PicActualizar);
            Controls.Add(PicBorrar);
            Controls.Add(picAgregar);
            Controls.Add(txtNomGenero);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Genero";
            Text = "Genero";
            ((System.ComponentModel.ISupportInitialize)PicActualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBorrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Genero_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal TextBox txtNomGenero;
        internal PictureBox PicActualizar;
        internal PictureBox PicBorrar;
        internal PictureBox picAgregar;
        internal PictureBox PictureBox1;
        internal Label Label4;
        internal TextBox txtidgen;
    }
}