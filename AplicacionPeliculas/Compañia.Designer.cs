using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Compañia : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Compañia));
            txtidCom = new TextBox();
            Label4 = new Label();
            txtNomCom = new TextBox();
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
            // txtidCom
            // 
            txtidCom.Font = new Font("Microsoft Sans Serif", 12.25f);
            txtidCom.Location = new Point(126, 79);
            txtidCom.Name = "txtidCom";
            txtidCom.Size = new Size(177, 26);
            txtidCom.TabIndex = 107;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label4.Location = new Point(27, 79);
            Label4.Name = "Label4";
            Label4.Size = new Size(27, 20);
            Label4.TabIndex = 106;
            Label4.Text = "Id:";
            // 
            // txtNomCom
            // 
            txtNomCom.Font = new Font("Microsoft Sans Serif", 12.25f);
            txtNomCom.Location = new Point(126, 118);
            txtNomCom.Name = "txtNomCom";
            txtNomCom.Size = new Size(177, 26);
            txtNomCom.TabIndex = 99;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(30, 121);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 98;
            Label2.Text = "Nombre:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 25.25f);
            Label1.Location = new Point(12, 28);
            Label1.Name = "Label1";
            Label1.Size = new Size(173, 39);
            Label1.TabIndex = 97;
            Label1.Text = "Compañia";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.vote_counting_magnifier_icon_154141;
            PictureBox1.Location = new Point(248, 21);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(55, 46);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 105;
            PictureBox1.TabStop = false;
            // 
            // PicActualizar
            // 
            PicActualizar.Image = My.Resources.Resources._27_Edit_Text_256x256_35395;
            PicActualizar.Location = new Point(31, 216);
            PicActualizar.Name = "PicActualizar";
            PicActualizar.Size = new Size(72, 74);
            PicActualizar.SizeMode = PictureBoxSizeMode.CenterImage;
            PicActualizar.TabIndex = 104;
            PicActualizar.TabStop = false;
            // 
            // PicBorrar
            // 
            PicBorrar.Image = My.Resources.Resources.garbage_trash_bin_delete_icon_219499;
            PicBorrar.Location = new Point(135, 218);
            PicBorrar.Name = "PicBorrar";
            PicBorrar.Size = new Size(72, 72);
            PicBorrar.SizeMode = PictureBoxSizeMode.CenterImage;
            PicBorrar.TabIndex = 103;
            PicBorrar.TabStop = false;
            // 
            // picAgregar
            // 
            picAgregar.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            picAgregar.Location = new Point(231, 218);
            picAgregar.Name = "picAgregar";
            picAgregar.Size = new Size(72, 72);
            picAgregar.SizeMode = PictureBoxSizeMode.AutoSize;
            picAgregar.TabIndex = 102;
            picAgregar.TabStop = false;
            // 
            // Compañia
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 391);
            Controls.Add(txtidCom);
            Controls.Add(Label4);
            Controls.Add(PictureBox1);
            Controls.Add(PicActualizar);
            Controls.Add(PicBorrar);
            Controls.Add(picAgregar);
            Controls.Add(txtNomCom);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Compañia";
            Text = "Compañia";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicActualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBorrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox txtidCom;
        internal Label Label4;
        internal PictureBox PictureBox1;
        internal PictureBox PicActualizar;
        internal PictureBox PicBorrar;
        internal PictureBox picAgregar;
        internal TextBox txtNomCom;
        internal Label Label2;
        internal Label Label1;
    }
}