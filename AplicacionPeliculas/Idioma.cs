using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace AplicacionPeliculas
{

    public partial class Idioma
    {
        private int numClicks = 0;

        public Idioma()
        {
            InitializeComponent();
        }

        private void picAgregar_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                txtidIdioma.Enabled = false;
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@Idioma", txtNomIdioma.Text), new SqlParameter("@UsuarioCrea", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPAgregarIdioma", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Agregado");
                    txtidIdioma.Enabled = true;
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
            txtNomIdioma.Clear();
            txtidIdioma.Clear();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string query = "SELECT idIdioma, Idioma  FROM Idioma where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaIdioma.dataBuscaIdioma.DataSource = dt;
            My.MyProject.Forms.BuscaIdioma.Show();
        }

        private void PicBorrar_Click(object sender, EventArgs e)
        {
            numClicks += 1;

            if (numClicks == 1)
            {
                txtNomIdioma.Enabled = false;
            }

            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@idIdioma", txtidIdioma.Text), new SqlParameter("@IdUsuarioModifica", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPEliminarIdioma", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Borrado");
                    txtNomIdioma.Enabled = true;
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
                string query = "SELECT idIdioma, Idioma  FROM Idioma where estatus = 1";
                var dt = Conecction.SelectQuery(query);
                My.MyProject.Forms.ModificaIdioma.DataModIdioma.DataSource = dt;
                My.MyProject.Forms.ModificaIdioma.Show();
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@idIdioma", txtidIdioma.Text), new SqlParameter("@nombre", txtNomIdioma.Text), new SqlParameter("@IdUsuarioModifica", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPActualizarIdioma", parameters);
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



    }
}