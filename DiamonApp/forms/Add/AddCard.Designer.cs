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
            labelPrice = new Label();
            textBoxName = new TextBox();
            buttonAdd = new Button();
            comboBoxUniteOfMeasure = new ComboBox();
            numPurchasePrice = new NumericUpDown();
            comboBoxCategory = new ComboBox();
            CategoryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numPurchasePrice).BeginInit();
            SuspendLayout();
            // 
            // labelAddCard
            // 
            labelAddCard.Anchor = AnchorStyles.Top;
            labelAddCard.AutoSize = true;
            labelAddCard.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddCard.Location = new Point(206, 11);
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
            labelNameCard.Location = new Point(118, 128);
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
            labelUnit.Location = new Point(96, 187);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(161, 83);
            labelUnit.TabIndex = 2;
            labelUnit.Text = "   Единица измерения:";
            // 
            // labelPrice
            // 
            labelPrice.Anchor = AnchorStyles.None;
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(91, 283);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(165, 29);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "цена закупки:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BackColor = SystemColors.ControlDarkDark;
            textBoxName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.ForeColor = SystemColors.Window;
            textBoxName.Location = new Point(263, 128);
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
            buttonAdd.Location = new Point(232, 427);
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
            comboBoxUniteOfMeasure.Location = new Point(264, 205);
            comboBoxUniteOfMeasure.Margin = new Padding(3, 4, 3, 4);
            comboBoxUniteOfMeasure.Name = "comboBoxUniteOfMeasure";
            comboBoxUniteOfMeasure.Size = new Size(225, 28);
            comboBoxUniteOfMeasure.TabIndex = 8;
            // 
            // numPurchasePrice
            // 
            numPurchasePrice.Anchor = AnchorStyles.None;
            numPurchasePrice.BackColor = SystemColors.ControlDarkDark;
            numPurchasePrice.Location = new Point(264, 288);
            numPurchasePrice.Maximum = new decimal(new int[] { -469762048, -590869294, 5421010, 0 });
            numPurchasePrice.Name = "numPurchasePrice";
            numPurchasePrice.Size = new Size(229, 27);
            numPurchasePrice.TabIndex = 9;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.None;
            comboBoxCategory.BackColor = SystemColors.WindowFrame;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FlatStyle = FlatStyle.Flat;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(264, 343);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(225, 28);
            comboBoxCategory.TabIndex = 11;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Anchor = AnchorStyles.None;
            CategoryLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CategoryLabel.Location = new Point(96, 339);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(150, 45);
            CategoryLabel.TabIndex = 10;
            CategoryLabel.Text = "Категория:";
            // 
            // AddCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(comboBoxCategory);
            Controls.Add(CategoryLabel);
            Controls.Add(numPurchasePrice);
            Controls.Add(comboBoxUniteOfMeasure);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxName);
            Controls.Add(labelPrice);
            Controls.Add(labelUnit);
            Controls.Add(labelNameCard);
            Controls.Add(labelAddCard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCard";
            Text = "Добавить карточку";
            ((System.ComponentModel.ISupportInitialize)numPurchasePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddCard;
        private System.Windows.Forms.Label labelNameCard;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private ComboBox comboBoxUniteOfMeasure;
        private NumericUpDown numPurchasePrice;
        private ComboBox comboBoxCategory;
        private Label CategoryLabel;
    }
}