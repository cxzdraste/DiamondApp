namespace Draft_Diamond_BD
{
    partial class Authorization
    {
        
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;

        private void InitializeComponent()
        {
            enter = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            autorizatoinWorker = new Label();
            loginWorker = new Label();
            passwordWorker = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // enter
            // 
            enter.Anchor = AnchorStyles.None;
            enter.BackColor = SystemColors.ScrollBar;
            enter.FlatStyle = FlatStyle.Flat;
            enter.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            enter.Location = new Point(236, 320);
            enter.Name = "enter";
            enter.Size = new Size(192, 49);
            enter.TabIndex = 0;
            enter.Text = "Войти";
            enter.UseVisualStyleBackColor = false;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.BackColor = SystemColors.ControlDarkDark;
            txtLogin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLogin.ForeColor = SystemColors.Window;
            txtLogin.Location = new Point(254, 131);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(184, 34);
            txtLogin.TabIndex = 1;
            txtLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = SystemColors.ControlDarkDark;
            txtPassword.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.ForeColor = SystemColors.Window;
            txtPassword.Location = new Point(254, 192);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(184, 36);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // autorizatoinWorker
            // 
            autorizatoinWorker.Anchor = AnchorStyles.None;
            autorizatoinWorker.AutoSize = true;
            autorizatoinWorker.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            autorizatoinWorker.Location = new Point(241, 63);
            autorizatoinWorker.Name = "autorizatoinWorker";
            autorizatoinWorker.Size = new Size(247, 32);
            autorizatoinWorker.TabIndex = 3;
            autorizatoinWorker.Text = "АВТОРИЗАЦИЯ ";
            // 
            // loginWorker
            // 
            loginWorker.Anchor = AnchorStyles.None;
            loginWorker.AutoSize = true;
            loginWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginWorker.Location = new Point(154, 134);
            loginWorker.Name = "loginWorker";
            loginWorker.Size = new Size(88, 29);
            loginWorker.TabIndex = 4;
            loginWorker.Text = "Логин:";
            // 
            // passwordWorker
            // 
            passwordWorker.Anchor = AnchorStyles.None;
            passwordWorker.AutoSize = true;
            passwordWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordWorker.Location = new Point(142, 195);
            passwordWorker.Name = "passwordWorker";
            passwordWorker.Size = new Size(102, 29);
            passwordWorker.TabIndex = 5;
            passwordWorker.Text = "Пароль:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(-2, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(174, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Зарегистрироваться ";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // Authorization
            // 
            ClientSize = new Size(662, 461);
            Controls.Add(btnRegister);
            Controls.Add(passwordWorker);
            Controls.Add(loginWorker);
            Controls.Add(autorizatoinWorker);
            Controls.Add(enter);
            Controls.Add(txtLogin);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Authorization";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();

        }
        private System.Windows.Forms.Label autorizatoinWorker;
        private System.Windows.Forms.Label loginWorker;
        private System.Windows.Forms.Label passwordWorker;
        private System.Windows.Forms.Button btnRegister;
    }
}