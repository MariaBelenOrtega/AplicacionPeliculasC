using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace AplicacionPeliculas
{
    public class Conecction
    {

        private static SqlConnection cnx = new SqlConnection();

        private static void connect()
        {
            try
            {
                cnx.ConnectionString = "Data Source=LAPTOP-EIM430LI; Initial Catalog=Peliculas_Animacion;Integrated Security=True";
                cnx.Open();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private static void disconect()
        {
            try
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al desconectar la base de datos" + ex.Message);
            }
        }


        public static DataTable SelectQuery(string query)
        {
            var dt = new DataTable();
            try
            {
                connect();
                var cmd = new SqlCommand(query, cnx);
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                disconect();
            }
            return dt;
        }





        public static bool ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters)
        {
            string connectionString = "Data Source=LAPTOP-EIM430LI; Initial Catalog=Peliculas_Animacion;Integrated Security=True"; // Reemplaza con tu cadena de conexión
            var connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                // Iniciar la transacción
                var transaction = connection.BeginTransaction();

                try
                {
                    // Crear el comando para el procedimiento almacenado
                    var command = new SqlCommand();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = procedureName;

                    // Agregar los parámetros al comando
                    if (parameters is not null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    // Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery();

                    // Confirmar la transacción si todas las operaciones se completaron correctamente
                    transaction.Commit();

                    return true;
                }

                catch (Exception ex)
                {
                    // Ocurrió un error, realizar un rollback de la transacción
                    transaction.Rollback();

                    // Registrar el error en la tabla Errores
                    string errorDescription = ex.Message;
                    string insertErrorQuery = "INSERT INTO Errores (descripcion) VALUES (@Descripcion);";

                    using (var insertErrorCommand = new SqlCommand(insertErrorQuery, connection))
                    {
                        insertErrorCommand.Parameters.AddWithValue("@Descripcion", errorDescription);
                        insertErrorCommand.ExecuteNonQuery();
                    }

                    return false;
                }
            }

            catch (Exception ex)
            {
                // Ocurrió un error al conectar con la base de datos
                Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}