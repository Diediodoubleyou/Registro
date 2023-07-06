using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Huellero.Admin.Admin_Usuarios
{
    public partial class Editar_Usuario : Form
    {
        public Editar_Usuario()
        {
            InitializeComponent();

            // Establece la longitud máxima de los campos de texto
            txt_buscar_dni.MaxLength = 8;
            box_buscar_d_verf.MaxLength = 1;
            txt_dni.MaxLength = 9;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            // Navega de vuelta a la pantalla de Perfil_Admin
            Perfil_Admin perfiladmin = new Perfil_Admin();
            perfiladmin.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores ingresados en los campos de texto y ComboBoxes
            string dni = txt_buscar_dni.Text.Trim();
            string verificador = box_buscar_d_verf.Text.Trim();
            string rut = dni + verificador;

            string nombre = txt_name.Text.Trim();
            string apellido = txt_lastname.Text.Trim();
            string contrasena = txt_password.Text.Trim();
            string horaInicio = box_hora_inicio.Text.Trim();
            string horaFin = box_hora_fin.Text.Trim();
            string rango = box_rango.Text.Trim();

            // Crea una instancia de la clase editarusuario para actualizar el usuario
            editarusuario editarUsuario = new editarusuario();

            // Llama al método ActualizarUsuario para actualizar los datos del usuario en la base de datos
            bool resultado = editarUsuario.ActualizarUsuario(rut, nombre, apellido, contrasena, horaInicio, horaFin, rango);

            if (resultado)
            {
                MessageBox.Show("El usuario se ha actualizado correctamente en la base de datos.");
            }
            else
            {
                MessageBox.Show("Error al actualizar el usuario en la base de datos.");
            }
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            // Obtiene los valores ingresados en los campos de texto de búsqueda
            string dni = txt_buscar_dni.Text.Trim();
            string verificador = box_buscar_d_verf.Text.Trim();
            string rut = dni + verificador;

            // Crea una instancia de la clase editarusuario para buscar el usuario
            editarusuario editarUsuario = new editarusuario();

            // Llama al método BuscarUsuario para obtener los datos del usuario desde la base de datos
            editarUsuario.BuscarUsuario(rut, txt_name, txt_lastname, txt_dni, txt_password,
                box_hora_inicio, box_hora_fin, box_rango);
        }
    }
}
