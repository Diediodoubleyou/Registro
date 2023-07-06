using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Huellero
{
    public partial class Eliminar_Usuario : Form
    {
        private UsuarioManager usuarioManager;

        public Eliminar_Usuario()
        {
            InitializeComponent();

            txt_buscar_dni.MaxLength = 8;
            box_buscar_d_verf.MaxLength = 1;

            usuarioManager = new UsuarioManager();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            // Navega de vuelta a la pantalla de Perfil_Admin
            Perfil_Admin perfiladmin = new Perfil_Admin();
            perfiladmin.Show();
            this.Hide();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores ingresados en los campos de texto de búsqueda
            string dni = txt_buscar_dni.Text.Trim();
            string verificador = box_buscar_d_verf.Text.Trim();
            string rut = dni + verificador;

            // Llama al método BuscarUsuario de usuarioManager para obtener los datos del usuario desde la base de datos
            usuarioManager.BuscarUsuario(rut, txt_name, txt_lastname, txt_dni);
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            // Obtiene el valor del rut del usuario a eliminar
            string rut = txt_dni.Text.Trim();

            // Muestra un cuadro de diálogo de confirmación para asegurar la eliminación del usuario
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Llama al método EliminarUsuario de usuarioManager para eliminar el usuario de la base de datos
                usuarioManager.EliminarUsuario(rut);

                // Limpia los campos de texto
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            // Limpia los campos de texto
            txt_name.Text = string.Empty;
            txt_lastname.Text = string.Empty;
            txt_dni.Text = string.Empty;
        }
    }
}
