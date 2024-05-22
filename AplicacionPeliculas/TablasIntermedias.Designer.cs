using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TablasIntermedias : Form
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
            Label1 = new Label();
            txtPelicula = new TextBox();
            txt = new TextBox();
            Label2 = new Label();
            Label3 = new Label();
            picActualizar = new PictureBox();
            PicAgregar = new PictureBox();
            PicEliminar = new PictureBox();
            PicBuscaPeli = new PictureBox();
            PicBuscaPeli.Click += new EventHandler(PicBuscaPeli_Click);
            PicBusca = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picActualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBuscaPeli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBusca).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(12, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(214, 67);
            Label1.TabIndex = 14;
            Label1.Text = "Agregar";
            // 
            // txtPelicula
            // 
            txtPelicula.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPelicula.Location = new Point(145, 124);
            txtPelicula.Name = "txtPelicula";
            txtPelicula.Size = new Size(234, 26);
            txtPelicula.TabIndex = 15;
            // 
            // txt
            // 
            txt.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt.Location = new Point(145, 174);
            txt.Name = "txt";
            txt.Size = new Size(234, 26);
            txt.TabIndex = 16;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(59, 127);
            Label2.Name = "Label2";
            Label2.Size = new Size(67, 20);
            Label2.TabIndex = 17;
            Label2.Text = "Pelicula:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(59, 177);
            Label3.Name = "Label3";
            Label3.Size = new Size(57, 20);
            Label3.TabIndex = 18;
            Label3.Text = "Label3";
            // 
            // picActualizar
            // 
            picActualizar.Image = My.Resources.Resources._27_Edit_Text_256x256_35395;
            picActualizar.Location = new Point(63, 240);
            picActualizar.Name = "picActualizar";
            picActualizar.Size = new Size(77, 73);
            picActualizar.SizeMode = PictureBoxSizeMode.StretchImage;
            picActualizar.TabIndex = 19;
            picActualizar.TabStop = false;
            // 
            // PicAgregar
            // 
            PicAgregar.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            PicAgregar.Location = new Point(182, 240);
            PicAgregar.Name = "PicAgregar";
            PicAgregar.Size = new Size(77, 74);
            PicAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicAgregar.TabIndex = 20;
            PicAgregar.TabStop = false;
            // 
            // PicEliminar
            // 
            PicEliminar.Image = My.Resources.Resources.garbage_trash_bin_delete_icon_219499;
            PicEliminar.Location = new Point(302, 239);
            PicEliminar.Name = "PicEliminar";
            PicEliminar.Size = new Size(77, 74);
            PicEliminar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicEliminar.TabIndex = 21;
            PicEliminar.TabStop = false;
            // 
            // PicBuscaPeli
            // 
            PicBuscaPeli.Image = My.Resources.Resources.loupe_79257;
            PicBuscaPeli.Location = new Point(385, 124);
            PicBuscaPeli.Name = "PicBuscaPeli";
            PicBuscaPeli.Size = new Size(41, 26);
            PicBuscaPeli.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBuscaPeli.TabIndex = 22;
            PicBuscaPeli.TabStop = false;
            // 
            // PicBusca
            // 
            PicBusca.Image = My.Resources.Resources.loupe_79257;
            PicBusca.Location = new Point(385, 174);
            PicBusca.Name = "PicBusca";
            PicBusca.Size = new Size(41, 26);
            PicBusca.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBusca.TabIndex = 23;
            PicBusca.TabStop = false;
            // 
            // TablasIntermedias
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 354);
            Controls.Add(PicBusca);
            Controls.Add(PicBuscaPeli);
            Controls.Add(PicEliminar);
            Controls.Add(PicAgregar);
            Controls.Add(picActualizar);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(txt);
            Controls.Add(txtPelicula);
            Controls.Add(Label1);
            Name = "TablasIntermedias";
            Text = "TablasIntermedias";
            ((System.ComponentModel.ISupportInitialize)picActualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBuscaPeli).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBusca).EndInit();
            Load += new EventHandler(TablasIntermedias_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal TextBox txtPelicula;
        internal TextBox txt;
        internal Label Label2;
        internal Label Label3;
        internal PictureBox picActualizar;
        internal PictureBox PicAgregar;
        internal PictureBox PicEliminar;
        internal PictureBox PicBuscaPeli;
        internal PictureBox PicBusca;
    }
}