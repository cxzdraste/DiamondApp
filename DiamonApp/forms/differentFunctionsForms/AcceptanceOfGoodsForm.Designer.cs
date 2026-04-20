namespace DiamondApp.forms.differentFunctionsForms
{
    partial class AcceptanceOfGoodsForm
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
            labelSumProduct = new Label();
            numPrice = new NumericUpDown();
            labelBusket = new Label();
            comboBoxProviderName = new ComboBox();
            numCount = new NumericUpDown();
            comboBoxName = new ComboBox();
            labelCustomerName = new Label();
            labelCount = new Label();
            labelName = new Label();
            labelCreatingShipment = new Label();
            buttonAddToBusket = new Button();
            menuStrip1 = new MenuStrip();
            сменитьАккаунтToolStripMenuItem = new ToolStripMenuItem();
            назадToolStripMenuItem = new ToolStripMenuItem();
            buttonDoAcceptance = new Button();
            buttonImport = new Button();
            labelImport = new Label();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelSumProduct
            // 
            labelSumProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSumProduct.AutoSize = true;
            labelSumProduct.Font = new Font("Segoe UI", 16F);
            labelSumProduct.Location = new Point(34, 259);
            labelSumProduct.Name = "labelSumProduct";
            labelSumProduct.Size = new Size(191, 37);
            labelSumProduct.TabIndex = 25;
            labelSumProduct.Text = "Цена закупки:";
            // 
            // numPrice
            // 
            numPrice.ForeColor = SystemColors.ControlDarkDark;
            numPrice.Location = new Point(231, 269);
            numPrice.Margin = new Padding(3, 4, 3, 4);
            numPrice.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(181, 27);
            numPrice.TabIndex = 24;
            // 
            // labelBusket
            // 
            labelBusket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelBusket.AutoSize = true;
            labelBusket.Font = new Font("Segoe UI", 20F);
            labelBusket.Location = new Point(507, 31);
            labelBusket.Name = "labelBusket";
            labelBusket.Size = new Size(134, 46);
            labelBusket.TabIndex = 23;
            labelBusket.Text = "Список";
            // 
            // comboBoxProviderName
            // 
            comboBoxProviderName.DropDownStyle = ComboBoxStyle.Simple;
            comboBoxProviderName.FormattingEnabled = true;
            comboBoxProviderName.Location = new Point(231, 332);
            comboBoxProviderName.Margin = new Padding(3, 4, 3, 4);
            comboBoxProviderName.Name = "comboBoxProviderName";
            comboBoxProviderName.Size = new Size(181, 29);
            comboBoxProviderName.TabIndex = 22;
            // 
            // numCount
            // 
            numCount.ForeColor = SystemColors.ControlDarkDark;
            numCount.Location = new Point(231, 205);
            numCount.Margin = new Padding(3, 4, 3, 4);
            numCount.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            numCount.Name = "numCount";
            numCount.Size = new Size(181, 27);
            numCount.TabIndex = 21;
            // 
            // comboBoxName
            // 
            comboBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(231, 141);
            comboBoxName.Margin = new Padding(3, 4, 3, 4);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(181, 28);
            comboBoxName.TabIndex = 20;
            // 
            // labelCustomerName
            // 
            labelCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Segoe UI", 16F);
            labelCustomerName.Location = new Point(58, 321);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(160, 37);
            labelCustomerName.TabIndex = 19;
            labelCustomerName.Text = "Поставщик:";
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 16F);
            labelCount.Location = new Point(58, 195);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(167, 37);
            labelCount.TabIndex = 18;
            labelCount.Text = "Количество:";
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 16F);
            labelName.Location = new Point(83, 132);
            labelName.Name = "labelName";
            labelName.Size = new Size(142, 37);
            labelName.TabIndex = 17;
            labelName.Text = "Название:";
            // 
            // labelCreatingShipment
            // 
            labelCreatingShipment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCreatingShipment.AutoSize = true;
            labelCreatingShipment.Font = new Font("Segoe UI", 20F);
            labelCreatingShipment.Location = new Point(48, 31);
            labelCreatingShipment.Name = "labelCreatingShipment";
            labelCreatingShipment.Size = new Size(275, 46);
            labelCreatingShipment.TabIndex = 16;
            labelCreatingShipment.Text = "Приемка товара";
            // 
            // buttonAddToBusket
            // 
            buttonAddToBusket.Font = new Font("Segoe UI", 14F);
            buttonAddToBusket.Location = new Point(120, 397);
            buttonAddToBusket.Margin = new Padding(3, 4, 3, 4);
            buttonAddToBusket.Name = "buttonAddToBusket";
            buttonAddToBusket.Size = new Size(259, 67);
            buttonAddToBusket.TabIndex = 26;
            buttonAddToBusket.Text = "Добавить";
            buttonAddToBusket.UseVisualStyleBackColor = false;
            buttonAddToBusket.Click += buttonAddToBusket_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { сменитьАккаунтToolStripMenuItem, назадToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1170, 28);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // сменитьАккаунтToolStripMenuItem
            // 
            сменитьАккаунтToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            сменитьАккаунтToolStripMenuItem.Name = "сменитьАккаунтToolStripMenuItem";
            сменитьАккаунтToolStripMenuItem.Size = new Size(139, 24);
            сменитьАккаунтToolStripMenuItem.Text = "Сменить аккаунт";
            сменитьАккаунтToolStripMenuItem.Click += сменитьАккаунтToolStripMenuItem_Click;
            // 
            // назадToolStripMenuItem
            // 
            назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            назадToolStripMenuItem.Size = new Size(65, 24);
            назадToolStripMenuItem.Text = "Назад";
            назадToolStripMenuItem.Click += назадToolStripMenuItem_Click;
            // 
            // buttonDoAcceptance
            // 
            buttonDoAcceptance.Font = new Font("Segoe UI", 14F);
            buttonDoAcceptance.Location = new Point(83, 554);
            buttonDoAcceptance.Margin = new Padding(3, 4, 3, 4);
            buttonDoAcceptance.Name = "buttonDoAcceptance";
            buttonDoAcceptance.Size = new Size(323, 67);
            buttonDoAcceptance.TabIndex = 28;
            buttonDoAcceptance.Text = "Произвести приемку";
            buttonDoAcceptance.UseVisualStyleBackColor = false;
            buttonDoAcceptance.Click += button1_Click;
            // 
            // buttonImport
            // 
            buttonImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonImport.Font = new Font("Segoe UI", 14F);
            buttonImport.Location = new Point(932, 567);
            buttonImport.Margin = new Padding(3, 4, 3, 4);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(199, 54);
            buttonImport.TabIndex = 29;
            buttonImport.Text = "Импортировать";
            buttonImport.UseVisualStyleBackColor = false;
            buttonImport.Click += buttonImport_Click;
            // 
            // labelImport
            // 
            labelImport.AutoSize = true;
            labelImport.Font = new Font("Segoe UI", 14F);
            labelImport.Location = new Point(706, 579);
            labelImport.Name = "labelImport";
            labelImport.Size = new Size(212, 32);
            labelImport.TabIndex = 30;
            labelImport.Text = "Импорт из файла:";
            // 
            // AcceptanceOfGoodsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 705);
            Controls.Add(labelImport);
            Controls.Add(buttonImport);
            Controls.Add(buttonDoAcceptance);
            Controls.Add(buttonAddToBusket);
            Controls.Add(labelSumProduct);
            Controls.Add(numPrice);
            Controls.Add(labelBusket);
            Controls.Add(comboBoxProviderName);
            Controls.Add(numCount);
            Controls.Add(comboBoxName);
            Controls.Add(labelCustomerName);
            Controls.Add(labelCount);
            Controls.Add(labelName);
            Controls.Add(labelCreatingShipment);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AcceptanceOfGoodsForm";
            Text = "Принять товар";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSumProduct;
        private NumericUpDown numPrice;
        private Label labelBusket;
        private ComboBox comboBoxProviderName;
        private NumericUpDown numCount;
        private ComboBox comboBoxName;
        private Label labelCustomerName;
        private Label labelCount;
        private Label labelName;
        private Label labelCreatingShipment;
        private Button buttonAddToBusket;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem сменитьАккаунтToolStripMenuItem;
        private Button buttonDoAcceptance;
        private ToolStripMenuItem назадToolStripMenuItem;
        private Button buttonImport;
        private Label labelImport;
    }
}