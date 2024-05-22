using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{
    public partial class ModificaIdioma
    {
        public int idIdioma;
        public string nombreIdioma;
        private string query;

        public ModificaIdioma()
        {
            InitializeComponent();
        }

        private void DataModIdioma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idIdioma = Conversions.ToInteger(DataModIdioma.Rows[e.RowIndex].Cells[0].Value);
                nombreIdioma = Conversions.ToString(DataModIdioma.Rows[e.RowIndex].Cells[1].Value);
                My.MyProject.Forms.Idioma.txtidIdioma.Text = idIdioma.ToString();
                My.MyProject.Forms.Idioma.txtNomIdioma.Text = nombreIdioma;
                My.MyProject.Forms.Idioma.Show();
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.");
            }
        }

        public void filitrarIdIdioma()
        {
            query = "select * from Idioma where idIdioma LIKE '%" + txtidIdioma.Text + "%' and estatus = 1";
            DataModIdioma.DataSource = Conecction.SelectQuery(query);
        }

        public void filitrarIdioma()
        {
            query = "select * from Idioma where Idioma LIKE '%" + txtNomIdioma.Text + "%' and estatus = 1";
            DataModIdioma.DataSource = Conecction.SelectQuery(query);
        }

        private void txtNomIdioma_TextChanged(object sender, EventArgs e)
        {
            filitrarIdioma();
        }

        private void txtidIdioma_TextChanged(object sender, EventArgs e)
        {
            filitrarIdIdioma();
        }
    }
}