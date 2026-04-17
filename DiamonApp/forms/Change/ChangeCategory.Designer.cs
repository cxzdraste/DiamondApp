namespace DiamonApp.forms
{
    partial class ChangeCategory
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
            labelChangeCategory = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            labelOldName = new Label();
            comboBoxOldName = new ComboBox();
            comboBoxNewName = new ComboBox();
            labelNewName = new Label();
            buttonChangeCategory = new Button();
            SuspendLayout();
            // 
            // labelChangeCategory
            // 
            labelChangeCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelChangeCategory.AutoSize = true;
            labelChangeCategory.Font = new Font("Microsoft Sans Serif", 18F);
            labelChangeCategory.Location = new Point(207, 41);
            labelChangeCategory.Name = "labelChangeCategory";
            labelChangeCategory.Size = new Size(260, 29);
            labelChangeCategory.TabIndex = 0;
            labelChangeCategory.Text = "Изменить категорию";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // labelOldName
            // 
            labelOldName.Anchor = AnchorStyles.None;
            labelOldName.AutoSize = true;
            labelOldName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOldName.Location = new Point(133, 103);
            labelOldName.Name = "labelOldName";
            labelOldName.Size = new Size(91, 40);
            labelOldName.TabIndex = 4;
            labelOldName.Text = "Название \r\nкатегории:";
            // 
            // comboBoxOldName
            // 
            comboBoxOldName.BackColor = SystemColors.ControlDarkDark;
            comboBoxOldName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOldName.FormattingEnabled = true;
            comboBoxOldName.Location = new Point(252, 120);
            comboBoxOldName.Margin = new Padding(3, 2, 3, 2);
            comboBoxOldName.Name = "comboBoxOldName";
            comboBoxOldName.Size = new Size(190, 23);
            comboBoxOldName.TabIndex = 12;
            // 
            // comboBoxNewName
            // 
            comboBoxNewName.BackColor = SystemColors.ControlDarkDark;
            comboBoxNewName.DropDownStyle = ComboBoxStyle.Simple;
            comboBoxNewName.FormattingEnabled = true;
            comboBoxNewName.Location = new Point(252, 197);
            comboBoxNewName.Margin = new Padding(3, 2, 3, 2);
            comboBoxNewName.Name = "comboBoxNewName";
            comboBoxNewName.Size = new Size(190, 23);
            comboBoxNewName.TabIndex = 14;
            // 
            // labelNewName
            // 
            labelNewName.Anchor = AnchorStyles.None;
            labelNewName.AutoSize = true;
            labelNewName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNewName.Location = new Point(133, 180);
            labelNewName.Name = "labelNewName";
            labelNewName.Size = new Size(84, 40);
            labelNewName.TabIndex = 13;
            labelNewName.Text = "Новое \r\nназвание:";
            // 
            // buttonChangeCategory
            // 
            buttonChangeCategory.BackColor = SystemColors.ScrollBar;
            buttonChangeCategory.FlatStyle = FlatStyle.Flat;
            buttonChangeCategory.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonChangeCategory.Location = new Point(224, 305);
            buttonChangeCategory.Name = "buttonChangeCategory";
            buttonChangeCategory.Size = new Size(194, 46);
            buttonChangeCategory.TabIndex = 15;
            buttonChangeCategory.Text = "Изменить";
            buttonChangeCategory.UseVisualStyleBackColor = false;
            // 
            // ChangeCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 450);
            Controls.Add(buttonChangeCategory);
            Controls.Add(comboBoxNewName);
            Controls.Add(labelNewName);
            Controls.Add(comboBoxOldName);
            Controls.Add(labelOldName);
            Controls.Add(labelChangeCategory);
            Name = "ChangeCategory";
            Text = "Изменить категорию";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelChangeCategory;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label labelOldName;
        private ComboBox comboBoxOldName;
        private ComboBox comboBoxNewName;
        private Label labelNewName;
        private Button buttonChangeCategory;
    }
}