using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Peliculas : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
            Label1 = new Label();
            DataGridView1 = new DataGridView();
            DataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(DataGridView1_CellDoubleClick);
            comboGenero = new ComboBox();
            comboGenero.SelectedIndexChanged += new EventHandler(comboGenero_SelectedIndexChanged);
            Label2 = new Label();
            comboPais = new ComboBox();
            comboPais.SelectedIndexChanged += new EventHandler(comboPais_SelectedIndexChanged);
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PicAgregar = new PictureBox();
            PicAgregar.Click += new EventHandler(PicAgregar_Click);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicAgregar).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label1.Location = new Point(462, 42);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(89, 25);
            Label1.TabIndex = 1;
            Label1.Text = "Genero:";
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(42, 112);
            DataGridView1.Margin = new Padding(4, 5, 4, 5);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(1222, 590);
            DataGridView1.TabIndex = 2;
            // 
            // comboGenero
            // 
            comboGenero.Font = new Font("Microsoft Sans Serif", 15.25f);
            comboGenero.FormattingEnabled = true;
            comboGenero.Location = new Point(559, 39);
            comboGenero.Margin = new Padding(4, 5, 4, 5);
            comboGenero.Name = "comboGenero";
            comboGenero.Size = new Size(373, 33);
            comboGenero.TabIndex = 6;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 15.25f);
            Label2.Location = new Point(37, 42);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(60, 25);
            Label2.TabIndex = 7;
            Label2.Text = "Pais:";
            // 
            // comboPais
            // 
            comboPais.Font = new Font("Microsoft Sans Serif", 15.25f);
            comboPais.FormattingEnabled = true;
            comboPais.Location = new Point(105, 39);
            comboPais.Margin = new Padding(4, 5, 4, 5);
            comboPais.Name = "comboPais";
            comboPais.Size = new Size(325, 33);
            comboPais.TabIndex = 9;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources._3643769_building_home_house_main_menu_start_113416;
            PictureBox1.Location = new Point(1053, 13);
            PictureBox1.Margin = new Padding(4, 5, 4, 5);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(94, 89);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 30;
            PictureBox1.TabStop = false;
            // 
            // PicAgregar
            // 
            PicAgregar.Image = My.Resources.Resources.Add_Image_icon_icons_com_54218;
            PicAgregar.Location = new Point(1170, 13);
            PicAgregar.Margin = new Padding(4, 5, 4, 5);
            PicAgregar.Name = "PicAgregar";
            PicAgregar.Size = new Size(94, 89);
            PicAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicAgregar.TabIndex = 29;
            PicAgregar.TabStop = false;
            // 
            // Peliculas
            // 
            AutoScaleDimensions = new SizeF(9.0f, 21.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 727);
            Controls.Add(PictureBox1);
            Controls.Add(PicAgregar);
            Controls.Add(comboPais);
            Controls.Add(Label2);
            Controls.Add(comboGenero);
            Controls.Add(DataGridView1);
            Controls.Add(Label1);
            Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Peliculas";
            Text = "Peliculas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicAgregar).EndInit();
            Load += new EventHandler(Peliculas_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal DataGridView DataGridView1;
        internal ComboBox comboGenero;
        internal Label Label2;
        internal ComboBox comboPais;
        internal PictureBox PicAgregar;
        internal PictureBox PictureBox1;
    }
}