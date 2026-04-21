namespace DiamonApp.forms
{
    partial class DeleteCard
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
            label1 = new Label();
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
            labelDeleteCategory.Location = new Point(229, 33);
            labelDeleteCategory.Name = "labelDeleteCategory";
            labelDeleteCategory.Size = new Size(278, 36);
            labelDeleteCategory.TabIndex = 1;
            labelDeleteCategory.Text = "Удалить карточку";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(162, 191);
            label1.Name = "label1";
            label1.Size = new Size(104, 50);
            label1.TabIndex = 16;
            label1.Text = "Название \r\nкарточки:";
            // 
            // comboBoxName
            // 
            comboBoxName.BackColor = SystemColors.ControlDarkDark;
            comboBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(298, 213);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(217, 28);
            comboBoxName.TabIndex = 17;
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.BackColor = SystemColors.ScrollBar;
            buttonDeleteCategory.FlatStyle = FlatStyle.Flat;
            buttonDeleteCategory.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteCategory.Location = new Point(242, 368);
            buttonDeleteCategory.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(222, 61);
            buttonDeleteCategory.TabIndex = 18;
            buttonDeleteCategory.Text = "Удалить";
            buttonDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BackToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(790, 28);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // BackToolStripMenuItem
            // 
            BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            BackToolStripMenuItem.Size = new Size(65, 24);
            BackToolStripMenuItem.Text = "Назад";
            BackToolStripMenuItem.Click += BackToolStripMenuItem_Click;
            // 
            // DeleteCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 600);
            Controls.Add(buttonDeleteCategory);
            Controls.Add(comboBoxName);
            Controls.Add(label1);
            Controls.Add(labelDeleteCategory);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "DeleteCard";
            Text = "Удалить карточку";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDeleteCategory;
        private Label label1;
        private ComboBox comboBoxName;
        private Button buttonDeleteCategory;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem BackToolStripMenuItem;
    }
}