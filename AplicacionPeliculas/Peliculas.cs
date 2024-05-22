using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{

    public partial class Peliculas
    {
        private bool auto;
        private string query;
        public int idpeli;


        public Peliculas()
        {
            auto = true;
            InitializeComponent();

            // Agregue cualquier inicialización después de la llamada a InitializeComponent().

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            // Add any initialization after the InitializeComponent() call.

            query = "SELECT pais, idPais FROM Pais where estatus = 1";
            comboPais.DataSource = Conecction.SelectQuery(query);
            comboPais.DisplayMember = "pais";
            comboPais.ValueMember = "idPais";
            auto = false;
        }

        private void comboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auto)
            {
                return;
            }

            if (comboPais.Text is null)
            {
                return;
            }
            var s = comboGenero.SelectedValue;
            Interaction.MsgBox(s);

            query = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * FROM VWBuscador1  where pais like '%" + comboPais.Text + "%' and id = ", s), " and estatus = 1"));
            // filtar()
            DataGridView1.DataSource = Conecction.SelectQuery(query);
            // Dim indiceColumna As Integer = 6
            // DataGridView1.Columns(indiceColumna).Visible = False
        }
        public void Actualizar()
        {
            if (auto)
            {
                return;
            }

            auto = true;

            query = Conversions.ToString(Operators.ConcatenateObject("select * from vwgeneropais1 where idpais = ", comboPais.SelectedValue));
            comboGenero.DataSource = Conecction.SelectQuery(query);
            comboGenero.DisplayMember = "Nombre";
            comboGenero.ValueMember = "id";

            auto = false;
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idpeli = Conversions.ToInteger(DataGridView1.Rows[e.RowIndex].Cells[0].Value);
                My.MyProject.Forms.Form1.Show();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.");
            }
        }

        private void comboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void PicAgregar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Pelicula.Show();
        }


        private void filtrar()
        {
            query = "select * FROM VWBuscador1 WHERE Pais LIKE  '% " + comboPais.Text + " %' AND   id ='%" + comboGenero.Text + "%'";
            DataGridView1.DataSource = Conecction.SelectQuery(query);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.inicio.Show();
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {

        }
    }
}