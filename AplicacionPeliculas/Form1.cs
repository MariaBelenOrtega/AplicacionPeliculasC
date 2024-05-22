using System;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{

    public partial class Form1
    {
        private string query;
        public int idbusca;

        public Form1()
        {
            InitializeComponent();
        }
        private void bloqueotextos()
        {
            txtId.ReadOnly = true;
            txtno.ReadOnly = true;
            txtNombreOriginal.ReadOnly = true;
            txtGenero.ReadOnly = true;
            txtFechaLanzamiento.ReadOnly = true;
            txtIdioma.ReadOnly = true;
            txtIdiomaOriginal.ReadOnly = true;
            txtCompania.ReadOnly = true;
            txtDuracion.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            comboAdult.Enabled = false;
            txtpais.ReadOnly = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bloqueotextos();
            idbusca = My.MyProject.Forms.Peliculas.idpeli;
            busqueda();
        }
        public void busqueda()
        {
            DataTable dt;
            string query = "select * from VWPELICULA2 where idPelicula = ' " + idbusca.ToString() + "'";
            dt = Conecction.SelectQuery(query);


            txtId.Text = Conversions.ToString(dt.Rows[0][0]);
            txtno.Text = Conversions.ToString(dt.Rows[0][1]);
            txtFechaLanzamiento.Text = Conversions.ToString(dt.Rows[0][2]);
            txtDuracion.Text = Conversions.ToString(Operators.ConcatenateObject(dt.Rows[0][3], " Min."));
            comboAdult.Text = Conversions.ToString(dt.Rows[0][4]);
            txtIdiomaOriginal.Text = Conversions.ToString(dt.Rows[0][5]);
            txtpais.Text = Conversions.ToString(dt.Rows[0][6]);
            txtNombreOriginal.Text = Conversions.ToString(dt.Rows[0][7]);
            txtDescripcion.Text = Conversions.ToString(dt.Rows[0][8]);
            txtGenero.Text = Conversions.ToString(dt.Rows[0][9]);
            txtCompania.Text = Conversions.ToString(dt.Rows[0][10]);
            txtIdioma.Text = Conversions.ToString(dt.Rows[0][11]);

        }

        public void limpiar()
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Pelicula.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Pelicula.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Pelicula.txtId.Visible = true;
            My.MyProject.Forms.Pelicula.Label7.Visible = true;
            My.MyProject.Forms.Pelicula.txtId.Text = idbusca.ToString();
            My.MyProject.Forms.Pelicula.Show();
        }
    }
}