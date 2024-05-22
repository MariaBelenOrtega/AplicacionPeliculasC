using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ModificarPais : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPais));
            txtidPais = new TextBox();
            txtidPais.TextChanged += new EventHandler(txtidPais_TextChanged);
            Label3 = new Label();
            txtNomPais = new TextBox();
            txtNomPais.TextChanged += new EventHandler(txtNomPais_TextChanged);
            Label2 = new Label();
            dataModPais = new DataGridView();
            dataModPais.CellContentClick += new DataGridViewCellEventHandler(dataModPais_CellContentClick);
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataModPais).BeginInit();
            SuspendLayout();
            // 
            // txtidPais
            // 
            txtidPais.Location = new Point(149, 123);
            txtidPais.Name = "txtidPais";
            txtidPais.Size = new Size(242, 20);
            txtidPais.TabIndex = 21;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label3.Location = new Point(63, 125);
            Label3.Name = "Label3";
            Label3.Size = new Size(27, 20);
            Label3.TabIndex = 20;
            Label3.Text = "Id:";
            // 
            // txtNomPais
            // 
            txtNomPais.Location = new Point(149, 93);
            txtNomPais.Name = "txtNomPais";
            txtNomPais.Size = new Size(242, 20);
            txtNomPais.TabIndex = 19;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(63, 93);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 18;
            Label2.Text = "Nombre:";
            // 
            // dataModPais
            // 
            dataModPais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataModPais.Location = new Point(67, 158);
            dataModPais.Name = "dataModPais";
            dataModPais.Size = new Size(324, 280);
            dataModPais.TabIndex = 17;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(33, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(403, 67);
            Label1.TabIndex = 22;
            Label1.Text = "Modifica Idioma";
            // 
            // ModificarPais
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 450);
            Controls.Add(Label1);
            Controls.Add(txtidPais);
            Controls.Add(Label3);
            Controls.Add(txtNomPais);
            Controls.Add(Label2);
            Controls.Add(dataModPais);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarPais";
            Text = "ModificarPais";
            ((System.ComponentModel.ISupportInitialize)dataModPais).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox txtidPais;
        internal Label Label3;
        internal TextBox txtNomPais;
        internal Label Label2;
        internal DataGridView dataModPais;
        internal Label Label1;
    }
}