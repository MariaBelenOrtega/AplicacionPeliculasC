using System;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace AplicacionPeliculas
{

    public partial class Usuario
    {
        public string query;
        private int numClicks = 0;

        public Usuario()
        {
            InitializeComponent();
        }
        private void Usuario_Load(object sender, EventArgs e)
        {
            Label2.Text = My.MyProject.Forms.Cuenta.NombreUser;
            txtContraseña.Visible = false;
            Label5.Visible = false;
            txtNombreU.Text = My.MyProject.Forms.Cuenta.NombreUser;
            txtUsernameU.Text = My.MyProject.Forms.Cuenta.Username;
            txtUsernameU.Enabled = false;
            txtNombreU.Enabled = false;
            txtId.Visible = false;
            Label6.Visible = false;

            if (My.MyProject.Forms.Cuenta.idU == 1)
            {
                picAgregar.Visible = true;
                PicBorrar.Visible = true;
                PicActualizar.Visible = true;
            }
            else
            {
                picAgregar.Visible = false;
                PicBorrar.Visible = false;
                PicActualizar.Visible = true;
            }

            if (My.MyProject.Forms.Cuenta.idU != 1)
            {
                txtContraseña.Enabled = false;
                txtUsernameU.Enabled = false;
                txtNombreU.Enabled = false;
            }
        }

        private void picAgregar_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                txtContraseña.Clear();
                txtUsernameU.Clear();
                txtNombreU.Clear();
                txtContraseña.Enabled = true;
                txtUsernameU.Enabled = true;
                txtNombreU.Enabled = true;
                txtContraseña.Visible = true;
                Label5.Visible = true;
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@nombre", txtNombreU.Text), new SqlParameter("@username", txtUsernameU.Text), new SqlParameter("@password", txtContraseña.Text) };
                bool success = Conecction.ExecuteStoredProcedure("SPAgregarUsuario", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Usuario ha sido Agregado");
                    txtUsernameU.Enabled = false;
                    txtNombreU.Enabled = false;
                    txtContraseña.Enabled = false;
                    numClicks = 0;
                }
                else
                {
                    Interaction.MsgBox("El Usuario no se Agrego");

                }
            }
        }

        private void PicActualizar_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (My.MyProject.Forms.Cuenta.idU == 1)
            {
                My.MyProject.Forms.BuscaUsuario.Show();

            }
            if (numClicks == 1)
            {
                txtContraseña.Clear();
                txtUsernameU.Clear();
                txtNombreU.Clear();
                txtContraseña.Enabled = true;
                txtUsernameU.Enabled = true;
                txtNombreU.Enabled = true;
                txtContraseña.Visible = true;
                Label5.Visible = true;
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@id", My.MyProject.Forms.Cuenta.idU), new SqlParameter("@nombre", txtNombreU.Text), new SqlParameter("@username", txtUsernameU.Text), new SqlParameter("@password", txtContraseña.Text) };
                bool success = Conecction.ExecuteStoredProcedure("SPActualizarUsuario", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Usuario ha sido Actualizado");
                    numClicks = 0;
                    if (My.MyProject.Forms.Cuenta.idU == 1)
                    {
                        Label2.Text = My.MyProject.Forms.Cuenta.NombreUser;
                    }
                    else
                    {
                        Label2.Text = txtNombreU.Text;
                    }

                    txtUsernameU.Enabled = false;
                    txtNombreU.Enabled = false;
                    txtContraseña.Enabled = false;
                }
                else
                {
                    Interaction.MsgBox("El Usuario no se Actualizo");

                }
            }
        }

        private void PicBorrar_Click(object sender, EventArgs e)
        {
            numClicks += 1;
            if (numClicks == 1)
            {
                txtId.Visible = true;
                Label6.Visible = true;
                txtUsernameU.Clear();
                txtNombreU.Clear();
                txtUsernameU.Visible = true;
                txtNombreU.Visible = true;
                txtContraseña.Visible = false;
                Label5.Visible = false;
            }
            else
            {
                SqlParameter[] parameters = new[] { new SqlParameter("@id", txtId.Text) };
                bool success = Conecction.ExecuteStoredProcedure("SPEliminarUsuario", parameters);
                if (success)
                {
                    Interaction.MsgBox("El Usuario ha sido Borrado");
                    numClicks = 0;
                    Label2.Text = txtNombreU.Text;
                    txtUsernameU.Enabled = false;
                    txtNombreU.Enabled = false;
                    txtContraseña.Enabled = false;
                    txtContraseña.Visible = false;
                    Label5.Visible = false;
                }
                else
                {
                    Interaction.MsgBox("El Usuario no se Borro");

                }
            }

        }

        private void PicBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT id, nombre  FROM Usuario where estatus = 1";
            var dt = Conecction.SelectQuery(query);
            My.MyProject.Forms.BuscaUsuario.DataBusca.DataSource = dt;
            My.MyProject.Forms.BuscaUsuario.Show();
        }
    }
}