namespace Draft_Diamond_BD
{
    partial class AddCard
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
            labelAddCard = new Label();
            labelNameCard = new Label();
            labelUnit = new Label();
            textBoxName = new TextBox();
            buttonAdd = new Button();
            comboBoxUniteOfMeasure = new ComboBox();
            comboBoxCategory = new ComboBox();
            CategoryLabel = new Label();
            menuStrip1 = new MenuStrip();
            назадToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelAddCard
            // 
            labelAddCard.Anchor = AnchorStyles.Top;
            labelAddCard.AutoSize = true;
            labelAddCard.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddCard.Location = new Point(203, 11);
            labelAddCard.Name = "labelAddCard";
            labelAddCard.Size = new Size(313, 36);
            labelAddCard.TabIndex = 0;
            labelAddCard.Text = "Добавить карточку";
            // 
            // labelNameCard
            // 
            labelNameCard.Anchor = AnchorStyles.None;
            labelNameCard.AutoSize = true;
            labelNameCard.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameCard.Location = new Point(115, 128);
            labelNameCard.Name = "labelNameCard";
            labelNameCard.Size = new Size(128, 29);
            labelNameCard.TabIndex = 1;
            labelNameCard.Text = "Название:";
            labelNameCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUnit
            // 
            labelUnit.Anchor = AnchorStyles.None;
            labelUnit.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUnit.Location = new Point(93, 187);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(161, 83);
            labelUnit.TabIndex = 2;
            labelUnit.Text = "   Единица измерения:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BackColor = SystemColors.ControlDarkDark;
            textBoxName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.ForeColor = SystemColors.Window;
            textBoxName.Location = new Point(260, 128);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(229, 35);
            textBoxName.TabIndex = 4;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.BackColor = SystemColors.ScrollBar;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(234, 389);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(251, 75);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBoxUniteOfMeasure
            // 
            comboBoxUniteOfMeasure.Anchor = AnchorStyles.None;
            comboBoxUniteOfMeasure.BackColor = SystemColors.WindowFrame;
            comboBoxUniteOfMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUniteOfMeasure.FlatStyle = FlatStyle.Flat;
            comboBoxUniteOfMeasure.FormattingEnabled = true;
            comboBoxUniteOfMeasure.Location = new Point(261, 205);
            comboBoxUniteOfMeasure.Margin = new Padding(3, 4, 3, 4);
            comboBoxUniteOfMeasure.Name = "comboBoxUniteOfMeasure";
            comboBoxUniteOfMeasure.Size = new Size(225, 28);
            comboBoxUniteOfMeasure.TabIndex = 8;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.None;
            comboBoxCategory.BackColor = SystemColors.WindowFrame;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FlatStyle = FlatStyle.Flat;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(260, 284);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(225, 28);
            comboBoxCategory.TabIndex = 11;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Anchor = AnchorStyles.None;
            CategoryLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CategoryLabel.Location = new Point(93, 280);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(150, 45);
            CategoryLabel.TabIndex = 10;
            CategoryLabel.Text = "Категория:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { назадToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(795, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            назадToolStripMenuItem.Size = new Size(65, 24);
            назадToolStripMenuItem.Text = "Назад";
            назадToolStripMenuItem.Click += BackToolStripMenuItem_Click;
            // 
            // AddCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 563);
            Controls.Add(comboBoxCategory);
            Controls.Add(CategoryLabel);
            Controls.Add(comboBoxUniteOfMeasure);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxName);
            Controls.Add(labelUnit);
            Controls.Add(labelNameCard);
            Controls.Add(labelAddCard);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AddCard";
            Text = "Добавить карточку";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddCard;
        private System.Windows.Forms.Label labelNameCard;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private ComboBox comboBoxUniteOfMeasure;
        private ComboBox comboBoxCategory;
        private Label CategoryLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem назадToolStripMenuItem;
    }
}