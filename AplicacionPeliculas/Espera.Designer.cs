using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Espera : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Espera));
            ProgressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // ProgressBar1
            // 
            ProgressBar1.ForeColor = SystemColors.MenuHighlight;
            resources.ApplyResources(ProgressBar1, "ProgressBar1");
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Step = 2;
            ProgressBar1.Style = ProgressBarStyle.Continuous;
            // 
            // Espera
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            BackgroundImage = My.Resources.Resources.Peliculasss;
            Controls.Add(ProgressBar1);
            Name = "Espera";
            TransparencyKey = Color.Transparent;
            Load += new EventHandler(Espera_Load);
            ResumeLayout(false);

        }

        internal ProgressBar ProgressBar1;
    }
}