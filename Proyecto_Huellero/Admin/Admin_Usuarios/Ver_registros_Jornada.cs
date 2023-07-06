using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Huellero.Admin.Admin_Usuarios
{
    public partial class Ver_registros_Jornada : Form
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Data Source=DESKTOP-6LO38TR\\SQLEXPRESS;Initial Catalog=Proyecto_Huellero;Integrated Security=True; TrustServerCertificate=true;";

        private DataTable dataTable;

        public Ver_registros_Jornada()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            DateTime fecha = date_fecha.Value.Date;

            // Realizar la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crear el comando SQL utilizando el procedimiento almacenado
                    SqlCommand command = new SqlCommand("ObtenerRegistrosPorFecha", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@Fecha", fecha);

                    // Crear el adaptador de datos y llenar el DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asignar el resultado al DataGridView
                    dgv_tabla_jornadas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
                }
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Perfil_Admin perfiladmin = new Perfil_Admin();
            perfiladmin.Show();
            this.Hide();
        }

    }
}
