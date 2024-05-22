using System;

namespace AplicacionPeliculas
{
    public partial class TablasIntermedias
    {
        private int idbuscaP;

        public TablasIntermedias()
        {
            InitializeComponent();
        }
        private void PicBuscaPeli_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Peliculas.Show();
        }

        private void TablasIntermedias_Load(object sender, EventArgs e)
        {
            idbuscaP = My.MyProject.Forms.Peliculas.idpeli;
        }


    }
}