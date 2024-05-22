using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ModificaIdioma : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaIdioma));
            txtidIdioma = new TextBox();
            txtidIdioma.TextChanged += new EventHandler(txtidIdioma_TextChanged);
            Label3 = new Label();
            txtNomIdioma = new TextBox();
            txtNomIdioma.TextChanged += new EventHandler(txtNomIdioma_TextChanged);
            Label2 = new Label();
            DataModIdioma = new DataGridView();
            DataModIdioma.CellContentClick += new DataGridViewCellEventHandler(DataModIdioma_CellContentClick);
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataModIdioma).BeginInit();
            SuspendLayout();
            // 
            // txtidIdioma
            // 
            txtidIdioma.Location = new Point(119, 115);
            txtidIdioma.Name = "txtidIdioma";
            txtidIdioma.Size = new Size(252, 20);
            txtidIdioma.TabIndex = 22;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label3.Location = new Point(40, 115);
            Label3.Name = "Label3";
            Label3.Size = new Size(27, 20);
            Label3.TabIndex = 21;
            Label3.Text = "Id:";
            // 
            // txtNomIdioma
            // 
            txtNomIdioma.Location = new Point(119, 85);
            txtNomIdioma.Name = "txtNomIdioma";
            txtNomIdioma.Size = new Size(252, 20);
            txtNomIdioma.TabIndex = 20;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(40, 83);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 19;
            Label2.Text = "Nombre:";
            // 
            // DataModIdioma
            // 
            DataModIdioma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataModIdioma.Location = new Point(44, 152);
            DataModIdioma.Name = "DataModIdioma";
            DataModIdioma.Size = new Size(328, 354);
            DataModIdioma.TabIndex = 18;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(8, 3);
            Label1.Name = "Label1";
            Label1.Size = new Size(403, 67);
            Label1.TabIndex = 17;
            Label1.Text = "Modifica Idioma";
            // 
            // ModificaIdioma
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 517);
            Controls.Add(txtidIdioma);
            Controls.Add(Label3);
            Controls.Add(txtNomIdioma);
            Controls.Add(Label2);
            Controls.Add(DataModIdioma);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificaIdioma";
            Text = "ModificaIdioma";
            ((System.ComponentModel.ISupportInitialize)DataModIdioma).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox txtidIdioma;
        internal Label Label3;
        internal TextBox txtNomIdioma;
        internal Label Label2;
        internal DataGridView DataModIdioma;
        internal Label Label1;
    }
}