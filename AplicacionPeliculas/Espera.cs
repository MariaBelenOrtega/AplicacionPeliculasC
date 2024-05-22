using System;
using System.Windows.Forms;

namespace AplicacionPeliculas
{
    public partial class Espera
    {
        public Espera()
        {
            InitializeComponent();
        }
        private void Espera_Load(object sender, EventArgs e)
        {
            SimularProgreso();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
            ProgressBar1.Maximum = 100;

        }

        public void SimularProgreso()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }

            if (ProgressBar1.Value == 100)
            {
                My.MyProject.Forms.Peliculas.Show();
                Close();
            }
            ProgressBar1.Value = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}