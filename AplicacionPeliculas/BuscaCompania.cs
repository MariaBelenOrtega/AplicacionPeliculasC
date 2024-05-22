using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{
    public partial class BuscaCompania
    {
        public int idCompania;
        public string nombreCompania;
        private string query;

        public BuscaCompania()
        {
            InitializeComponent();
        }
        private void DataBuscaCompania_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                idCompania = Conversions.ToInteger(DataBuscaCompania.Rows[e.RowIndex].Cells[0].Value);
                nombreCompania = Conversions.ToString(DataBuscaCompania.Rows[e.RowIndex].Cells[1].Value);
                My.MyProject.Forms.Pelicula.idCom = idCompania;
                My.MyProject.Forms.Pelicula.txtCompania.Text = nombreCompania;
                My.MyProject.Forms.Pelicula.Show();
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre de la Compañia.");
            }
        }

        public void flitrarCom()
        {
            query = "select * from Compania where nombre LIKE '%" + txtNomCom.Text + "%' and estatus = 1";
            DataBuscaCompania.DataSource = Conecction.SelectQuery(query);
        }

        private void txtNomCom_TextChanged(object sender, EventArgs e)
        {
            flitrarCom();
            int Columna = 2;
            int Columna2 = 3;
            int Columna3 = 4;
            int Columna4 = 5;
            int Columna5 = 6;
            DataBuscaCompania.Columns[Columna].Visible = false;
            DataBuscaCompania.Columns[Columna2].Visible = false;
            DataBuscaCompania.Columns[Columna3].Visible = false;
            DataBuscaCompania.Columns[Columna4].Visible = false;
            DataBuscaCompania.Columns[Columna5].Visible = false;
        }

        public void flitrarIdCom()
        {
            query = "select * from Compania where idCompania LIKE '%" + txtid.Text + "%' and estatus = 1";
            DataBuscaCompania.DataSource = Conecction.SelectQuery(query);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            flitrarIdCom();
            int Columna = 2;
            int Columna2 = 3;
            int Columna3 = 4;
            int Columna4 = 5;
            int Columna5 = 6;
            DataBuscaCompania.Columns[Columna].Visible = false;
            DataBuscaCompania.Columns[Columna2].Visible = false;
            DataBuscaCompania.Columns[Columna3].Visible = false;
            DataBuscaCompania.Columns[Columna4].Visible = false;
            DataBuscaCompania.Columns[Columna5].Visible = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Compañia.Show();

        }


    }
}