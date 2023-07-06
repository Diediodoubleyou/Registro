namespace Proyecto_Huellero.Admin.Admin_Usuarios
{
    partial class Editar_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_eliminar_usuario = new Label();
            btn_buscar = new Button();
            box_buscar_d_verf = new ComboBox();
            lbl_guion = new Label();
            txt_buscar_dni = new TextBox();
            lbl_rut = new Label();
            box_hora_fin = new ComboBox();
            box_hora_inicio = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btn_volver = new Button();
            btn_guardar = new Button();
            txt_password = new TextBox();
            txt_dni = new TextBox();
            txt_lastname = new TextBox();
            txt_name = new TextBox();
            lbl_password = new Label();
            label4 = new Label();
            lbl_apellido = new Label();
            lbl_nombre = new Label();
            lbl_rango = new Label();
            box_rango = new ComboBox();
            SuspendLayout();
            // 
            // lbl_eliminar_usuario
            // 
            lbl_eliminar_usuario.AutoSize = true;
            lbl_eliminar_usuario.BackColor = Color.Transparent;
            lbl_eliminar_usuario.Location = new Point(34, 32);
            lbl_eliminar_usuario.Name = "lbl_eliminar_usuario";
            lbl_eliminar_usuario.Size = new Size(80, 15);
            lbl_eliminar_usuario.TabIndex = 39;
            lbl_eliminar_usuario.Text = "Editar Usuario";
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 64, 64);
            btn_buscar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Location = new Point(577, 25);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(92, 26);
            btn_buscar.TabIndex = 38;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click_1;
            // 
            // box_buscar_d_verf
            // 
            box_buscar_d_verf.FormattingEnabled = true;
            box_buscar_d_verf.Items.AddRange(new object[] { "K", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            box_buscar_d_verf.Location = new Point(526, 29);
            box_buscar_d_verf.Margin = new Padding(3, 2, 3, 2);
            box_buscar_d_verf.Name = "box_buscar_d_verf";
            box_buscar_d_verf.Size = new Size(32, 23);
            box_buscar_d_verf.TabIndex = 37;
            // 
            // lbl_guion
            // 
            lbl_guion.AutoSize = true;
            lbl_guion.BackColor = Color.Transparent;
            lbl_guion.Location = new Point(507, 33);
            lbl_guion.Name = "lbl_guion";
            lbl_guion.Size = new Size(12, 15);
            lbl_guion.TabIndex = 36;
            lbl_guion.Text = "-";
            // 
            // txt_buscar_dni
            // 
            txt_buscar_dni.Location = new Point(386, 28);
            txt_buscar_dni.Margin = new Padding(3, 2, 3, 2);
            txt_buscar_dni.Name = "txt_buscar_dni";
            txt_buscar_dni.Size = new Size(117, 23);
            txt_buscar_dni.TabIndex = 35;
            // 
            // lbl_rut
            // 
            lbl_rut.AutoSize = true;
            lbl_rut.BackColor = Color.Transparent;
            lbl_rut.Location = new Point(293, 33);
            lbl_rut.Name = "lbl_rut";
            lbl_rut.Size = new Size(87, 15);
            lbl_rut.TabIndex = 34;
            lbl_rut.Text = "Buscar por RUT";
            // 
            // box_hora_fin
            // 
            box_hora_fin.FormattingEnabled = true;
            box_hora_fin.Items.AddRange(new object[] { "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" });
            box_hora_fin.Location = new Point(147, 270);
            box_hora_fin.Margin = new Padding(3, 2, 3, 2);
            box_hora_fin.Name = "box_hora_fin";
            box_hora_fin.Size = new Size(117, 23);
            box_hora_fin.TabIndex = 54;
            // 
            // box_hora_inicio
            // 
            box_hora_inicio.FormattingEnabled = true;
            box_hora_inicio.Items.AddRange(new object[] { "06:00", "07:00", "08:00", "09:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00" });
            box_hora_inicio.Location = new Point(147, 234);
            box_hora_inicio.Margin = new Padding(3, 2, 3, 2);
            box_hora_inicio.Name = "box_hora_inicio";
            box_hora_inicio.Size = new Size(117, 23);
            box_hora_inicio.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(74, 276);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 52;
            label3.Text = "Hora Fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(59, 240);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 51;
            label2.Text = "Hora Inicio";
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.FromArgb(192, 64, 0);
            btn_volver.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_volver.ForeColor = Color.White;
            btn_volver.Location = new Point(431, 344);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(112, 26);
            btn_volver.TabIndex = 50;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(0, 64, 64);
            btn_guardar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Location = new Point(557, 344);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(112, 26);
            btn_guardar.TabIndex = 49;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(147, 201);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(172, 23);
            txt_password.TabIndex = 47;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(147, 175);
            txt_dni.Margin = new Padding(3, 2, 3, 2);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(172, 23);
            txt_dni.TabIndex = 46;
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(147, 147);
            txt_lastname.Margin = new Padding(3, 2, 3, 2);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(213, 23);
            txt_lastname.TabIndex = 45;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(147, 118);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(213, 23);
            txt_name.TabIndex = 44;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.BackColor = Color.Transparent;
            lbl_password.Location = new Point(63, 206);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(63, 15);
            lbl_password.TabIndex = 43;
            lbl_password.Text = "Contaseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(104, 180);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 42;
            label4.Text = "Rut";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.BackColor = Color.Transparent;
            lbl_apellido.Location = new Point(74, 152);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 41;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = Color.Transparent;
            lbl_nombre.Location = new Point(75, 123);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 40;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_rango
            // 
            lbl_rango.AutoSize = true;
            lbl_rango.BackColor = Color.Transparent;
            lbl_rango.Location = new Point(90, 311);
            lbl_rango.Name = "lbl_rango";
            lbl_rango.Size = new Size(39, 15);
            lbl_rango.TabIndex = 55;
            lbl_rango.Text = "Cargo";
            lbl_rango.UseMnemonic = false;
            // 
            // box_rango
            // 
            box_rango.FormattingEnabled = true;
            box_rango.Items.AddRange(new object[] { "Administrador", "Supervisor", "Vendedor" });
            box_rango.Location = new Point(147, 303);
            box_rango.Name = "box_rango";
            box_rango.Size = new Size(121, 23);
            box_rango.TabIndex = 57;
            // 
            // Editar_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo3;
            ClientSize = new Size(695, 417);
            Controls.Add(box_rango);
            Controls.Add(lbl_rango);
            Controls.Add(box_hora_fin);
            Controls.Add(box_hora_inicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_volver);
            Controls.Add(btn_guardar);
            Controls.Add(txt_password);
            Controls.Add(txt_dni);
            Controls.Add(txt_lastname);
            Controls.Add(txt_name);
            Controls.Add(lbl_password);
            Controls.Add(label4);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_eliminar_usuario);
            Controls.Add(btn_buscar);
            Controls.Add(box_buscar_d_verf);
            Controls.Add(lbl_guion);
            Controls.Add(txt_buscar_dni);
            Controls.Add(lbl_rut);
            Name = "Editar_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar_Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_eliminar_usuario;
        private Button btn_buscar;
        private ComboBox box_buscar_d_verf;
        private Label lbl_guion;
        private TextBox txt_buscar_dni;
        private Label lbl_rut;
        private ComboBox box_hora_fin;
        private ComboBox box_hora_inicio;
        private Label label3;
        private Label label2;
        private Button btn_volver;
        private Button btn_guardar;
        private TextBox txt_password;
        private TextBox txt_dni;
        private TextBox txt_lastname;
        private TextBox txt_name;
        private Label lbl_password;
        private Label label4;
        private Label lbl_apellido;
        private Label lbl_nombre;
        private Label lbl_rango;
        private ComboBox box_rango;
    }
}