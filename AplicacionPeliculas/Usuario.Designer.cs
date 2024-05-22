using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Usuario : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            Label1 = new Label();
            Label2 = new Label();
            txtNombreU = new TextBox();
            txtUsernameU = new TextBox();
            txtContraseña = new TextBox();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            txtId = new TextBox();
            PicBuscar = new PictureBox();
            PicBuscar.Click += new EventHandler(PicBuscar_Click);
            PicActualizar = new PictureBox();
            PicActualizar.Click += new EventHandler(PicActualizar_Click);
            PicBorrar = new PictureBox();
            PicBorrar.Click += new EventHandler(PicBorrar_Click);
            picAgregar = new PictureBox();
            picAgregar.Click += new EventHandler(picAgregar_Click);
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicActualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBorrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(120, 29);
            Label1.Name = "Label1";
            Label1.Size = new Size(76, 20);
            Label1.TabIndex = 1;
            Label1.Text = "Usuario:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(117, 67);
            Label2.Name = "Label2";
            Label2.Size = new Size(119, 37);
            Label2.TabIndex = 2;
            Label2.Text = "Label2";
            // 
            // txtNombreU
            // 
            txtNombreU.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreU.Location = new Point(112, 162);
            txtNombreU.Name = "txtNombreU";
            txtNombreU.Size = new Size(272, 29);
            txtNombreU.TabIndex = 3;
            // 
            // txtUsernameU
            // 
            txtUsernameU.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsernameU.Location = new Point(112, 197);
            txtUsernameU.Name = "txtUsernameU";
            txtUsernameU.Size = new Size(272, 29);
            txtUsernameU.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(112, 232);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(272, 29);
            txtContraseña.TabIndex = 8;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(12, 168);
            Label3.Name = "Label3";
            Label3.Size = new Size(69, 20);
            Label3.TabIndex = 9;
            Label3.Text = "Nombre:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(12, 203);
            Label4.Name = "Label4";
            Label4.Size = new Size(87, 20);
            Label4.TabIndex = 10;
            Label4.Text = "Username:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(12, 238);
            Label5.Name = "Label5";
            Label5.Size = new Size(96, 20);
            Label5.TabIndex = 11;
            Label5.Text = "Contraseña:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(12, 133);
            Label6.Name = "Label6";
            Label6.Size = new Size(27, 20);
            Label6.TabIndex = 14;
            Label6.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(112, 127);
            txtId.Name = "txtId";
            txtId.Size = new Size(272, 29);
            txtId.TabIndex = 13;
            // 
            // PicBuscar
            // 
            PicBuscar.Image = My.Resources.Resources.loupe_79257;
            PicBuscar.Location = new Point(318, 12);
            PicBuscar.Name = "PicBuscar";
            PicBuscar.Size = new Size(83, 75);
            PicBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBuscar.TabIndex = 12;
            PicBuscar.TabStop = false;
            // 
            // PicActualizar
            // 
            PicActualizar.Image = My.Resources.Resources.UserEdit_40958;
            PicActualizar.Location = new Point(16, 287);
            PicActualizar.Name = "PicActualizar";
            PicActualizar.Size = new Size(83, 66);
            PicActualizar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicActualizar.TabIndex = 6;
            PicActualizar.TabStop = false;
            // 
            // PicBorrar
            // 
            PicBorrar.Image = My.Resources.Resources.UserRemove_40959;
            PicBorrar.Location = new Point(294, 287);
            PicBorrar.Name = "PicBorrar";
            PicBorrar.Size = new Size(90, 66);
            PicBorrar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBorrar.TabIndex = 5;
            PicBorrar.TabStop = false;
            // 
            // picAgregar
            // 
            picAgregar.Image = My.Resources.Resources.UserAdd_40960;
            picAgregar.Location = new Point(154, 287);
            picAgregar.Name = "picAgregar";
            picAgregar.Size = new Size(82, 66);
            picAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAgregar.TabIndex = 4;
            picAgregar.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.administrator_3552;
            PictureBox1.Location = new Point(12, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(102, 102);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 391);
            Controls.Add(Label6);
            Controls.Add(txtId);
            Controls.Add(PicBuscar);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsernameU);
            Controls.Add(PicActualizar);
            Controls.Add(PicBorrar);
            Controls.Add(picAgregar);
            Controls.Add(txtNombreU);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Usuario";
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)PicBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicActualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBorrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Usuario_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal PictureBox PictureBox1;
        internal Label Label1;
        internal Label Label2;
        internal TextBox txtNombreU;
        internal PictureBox picAgregar;
        internal PictureBox PicBorrar;
        internal PictureBox PicActualizar;
        internal TextBox txtUsernameU;
        internal TextBox txtContraseña;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal PictureBox PicBuscar;
        internal Label Label6;
        internal TextBox txtId;
    }
}