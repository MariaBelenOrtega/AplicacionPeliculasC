using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ModificaGenero : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaGenero));
            txtidGen = new TextBox();
            txtidGen.TextChanged += new EventHandler(txtidGen_TextChanged);
            Label3 = new Label();
            txtNomGen = new TextBox();
            txtNomGen.TextChanged += new EventHandler(txtNomGen_TextChanged);
            Label2 = new Label();
            DataModgenero = new DataGridView();
            DataModgenero.CellContentClick += new DataGridViewCellEventHandler(DataModgenero_CellContentClick);
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataModgenero).BeginInit();
            SuspendLayout();
            // 
            // txtidGen
            // 
            txtidGen.Location = new Point(122, 116);
            txtidGen.Name = "txtidGen";
            txtidGen.Size = new Size(252, 20);
            txtidGen.TabIndex = 16;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label3.Location = new Point(43, 116);
            Label3.Name = "Label3";
            Label3.Size = new Size(27, 20);
            Label3.TabIndex = 15;
            Label3.Text = "Id:";
            // 
            // txtNomGen
            // 
            txtNomGen.Location = new Point(122, 86);
            txtNomGen.Name = "txtNomGen";
            txtNomGen.Size = new Size(252, 20);
            txtNomGen.TabIndex = 14;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(43, 84);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 13;
            Label2.Text = "Nombre:";
            // 
            // DataModgenero
            // 
            DataModgenero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataModgenero.Location = new Point(47, 153);
            DataModgenero.Name = "DataModgenero";
            DataModgenero.Size = new Size(328, 354);
            DataModgenero.TabIndex = 12;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(11, 4);
            Label1.Name = "Label1";
            Label1.Size = new Size(407, 67);
            Label1.TabIndex = 11;
            Label1.Text = "Modifica Genero";
            // 
            // ModificaGenero
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 519);
            Controls.Add(txtidGen);
            Controls.Add(Label3);
            Controls.Add(txtNomGen);
            Controls.Add(Label2);
            Controls.Add(DataModgenero);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificaGenero";
            Text = "ModificaGenero";
            ((System.ComponentModel.ISupportInitialize)DataModgenero).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox txtidGen;
        internal Label Label3;
        internal TextBox txtNomGen;
        internal Label Label2;
        internal DataGridView DataModgenero;
        internal Label Label1;
    }
}