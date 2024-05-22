using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BuscaCompania : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaCompania));
            DataBuscaCompania = new DataGridView();
            DataBuscaCompania.CellContentDoubleClick += new DataGridViewCellEventHandler(DataBuscaCompania_CellContentDoubleClick);
            Label1 = new Label();
            Label2 = new Label();
            txtNomCom = new TextBox();
            txtNomCom.TextChanged += new EventHandler(txtNomCom_TextChanged);
            Label3 = new Label();
            txtid = new TextBox();
            txtid.TextChanged += new EventHandler(txtid_TextChanged);
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            ((System.ComponentModel.ISupportInitialize)DataBuscaCompania).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataBuscaCompania
            // 
            DataBuscaCompania.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataBuscaCompania.Location = new Point(12, 159);
            DataBuscaCompania.Name = "DataBuscaCompania";
            DataBuscaCompania.Size = new Size(439, 279);
            DataBuscaCompania.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(0, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(390, 67);
            Label1.TabIndex = 2;
            Label1.Text = "Busca Compañia";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(12, 95);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 3;
            Label2.Text = "Nombre:";
            // 
            // txtNomCom
            // 
            txtNomCom.Location = new Point(91, 97);
            txtNomCom.Name = "txtNomCom";
            txtNomCom.Size = new Size(360, 20);
            txtNomCom.TabIndex = 4;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label3.Location = new Point(12, 127);
            Label3.Name = "Label3";
            Label3.Size = new Size(27, 20);
            Label3.TabIndex = 5;
            Label3.Text = "Id:";
            // 
            // txtid
            // 
            txtid.Location = new Point(91, 129);
            txtid.Name = "txtid";
            txtid.Size = new Size(360, 20);
            txtid.TabIndex = 6;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            PictureBox1.Location = new Point(379, 9);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(72, 64);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 12;
            PictureBox1.TabStop = false;
            // 
            // BuscaCompania
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 450);
            Controls.Add(PictureBox1);
            Controls.Add(txtid);
            Controls.Add(Label3);
            Controls.Add(txtNomCom);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(DataBuscaCompania);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BuscaCompania";
            Text = "BuscaCompania";
            ((System.ComponentModel.ISupportInitialize)DataBuscaCompania).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataBuscaCompania;
        internal Label Label1;
        internal Label Label2;
        internal TextBox txtNomCom;
        internal Label Label3;
        internal TextBox txtid;
        internal PictureBox PictureBox1;
    }
}