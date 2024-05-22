using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{
    public partial class ModificarPais
    {
        public int idPais;
        public string nombrePais;
        private string query;

        public ModificarPais()
        {
            InitializeComponent();
        }

        private void dataModPais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idPais = Conversions.ToInteger(dataModPais.Rows[e.RowIndex].Cells[0].Value);
                nombrePais = Conversions.ToString(dataModPais.Rows[e.RowIndex].Cells[1].Value);
                My.MyProject.Forms.Pais.txtidIPais.Text = idPais.ToString();
                My.MyProject.Forms.Pais.txtNomPais.Text = nombrePais;
                My.MyProject.Forms.Pais.Show();
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.");
            }
        }

        private void txtNomPais_TextChanged(object sender, EventArgs e)
        {
            filitrarPais();
        }
        public void filitrarIdPais()
        {
            query = "select * from Pais where idPais LIKE '%" + txtidPais.Text + "%'and estatus = 1";
            dataModPais.DataSource = Conecction.SelectQuery(query);
        }

        public void filitrarPais()
        {
            query = "select * from Pais where Pais LIKE '%" + txtNomPais.Text + "%' and estatus = 1";
            dataModPais.DataSource = Conecction.SelectQuery(query);
        }

        private void txtidPais_TextChanged(object sender, EventArgs e)
        {
            filitrarIdPais();
        }
    }
}