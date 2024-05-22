using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{
    public partial class BuscaUsuario
    {
        public int id;
        public string nombre;
        public string Username;
        private string query;

        public BuscaUsuario()
        {
            InitializeComponent();
        }

        private void DataBusca_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                id = Conversions.ToInteger(DataBusca.Rows[e.RowIndex].Cells[0].Value);
                nombre = Conversions.ToString(DataBusca.Rows[e.RowIndex].Cells[1].Value);
                Username = Conversions.ToString(DataBusca.Rows[e.RowIndex].Cells[2].Value);
                My.MyProject.Forms.Usuario.txtNombreU.Text = nombre;
                My.MyProject.Forms.Usuario.txtId.Text = id.ToString();
                My.MyProject.Forms.Usuario.txtUsernameU.Text = Username;
                My.MyProject.Forms.Usuario.Show();
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre del Usuario a buscar.");
            }
        }

        public void filitrarId()
        {
            query = "select id, nombre, username from Usuario where id LIKE '%" + txtid.Text + "%'and estatus = 1";
            DataBusca.DataSource = Conecction.SelectQuery(query);
        }

        public void filitrar()
        {
            query = "select id, nombre, username from Usuario where nombre LIKE '%" + txtNom.Text + "%' and estatus = 1";
            DataBusca.DataSource = Conecction.SelectQuery(query);
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            filitrar();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            filitrarId();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Usuario.Show();
        }
    }
}