namespace DiamonApp
{
    partial class Registration
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
            registrationWorker = new Label();
            nameWorker = new Label();
            surnameWorker = new Label();
            loginWorker = new Label();
            passwordWorker = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegister = new Button();
            btnAuthorization = new Button();
            SuspendLayout();
            // 
            // registrationWorker
            // 
            registrationWorker.Anchor = AnchorStyles.None;
            registrationWorker.AutoSize = true;
            registrationWorker.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registrationWorker.Location = new Point(246, 42);
            registrationWorker.Name = "registrationWorker";
            registrationWorker.Size = new Size(194, 26);
            registrationWorker.TabIndex = 0;
            registrationWorker.Text = "РЕГИСТРАЦИЯ ";
            registrationWorker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameWorker
            // 
            nameWorker.Anchor = AnchorStyles.None;
            nameWorker.AutoSize = true;
            nameWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameWorker.Location = new Point(115, 116);
            nameWorker.Name = "nameWorker";
            nameWorker.Size = new Size(51, 24);
            nameWorker.TabIndex = 1;
            nameWorker.Text = "Имя:";
            // 
            // surnameWorker
            // 
            surnameWorker.Anchor = AnchorStyles.None;
            surnameWorker.AutoSize = true;
            surnameWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameWorker.Location = new Point(81, 173);
            surnameWorker.Name = "surnameWorker";
            surnameWorker.Size = new Size(96, 24);
            surnameWorker.TabIndex = 2;
            surnameWorker.Text = "Фамилия:";
            // 
            // loginWorker
            // 
            loginWorker.Anchor = AnchorStyles.None;
            loginWorker.AutoSize = true;
            loginWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginWorker.Location = new Point(107, 229);
            loginWorker.Name = "loginWorker";
            loginWorker.Size = new Size(69, 24);
            loginWorker.TabIndex = 3;
            loginWorker.Text = "Логин:";
            // 
            // passwordWorker
            // 
            passwordWorker.Anchor = AnchorStyles.None;
            passwordWorker.AutoSize = true;
            passwordWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordWorker.Location = new Point(94, 285);
            passwordWorker.Name = "passwordWorker";
            passwordWorker.Size = new Size(81, 24);
            passwordWorker.TabIndex = 4;
            passwordWorker.Text = "Пароль:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BackColor = SystemColors.ControlDarkDark;
            textBoxName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.ForeColor = SystemColors.Window;
            textBoxName.Location = new Point(216, 114);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(287, 29);
            textBoxName.TabIndex = 5;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.None;
            textBoxSurname.BackColor = SystemColors.ControlDarkDark;
            textBoxSurname.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSurname.ForeColor = SystemColors.Window;
            textBoxSurname.Location = new Point(218, 173);
            textBoxSurname.Multiline = true;
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(286, 30);
            textBoxSurname.TabIndex = 6;
            textBoxSurname.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.BackColor = SystemColors.ControlDarkDark;
            textBoxLogin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogin.ForeColor = SystemColors.Window;
            textBoxLogin.Location = new Point(218, 229);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(285, 27);
            textBoxLogin.TabIndex = 7;
            textBoxLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BackColor = SystemColors.ControlDarkDark;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.ForeColor = SystemColors.Window;
            textBoxPassword.Location = new Point(217, 285);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(284, 27);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.None;
            buttonRegister.BackColor = SystemColors.ScrollBar;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRegister.Location = new Point(217, 395);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(273, 50);
            buttonRegister.TabIndex = 9;
            buttonRegister.Text = "Зарегистрироваться ";
            buttonRegister.UseVisualStyleBackColor = false;
            // 
            // btnAuthorization
            // 
            btnAuthorization.FlatStyle = FlatStyle.Flat;
            btnAuthorization.Location = new Point(-1, -2);
            btnAuthorization.Name = "btnAuthorization";
            btnAuthorization.Size = new Size(180, 25);
            btnAuthorization.TabIndex = 10;
            btnAuthorization.Text = "Авторизоваться ";
            btnAuthorization.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 506);
            Controls.Add(btnAuthorization);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(passwordWorker);
            Controls.Add(loginWorker);
            Controls.Add(surnameWorker);
            Controls.Add(nameWorker);
            Controls.Add(registrationWorker);
            Name = "Registration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationWorker;
        private System.Windows.Forms.Label nameWorker;
        private System.Windows.Forms.Label surnameWorker;
        private System.Windows.Forms.Label loginWorker;
        private System.Windows.Forms.Label passwordWorker;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button btnAuthorization;
    }
}