namespace DiamonApp.forms
{
    partial class DeleteCategory
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
            labelDeleteCategory = new Label();
            labelNameCategory = new Label();
            comboBoxName = new ComboBox();
            buttonDeleteCategory = new Button();
            menuStrip1 = new MenuStrip();
            BackToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDeleteCategory
            // 
            labelDeleteCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDeleteCategory.AutoSize = true;
            labelDeleteCategory.Font = new Font("Microsoft Sans Serif", 18F);
            labelDeleteCategory.Location = new Point(233, 37);
            labelDeleteCategory.Name = "labelDeleteCategory";
            labelDeleteCategory.Size = new Size(303, 36);
            labelDeleteCategory.TabIndex = 2;
            labelDeleteCategory.Text = "Удалить категорию";
            // 
            // labelNameCategory
            // 
            labelNameCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNameCategory.AutoSize = true;
            labelNameCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameCategory.Location = new Point(130, 203);
            labelNameCategory.Name = "labelNameCategory";
            labelNameCategory.Size = new Size(113, 50);
            labelNameCategory.TabIndex = 17;
            labelNameCategory.Text = "Название \r\nкатегории:";
            // 
            // comboBoxName
            // 
            comboBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxName.BackColor = SystemColors.ControlDarkDark;
            comboBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(267, 204);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(217, 28);
            comboBoxName.TabIndex = 18;
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDeleteCategory.BackColor = SystemColors.ScrollBar;
            buttonDeleteCategory.FlatStyle = FlatStyle.Flat;
            buttonDeleteCategory.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteCategory.Location = new Point(233, 441);
            buttonDeleteCategory.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(222, 61);
            buttonDeleteCategory.TabIndex = 19;
            buttonDeleteCategory.Text = "Удалить";
            buttonDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BackToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(713, 28);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // BackToolStripMenuItem
            // 
            BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            BackToolStripMenuItem.Size = new Size(65, 24);
            BackToolStripMenuItem.Text = "Назад";
            BackToolStripMenuItem.Click += BackToolStripMenuItem_Click;
            // 
            // DeleteCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 600);
            Controls.Add(buttonDeleteCategory);
            Controls.Add(comboBoxName);
            Controls.Add(labelNameCategory);
            Controls.Add(labelDeleteCategory);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "DeleteCategory";
            Text = "Удалить категорию";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDeleteCategory;
        private Label labelNameCategory;
        private ComboBox comboBoxName;
        private Button buttonDeleteCategory;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem BackToolStripMenuItem;
    }
}