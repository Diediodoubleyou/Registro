namespace Proyecto_Huellero
{
    partial class Eliminar_Usuario
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
            btn_eliminar = new Button();
            btn_volver = new Button();
            btn_buscar = new Button();
            box_buscar_d_verf = new ComboBox();
            lbl_guion = new Label();
            txt_buscar_dni = new TextBox();
            lbl_rut = new Label();
            lbl_eliminar_usuario = new Label();
            txt_lastname = new TextBox();
            txt_name = new TextBox();
            label4 = new Label();
            lbl_apellido = new Label();
            lbl_nombre = new Label();
            txt_dni = new TextBox();
            SuspendLayout();
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(0, 64, 64);
            btn_eliminar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(473, 268);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(112, 26);
            btn_eliminar.TabIndex = 26;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click_1;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.FromArgb(192, 64, 0);
            btn_volver.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_volver.ForeColor = Color.White;
            btn_volver.Location = new Point(346, 268);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(112, 26);
            btn_volver.TabIndex = 27;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 64, 64);
            btn_buscar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Location = new Point(494, 22);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(92, 26);
            btn_buscar.TabIndex = 32;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // box_buscar_d_verf
            // 
            box_buscar_d_verf.FormattingEnabled = true;
            box_buscar_d_verf.Items.AddRange(new object[] { "K", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            box_buscar_d_verf.Location = new Point(443, 26);
            box_buscar_d_verf.Margin = new Padding(3, 2, 3, 2);
            box_buscar_d_verf.Name = "box_buscar_d_verf";
            box_buscar_d_verf.Size = new Size(32, 23);
            box_buscar_d_verf.TabIndex = 31;
            // 
            // lbl_guion
            // 
            lbl_guion.AutoSize = true;
            lbl_guion.BackColor = Color.Transparent;
            lbl_guion.Location = new Point(424, 30);
            lbl_guion.Name = "lbl_guion";
            lbl_guion.Size = new Size(12, 15);
            lbl_guion.TabIndex = 30;
            lbl_guion.Text = "-";
            // 
            // txt_buscar_dni
            // 
            txt_buscar_dni.Location = new Point(303, 25);
            txt_buscar_dni.Margin = new Padding(3, 2, 3, 2);
            txt_buscar_dni.Name = "txt_buscar_dni";
            txt_buscar_dni.Size = new Size(117, 23);
            txt_buscar_dni.TabIndex = 29;
            // 
            // lbl_rut
            // 
            lbl_rut.AutoSize = true;
            lbl_rut.BackColor = Color.Transparent;
            lbl_rut.Location = new Point(196, 27);
            lbl_rut.Name = "lbl_rut";
            lbl_rut.Size = new Size(87, 15);
            lbl_rut.TabIndex = 28;
            lbl_rut.Text = "Buscar por RUT";
            // 
            // lbl_eliminar_usuario
            // 
            lbl_eliminar_usuario.AutoSize = true;
            lbl_eliminar_usuario.BackColor = Color.Transparent;
            lbl_eliminar_usuario.Location = new Point(41, 30);
            lbl_eliminar_usuario.Name = "lbl_eliminar_usuario";
            lbl_eliminar_usuario.Size = new Size(93, 15);
            lbl_eliminar_usuario.TabIndex = 33;
            lbl_eliminar_usuario.Text = "Eliminar Usuario";
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(116, 130);
            txt_lastname.Margin = new Padding(3, 2, 3, 2);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(213, 23);
            txt_lastname.TabIndex = 44;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(116, 101);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(213, 23);
            txt_name.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(74, 168);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 42;
            label4.Text = "Rut";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.BackColor = Color.Transparent;
            lbl_apellido.Location = new Point(41, 135);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 41;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = Color.Transparent;
            lbl_nombre.Location = new Point(46, 106);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 40;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(116, 163);
            txt_dni.Margin = new Padding(3, 2, 3, 2);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(213, 23);
            txt_dni.TabIndex = 45;
            // 
            // Eliminar_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo3;
            ClientSize = new Size(704, 426);
            Controls.Add(txt_dni);
            Controls.Add(txt_lastname);
            Controls.Add(txt_name);
            Controls.Add(label4);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_eliminar_usuario);
            Controls.Add(btn_buscar);
            Controls.Add(box_buscar_d_verf);
            Controls.Add(lbl_guion);
            Controls.Add(txt_buscar_dni);
            Controls.Add(lbl_rut);
            Controls.Add(btn_volver);
            Controls.Add(btn_eliminar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Eliminar_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar_Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_eliminar;
        private Button btn_volver;
        private Button btn_buscar;
        private ComboBox box_buscar_d_verf;
        private Label lbl_guion;
        private TextBox txt_buscar_dni;
        private Label lbl_rut;
        private Label lbl_eliminar_usuario;
        private TextBox txt_lastname;
        private TextBox txt_name;
        private Label label4;
        private Label lbl_apellido;
        private Label lbl_nombre;
        private TextBox txt_dni;
    }
}