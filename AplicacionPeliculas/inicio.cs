using System;
using System.Drawing;

namespace AplicacionPeliculas
{
    public partial class inicio
    {
        public inicio()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Pelicula.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Genero.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT idPais, Pais  FROM Pais where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BusquedaPais.DataBuscaPais.DataSource = dt;
            My.MyProject.Forms.BusquedaPais.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT id, nombre  FROM Genero where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaGenero.DataBuscagenero.DataSource = dt;
            My.MyProject.Forms.BuscaGenero.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT idCompania, nombre  FROM Compania where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaCompania.DataBuscaCompania.DataSource = dt;
            My.MyProject.Forms.BuscaCompania.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string query = "SELECT idIdioma, Idioma  FROM Idioma where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaIdioma.dataBuscaIdioma.DataSource = dt;
            My.MyProject.Forms.BuscaIdioma.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Idioma.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Pais.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Compañia.Show();
        }



        private void inicio_Load(object sender, EventArgs e)
        {
            Label1.BackColor = Color.Transparent;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Usuario.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Peliculas.Show();
        }


    }
}