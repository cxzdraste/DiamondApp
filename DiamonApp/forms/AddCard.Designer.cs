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
            textBoxPrice = new TextBox();
            buttonAdd = new Button();
            comboBoxUniteOfMeasure = new ComboBox();
            SuspendLayout();
            // 
            // labelAddCard
            // 
            labelAddCard.Anchor = AnchorStyles.Top;
            labelAddCard.AutoSize = true;
            labelAddCard.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddCard.Location = new Point(180, 8);
            labelAddCard.Name = "labelAddCard";
            labelAddCard.Size = new Size(248, 29);
            labelAddCard.TabIndex = 0;
            labelAddCard.Text = "Добавить карточку";
            // 
            // labelNameCard
            // 
            labelNameCard.Anchor = AnchorStyles.None;
            labelNameCard.AutoSize = true;
            labelNameCard.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameCard.Location = new Point(103, 96);
            labelNameCard.Name = "labelNameCard";
            labelNameCard.Size = new Size(102, 24);
            labelNameCard.TabIndex = 1;
            labelNameCard.Text = "Название:";
            labelNameCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUnit
            // 
            labelUnit.Anchor = AnchorStyles.None;
            labelUnit.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUnit.Location = new Point(84, 140);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(141, 62);
            labelUnit.TabIndex = 2;
            labelUnit.Text = "   Единица измерения:";
            // 
            // labelPrice
            // 
            labelPrice.Anchor = AnchorStyles.None;
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(80, 212);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(132, 24);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "цена закупки:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BackColor = SystemColors.ControlDarkDark;
            textBoxName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.ForeColor = SystemColors.Window;
            textBoxName.Location = new Point(230, 96);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(201, 27);
            textBoxName.TabIndex = 4;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = AnchorStyles.None;
            textBoxPrice.BackColor = SystemColors.ControlDarkDark;
            textBoxPrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPrice.ForeColor = SystemColors.Window;
            textBoxPrice.Location = new Point(230, 212);
            textBoxPrice.Multiline = true;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(201, 27);
            textBoxPrice.TabIndex = 6;
            textBoxPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ScrollBar;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(203, 320);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(220, 56);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBoxUniteOfMeasure
            // 
            comboBoxUniteOfMeasure.BackColor = SystemColors.WindowFrame;
            comboBoxUniteOfMeasure.FormattingEnabled = true;
            comboBoxUniteOfMeasure.Location = new Point(231, 154);
            comboBoxUniteOfMeasure.Name = "comboBoxUniteOfMeasure";
            comboBoxUniteOfMeasure.Size = new Size(197, 23);
            comboBoxUniteOfMeasure.TabIndex = 8;
            comboBoxUniteOfMeasure.SelectedIndexChanged += comboBoxUniteOfMeasure_SelectedIndexChanged;
            // 
            // AddCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(comboBoxUniteOfMeasure);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelPrice);
            Controls.Add(labelUnit);
            Controls.Add(labelNameCard);
            Controls.Add(labelAddCard);
            Name = "AddCard";
            Text = "AddCard";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddCard;
        private System.Windows.Forms.Label labelNameCard;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
        private ComboBox comboBoxUniteOfMeasure;
    }
}