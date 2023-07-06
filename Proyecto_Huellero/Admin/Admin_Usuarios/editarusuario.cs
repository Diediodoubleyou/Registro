using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Huellero.Admin.Admin_Usuarios
{
    internal class editarusuario
    {
        private const string connectionString = "Data Source=DESKTOP-6LO38TR\\SQLEXPRESS;Initial Catalog=Proyecto_Huellero;Integrated Security=True; Integrated Security=True; TrustServerCertificate=true;";

        public void BuscarUsuario(string rut, TextBox txtNombre, TextBox txtApellido, TextBox txtRut, TextBox txt_password, ComboBox box_hora_inicio, ComboBox box_hora_fin, ComboBox box_rango)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("BuscarUsuarioPorRut", connection); // Crea un comando para ejecutar el procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Rut", rut);

                    connection.Open(); // Abre la conexión a la base de datos
                    SqlDataReader reader = command.ExecuteReader(); // Ejecuta el comando y obtiene un lector de datos

                    if (reader.Read()) // Si se encuentra un registro
                    {
                        txtNombre.Text = reader["nombre"].ToString(); // Asigna el valor del campo "nombre" al TextBox correspondiente
                        txtApellido.Text = reader["apellido"].ToString(); // Asigna el valor del campo "apellido" al TextBox correspondiente
                        txtRut.Text = reader["rut"].ToString(); // Asigna el valor del campo "rut" al TextBox correspondiente
                        txt_password.Text = reader["contrasena"].ToString(); // Asigna el valor del campo "contrasena" al TextBox correspondiente
                        box_hora_inicio.Text = reader["hora_inicio"].ToString(); // Asigna el valor del campo "hora_inicio" al ComboBox correspondiente
                        box_hora_fin.Text = reader["hora_fin"].ToString(); // Asigna el valor del campo "hora_fin" al ComboBox correspondiente
                        box_rango.Text = reader["rango"].ToString(); // Asigna el valor del campo "rango" al ComboBox correspondiente
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario con el Rut especificado."); // Muestra un mensaje de error
                    }

                    reader.Close(); // Cierra el lector de datos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex.Message); // Muestra un mensaje de error
            }
        }

        public bool ActualizarUsuario(string rut, string nombre, string apellido, string contrasena, string horaInicio, string horaFin, string rango)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("ActualizarUsuario", connection); // Crea un comando para ejecutar el procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Rut", rut);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);
                    command.Parameters.AddWithValue("@HoraInicio", DateTime.Parse(horaInicio));
                    command.Parameters.AddWithValue("@HoraFin", DateTime.Parse(horaFin));
                    command.Parameters.AddWithValue("@Rango", rango);

                    connection.Open(); // Abre la conexión a la base de datos
                    int rowsAffected = command.ExecuteNonQuery(); // Ejecuta el comando y obtiene el número de filas afectadas

                    return rowsAffected > 0; // Retorna si se actualizaron filas o no
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message); // Muestra un mensaje de error
                return false;
            }
        }
    }
}
