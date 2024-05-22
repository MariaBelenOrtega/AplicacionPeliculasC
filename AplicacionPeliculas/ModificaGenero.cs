using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{
    public partial class ModificaGenero
    {
        public int idgenero;
        public string nombregenero;
        private string query;

        public ModificaGenero()
        {
            InitializeComponent();
        }
        private void DataModgenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idgenero = Conversions.ToInteger(DataModgenero.Rows[e.RowIndex].Cells[0].Value);
                nombregenero = Conversions.ToString(DataModgenero.Rows[e.RowIndex].Cells[1].Value);
                My.MyProject.Forms.Genero.txtidgen.Text = idgenero.ToString();
                My.MyProject.Forms.Genero.txtNomGenero.Text = nombregenero;
                My.MyProject.Forms.Genero.Show();
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.");
            }
        }
        public void flitrarIdGen()
        {
            query = "select * from Genero where id LIKE '%" + txtidGen.Text + "%' and estatus = 1";
            DataModgenero.DataSource = Conecction.SelectQuery(query);
        }

        public void flitrarGen()
        {
            query = "select * from Genero where nombre LIKE '%" + txtNomGen.Text + "%' and estatus = 1";
            DataModgenero.DataSource = Conecction.SelectQuery(query);
        }

        private void txtNomGen_TextChanged(object sender, EventArgs e)
        {
            flitrarGen();
        }

        private void txtidGen_TextChanged(object sender, EventArgs e)
        {
            flitrarIdGen();
        }

    }
}