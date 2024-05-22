using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace AplicacionPeliculas
{

    public partial class Pais
    {

        private int numClicks = 0;

        public Pais()
        {
            InitializeComponent();
        }
        private void picAgregar_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                txtidIPais.Enabled = false;
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@pais", txtNomPais.Text), new SqlParameter("@UsuarioCrea", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPAgregarPais", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Agregado");
                    txtidIPais.Enabled = true;
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
            txtNomPais.Clear();
            txtidIPais.Clear();
        }

        private void PicBorrar_Click(object sender, EventArgs e)
        {
            numClicks += 1;

            if (numClicks == 1)
            {
                txtNomPais.Enabled = false;
            }

            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@idPais", txtidIPais.Text), new SqlParameter("@IdUsuarioModifica", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPEliminarPais", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Borrado");
                    txtNomPais.Enabled = true;
                    numClicks = 0;
                }
                else
                {
                    Interaction.MsgBox("El Registro no se Borro");
                    numClicks = 0;
                }
            }
            Limpiar();
        }

        private void PicActualizar_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                string query = "SELECT idPais, Pais  FROM Pais where estatus = 1";
                var dt = Conecction.SelectQuery(query);
                My.MyProject.Forms.ModificarPais.dataModPais.DataSource = dt;
                My.MyProject.Forms.ModificarPais.Show();
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@idPais", txtidIPais.Text), new SqlParameter("@pais", txtNomPais.Text), new SqlParameter("@IdUsuarioModifica", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPActualizarPais", parameters);
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string query = "SELECT idPais, Pais  FROM Pais where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BusquedaPais.DataBuscaPais.DataSource = dt;
            My.MyProject.Forms.BusquedaPais.Show();
        }
    }
}