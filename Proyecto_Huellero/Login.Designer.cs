namespace Proyecto_Huellero
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_user = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.BorderStyle = BorderStyle.None;
            txt_user.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.ForeColor = Color.Black;
            txt_user.Location = new Point(63, 128);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(252, 36);
            txt_user.TabIndex = 6;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = Color.Black;
            txt_password.Location = new Point(63, 204);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(252, 36);
            txt_password.TabIndex = 7;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(0, 64, 64);
            btn_login.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(146, 282);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(92, 40);
            btn_login.TabIndex = 8;
            btn_login.Text = "INGRESAR";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(386, 423);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_user;
        private TextBox txt_password;
        private Button btn_login;
    }
}