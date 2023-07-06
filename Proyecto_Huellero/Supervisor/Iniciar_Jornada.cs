using Proyecto_Huellero.Vendedor; // Importa el espacio de nombres para las clases relacionadas con los vendedores
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Huellero.Supervisor
{
    public partial class Iniciar_Jornada : Form
    {
        private string? rutUsuario;

        public Iniciar_Jornada()
        {
            InitializeComponent();
            txt_dia.Text = DateTime.Now.ToString("dd-MM-yyyy"); // Establece la fecha actual en el campo de texto del día
            txt_hora_inicio.Text = DateTime.Now.ToString("HH:mm"); // Establece la hora actual en el campo de texto de la hora de inicio
        }

        public string? RutUsuario
        {
            get { return rutUsuario; }
            set
            {
                rutUsuario = value;
                txt_supervisor.Text = rutUsuario; // Asigna el valor del RUT del usuario al campo de texto del supervisor
            }
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Login login = new Login(); // Crea una instancia de la clase Login
            login.Show(); // Muestra la ventana de inicio de sesión
            this.Hide(); // Oculta la ventana actual de inicio de jornada
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            string supervisor = txt_supervisor.Text; // Obtiene el valor del campo de texto del supervisor
            DateTime dia = DateTime.Parse(txt_dia.Text); // Convierte el valor del campo de texto del día a un objeto DateTime
            DateTime hora = DateTime.Parse(txt_hora_inicio.Text); // Convierte el valor del campo de texto de la hora de inicio a un objeto DateTime

            string connectionString = "Data Source=DESKTOP-6LO38TR\\SQLEXPRESS;Initial Catalog=Proyecto_Huellero;Integrated Security=True; Integrated Security=True; TrustServerCertificate=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre la conexión a la base de datos

                    SqlCommand command = new SqlCommand("InsertarJornada", connection); // Crea un comando para ejecutar un procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure; // Indica que el comando es un procedimiento almacenado

                    command.Parameters.AddWithValue("@Supervisor", supervisor); // Agrega un parámetro para el supervisor
                    command.Parameters.AddWithValue("@Dia", dia); // Agrega un parámetro para el día
                    command.Parameters.AddWithValue("@Hora", hora); // Agrega un parámetro para la hora de inicio

                    command.ExecuteNonQuery(); // Ejecuta el comando

                    MessageBox.Show("Jornada Iniciada."); // Muestra un mensaje de éxito

                    Registro_Horarios registroHorarios = new Registro_Horarios(); // Crea una instancia de la clase Registro_Horarios
                    registroHorarios.Show(); // Muestra la ventana de registro de horarios
                    this.Hide(); // Oculta la ventana actual de inicio de jornada
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message); // Muestra un mensaje de error
                }
                finally
                {
                    connection.Close(); // Cierra la conexión a la base de datos
                }
            }
        }
    }
}
