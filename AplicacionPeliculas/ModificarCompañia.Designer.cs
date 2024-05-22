using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ModificarCompañia : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCompañia));
            Label1 = new Label();
            txtidCom = new TextBox();
            txtidCom.TextChanged += new EventHandler(txtidCom_TextChanged);
            Label3 = new Label();
            txtNomCom = new TextBox();
            txtNomCom.TextChanged += new EventHandler(txtNomCom_TextChanged);
            Label2 = new Label();
            dataModCom = new DataGridView();
            dataModCom.CellContentClick += new DataGridViewCellEventHandler(dataModCom_CellContentClick);
            ((System.ComponentModel.ISupportInitialize)dataModCom).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(9, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(457, 67);
            Label1.TabIndex = 28;
            Label1.Text = "Modifica Compañia";
            // 
            // txtidCom
            // 
            txtidCom.Location = new Point(156, 110);
            txtidCom.Name = "txtidCom";
            txtidCom.Size = new Size(242, 20);
            txtidCom.TabIndex = 27;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label3.Location = new Point(70, 112);
            Label3.Name = "Label3";
            Label3.Size = new Size(27, 20);
            Label3.TabIndex = 26;
            Label3.Text = "Id:";
            // 
            // txtNomCom
            // 
            txtNomCom.Location = new Point(156, 80);
            txtNomCom.Name = "txtNomCom";
            txtNomCom.Size = new Size(242, 20);
            txtNomCom.TabIndex = 25;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(70, 80);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 24;
            Label2.Text = "Nombre:";
            // 
            // dataModCom
            // 
            dataModCom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataModCom.Location = new Point(74, 145);
            dataModCom.Name = "dataModCom";
            dataModCom.Size = new Size(324, 280);
            dataModCom.TabIndex = 23;
            // 
            // ModificarCompañia
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(Label1);
            Controls.Add(txtidCom);
            Controls.Add(Label3);
            Controls.Add(txtNomCom);
            Controls.Add(Label2);
            Controls.Add(dataModCom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModificarCompañia";
            Text = "ModificarCompañia";
            ((System.ComponentModel.ISupportInitialize)dataModCom).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal TextBox txtidCom;
        internal Label Label3;
        internal TextBox txtNomCom;
        internal Label Label2;
        internal DataGridView dataModCom;
    }
}