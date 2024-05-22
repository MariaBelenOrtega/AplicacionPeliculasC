using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BusquedaPais : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaPais));
            Label1 = new Label();
            DataBuscaPais = new DataGridView();
            DataBuscaPais.CellContentDoubleClick += new DataGridViewCellEventHandler(DataBuscaPais_CellContentDoubleClick);
            txtidPais = new TextBox();
            txtidPais.TextChanged += new EventHandler(txtidPais_TextChanged);
            Label3 = new Label();
            txtNomPais = new TextBox();
            txtNomPais.TextChanged += new EventHandler(txtNomPais_TextChanged);
            Label2 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            ((System.ComponentModel.ISupportInitialize)DataBuscaPais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(269, 67);
            Label1.TabIndex = 0;
            Label1.Text = "Busca Pais";
            // 
            // DataBuscaPais
            // 
            DataBuscaPais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataBuscaPais.Location = new Point(24, 135);
            DataBuscaPais.Name = "DataBuscaPais";
            DataBuscaPais.Size = new Size(320, 239);
            DataBuscaPais.TabIndex = 1;
            // 
            // txtidPais
            // 
            txtidPais.Location = new Point(106, 109);
            txtidPais.Name = "txtidPais";
            txtidPais.Size = new Size(238, 20);
            txtidPais.TabIndex = 10;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label3.Location = new Point(27, 109);
            Label3.Name = "Label3";
            Label3.Size = new Size(27, 20);
            Label3.TabIndex = 9;
            Label3.Text = "Id:";
            // 
            // txtNomPais
            // 
            txtNomPais.Location = new Point(106, 79);
            txtNomPais.Name = "txtNomPais";
            txtNomPais.Size = new Size(238, 20);
            txtNomPais.TabIndex = 8;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(27, 77);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 7;
            Label2.Text = "Nombre:";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            PictureBox1.Location = new Point(272, 9);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(72, 64);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 12;
            PictureBox1.TabStop = false;
            // 
            // BusquedaPais
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 402);
            Controls.Add(PictureBox1);
            Controls.Add(txtidPais);
            Controls.Add(Label3);
            Controls.Add(txtNomPais);
            Controls.Add(Label2);
            Controls.Add(DataBuscaPais);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BusquedaPais";
            Text = "BusquedaPais";
            ((System.ComponentModel.ISupportInitialize)DataBuscaPais).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal DataGridView DataBuscaPais;
        internal TextBox txtidPais;
        internal Label Label3;
        internal TextBox txtNomPais;
        internal Label Label2;
        internal PictureBox PictureBox1;
    }
}