using Proyecto_Huellero.Admin.Admin_Usuarios; // Importa el espacio de nombres para las clases relacionadas con la administración de usuarios
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Huellero
{
    public partial class Perfil_Admin : Form
    {
        public Perfil_Admin()
        {
            InitializeComponent();
        }

        private void btn_registrar_trabajador_Click(object sender, EventArgs e)
        {
            Registrar_Usuario registrarusuario = new Registrar_Usuario(); // Crea una instancia de la clase Registrar_Usuario
            registrarusuario.Show(); // Muestra la ventana de registro de usuario
            this.Hide(); // Oculta la ventana actual de perfil de administrador
        }

        private void btn_editar_trabajador_Click(object sender, EventArgs e)
        {
            Editar_Usuario editarusuario = new Editar_Usuario(); // Crea una instancia de la clase Editar_Usuario
            editarusuario.Show(); // Muestra la ventana de edición de usuario
            this.Hide(); // Oculta la ventana actual de perfil de administrador
        }

        private void btn_eliminar_trabajador_Click(object sender, EventArgs e)
        {
            Eliminar_Usuario eliminarusuario = new Eliminar_Usuario(); // Crea una instancia de la clase Eliminar_Usuario
            eliminarusuario.Show(); // Muestra la ventana de eliminación de usuario
            this.Hide(); // Oculta la ventana actual de perfil de administrador
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Login login = new Login(); // Crea una instancia de la clase Login
            login.Show(); // Muestra la ventana de inicio de sesión
            this.Hide(); // Oculta la ventana actual de perfil de administrador
        }

        private void btn_jornadas_Click(object sender, EventArgs e)
        {
            Ver_registros_Jornada verjornada = new Ver_registros_Jornada(); // Crea una instancia de la clase Ver_registros_Jornada
            verjornada.Show(); // Muestra la ventana de ver registros de jornada
            this.Hide(); // Oculta la ventana actual de perfil de administrador
        }
    }
}
