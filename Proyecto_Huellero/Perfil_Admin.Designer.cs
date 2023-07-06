namespace Proyecto_Huellero
{
    partial class Perfil_Admin
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
            btn_registrar_trabajador = new Button();
            btn_editar_trabajador = new Button();
            btn_eliminar_trabajador = new Button();
            btn_volver = new Button();
            btn_jornadas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Perfil Admin";
            // 
            // btn_registrar_trabajador
            // 
            btn_registrar_trabajador.BackColor = Color.FromArgb(0, 64, 64);
            btn_registrar_trabajador.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_registrar_trabajador.ForeColor = Color.White;
            btn_registrar_trabajador.Location = new Point(76, 215);
            btn_registrar_trabajador.Name = "btn_registrar_trabajador";
            btn_registrar_trabajador.Size = new Size(153, 43);
            btn_registrar_trabajador.TabIndex = 9;
            btn_registrar_trabajador.Text = "Registrar Usuario";
            btn_registrar_trabajador.UseVisualStyleBackColor = false;
            btn_registrar_trabajador.Click += btn_registrar_trabajador_Click;
            // 
            // btn_editar_trabajador
            // 
            btn_editar_trabajador.BackColor = Color.FromArgb(0, 64, 64);
            btn_editar_trabajador.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_editar_trabajador.ForeColor = Color.White;
            btn_editar_trabajador.Location = new Point(76, 131);
            btn_editar_trabajador.Name = "btn_editar_trabajador";
            btn_editar_trabajador.Size = new Size(153, 43);
            btn_editar_trabajador.TabIndex = 14;
            btn_editar_trabajador.Text = "Editar Usuario";
            btn_editar_trabajador.UseVisualStyleBackColor = false;
            btn_editar_trabajador.Click += btn_editar_trabajador_Click;
            // 
            // btn_eliminar_trabajador
            // 
            btn_eliminar_trabajador.BackColor = Color.FromArgb(0, 64, 64);
            btn_eliminar_trabajador.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_eliminar_trabajador.ForeColor = Color.White;
            btn_eliminar_trabajador.Location = new Point(461, 215);
            btn_eliminar_trabajador.Name = "btn_eliminar_trabajador";
            btn_eliminar_trabajador.Size = new Size(153, 43);
            btn_eliminar_trabajador.TabIndex = 15;
            btn_eliminar_trabajador.Text = "Eliminar Usuario";
            btn_eliminar_trabajador.UseVisualStyleBackColor = false;
            btn_eliminar_trabajador.Click += btn_eliminar_trabajador_Click;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.FromArgb(192, 64, 0);
            btn_volver.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_volver.ForeColor = Color.White;
            btn_volver.Location = new Point(561, 21);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(112, 26);
            btn_volver.TabIndex = 24;
            btn_volver.Text = "Cerrar Sesion";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_jornadas
            // 
            btn_jornadas.BackColor = Color.FromArgb(0, 64, 64);
            btn_jornadas.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_jornadas.ForeColor = Color.White;
            btn_jornadas.Location = new Point(461, 131);
            btn_jornadas.Name = "btn_jornadas";
            btn_jornadas.Size = new Size(153, 43);
            btn_jornadas.TabIndex = 25;
            btn_jornadas.Text = "Ver Jornadas";
            btn_jornadas.UseVisualStyleBackColor = false;
            btn_jornadas.Click += btn_jornadas_Click;
            // 
            // Perfil_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo3;
            ClientSize = new Size(698, 421);
            Controls.Add(btn_jornadas);
            Controls.Add(btn_volver);
            Controls.Add(btn_eliminar_trabajador);
            Controls.Add(btn_editar_trabajador);
            Controls.Add(btn_registrar_trabajador);
            Controls.Add(label1);
            Name = "Perfil_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_registrar_trabajador;
        private Button btn_editar_trabajador;
        private Button btn_eliminar_trabajador;
        private Button btn_volver;
        private Button btn_jornadas;
    }
}