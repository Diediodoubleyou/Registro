using Proyecto_Huellero.Supervisor;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Huellero
{
    public partial class Login : Form
    {
        private Conexion conexion; // Objeto para manejar la conexión a la base de datos
        private string? rutUsuario; // Variable para almacenar el RUT del usuario

        public Login()
        {
            InitializeComponent();
            conexion = new Conexion(); // Inicializa el objeto de conexión
            MostrarEstadoConexion(); // Muestra el estado de la conexión a la base de datos
        }

        private void MostrarEstadoConexion()
        {
            bool conexionExitosa = conexion.TestConnection(); // Verifica si la conexión a la base de datos es exitosa
            string mensaje = conexionExitosa ? "Conexión exitosa a la base de datos." : "Error al conectar a la base de datos.";
            MessageBox.Show(mensaje); // Muestra un mensaje con el estado de la conexión
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            rutUsuario = txt_user.Text; // Obtiene el RUT del usuario ingresado en el campo de texto
            string contraseña = txt_password.Text; // Obtiene la contraseña ingresada en el campo de texto
            string rango = string.Empty; // Variable para almacenar el rango del usuario

            bool credencialesValidas = conexion.VerificarCredenciales(rutUsuario, contraseña, out rango); // Verifica las credenciales del usuario

            if (credencialesValidas)
            {
                // Abrir la clase según el rango
                AbrirClaseSegunRango(rango); // Abre la clase correspondiente al rango del usuario
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Inténtalo de nuevo."); // Muestra un mensaje de error si las credenciales son inválidas
            }
        }

        private void AbrirClaseSegunRango(string rango)
        {
            string rangoSinEspacios = rango.Trim(); // Elimina los espacios en blanco al inicio y al final del rango

            if (string.Equals(rangoSinEspacios, "administrador", StringComparison.OrdinalIgnoreCase))
            {
                Perfil_Admin perfilAdmin = new Perfil_Admin(); // Crea una instancia de la clase Perfil_Admin
                perfilAdmin.Show(); // Muestra la ventana del perfil de administrador
                this.Hide(); // Oculta la ventana actual de inicio de sesión
            }
            else if (string.Equals(rangoSinEspacios, "supervisor", StringComparison.OrdinalIgnoreCase))
            {
                if (rutUsuario != null) // Comprobar si rutUsuario no es nulo antes de asignarlo
                {
                    Iniciar_Jornada iniciarJornada = new Iniciar_Jornada(); // Crea una instancia de la clase Iniciar_Jornada
                    iniciarJornada.RutUsuario = rutUsuario; // Asigna el RUT del usuario a la propiedad RutUsuario de la instancia
                    iniciarJornada.Show(); // Muestra la ventana de inicio de jornada
                    this.Hide(); // Oculta la ventana actual de inicio de sesión
                }
                else
                {
                    MessageBox.Show("RUT de usuario no válido."); // Muestra un mensaje de error si el RUT del usuario es nulo
                }
            }
            else
            {
                MessageBox.Show("Rango de usuario no válido."); // Muestra un mensaje de error si el rango del usuario no es válido
            }
        }
    }
}
