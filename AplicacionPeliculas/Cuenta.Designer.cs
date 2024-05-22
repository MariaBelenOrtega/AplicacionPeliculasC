using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Cuenta : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuenta));
            Label2 = new Label();
            txtusuario = new TextBox();
            Label1 = new Label();
            txtcontra = new TextBox();
            Label4 = new Label();
            btnAceptar = new Button();
            btnAceptar.Click += new EventHandler(btnAceptar_Click);
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label2.Location = new Point(26, 79);
            Label2.Name = "Label2";
            Label2.Size = new Size(116, 25);
            Label2.TabIndex = 2;
            Label2.Text = "Username:";
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtusuario.Location = new Point(148, 79);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(361, 31);
            txtusuario.TabIndex = 26;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label1.Location = new Point(26, 143);
            Label1.Name = "Label1";
            Label1.Size = new Size(129, 25);
            Label1.TabIndex = 27;
            Label1.Text = "Contraseña:";
            // 
            // txtcontra
            // 
            txtcontra.Font = new Font("Microsoft Sans Serif", 15.25f);
            txtcontra.Location = new Point(148, 140);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(361, 31);
            txtcontra.TabIndex = 28;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 25.25f);
            Label4.Location = new Point(141, 25);
            Label4.Name = "Label4";
            Label4.Size = new Size(212, 39);
            Label4.TabIndex = 30;
            Label4.Text = "Inicia Sesion";
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Arrow;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 15.25f);
            btnAceptar.Location = new Point(390, 188);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(119, 39);
            btnAceptar.TabIndex = 31;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Cuenta
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 242);
            Controls.Add(btnAceptar);
            Controls.Add(Label4);
            Controls.Add(txtcontra);
            Controls.Add(Label1);
            Controls.Add(txtusuario);
            Controls.Add(Label2);
            Cursor = Cursors.Arrow;
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cuenta";
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label2;
        internal TextBox txtusuario;
        internal Label Label1;
        internal TextBox txtcontra;
        internal Label Label4;
        internal Button btnAceptar;
    }
}