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
            registrationWorker.Location = new Point(281, 56);
            registrationWorker.Name = "registrationWorker";
            registrationWorker.Size = new Size(243, 32);
            registrationWorker.TabIndex = 0;
            registrationWorker.Text = "РЕГИСТРАЦИЯ ";
            registrationWorker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameWorker
            // 
            nameWorker.Anchor = AnchorStyles.None;
            nameWorker.AutoSize = true;
            nameWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameWorker.Location = new Point(131, 155);
            nameWorker.Name = "nameWorker";
            nameWorker.Size = new Size(70, 29);
            nameWorker.TabIndex = 1;
            nameWorker.Text = "Имя:";
            // 
            // surnameWorker
            // 
            surnameWorker.Anchor = AnchorStyles.None;
            surnameWorker.AutoSize = true;
            surnameWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameWorker.Location = new Point(93, 231);
            surnameWorker.Name = "surnameWorker";
            surnameWorker.Size = new Size(130, 29);
            surnameWorker.TabIndex = 2;
            surnameWorker.Text = "Фамилия:";
            // 
            // loginWorker
            // 
            loginWorker.Anchor = AnchorStyles.None;
            loginWorker.AutoSize = true;
            loginWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginWorker.Location = new Point(122, 305);
            loginWorker.Name = "loginWorker";
            loginWorker.Size = new Size(88, 29);
            loginWorker.TabIndex = 3;
            loginWorker.Text = "Логин:";
            // 
            // passwordWorker
            // 
            passwordWorker.Anchor = AnchorStyles.None;
            passwordWorker.AutoSize = true;
            passwordWorker.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordWorker.Location = new Point(107, 380);
            passwordWorker.Name = "passwordWorker";
            passwordWorker.Size = new Size(102, 29);
            passwordWorker.TabIndex = 4;
            passwordWorker.Text = "Пароль:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BackColor = SystemColors.ControlDarkDark;
            textBoxName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.ForeColor = SystemColors.Window;
            textBoxName.Location = new Point(247, 152);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(327, 37);
            textBoxName.TabIndex = 5;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.None;
            textBoxSurname.BackColor = SystemColors.ControlDarkDark;
            textBoxSurname.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSurname.ForeColor = SystemColors.Window;
            textBoxSurname.Location = new Point(249, 231);
            textBoxSurname.Margin = new Padding(3, 4, 3, 4);
            textBoxSurname.Multiline = true;
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(326, 39);
            textBoxSurname.TabIndex = 6;
            textBoxSurname.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.BackColor = SystemColors.ControlDarkDark;
            textBoxLogin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogin.ForeColor = SystemColors.Window;
            textBoxLogin.Location = new Point(249, 305);
            textBoxLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(325, 35);
            textBoxLogin.TabIndex = 7;
            textBoxLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BackColor = SystemColors.ControlDarkDark;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.ForeColor = SystemColors.Window;
            textBoxPassword.Location = new Point(248, 380);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(324, 35);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.None;
            buttonRegister.BackColor = SystemColors.ScrollBar;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRegister.Location = new Point(248, 527);
            buttonRegister.Margin = new Padding(3, 4, 3, 4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(312, 67);
            buttonRegister.TabIndex = 9;
            buttonRegister.Text = "Зарегистрироваться ";
            buttonRegister.UseVisualStyleBackColor = false;
            // 
            // btnAuthorization
            // 
            btnAuthorization.FlatStyle = FlatStyle.Flat;
            btnAuthorization.Location = new Point(-1, -3);
            btnAuthorization.Margin = new Padding(3, 4, 3, 4);
            btnAuthorization.Name = "btnAuthorization";
            btnAuthorization.Size = new Size(206, 33);
            btnAuthorization.TabIndex = 10;
            btnAuthorization.Text = "Авторизоваться ";
            btnAuthorization.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 675);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
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