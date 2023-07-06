namespace Proyecto_Huellero.Supervisor
{
    partial class Iniciar_Jornada
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
            txt_dia = new TextBox();
            txt_hora_inicio = new TextBox();
            lbl_dia = new Label();
            lbl_hora_inicio = new Label();
            lbl_inciar_jornada = new Label();
            txt_supervisor = new TextBox();
            lbl_supervisor = new Label();
            btn_cerrar_sesion = new Button();
            btn_iniciar = new Button();
            SuspendLayout();
            // 
            // txt_dia
            // 
            txt_dia.Location = new Point(190, 141);
            txt_dia.Name = "txt_dia";
            txt_dia.Size = new Size(154, 23);
            txt_dia.TabIndex = 0;
            // 
            // txt_hora_inicio
            // 
            txt_hora_inicio.Location = new Point(190, 180);
            txt_hora_inicio.Name = "txt_hora_inicio";
            txt_hora_inicio.Size = new Size(154, 23);
            txt_hora_inicio.TabIndex = 1;
            // 
            // lbl_dia
            // 
            lbl_dia.AutoSize = true;
            lbl_dia.BackColor = Color.Transparent;
            lbl_dia.Location = new Point(127, 149);
            lbl_dia.Name = "lbl_dia";
            lbl_dia.Size = new Size(24, 15);
            lbl_dia.TabIndex = 3;
            lbl_dia.Text = "Dia";
            // 
            // lbl_hora_inicio
            // 
            lbl_hora_inicio.AutoSize = true;
            lbl_hora_inicio.BackColor = Color.Transparent;
            lbl_hora_inicio.Location = new Point(86, 188);
            lbl_hora_inicio.Name = "lbl_hora_inicio";
            lbl_hora_inicio.Size = new Size(65, 15);
            lbl_hora_inicio.TabIndex = 4;
            lbl_hora_inicio.Text = "Hora Inicio";
            // 
            // lbl_inciar_jornada
            // 
            lbl_inciar_jornada.AutoSize = true;
            lbl_inciar_jornada.BackColor = Color.Transparent;
            lbl_inciar_jornada.Location = new Point(38, 32);
            lbl_inciar_jornada.Name = "lbl_inciar_jornada";
            lbl_inciar_jornada.Size = new Size(83, 15);
            lbl_inciar_jornada.TabIndex = 53;
            lbl_inciar_jornada.Text = "Iniciar Jornada";
            // 
            // txt_supervisor
            // 
            txt_supervisor.Location = new Point(190, 103);
            txt_supervisor.Name = "txt_supervisor";
            txt_supervisor.Size = new Size(154, 23);
            txt_supervisor.TabIndex = 54;
            // 
            // lbl_supervisor
            // 
            lbl_supervisor.AutoSize = true;
            lbl_supervisor.BackColor = Color.Transparent;
            lbl_supervisor.Location = new Point(89, 111);
            lbl_supervisor.Name = "lbl_supervisor";
            lbl_supervisor.Size = new Size(62, 15);
            lbl_supervisor.TabIndex = 55;
            lbl_supervisor.Text = "Supervisor";
            // 
            // btn_cerrar_sesion
            // 
            btn_cerrar_sesion.BackColor = Color.FromArgb(192, 64, 0);
            btn_cerrar_sesion.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_cerrar_sesion.ForeColor = Color.White;
            btn_cerrar_sesion.Location = new Point(559, 21);
            btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            btn_cerrar_sesion.Size = new Size(112, 26);
            btn_cerrar_sesion.TabIndex = 52;
            btn_cerrar_sesion.Text = "Cerrar Sesión";
            btn_cerrar_sesion.UseVisualStyleBackColor = false;
            btn_cerrar_sesion.Click += btn_cerrar_sesion_Click;
            // 
            // btn_iniciar
            // 
            btn_iniciar.BackColor = Color.FromArgb(0, 64, 64);
            btn_iniciar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_iniciar.ForeColor = Color.White;
            btn_iniciar.Location = new Point(550, 366);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(112, 26);
            btn_iniciar.TabIndex = 56;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // Iniciar_Jornada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo3;
            ClientSize = new Size(702, 421);
            Controls.Add(btn_iniciar);
            Controls.Add(lbl_supervisor);
            Controls.Add(txt_supervisor);
            Controls.Add(lbl_inciar_jornada);
            Controls.Add(btn_cerrar_sesion);
            Controls.Add(lbl_hora_inicio);
            Controls.Add(lbl_dia);
            Controls.Add(txt_hora_inicio);
            Controls.Add(txt_dia);
            Name = "Iniciar_Jornada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar_Jornada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_dia;
        private TextBox txt_hora_inicio;
        private Label lbl_dia;
        private Label lbl_hora_inicio;
        private Label lbl_inciar_jornada;
        private TextBox txt_supervisor;
        private Label lbl_supervisor;
        private Button btn_cerrar_sesion;
        private Button btn_iniciar;
    }
}