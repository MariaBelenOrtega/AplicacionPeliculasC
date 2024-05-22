using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{
    public partial class ModificarCompañia
    {
        public int idcom;
        public string nombreCom;
        private string query;

        public ModificarCompañia()
        {
            InitializeComponent();
        }
        private void dataModCom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idcom = Conversions.ToInteger(dataModCom.Rows[e.RowIndex].Cells[0].Value);
                nombreCom = Conversions.ToString(dataModCom.Rows[e.RowIndex].Cells[1].Value);
                My.MyProject.Forms.Compañia.txtidCom.Text = idcom.ToString();
                My.MyProject.Forms.Compañia.txtNomCom.Text = nombreCom;
                My.MyProject.Forms.Compañia.Show();
                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error" + Constants.vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.");
            }
        }
        public void flitrarIdCom()
        {
            query = "select * from Compania where idCompania LIKE '%" + txtidCom.Text + "%' and estatus = 1";
            dataModCom.DataSource = Conecction.SelectQuery(query);
        }
        public void flitrarCom()
        {
            query = "select * from Compania where nombre LIKE '%" + txtNomCom.Text + "%' and estatus = 1";
            dataModCom.DataSource = Conecction.SelectQuery(query);
        }

        private void txtNomCom_TextChanged(object sender, EventArgs e)
        {
            flitrarCom();
        }

        private void txtidCom_TextChanged(object sender, EventArgs e)
        {
            flitrarIdCom();
        }
    }
}