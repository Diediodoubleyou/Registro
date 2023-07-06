using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Huellero
{
    internal class Conexion
    {
        private const string connectionString = "Data Source=DESKTOP-6LO38TR\\SQLEXPRESS;Initial Catalog=Proyecto_Huellero;Integrated Security=True; Integrated Security=True; TrustServerCertificate=true;";

        // Prueba la conexión a la base de datos
        public bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Abre la conexión a la base de datos
                    return true; // La conexión fue exitosa
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message); // Muestra un mensaje de error en la consola
                return false; // La conexión falló
            }
        }

        // Verifica las credenciales del usuario en la base de datos
        public bool VerificarCredenciales(string rutUsuario, string contraseña, out string rango)
        {
            bool credencialesValidas = false; // Variable para almacenar si las credenciales son válidas
            rango = string.Empty; // Variable para almacenar el rango del usuario

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("VerificarCredenciales", connection); // Crea un comando para ejecutar un procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure; // Indica que el comando es un procedimiento almacenado

                    command.Parameters.AddWithValue("@RutUsuario", rutUsuario); // Agrega un parámetro para el RUT del usuario
                    command.Parameters.AddWithValue("@Contraseña", contraseña); // Agrega un parámetro para la contraseña del usuario

                    SqlParameter outputParameter = new SqlParameter("@Rango", SqlDbType.VarChar, 50); // Crea un parámetro de salida para obtener el rango del usuario
                    outputParameter.Direction = ParameterDirection.Output; // Indica que es un parámetro de salida
                    command.Parameters.Add(outputParameter); // Agrega el parámetro de salida al comando

                    connection.Open(); // Abre la conexión a la base de datos
                    object result = command.ExecuteScalar(); // Ejecuta el comando y obtiene el resultado

                    if (result != null && int.TryParse(result.ToString(), out int resultado) && resultado == 1)
                    {
                        credencialesValidas = true; // Las credenciales son válidas
                        rango = command.Parameters["@Rango"].Value.ToString(); // Obtiene el valor del parámetro de salida (rango del usuario)
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar las credenciales: " + ex.Message); // Muestra un mensaje de error en la consola
            }

            return credencialesValidas; // Retorna si las credenciales son válidas o no
        }
    }
}
