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
            menuStrip1 = new MenuStrip();
            BackToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numePurchasePrise).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelChangeCard
            // 
            labelChangeCard.AutoSize = true;
            labelChangeCard.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelChangeCard.Location = new Point(245, 37);
            labelChangeCard.Name = "labelChangeCard";
            labelChangeCard.Size = new Size(307, 36);
            labelChangeCard.TabIndex = 0;
            labelChangeCard.Text = "Изменить карточку ";
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.None;
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(203, 107);
            labelName.Name = "labelName";
            labelName.Size = new Size(105, 25);
            labelName.TabIndex = 3;
            labelName.Text = "Название:";
            // 
            // labelUnit
            // 
            labelUnit.Anchor = AnchorStyles.None;
            labelUnit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUnit.Location = new Point(167, 171);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(142, 64);
            labelUnit.TabIndex = 4;
            labelUnit.Text = "Единица измерения:";
            labelUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            labelPrice.Anchor = AnchorStyles.None;
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(168, 267);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(141, 25);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "Цена закупки:";
            labelPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonChange
            // 
            buttonChange.BackColor = SystemColors.ScrollBar;
            buttonChange.FlatStyle = FlatStyle.Flat;
            buttonChange.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonChange.Location = new Point(277, 411);
            buttonChange.Margin = new Padding(3, 4, 3, 4);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(222, 61);
            buttonChange.TabIndex = 10;
            buttonChange.Text = "Изменить";
            buttonChange.UseVisualStyleBackColor = false;
            // 
            // comboBoxName
            // 
            comboBoxName.BackColor = SystemColors.ControlDarkDark;
            comboBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(335, 116);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(217, 28);
            comboBoxName.TabIndex = 11;
            // 
            // comboBoxUniteOfMeasure
            // 
            comboBoxUniteOfMeasure.BackColor = SystemColors.ControlDarkDark;
            comboBoxUniteOfMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUniteOfMeasure.FormattingEnabled = true;
            comboBoxUniteOfMeasure.Location = new Point(338, 191);
            comboBoxUniteOfMeasure.Name = "comboBoxUniteOfMeasure";
            comboBoxUniteOfMeasure.Size = new Size(217, 28);
            comboBoxUniteOfMeasure.TabIndex = 13;
            // 
            // numePurchasePrise
            // 
            numePurchasePrise.BackColor = SystemColors.ControlDarkDark;
            numePurchasePrise.Location = new Point(343, 265);
            numePurchasePrise.Maximum = new decimal(new int[] { 1241513984, 370409800, 542101, 0 });
            numePurchasePrise.Name = "numePurchasePrise";
            numePurchasePrise.Size = new Size(213, 27);
            numePurchasePrise.TabIndex = 14;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BackToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(806, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // BackToolStripMenuItem
            // 
            BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            BackToolStripMenuItem.Size = new Size(65, 24);
            BackToolStripMenuItem.Text = "Назад";
            BackToolStripMenuItem.Click += BackToolStripMenuItem_Click;
            // 
            // ChangeCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 563);
            Controls.Add(numePurchasePrise);
            Controls.Add(comboBoxUniteOfMeasure);
            Controls.Add(comboBoxName);
            Controls.Add(buttonChange);
            Controls.Add(labelPrice);
            Controls.Add(labelUnit);
            Controls.Add(labelName);
            Controls.Add(labelChangeCard);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ChangeCard";
            Text = "Изменить карточку";
            ((System.ComponentModel.ISupportInitialize)numePurchasePrise).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem BackToolStripMenuItem;
    }
}