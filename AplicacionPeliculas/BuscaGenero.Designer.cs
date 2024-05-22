using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BuscaGenero : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaGenero));
            Label1 = new Label();
            DataBuscagenero = new DataGridView();
            DataBuscagenero.CellContentDoubleClick += new DataGridViewCellEventHandler(DataBuscagenero_CellContentDoubleClick);
            txtidGen = new TextBox();
            txtidGen.TextChanged += new EventHandler(txtidGen_TextChanged);
            Label3 = new Label();
            txtNomGen = new TextBox();
            txtNomGen.TextChanged += new EventHandler(txtNomCom_TextChanged);
            Label2 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            ((System.ComponentModel.ISupportInitialize)DataBuscagenero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 36.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(340, 67);
            Label1.TabIndex = 2;
            Label1.Text = "Busca Genero";
            // 
            // DataBuscagenero
            // 
            DataBuscagenero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataBuscagenero.Location = new Point(24, 158);
            DataBuscagenero.Name = "DataBuscagenero";
            DataBuscagenero.Size = new Size(388, 354);
            DataBuscagenero.TabIndex = 3;
            // 
            // txtidGen
            // 
            txtidGen.Location = new Point(100, 119);
            txtidGen.Name = "txtidGen";
            txtidGen.Size = new Size(312, 20);
            txtidGen.TabIndex = 10;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label3.Location = new Point(21, 119);
            Label3.Name = "Label3";
            Label3.Size = new Size(27, 20);
            Label3.TabIndex = 9;
            Label3.Text = "Id:";
            // 
            // txtNomGen
            // 
            txtNomGen.Location = new Point(100, 89);
            txtNomGen.Name = "txtNomGen";
            txtNomGen.Size = new Size(312, 20);
            txtNomGen.TabIndex = 8;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label2.Location = new Point(21, 87);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 20);
            Label2.TabIndex = 7;
            Label2.Text = "Nombre:";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            PictureBox1.Location = new Point(340, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(72, 64);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 11;
            PictureBox1.TabStop = false;
            // 
            // BuscaGenero
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 529);
            Controls.Add(PictureBox1);
            Controls.Add(txtidGen);
            Controls.Add(Label3);
            Controls.Add(txtNomGen);
            Controls.Add(Label2);
            Controls.Add(DataBuscagenero);
            Controls.Add(Label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BuscaGenero";
            Text = "BuscaGenero";
            ((System.ComponentModel.ISupportInitialize)DataBuscagenero).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal DataGridView DataBuscagenero;
        internal TextBox txtidGen;
        internal Label Label3;
        internal TextBox txtNomGen;
        internal Label Label2;
        internal PictureBox PictureBox1;
    }
}