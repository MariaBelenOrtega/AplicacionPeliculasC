using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace AplicacionPeliculas
{

    public partial class Compañia
    {
        private int numClicks = 0;

        public Compañia()
        {
            InitializeComponent();
        }

        private void picAgregar_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                txtidCom.Enabled = false;
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@nombre", txtNomCom.Text), new SqlParameter("@UsuarioCrea", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPAgregarCompania", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Agregado");
                    txtidCom.Enabled = true;
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
            txtNomCom.Clear();
            txtidCom.Clear();
        }

        private void PicBorrar_Click(object sender, EventArgs e)
        {
            numClicks += 1;

            if (numClicks == 1)
            {
                txtNomCom.Enabled = false;
            }

            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@idCompania", txtidCom.Text), new SqlParameter("@IdUsuarioModifica", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPEliminarCompania", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Registro ha sido Borrado");
                    txtNomCom.Enabled = true;
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
                string query = "SELECT idCompania, nombre  FROM Compania where estatus = 1";
                var dt = Conecction.SelectQuery(query);
                My.MyProject.Forms.ModificarCompañia.dataModCom.DataSource = dt;
                My.MyProject.Forms.ModificarCompañia.Show();
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@idCompania", txtidCom.Text), new SqlParameter("@nombre", txtNomCom.Text), new SqlParameter("@IdUsuarioModifica", My.MyProject.Forms.Cuenta.idU) };
                bool success = Conecction.ExecuteStoredProcedure("SPActualizarCompania", parameters);
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
            string query = "SELECT idCompania, nombre  FROM Compania where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaCompania.DataBuscaCompania.DataSource = dt;
            My.MyProject.Forms.BuscaCompania.Show();
        }


    }
}