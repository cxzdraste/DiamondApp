namespace DiamonApp.forms.differentFunctionsForms
{
    partial class CreatingShipmentForm
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
            labelCreatingShipment = new Label();
            labelName = new Label();
            labelUniteOfMeasure = new Label();
            labelCount = new Label();
            labelCustomerName = new Label();
            labelCustomerPlace = new Label();
            comboBoxName = new ComboBox();
            comboBoxUniteOfMeasure = new ComboBox();
            numCount = new NumericUpDown();
            comboBoxCustomerName = new ComboBox();
            comboBoxCustomerPlace = new ComboBox();
            buttonAddToBusket = new Button();
            labelBusket = new Label();
            buttonShipment = new Button();
            numSumProduct = new NumericUpDown();
            labelSumProduct = new Label();
            menuStrip1 = new MenuStrip();
            BackToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSumProduct).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCreatingShipment
            // 
            labelCreatingShipment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCreatingShipment.AutoSize = true;
            labelCreatingShipment.Font = new Font("Segoe UI", 20F);
            labelCreatingShipment.Location = new Point(134, 56);
            labelCreatingShipment.Name = "labelCreatingShipment";
            labelCreatingShipment.Size = new Size(283, 46);
            labelCreatingShipment.TabIndex = 0;
            labelCreatingShipment.Text = "Создать отгрузку";
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 16F);
            labelName.Location = new Point(69, 164);
            labelName.Name = "labelName";
            labelName.Size = new Size(142, 37);
            labelName.TabIndex = 1;
            labelName.Text = "Название:";
            // 
            // labelUniteOfMeasure
            // 
            labelUniteOfMeasure.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelUniteOfMeasure.AutoSize = true;
            labelUniteOfMeasure.Font = new Font("Segoe UI", 16F);
            labelUniteOfMeasure.Location = new Point(14, 249);
            labelUniteOfMeasure.Name = "labelUniteOfMeasure";
            labelUniteOfMeasure.Size = new Size(202, 37);
            labelUniteOfMeasure.TabIndex = 2;
            labelUniteOfMeasure.Text = "Ед. измерения:";
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 16F);
            labelCount.Location = new Point(45, 347);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(167, 37);
            labelCount.TabIndex = 3;
            labelCount.Text = "Количество:";
            // 
            // labelCustomerName
            // 
            labelCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Segoe UI", 16F);
            labelCustomerName.Location = new Point(121, 483);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(87, 37);
            labelCustomerName.TabIndex = 4;
            labelCustomerName.Text = "Кому:";
            // 
            // labelCustomerPlace
            // 
            labelCustomerPlace.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCustomerPlace.AutoSize = true;
            labelCustomerPlace.Font = new Font("Segoe UI", 16F);
            labelCustomerPlace.Location = new Point(121, 564);
            labelCustomerPlace.Name = "labelCustomerPlace";
            labelCustomerPlace.Size = new Size(81, 37);
            labelCustomerPlace.TabIndex = 5;
            labelCustomerPlace.Text = "Куда:";
            // 
            // comboBoxName
            // 
            comboBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(222, 176);
            comboBoxName.Margin = new Padding(3, 4, 3, 4);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(198, 28);
            comboBoxName.TabIndex = 6;
            // 
            // comboBoxUniteOfMeasure
            // 
            comboBoxUniteOfMeasure.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxUniteOfMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUniteOfMeasure.FormattingEnabled = true;
            comboBoxUniteOfMeasure.Location = new Point(222, 261);
            comboBoxUniteOfMeasure.Margin = new Padding(3, 4, 3, 4);
            comboBoxUniteOfMeasure.Name = "comboBoxUniteOfMeasure";
            comboBoxUniteOfMeasure.Size = new Size(198, 28);
            comboBoxUniteOfMeasure.TabIndex = 7;
            // 
            // numCount
            // 
            numCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numCount.ForeColor = SystemColors.ControlDarkDark;
            numCount.Location = new Point(222, 356);
            numCount.Margin = new Padding(3, 4, 3, 4);
            numCount.Name = "numCount";
            numCount.Size = new Size(199, 27);
            numCount.TabIndex = 8;
            // 
            // comboBoxCustomerName
            // 
            comboBoxCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCustomerName.DropDownStyle = ComboBoxStyle.Simple;
            comboBoxCustomerName.FormattingEnabled = true;
            comboBoxCustomerName.Location = new Point(222, 491);
            comboBoxCustomerName.Margin = new Padding(3, 4, 3, 4);
            comboBoxCustomerName.Name = "comboBoxCustomerName";
            comboBoxCustomerName.Size = new Size(198, 29);
            comboBoxCustomerName.TabIndex = 9;
            // 
            // comboBoxCustomerPlace
            // 
            comboBoxCustomerPlace.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCustomerPlace.DropDownStyle = ComboBoxStyle.Simple;
            comboBoxCustomerPlace.FormattingEnabled = true;
            comboBoxCustomerPlace.Location = new Point(222, 572);
            comboBoxCustomerPlace.Margin = new Padding(3, 4, 3, 4);
            comboBoxCustomerPlace.Name = "comboBoxCustomerPlace";
            comboBoxCustomerPlace.Size = new Size(198, 29);
            comboBoxCustomerPlace.TabIndex = 10;
            // 
            // buttonAddToBusket
            // 
            buttonAddToBusket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddToBusket.Font = new Font("Segoe UI", 14F);
            buttonAddToBusket.Location = new Point(151, 639);
            buttonAddToBusket.Margin = new Padding(3, 4, 3, 4);
            buttonAddToBusket.Name = "buttonAddToBusket";
            buttonAddToBusket.Size = new Size(224, 67);
            buttonAddToBusket.TabIndex = 11;
            buttonAddToBusket.Text = "Добавить";
            buttonAddToBusket.UseVisualStyleBackColor = false;
            // 
            // labelBusket
            // 
            labelBusket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelBusket.AutoSize = true;
            labelBusket.Font = new Font("Segoe UI", 20F);
            labelBusket.Location = new Point(537, 56);
            labelBusket.Name = "labelBusket";
            labelBusket.Size = new Size(134, 46);
            labelBusket.TabIndex = 12;
            labelBusket.Text = "Список";
            // 
            // buttonShipment
            // 
            buttonShipment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonShipment.Font = new Font("Segoe UI", 14F);
            buttonShipment.Location = new Point(447, 717);
            buttonShipment.Margin = new Padding(3, 4, 3, 4);
            buttonShipment.Name = "buttonShipment";
            buttonShipment.Size = new Size(224, 67);
            buttonShipment.TabIndex = 13;
            buttonShipment.Text = "Отгрузить";
            buttonShipment.UseVisualStyleBackColor = false;
            // 
            // numSumProduct
            // 
            numSumProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numSumProduct.ForeColor = SystemColors.ControlDarkDark;
            numSumProduct.Location = new Point(222, 423);
            numSumProduct.Margin = new Padding(3, 4, 3, 4);
            numSumProduct.Name = "numSumProduct";
            numSumProduct.Size = new Size(199, 27);
            numSumProduct.TabIndex = 14;
            // 
            // labelSumProduct
            // 
            labelSumProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSumProduct.AutoSize = true;
            labelSumProduct.Font = new Font("Segoe UI", 16F);
            labelSumProduct.Location = new Point(97, 413);
            labelSumProduct.Name = "labelSumProduct";
            labelSumProduct.Size = new Size(105, 37);
            labelSumProduct.TabIndex = 15;
            labelSumProduct.Text = "Сумма:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BackToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1121, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // BackToolStripMenuItem
            // 
            BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            BackToolStripMenuItem.Size = new Size(65, 24);
            BackToolStripMenuItem.Text = "Назад";
            BackToolStripMenuItem.Click += BackToolStripMenuItem_Click;
            // 
            // CreatingShipmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 817);
            Controls.Add(labelSumProduct);
            Controls.Add(numSumProduct);
            Controls.Add(buttonShipment);
            Controls.Add(labelBusket);
            Controls.Add(buttonAddToBusket);
            Controls.Add(comboBoxCustomerPlace);
            Controls.Add(comboBoxCustomerName);
            Controls.Add(numCount);
            Controls.Add(comboBoxUniteOfMeasure);
            Controls.Add(comboBoxName);
            Controls.Add(labelCustomerPlace);
            Controls.Add(labelCustomerName);
            Controls.Add(labelCount);
            Controls.Add(labelUniteOfMeasure);
            Controls.Add(labelName);
            Controls.Add(labelCreatingShipment);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreatingShipmentForm";
            Text = "Создать отгрузку";
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSumProduct).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCreatingShipment;
        private Label labelName;
        private Label labelUniteOfMeasure;
        private Label labelCount;
        private Label labelCustomerName;
        private Label labelCustomerPlace;
        private ComboBox comboBoxName;
        private ComboBox comboBoxUniteOfMeasure;
        private NumericUpDown numCount;
        private ComboBox comboBoxCustomerName;
        private ComboBox comboBoxCustomerPlace;
        private Button buttonAddToBusket;
        private Label labelBusket;
        private Button buttonShipment;
        private NumericUpDown numSumProduct;
        private Label labelSumProduct;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem BackToolStripMenuItem;
    }
}