namespace DiamonApp.forms
{
    partial class AddCategory
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
            labelAddCategory = new Label();
            textBoxName = new TextBox();
            labelNameCategory = new Label();
            buttonAdd = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelAddCategory
            // 
            labelAddCategory.Anchor = AnchorStyles.Top;
            labelAddCategory.AutoSize = true;
            labelAddCategory.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddCategory.Location = new Point(242, 53);
            labelAddCategory.Name = "labelAddCategory";
            labelAddCategory.Size = new Size(339, 36);
            labelAddCategory.TabIndex = 1;
            labelAddCategory.Text = "Добавить категорию";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BackColor = SystemColors.ControlDarkDark;
            textBoxName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.ForeColor = SystemColors.Window;
            textBoxName.Location = new Point(321, 175);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(229, 35);
            textBoxName.TabIndex = 5;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNameCategory
            // 
            labelNameCategory.Anchor = AnchorStyles.None;
            labelNameCategory.AutoSize = true;
            labelNameCategory.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameCategory.Location = new Point(177, 179);
            labelNameCategory.Name = "labelNameCategory";
            labelNameCategory.Size = new Size(128, 29);
            labelNameCategory.TabIndex = 6;
            labelNameCategory.Text = "Название:";
            labelNameCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ScrollBar;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(265, 383);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(251, 75);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(65, 24);
            backToolStripMenuItem.Text = "Назад";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(buttonAdd);
            Controls.Add(labelNameCategory);
            Controls.Add(textBoxName);
            Controls.Add(labelAddCategory);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AddCategory";
            Text = "Добавить категорию";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddCategory;
        private TextBox textBoxName;
        private Label labelNameCategory;
        private Button buttonAdd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}