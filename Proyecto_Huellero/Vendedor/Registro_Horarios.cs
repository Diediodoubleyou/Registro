using Proyecto_Huellero.Supervisor; // Importa el espacio de nombres para las clases relacionadas con los supervisores
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Huellero.Vendedor
{
    public partial class Registro_Horarios : Form
    {
        private string connectionString = "Data Source=DESKTOP-6LO38TR\\SQLEXPRESS;Initial Catalog=Proyecto_Huellero;Integrated Security=True; Integrated Security=True; TrustServerCertificate=true;";
        private string nombreUsuario = "";

        public Registro_Horarios()
        {
            InitializeComponent();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            nombreUsuario = txt_rut.Text; // Obtiene el valor del campo de texto del RUT
            string contraseña = txt_contraseña.Text; // Obtiene el valor del campo de texto de la contraseña

            Conexion conexion = new Conexion(); // Crea una instancia de la clase Conexion

            if (conexion.TestConnection()) // Verifica la conexión a la base de datos
            {
                string rangoUsuario;
                bool credencialesValidas = conexion.VerificarCredenciales(nombreUsuario, contraseña, out rangoUsuario); // Verifica las credenciales del usuario

                if (credencialesValidas && rangoUsuario == "Vendedor") // Si las credenciales son válidas y el usuario es un vendedor
                {
                    MessageBox.Show("Usuario Reconocido", "Éxito"); // Muestra un mensaje de éxito

                    int idJornada = ObtenerIdJornadaActual(); // Obtiene el ID de la jornada actual

                    if (idJornada != -1) // Si se obtiene un ID válido
                    {
                        bool ingresoRegistrado = VerificarIngresoRegistrado(idJornada, nombreUsuario); // Verifica si el usuario ya ha registrado su ingreso en esta jornada

                        if (ingresoRegistrado) // Si el ingreso ya ha sido registrado
                        {
                            MessageBox.Show("El usuario ya ha ingresado en esta jornada.", "Aviso"); // Muestra un mensaje de aviso
                        }
                        else // Si el ingreso no ha sido registrado
                        {
                            GuardarRegistroIngreso(idJornada, nombreUsuario); // Guarda el registro de ingreso del usuario
                        }
                    }
                    else // Si no se pudo obtener el ID de la jornada actual
                    {
                        MessageBox.Show("No se pudo obtener el ID de la jornada actual."); // Muestra un mensaje de error
                    }
                }
                else // Si las credenciales no son válidas o el usuario no es un vendedor
                {
                    MessageBox.Show("Credenciales inválidas o el usuario no es un vendedor", "Error"); // Muestra un mensaje de error
                }
            }
            else // Si hay un error de conexión a la base de datos
            {
                MessageBox.Show("Error de conexión a la base de datos", "Error"); // Muestra un mensaje de error
            }
        }

        private int ObtenerIdJornadaActual()
        {
            int idJornada = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre la conexión a la base de datos

                    string query = "SELECT MAX(id_jornada) FROM iniciar_jornada"; // Consulta SQL para obtener el ID de la jornada actual
                    SqlCommand command = new SqlCommand(query, connection);
                    idJornada = Convert.ToInt32(command.ExecuteScalar()); // Ejecuta la consulta y obtiene el resultado como entero
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID de la jornada actual: " + ex.Message); // Muestra un mensaje de error
                }
                finally
                {
                    connection.Close(); // Cierra la conexión a la base de datos
                }
            }

            return idJornada; // Retorna el ID de la jornada actual
        }

        private bool VerificarIngresoRegistrado(int idJornada, string rut)
        {
            bool ingresoRegistrado = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre la conexión a la base de datos

                    string query = "SELECT COUNT(*) FROM registro_ingreso WHERE id_jornada = @IdJornada AND rut = @Rut"; // Consulta SQL para verificar si el ingreso ya ha sido registrado
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdJornada", idJornada);
                    command.Parameters.AddWithValue("@Rut", rut);

                    int count = Convert.ToInt32(command.ExecuteScalar()); // Ejecuta la consulta y obtiene el resultado como entero

                    if (count > 0) // Si se encuentra al menos un registro
                    {
                        ingresoRegistrado = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el ingreso registrado: " + ex.Message); // Muestra un mensaje de error
                }
                finally
                {
                    connection.Close(); // Cierra la conexión a la base de datos
                }
            }

            return ingresoRegistrado; // Retorna si el ingreso ya ha sido registrado o no
        }

        private void GuardarRegistroIngreso(int idJornada, string rut)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre la conexión a la base de datos

                    SqlCommand command = new SqlCommand("GuardarRegistroIngreso", connection); // Crea un comando para ejecutar el procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdJornada", idJornada);
                    command.Parameters.AddWithValue("@Rut", rut);

                    command.ExecuteNonQuery(); // Ejecuta el comando para guardar el registro de ingreso
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el registro de ingreso: " + ex.Message); // Muestra un mensaje de error
                }
                finally
                {
                    connection.Close(); // Cierra la conexión a la base de datos
                }
            }
        }

        private void btn_cerrar_jornada_Click(object sender, EventArgs e)
        {
            Iniciar_Jornada iniciarjornada = new Iniciar_Jornada(); // Crea una instancia de la clase Iniciar_Jornada
            iniciarjornada.Show(); // Muestra la ventana de inicio de jornada
            this.Hide(); // Oculta la ventana actual
        }
    }
}
