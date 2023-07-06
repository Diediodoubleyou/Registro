namespace Proyecto_Huellero.Admin.Admin_Usuarios
{
    partial class Ver_registros_Jornada
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
            dgv_tabla_jornadas = new DataGridView();
            lbl_registro_de_jornadas = new Label();
            lbl_buscar = new Label();
            date_fecha = new DateTimePicker();
            btn_buscar = new Button();
            btn_volver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_tabla_jornadas).BeginInit();
            SuspendLayout();
            // 
            // dgv_tabla_jornadas
            // 
            dgv_tabla_jornadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tabla_jornadas.Location = new Point(73, 163);
            dgv_tabla_jornadas.Name = "dgv_tabla_jornadas";
            dgv_tabla_jornadas.RowTemplate.Height = 25;
            dgv_tabla_jornadas.Size = new Size(554, 192);
            dgv_tabla_jornadas.TabIndex = 0;
            // 
            // lbl_registro_de_jornadas
            // 
            lbl_registro_de_jornadas.AutoSize = true;
            lbl_registro_de_jornadas.BackColor = Color.Transparent;
            lbl_registro_de_jornadas.Location = new Point(34, 28);
            lbl_registro_de_jornadas.Name = "lbl_registro_de_jornadas";
            lbl_registro_de_jornadas.Size = new Size(53, 15);
            lbl_registro_de_jornadas.TabIndex = 1;
            lbl_registro_de_jornadas.Text = "Jornadas";
            // 
            // lbl_buscar
            // 
            lbl_buscar.AutoSize = true;
            lbl_buscar.BackColor = Color.Transparent;
            lbl_buscar.Location = new Point(73, 142);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(85, 15);
            lbl_buscar.TabIndex = 2;
            lbl_buscar.Text = "Buscar por dia:";
            // 
            // date_fecha
            // 
            date_fecha.Location = new Point(173, 134);
            date_fecha.Name = "date_fecha";
            date_fecha.Size = new Size(215, 23);
            date_fecha.TabIndex = 4;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 64, 64);
            btn_buscar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Location = new Point(403, 131);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(98, 26);
            btn_buscar.TabIndex = 13;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click_1;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.DarkOrange;
            btn_volver.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_volver.ForeColor = Color.White;
            btn_volver.Location = new Point(565, 22);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(98, 26);
            btn_volver.TabIndex = 15;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // Ver_registros_Jornada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo3;
            ClientSize = new Size(698, 420);
            Controls.Add(btn_volver);
            Controls.Add(btn_buscar);
            Controls.Add(date_fecha);
            Controls.Add(lbl_buscar);
            Controls.Add(lbl_registro_de_jornadas);
            Controls.Add(dgv_tabla_jornadas);
            Name = "Ver_registros_Jornada";
            Text = "Ver_registros_Jornada";
            ((System.ComponentModel.ISupportInitialize)dgv_tabla_jornadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_tabla_jornadas;
        private Label lbl_registro_de_jornadas;
        private Label lbl_buscar;
        private DateTimePicker date_fecha;
        private Button btn_buscar;
        private Button btn_volver;
    }
}