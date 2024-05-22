using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BuscaUsuario : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaUsuario));
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            txtid = new TextBox();
            txtid.TextChanged += new EventHandler(txtid_TextChanged);
            Label3 = new Label();
            txtNom = new TextBox();
            txtNom.TextChanged += new EventHandler(txtNom_TextChanged);
            Label2 = new Label();
            DataBusca = new DataGridView();
            DataBusca.CellContentDoubleClick += new DataGridViewCellEventHandler(DataBusca_CellContentDoubleClick);
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataBusca).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            PictureBox1.Location = new Point(361, 21);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(72, 64);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 19;
            PictureBox1.TabStop = false;
            // 
            // txtid
            // 
            txtid.Location = new Point(106, 121);
            txtid.Name = "txtid";
            txtid.Size = new Size(327, 20);
            txtid.TabIndex = 18;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label3.Location = new Point(27, 121);
            Label3.Name = "Label3";
            Label3.Size = new Size(27, 20);
            Label3.TabIndex = 17;
            Label3.Text = "Id:";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(106, 91);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(327, 20);
            txtNom.TabIndex = 16;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(27, 89);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 15;
            Label2.Text = "Nombre:";
            // 
            // DataBusca
            // 
            DataBusca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataBusca.Location = new Point(24, 147);
            DataBusca.Name = "DataBusca";
            DataBusca.Size = new Size(409, 239);
            DataBusca.TabIndex = 14;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(4, 18);
            Label1.Name = "Label1";
            Label1.Size = new Size(351, 67);
            Label1.TabIndex = 13;
            Label1.Text = "Busca Usuario";
            // 
            // BuscaUsuario
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 396);
            Controls.Add(PictureBox1);
            Controls.Add(txtid);
            Controls.Add(Label3);
            Controls.Add(txtNom);
            Controls.Add(Label2);
            Controls.Add(DataBusca);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BuscaUsuario";
            Text = "BuscaUsuario";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataBusca).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal PictureBox PictureBox1;
        internal TextBox txtid;
        internal Label Label3;
        internal TextBox txtNom;
        internal Label Label2;
        internal DataGridView DataBusca;
        internal Label Label1;
    }
}