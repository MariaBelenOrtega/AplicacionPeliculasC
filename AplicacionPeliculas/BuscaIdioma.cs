using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{
    public partial class BuscaIdioma
    {
        public int idIdioma;
        public string nombreIdioma;
        private string query;

        public BuscaIdioma()
        {
            InitializeComponent();
        }


        private void dataBuscaIdioma_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                idIdioma = Conversions.ToInteger(dataBuscaIdioma.Rows[e.RowIndex].Cells[0].Value);
                nombreIdioma = Conversions.ToString(dataBuscaIdioma.Rows[e.RowIndex].Cells[1].Value);
                My.MyProject.Forms.Pelicula.idid = idIdioma;
                My.MyProject.Forms.Pelicula.txtIdioma.Text = nombreIdioma;
                My.MyProject.Forms.Pelicula.Show();
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre del Idioma");
            }
        }

        private void txtNomIdioma_TextChanged(object sender, EventArgs e)
        {
            filitrarIdioma();
        }

        public void filitrarIdIdioma()
        {
            query = "select * from Idioma where idIdioma LIKE '%" + txtidIdioma.Text + "%' and estatus = 1";
            dataBuscaIdioma.DataSource = Conecction.SelectQuery(query);
        }

        public void filitrarIdioma()
        {
            query = "select * from Idioma where Idioma LIKE '%" + txtNomIdioma.Text + "%' and estatus = 1";
            dataBuscaIdioma.DataSource = Conecction.SelectQuery(query);
        }

        private void txtidIdioma_TextChanged(object sender, EventArgs e)
        {
            filitrarIdIdioma();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Idioma.Show();
        }
    }
}