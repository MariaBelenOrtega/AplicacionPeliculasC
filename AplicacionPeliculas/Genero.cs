using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace AplicacionPeliculas
{

    public partial class Genero
    {
        private int numClicks = 0;

        public Genero()
        {
            InitializeComponent();
        }
        private void picAgregar_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                txtidgen.Enabled = false;
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@NombreGenero", txtNomGenero.Text), new SqlParameter("@UsuarioCrea", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPAgregarGenero", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Agregado");
                    txtidgen.Enabled = true;
                    numClicks = 0;
                }
                else
                {
                    Interaction.MsgBox("El Registro no se Agrego");
                }
            }

            Limpiar();
        }


        public void Limpiar()
        {
            txtNomGenero.Clear();
            txtidgen.Clear();
        }

        private void PicBorrar_Click(object sender, EventArgs e)
        {
            numClicks += 1;

            if (numClicks == 1)
            {
                txtNomGenero.Enabled = false;
            }

            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@id", txtidgen.Text), new SqlParameter("@IdUsuarioModifica", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPEliminarGenero", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Borrado");
                    txtNomGenero.Enabled = true;
                    numClicks = 0;
                }
                else
                {
                    Interaction.MsgBox("El Registro no se Borro");
                }
            }

            Limpiar();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string query = "SELECT id, nombre  FROM Genero where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaGenero.DataBuscagenero.DataSource = dt;
            My.MyProject.Forms.BuscaGenero.Show();
        }

        private void PicActualizar_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                string query = "SELECT id, nombre  FROM Genero where estatus = 1";
                var dt = Conecction.SelectQuery(query);
                My.MyProject.Forms.ModificaGenero.DataModgenero.DataSource = dt;
                My.MyProject.Forms.ModificaGenero.Show();
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@id", txtidgen.Text), new SqlParameter("@nombre", txtNomGenero.Text), new SqlParameter("@IdUsuarioModifica", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPActualizarGenero", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Modificado");
                    numClicks = 0;
                }
                else
                {
                    Interaction.MsgBox("El Registro no se Modifico");

                }
            }
            Limpiar();
        }

        private void Genero_Load(object sender, EventArgs e)
        {

        }
    }
}