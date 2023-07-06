using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Huellero
{
    internal class UsuarioManager
    {
        private const string connectionString = "Data Source=DESKTOP-6LO38TR\\SQLEXPRESS;Initial Catalog=Proyecto_Huellero;Integrated Security=True; Integrated Security=True; TrustServerCertificate=true;";

        public void BuscarUsuario(string rut, TextBox txtNombre, TextBox txtApellido, TextBox txtRut)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Crea un nuevo comando de SQL para buscar un usuario por su Rut
                    SqlCommand command = new SqlCommand("BuscarUsuarioPorRut", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Agrega el parámetro del Rut al comando
                    command.Parameters.AddWithValue("@Rut", rut);

                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Ejecuta el comando y obtiene un lector de datos para leer los resultados
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Si se encontró un usuario, asigna los valores a los campos de texto correspondientes
                        txtNombre.Text = reader["nombre"].ToString();
                        txtApellido.Text = reader["apellido"].ToString();
                        txtRut.Text = reader["rut"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario con el Rut especificado.");
                    }

                    // Cierra el lector de datos
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex.Message);
            }
        }

        public void EliminarUsuario(string rut)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Crea un nuevo comando de SQL para eliminar un usuario por su Rut
                    SqlCommand command = new SqlCommand("EliminarUsuarioPorRut", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Agrega el parámetro del Rut al comando
                    command.Parameters.AddWithValue("@Rut", rut);

                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Ejecuta el comando de eliminación
                    int rowsAffected = command.ExecuteNonQuery();

                    // Muestra un mensaje según los resultados de la eliminación
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario con el Rut especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }
    }
}
