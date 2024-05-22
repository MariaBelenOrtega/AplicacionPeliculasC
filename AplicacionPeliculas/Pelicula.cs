using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace AplicacionPeliculas
{

    public partial class Pelicula
    {
        public int idp;
        public string nomPais;
        public int idG;
        public string nomG;
        public int idid;
        public string noiD;
        public int idCom;
        public string nomcOM;
        private int numClicks = 0;
        public Pelicula()
        {
            InitializeComponent();
        }
        private void bloqueotextos()
        {
            txtpais.ReadOnly = true;
            txtIdioma.ReadOnly = true;
            txtGenero.ReadOnly = true;
            txtCompania.ReadOnly = true;
        }
        private void Pelicula_Load(object sender, EventArgs e)
        {
            bloqueotextos();
            Label7.Visible = false;
            txtId.Visible = false;
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            string adultValue = comboAdult.Text;

            SqlParameter[] parameters = new[] { new SqlParameter("@Titulo", txtno.Text), new SqlParameter("@LanzamientoPelicula", txtFechaLanzamiento.Text), new SqlParameter("@DuracionPelicula", txtDuracion.Text), new SqlParameter("@Adult", adultValue), new SqlParameter("@IdiomaOriginal", txtIdiomaOriginal.Text), new SqlParameter("@TituloOriginal", txtNombreOriginal.Text), new SqlParameter("@Descripcion", txtDescripcion.Text), new SqlParameter("@Genero", txtGenero.Text), new SqlParameter("@Compania", txtCompania.Text), new SqlParameter("@Idioma", txtIdioma.Text), new SqlParameter("@Pais", txtpais.Text), new SqlParameter("@IdGenero", idG), new SqlParameter("@IdCompania", idCom), new SqlParameter("@IdPais", idp), new SqlParameter("@Ididioma", idid) };

            // Ejecutar el stored procedure
            bool success = Conecction.ExecuteStoredProcedure("SPAgregarPelicula3", parameters);
            if (success)
            {
                Interaction.MsgBox("El Registro ha sido Agregado");
                My.MyProject.Forms.Peliculas.Actualizar();
                numClicks = 0;
            }
            else
            {
                Interaction.MsgBox("El Registro no se Agrego");
                numClicks = 0;
            }

            Limpiar();
        }
        public void Limpiar()
        {
            txtno.Clear();
            txtNombreOriginal.Clear();
            txtDuracion.Clear();
            txtFechaLanzamiento.Clear();
            txtGenero.Clear();
            txtIdiomaOriginal.Clear();
            txtpais.Clear();
            txtCompania.Clear();
            txtDescripcion.Clear();
            txtIdioma.Clear();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string query = "SELECT idPais, Pais  FROM Pais where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BusquedaPais.DataBuscaPais.DataSource = dt;
            My.MyProject.Forms.BusquedaPais.Show();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            string query = "SELECT idIdioma, Idioma  FROM Idioma where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaIdioma.dataBuscaIdioma.DataSource = dt;
            My.MyProject.Forms.BuscaIdioma.Show();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            string query = "SELECT id, nombre  FROM Genero where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaGenero.DataBuscagenero.DataSource = dt;
            My.MyProject.Forms.BuscaGenero.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            string query = "SELECT idCompania, nombre  FROM Compania where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaCompania.DataBuscaCompania.DataSource = dt;
            My.MyProject.Forms.BuscaCompania.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                Label7.Visible = true;
                txtId.Visible = true;
                txtno.ReadOnly = true;
                txtNombreOriginal.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
                txtDuracion.ReadOnly = true;
                txtIdiomaOriginal.ReadOnly = true;
                txtFechaLanzamiento.ReadOnly = true;
                comboAdult.Enabled = false;
            }

            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@idPelicula", txtId.Text), new SqlParameter("@IdUsuarioModifica", My.MyProject.Forms.Cuenta.idU) };

                // Ejecutar el stored procedure
                bool success = Conecction.ExecuteStoredProcedure("SPEliminarPelicula3", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Eliminado");
                    Label7.Visible = false;
                    txtId.Visible = false;
                    My.MyProject.Forms.Peliculas.Actualizar();
                    numClicks = 0;
                }
                else
                {
                    Interaction.MsgBox("El Registro no se Elimino");
                    numClicks = 0;
                }
            }

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                txtId.Visible = true;
                Label7.Visible = true;
            }
            else
            {
                string adultValue = comboAdult.Text;

                SqlParameter[] parameters = new[] { new SqlParameter("@IdPelicula", txtId.Text), new SqlParameter("@Titulo", txtno.Text), new SqlParameter("@LanzamientoPelicula", txtFechaLanzamiento.Text), new SqlParameter("@DuracionPelicula", txtDuracion.Text), new SqlParameter("@Adult", adultValue), new SqlParameter("@IdiomaOriginal", txtIdiomaOriginal.Text), new SqlParameter("@TituloOriginal", txtNombreOriginal.Text), new SqlParameter("@Descripcion", txtDescripcion.Text), new SqlParameter("@Genero", txtGenero.Text), new SqlParameter("@Compania", txtCompania.Text), new SqlParameter("@Idioma", txtIdioma.Text), new SqlParameter("@Pais", txtpais.Text), new SqlParameter("@IdGenero", idG), new SqlParameter("@IdCompania", idCom), new SqlParameter("@IdPais", idp), new SqlParameter("@Ididioma", idid) };

                // Ejecutar el stored procedure
                bool success = Conecction.ExecuteStoredProcedure("SPActualizarPelicula3", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Actualizado");
                    My.MyProject.Forms.Peliculas.Actualizar();
                    numClicks = 0;
                }
                else
                {
                    Interaction.MsgBox("El Registro no se Actualizo");
                    numClicks = 0;
                }

                Limpiar();
            }
        }
    }
}