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
    public partial class Registrar_Usuario : Form
    {
        public Registrar_Usuario()
        {
            InitializeComponent();
            txt_dni.MaxLength = 8;
            box_d_verf.MaxLength = 1;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores ingresados en los campos del formulario
            string nombre = txt_name.Text;
            string apellido = txt_lastname.Text;
            string rut = txt_dni.Text + box_d_verf.Text;
            string contraseña = txt_password.Text;
            DateTime horaInicio = Convert.ToDateTime(box_hora_inicio.Text);
            DateTime horaFin = Convert.ToDateTime(box_hora_fin.Text);
            string rango = box_rango.Text;

            // Crea una instancia de la clase RegistroUsuarios para realizar el registro
            RegistroUsuarios registroUsuarios = new RegistroUsuarios();

            // Llama al método RegistrarUsuario para intentar registrar al usuario
            bool exito = registroUsuarios.RegistrarUsuario(nombre, apellido, rut, contraseña, horaInicio, horaFin, rango);

            // Muestra un mensaje según el resultado del registro
            if (exito)
            {
                MessageBox.Show("Usuario registrado correctamente.");
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario. Por favor, inténtelo nuevamente.");
            }
        }

        private void LimpiarFormulario()
        {
            // Limpia los campos del formulario
            txt_name.Text = "";
            txt_lastname.Text = "";
            txt_dni.Text = "";
            txt_password.Text = "";
            box_d_verf.Text = "";
            box_hora_inicio.Text = "";
            box_hora_fin.Text = "";
            box_rango.Text = "";
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            // Muestra el formulario Perfil_Admin y oculta el formulario actual
            Perfil_Admin perfiladmin = new Perfil_Admin();
            perfiladmin.Show();
            this.Hide();
        }
    }
}
