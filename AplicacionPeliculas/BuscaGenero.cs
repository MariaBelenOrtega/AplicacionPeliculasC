using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{
    public partial class BuscaGenero
    {
        public int idgenero;
        public string nombregenero;
        private string query;

        public BuscaGenero()
        {
            InitializeComponent();
        }

        private void DataBuscagenero_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idgenero = Conversions.ToInteger(DataBuscagenero.Rows[e.RowIndex].Cells[0].Value);
                nombregenero = Conversions.ToString(DataBuscagenero.Rows[e.RowIndex].Cells[1].Value);
                My.MyProject.Forms.Pelicula.idG = idgenero;
                My.MyProject.Forms.Pelicula.txtGenero.Text = nombregenero;
                My.MyProject.Forms.Pelicula.Show();
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre del Genero");
            }
        }

        private void txtNomCom_TextChanged(object sender, EventArgs e)
        {
            flitrarGen();
        }

        public void flitrarIdGen()
        {
            query = "select * from Genero where id LIKE '%" + txtidGen.Text + "%' and estatus = 1";
            DataBuscagenero.DataSource = Conecction.SelectQuery(query);
        }

        public void flitrarGen()
        {
            query = "select * from Genero where nombre LIKE '%" + txtNomGen.Text + "%' and estatus = 1";
            DataBuscagenero.DataSource = Conecction.SelectQuery(query);
        }

        private void txtidGen_TextChanged(object sender, EventArgs e)
        {
            flitrarIdGen();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Genero.Show();
        }
    }
}