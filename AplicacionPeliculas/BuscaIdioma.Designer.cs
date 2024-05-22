using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BuscaIdioma : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaIdioma));
            Label1 = new Label();
            dataBuscaIdioma = new DataGridView();
            dataBuscaIdioma.CellContentDoubleClick += new DataGridViewCellEventHandler(dataBuscaIdioma_CellContentDoubleClick);
            txtidIdioma = new TextBox();
            txtidIdioma.TextChanged += new EventHandler(txtidIdioma_TextChanged);
            Label3 = new Label();
            txtNomIdioma = new TextBox();
            txtNomIdioma.TextChanged += new EventHandler(txtNomIdioma_TextChanged);
            Label2 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            ((System.ComponentModel.ISupportInitialize)dataBuscaIdioma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(336, 67);
            Label1.TabIndex = 1;
            Label1.Text = "Busca Idioma";
            // 
            // dataBuscaIdioma
            // 
            dataBuscaIdioma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBuscaIdioma.Location = new Point(24, 158);
            dataBuscaIdioma.Name = "dataBuscaIdioma";
            dataBuscaIdioma.Size = new Size(402, 280);
            dataBuscaIdioma.TabIndex = 2;
            // 
            // txtidIdioma
            // 
            txtidIdioma.Location = new Point(106, 123);
            txtidIdioma.Name = "txtidIdioma";
            txtidIdioma.Size = new Size(320, 20);
            txtidIdioma.TabIndex = 15;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label3.Location = new Point(27, 123);
            Label3.Name = "Label3";
            Label3.Size = new Size(27, 20);
            Label3.TabIndex = 14;
            Label3.Text = "Id:";
            // 
            // txtNomIdioma
            // 
            txtNomIdioma.Location = new Point(106, 93);
            txtNomIdioma.Name = "txtNomIdioma";
            txtNomIdioma.Size = new Size(320, 20);
            txtNomIdioma.TabIndex = 13;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(27, 91);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 12;
            Label2.Text = "Nombre:";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            PictureBox1.Location = new Point(354, 9);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(72, 64);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 16;
            PictureBox1.TabStop = false;
            // 
            // BuscaIdioma
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(PictureBox1);
            Controls.Add(txtidIdioma);
            Controls.Add(Label3);
            Controls.Add(txtNomIdioma);
            Controls.Add(Label2);
            Controls.Add(dataBuscaIdioma);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BuscaIdioma";
            Text = "BuscaIdioma";
            ((System.ComponentModel.ISupportInitialize)dataBuscaIdioma).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal DataGridView dataBuscaIdioma;
        internal TextBox txtidIdioma;
        internal Label Label3;
        internal TextBox txtNomIdioma;
        internal Label Label2;
        internal PictureBox PictureBox1;
    }
}