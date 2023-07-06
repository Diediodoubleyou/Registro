namespace Proyecto_Huellero.Vendedor
{
    partial class Registro_Horarios
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
            lbl_registro = new Label();
            lbl_rut = new Label();
            lbl_contraseña = new Label();
            txt_rut = new TextBox();
            txt_contraseña = new TextBox();
            btn_iniciar = new Button();
            btn_cerrar_jornada = new Button();
            SuspendLayout();
            // 
            // lbl_registro
            // 
            lbl_registro.AutoSize = true;
            lbl_registro.BackColor = Color.White;
            lbl_registro.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_registro.ForeColor = Color.ForestGreen;
            lbl_registro.Location = new Point(136, 61);
            lbl_registro.Name = "lbl_registro";
            lbl_registro.Size = new Size(114, 37);
            lbl_registro.TabIndex = 0;
            lbl_registro.Text = "Registro";
            // 
            // lbl_rut
            // 
            lbl_rut.AutoSize = true;
            lbl_rut.BackColor = Color.Transparent;
            lbl_rut.Location = new Point(60, 98);
            lbl_rut.Name = "lbl_rut";
            lbl_rut.Size = new Size(28, 15);
            lbl_rut.TabIndex = 1;
            lbl_rut.Text = "Rut:";
            // 
            // lbl_contraseña
            // 
            lbl_contraseña.AutoSize = true;
            lbl_contraseña.BackColor = Color.Transparent;
            lbl_contraseña.Location = new Point(51, 184);
            lbl_contraseña.Name = "lbl_contraseña";
            lbl_contraseña.Size = new Size(70, 15);
            lbl_contraseña.TabIndex = 2;
            lbl_contraseña.Text = "Contraseña:";
            // 
            // txt_rut
            // 
            txt_rut.BackColor = SystemColors.Window;
            txt_rut.BorderStyle = BorderStyle.None;
            txt_rut.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_rut.Location = new Point(60, 125);
            txt_rut.Name = "txt_rut";
            txt_rut.Size = new Size(260, 36);
            txt_rut.TabIndex = 3;
            // 
            // txt_contraseña
            // 
            txt_contraseña.BackColor = SystemColors.Window;
            txt_contraseña.BorderStyle = BorderStyle.None;
            txt_contraseña.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_contraseña.Location = new Point(60, 202);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.PasswordChar = '*';
            txt_contraseña.Size = new Size(260, 36);
            txt_contraseña.TabIndex = 4;
            // 
            // btn_iniciar
            // 
            btn_iniciar.BackColor = Color.FromArgb(0, 64, 64);
            btn_iniciar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_iniciar.ForeColor = Color.White;
            btn_iniciar.Location = new Point(116, 285);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(153, 43);
            btn_iniciar.TabIndex = 16;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // btn_cerrar_jornada
            // 
            btn_cerrar_jornada.BackColor = Color.DarkOrange;
            btn_cerrar_jornada.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_cerrar_jornada.ForeColor = Color.White;
            btn_cerrar_jornada.Location = new Point(255, 24);
            btn_cerrar_jornada.Name = "btn_cerrar_jornada";
            btn_cerrar_jornada.Size = new Size(101, 25);
            btn_cerrar_jornada.TabIndex = 17;
            btn_cerrar_jornada.Text = "Cerrar Jornada";
            btn_cerrar_jornada.UseVisualStyleBackColor = false;
            btn_cerrar_jornada.Click += btn_cerrar_jornada_Click;
            // 
            // Registro_Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(380, 422);
            Controls.Add(btn_cerrar_jornada);
            Controls.Add(btn_iniciar);
            Controls.Add(txt_contraseña);
            Controls.Add(txt_rut);
            Controls.Add(lbl_contraseña);
            Controls.Add(lbl_rut);
            Controls.Add(lbl_registro);
            Name = "Registro_Horarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro_Horarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_registro;
        private Label lbl_rut;
        private Label lbl_contraseña;
        private TextBox txt_rut;
        private TextBox txt_contraseña;
        private Button btn_iniciar;
        private Button btn_cerrar_jornada;
    }
}