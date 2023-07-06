using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Huellero
{
    public class RegistroUsuarios
    {
        private const string connectionString = "Data Source=DESKTOP-6LO38TR\\SQLEXPRESS;Initial Catalog=Proyecto_Huellero;Integrated Security=True; Integrated Security=True; TrustServerCertificate=true;";

        public bool RegistrarUsuario(string nombre, string apellido, string rut, string contraseña, DateTime horaInicio, DateTime horaFin, string rango)
        {
            try
            {
                // Verifica si el RUT ingresado es válido
                if (!EsRutValido(rut))
                {
                    Console.WriteLine("El RUT ingresado no es válido.");
                    return false;
                }

                // Verifica si el usuario ya está registrado
                if (ExisteUsuario(rut))
                {
                    Console.WriteLine("El usuario ya está registrado.");
                    return false;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("RegistrarUsuario", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Asigna los parámetros de entrada del procedimiento almacenado
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Rut", rut);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    command.Parameters.AddWithValue("@HoraInicio", horaInicio);
                    command.Parameters.AddWithValue("@HoraFin", horaFin);
                    command.Parameters.AddWithValue("@Rango", rango);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el usuario: " + ex.Message);
                return false;
            }
        }

        private bool ExisteUsuario(string rut)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM registrar_usuarios WHERE rut = @Rut", connection);
                    command.Parameters.AddWithValue("@Rut", rut);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar si el usuario existe: " + ex.Message);
                return false;
            }
        }

        private bool EsRutValido(string rut)
        {
            if (string.IsNullOrEmpty(rut))
            {
                return false;
            }

            rut = rut.ToUpper().Replace(".", "").Replace("-", "");

            int rutNumerico;
            if (!int.TryParse(rut.Substring(0, rut.Length - 1), out rutNumerico))
            {
                return false;
            }

            char dv = rut[rut.Length - 1];
            int m = 0, s = 1;
            for (; rutNumerico != 0; rutNumerico /= 10)
            {
                s = (s + rutNumerico % 10 * (9 - m++ % 6)) % 11;
            }

            return dv == (char)(s != 0 ? s + 47 : 75);
        }
    }
}
