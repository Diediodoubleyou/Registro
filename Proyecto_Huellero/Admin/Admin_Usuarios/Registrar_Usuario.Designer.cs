namespace Proyecto_Huellero
{
    partial class Registrar_Usuario
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
            label1 = new Label();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            lbl_rut = new Label();
            lbl_password = new Label();
            txt_name = new TextBox();
            txt_lastname = new TextBox();
            txt_dni = new TextBox();
            txt_password = new TextBox();
            lbl_guion = new Label();
            btn_registrar = new Button();
            btn_volver = new Button();
            label2 = new Label();
            label3 = new Label();
            box_hora_inicio = new ComboBox();
            box_hora_fin = new ComboBox();
            box_d_verf = new ComboBox();
            box_rango = new ComboBox();
            lbl_rango = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Registro Usuario";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = Color.Transparent;
            lbl_nombre.Location = new Point(38, 83);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.BackColor = Color.Transparent;
            lbl_apellido.Location = new Point(37, 112);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 3;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_rut
            // 
            lbl_rut.AutoSize = true;
            lbl_rut.BackColor = Color.Transparent;
            lbl_rut.Location = new Point(67, 140);
            lbl_rut.Name = "lbl_rut";
            lbl_rut.Size = new Size(25, 15);
            lbl_rut.TabIndex = 4;
            lbl_rut.Text = "Rut";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.BackColor = Color.Transparent;
            lbl_password.Location = new Point(26, 166);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(63, 15);
            lbl_password.TabIndex = 5;
            lbl_password.Text = "Contaseña";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(110, 78);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(213, 23);
            txt_name.TabIndex = 6;
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(110, 107);
            txt_lastname.Margin = new Padding(3, 2, 3, 2);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(213, 23);
            txt_lastname.TabIndex = 7;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(110, 135);
            txt_dni.Margin = new Padding(3, 2, 3, 2);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(117, 23);
            txt_dni.TabIndex = 8;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(110, 161);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(172, 23);
            txt_password.TabIndex = 9;
            // 
            // lbl_guion
            // 
            lbl_guion.AutoSize = true;
            lbl_guion.BackColor = Color.Transparent;
            lbl_guion.Location = new Point(232, 140);
            lbl_guion.Name = "lbl_guion";
            lbl_guion.Size = new Size(12, 15);
            lbl_guion.TabIndex = 11;
            lbl_guion.Text = "-";
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = Color.FromArgb(0, 64, 64);
            btn_registrar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_registrar.ForeColor = Color.White;
            btn_registrar.Location = new Point(560, 363);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(112, 26);
            btn_registrar.TabIndex = 12;
            btn_registrar.Text = "Registrar";
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.FromArgb(192, 64, 0);
            btn_volver.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_volver.ForeColor = Color.White;
            btn_volver.Location = new Point(434, 363);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(112, 26);
            btn_volver.TabIndex = 13;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(22, 200);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 14;
            label2.Text = "Hora Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(37, 236);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 15;
            label3.Text = "Hora Fin";
            // 
            // box_hora_inicio
            // 
            box_hora_inicio.FormattingEnabled = true;
            box_hora_inicio.Items.AddRange(new object[] { "06:00", "07:00", "08:00", "09:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00" });
            box_hora_inicio.Location = new Point(110, 194);
            box_hora_inicio.Margin = new Padding(3, 2, 3, 2);
            box_hora_inicio.Name = "box_hora_inicio";
            box_hora_inicio.Size = new Size(117, 23);
            box_hora_inicio.TabIndex = 16;
            // 
            // box_hora_fin
            // 
            box_hora_fin.FormattingEnabled = true;
            box_hora_fin.Items.AddRange(new object[] { "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" });
            box_hora_fin.Location = new Point(110, 230);
            box_hora_fin.Margin = new Padding(3, 2, 3, 2);
            box_hora_fin.Name = "box_hora_fin";
            box_hora_fin.Size = new Size(117, 23);
            box_hora_fin.TabIndex = 17;
            // 
            // box_d_verf
            // 
            box_d_verf.FormattingEnabled = true;
            box_d_verf.Items.AddRange(new object[] { "k", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            box_d_verf.Location = new Point(250, 136);
            box_d_verf.Margin = new Padding(3, 2, 3, 2);
            box_d_verf.Name = "box_d_verf";
            box_d_verf.Size = new Size(32, 23);
            box_d_verf.TabIndex = 18;
            // 
            // box_rango
            // 
            box_rango.FormattingEnabled = true;
            box_rango.Items.AddRange(new object[] { "Administrador", "Supervisor", "Vendedor" });
            box_rango.Location = new Point(110, 271);
            box_rango.Name = "box_rango";
            box_rango.Size = new Size(121, 23);
            box_rango.TabIndex = 59;
            // 
            // lbl_rango
            // 
            lbl_rango.AutoSize = true;
            lbl_rango.BackColor = Color.Transparent;
            lbl_rango.Location = new Point(53, 279);
            lbl_rango.Name = "lbl_rango";
            lbl_rango.Size = new Size(39, 15);
            lbl_rango.TabIndex = 58;
            lbl_rango.Text = "Cargo";
            lbl_rango.UseMnemonic = false;
            // 
            // Registrar_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo3;
            ClientSize = new Size(701, 421);
            Controls.Add(box_rango);
            Controls.Add(lbl_rango);
            Controls.Add(box_d_verf);
            Controls.Add(box_hora_fin);
            Controls.Add(box_hora_inicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_volver);
            Controls.Add(btn_registrar);
            Controls.Add(lbl_guion);
            Controls.Add(txt_password);
            Controls.Add(txt_dni);
            Controls.Add(txt_lastname);
            Controls.Add(txt_name);
            Controls.Add(lbl_password);
            Controls.Add(lbl_rut);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Registrar_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar_Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_rut;
        private Label lbl_password;
        private TextBox txt_name;
        private TextBox txt_lastname;
        private TextBox txt_dni;
        private TextBox txt_password;
        private Label lbl_guion;
        private Button btn_registrar;
        private Button btn_volver;
        private Label label2;
        private Label label3;
        private ComboBox box_hora_inicio;
        private ComboBox box_hora_fin;
        private ComboBox box_d_verf;
        private ComboBox box_rango;
        private Label lbl_rango;
    }
}