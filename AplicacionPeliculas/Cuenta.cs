using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AplicacionPeliculas
{

    public partial class Cuenta
    {
        private string query;
        public int idU;
        public string NombreUser;
        public string Username;
        public string contraseñaU;

        public Cuenta()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            query = "select convert(nvarchar(50),hashbytes('SHA1','" + txtcontra.Text + @"'),1) from usuario
        where username = '" + txtusuario.Text + "'";
            DataTable dt;
            try
            {
                dt = Conecction.SelectQuery(query);
                var contrausuario = dt.Rows[0][0];

                query = "select id, nombre,password, username from usuario where username ='" + txtusuario.Text + "'";
                dt = Conecction.SelectQuery(query);
                var contrabase = dt.Rows[0][2];

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(contrabase, contrausuario, false)))
                {
                    idU = Conversions.ToInteger(dt.Rows[0][0]);
                    NombreUser = Conversions.ToString(dt.Rows[0][1]);
                    Username = Conversions.ToString(dt.Rows[0][3]);
                    // '  MsgBox("Contraseña Correcta")
                    My.MyProject.Forms.Espera.Show();
                }

                else
                {
                    Interaction.MsgBox("Contraseña incorrecta");
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Usuario No existe");
            }
        }
    }
}