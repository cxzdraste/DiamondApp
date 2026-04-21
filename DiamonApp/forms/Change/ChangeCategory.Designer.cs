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
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelChangeCategory
            // 
            labelChangeCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelChangeCategory.AutoSize = true;
            labelChangeCategory.Font = new Font("Microsoft Sans Serif", 18F);
            labelChangeCategory.Location = new Point(237, 55);
            labelChangeCategory.Name = "labelChangeCategory";
            labelChangeCategory.Size = new Size(324, 36);
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
            labelOldName.Location = new Point(152, 137);
            labelOldName.Name = "labelOldName";
            labelOldName.Size = new Size(113, 50);
            labelOldName.TabIndex = 4;
            labelOldName.Text = "Название \r\nкатегории:";
            // 
            // comboBoxOldName
            // 
            comboBoxOldName.BackColor = SystemColors.ControlDarkDark;
            comboBoxOldName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOldName.FormattingEnabled = true;
            comboBoxOldName.Location = new Point(288, 160);
            comboBoxOldName.Name = "comboBoxOldName";
            comboBoxOldName.Size = new Size(217, 28);
            comboBoxOldName.TabIndex = 12;
            // 
            // comboBoxNewName
            // 
            comboBoxNewName.BackColor = SystemColors.ControlDarkDark;
            comboBoxNewName.DropDownStyle = ComboBoxStyle.Simple;
            comboBoxNewName.FormattingEnabled = true;
            comboBoxNewName.Location = new Point(288, 263);
            comboBoxNewName.Name = "comboBoxNewName";
            comboBoxNewName.Size = new Size(217, 29);
            comboBoxNewName.TabIndex = 14;
            // 
            // labelNewName
            // 
            labelNewName.Anchor = AnchorStyles.None;
            labelNewName.AutoSize = true;
            labelNewName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNewName.Location = new Point(152, 240);
            labelNewName.Name = "labelNewName";
            labelNewName.Size = new Size(103, 50);
            labelNewName.TabIndex = 13;
            labelNewName.Text = "Новое \r\nназвание:";
            // 
            // buttonChangeCategory
            // 
            buttonChangeCategory.BackColor = SystemColors.ScrollBar;
            buttonChangeCategory.FlatStyle = FlatStyle.Flat;
            buttonChangeCategory.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonChangeCategory.Location = new Point(256, 407);
            buttonChangeCategory.Margin = new Padding(3, 4, 3, 4);
            buttonChangeCategory.Name = "buttonChangeCategory";
            buttonChangeCategory.Size = new Size(222, 61);
            buttonChangeCategory.TabIndex = 15;
            buttonChangeCategory.Text = "Изменить";
            buttonChangeCategory.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(767, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(65, 24);
            backToolStripMenuItem.Text = "Назад";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // ChangeCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 600);
            Controls.Add(buttonChangeCategory);
            Controls.Add(comboBoxNewName);
            Controls.Add(labelNewName);
            Controls.Add(comboBoxOldName);
            Controls.Add(labelOldName);
            Controls.Add(labelChangeCategory);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ChangeCategory";
            Text = "Изменить категорию";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}