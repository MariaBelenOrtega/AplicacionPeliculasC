using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{

    public partial class BusquedaPais
    {
        public int idpais;
        public string nombrepais;
        private string query;

        public BusquedaPais()
        {
            InitializeComponent();
        }

        private void DataBuscaPais_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                idpais = Conversions.ToInteger(DataBuscaPais.Rows[e.RowIndex].Cells[0].Value);
                nombrepais = Conversions.ToString(DataBuscaPais.Rows[e.RowIndex].Cells[1].Value);
                My.MyProject.Forms.Pelicula.idp = idpais;
                My.MyProject.Forms.Pelicula.txtpais.Text = nombrepais;
                My.MyProject.Forms.Pelicula.Show();
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre del Pais.");
            }
        }

        private void txtNomPais_TextChanged(object sender, EventArgs e)
        {
            filitrarPais();
        }
        public void filitrarIdPais()
        {
            query = "select * from Pais where idPais LIKE '%" + txtidPais.Text + "%'and estatus = 1";
            DataBuscaPais.DataSource = Conecction.SelectQuery(query);
        }

        public void filitrarPais()
        {
            query = "select * from Pais where Pais LIKE '%" + txtNomPais.Text + "%' and estatus = 1";
            DataBuscaPais.DataSource = Conecction.SelectQuery(query);
        }

        private void txtidPais_TextChanged(object sender, EventArgs e)
        {
            filitrarIdPais();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Pais.Show();
        }
    }
}