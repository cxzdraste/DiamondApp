namespace Draft_Diamond_BD
{
    partial class ChangeCard
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
            labelChangeCard = new Label();
            labelName = new Label();
            labelUnit = new Label();
            labelPrice = new Label();
            buttonChange = new Button();
            comboBoxName = new ComboBox();
            comboBoxUniteOfMeasure = new ComboBox();
            numePurchasePrise = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numePurchasePrise).BeginInit();
            SuspendLayout();
            // 
            // labelChangeCard
            // 
            labelChangeCard.AutoSize = true;
            labelChangeCard.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelChangeCard.Location = new Point(214, 28);
            labelChangeCard.Name = "labelChangeCard";
            labelChangeCard.Size = new Size(245, 29);
            labelChangeCard.TabIndex = 0;
            labelChangeCard.Text = "Изменить карточку ";
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.None;
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(178, 80);
            labelName.Name = "labelName";
            labelName.Size = new Size(87, 20);
            labelName.TabIndex = 3;
            labelName.Text = "Название:";
            // 
            // labelUnit
            // 
            labelUnit.Anchor = AnchorStyles.None;
            labelUnit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUnit.Location = new Point(146, 128);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(124, 48);
            labelUnit.TabIndex = 4;
            labelUnit.Text = "Единица измерения:";
            labelUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            labelPrice.Anchor = AnchorStyles.None;
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(147, 200);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(114, 20);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "Цена закупки:";
            labelPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonChange
            // 
            buttonChange.BackColor = SystemColors.ScrollBar;
            buttonChange.FlatStyle = FlatStyle.Flat;
            buttonChange.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonChange.Location = new Point(242, 308);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(194, 46);
            buttonChange.TabIndex = 10;
            buttonChange.Text = "Изменить";
            buttonChange.UseVisualStyleBackColor = false;
            // 
            // comboBoxName
            // 
            comboBoxName.BackColor = SystemColors.ControlDarkDark;
            comboBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(293, 87);
            comboBoxName.Margin = new Padding(3, 2, 3, 2);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(190, 23);
            comboBoxName.TabIndex = 11;
            // 
            // comboBoxUniteOfMeasure
            // 
            comboBoxUniteOfMeasure.BackColor = SystemColors.ControlDarkDark;
            comboBoxUniteOfMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUniteOfMeasure.FormattingEnabled = true;
            comboBoxUniteOfMeasure.Location = new Point(296, 143);
            comboBoxUniteOfMeasure.Margin = new Padding(3, 2, 3, 2);
            comboBoxUniteOfMeasure.Name = "comboBoxUniteOfMeasure";
            comboBoxUniteOfMeasure.Size = new Size(190, 23);
            comboBoxUniteOfMeasure.TabIndex = 13;
            // 
            // numePurchasePrise
            // 
            numePurchasePrise.BackColor = SystemColors.ControlDarkDark;
            numePurchasePrise.Location = new Point(300, 199);
            numePurchasePrise.Margin = new Padding(3, 2, 3, 2);
            numePurchasePrise.Maximum = new decimal(new int[] { 1241513984, 370409800, 542101, 0 });
            numePurchasePrise.Name = "numePurchasePrise";
            numePurchasePrise.Size = new Size(186, 23);
            numePurchasePrise.TabIndex = 14;
            // 
            // ChangeCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 422);
            Controls.Add(numePurchasePrise);
            Controls.Add(comboBoxUniteOfMeasure);
            Controls.Add(comboBoxName);
            Controls.Add(buttonChange);
            Controls.Add(labelPrice);
            Controls.Add(labelUnit);
            Controls.Add(labelName);
            Controls.Add(labelChangeCard);
            Name = "ChangeCard";
            Text = "Изменить карточку";
            ((System.ComponentModel.ISupportInitialize)numePurchasePrise).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChangeCard;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonChange;
        private ComboBox comboBoxName;
        private ComboBox comboBoxUniteOfMeasure;
        private NumericUpDown numePurchasePrise;
    }
}