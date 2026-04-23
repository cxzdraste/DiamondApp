namespace Draft_Diamond_BD
{
    partial class WarehouseAdmin
    {
        private System.Windows.Forms.Label warehouseProducts;
        private System.Windows.Forms.Button ring;
        private System.Windows.Forms.Button earrings;
        private System.Windows.Forms.Button bracelet;
        private System.Windows.Forms.Button necklace;
        private System.Windows.Forms.Button brooch;
        private System.Windows.Forms.Label labelwarehouse;
        private System.Windows.Forms.MenuStrip menuStripWarehouseProducts;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItemFilter;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItemOutput;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonHistoryShipment;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAccountToolStripMenuItem;
        private ToolStripMenuItem весьСкладToolStripMenuItem;
        private ToolStripMenuItem категорииToolStripMenuItem;
        private ToolStripMenuItem NewCategoryToolStripMenuItem;
        private ToolStripMenuItem changeCategoryToolStripMenuItem1;
        private ToolStripMenuItem DeleteCategoryToolStripMenuItem2;
        private ToolStripMenuItem принятьПоставкуToolStripMenuItem;
        private Label labelSeasonalCollection;
        private Label labelTypeProduct;
        private ComboBox comboBoxTypeProduct;
        private Label labelSeasonDuration;
        private ComboBox comboBoxSeasonDuration;
        private NumericUpDown numDiscountBeforeEnd;
        private NumericUpDown numDiscount;
        private Label labelDiscont;
        private Label label;
        private Button buttonSaveOptions;

        private void InitializeComponent()
        {
            labelwarehouse = new Label();
            menuStripWarehouseProducts = new MenuStrip();
            toolStripMenuItem3 = new ToolStripMenuItem();
            addCardToolStripMenuItem = new ToolStripMenuItem();
            NewCategoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            changeCardToolStripMenuItem = new ToolStripMenuItem();
            changeCategoryToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            deleteCardToolStripMenuItem = new ToolStripMenuItem();
            DeleteCategoryToolStripMenuItem2 = new ToolStripMenuItem();
            filterToolStripMenuItemFilter = new ToolStripMenuItem();
            весьСкладToolStripMenuItem = new ToolStripMenuItem();
            категорииToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItemOutput = new ToolStripMenuItem();
            changeAccountToolStripMenuItem = new ToolStripMenuItem();
            принятьПоставкуToolStripMenuItem = new ToolStripMenuItem();
            labelLogin = new Label();
            buttonHistoryShipment = new Button();
            labelSeasonalCollection = new Label();
            labelTypeProduct = new Label();
            comboBoxTypeProduct = new ComboBox();
            labelSeasonDuration = new Label();
            comboBoxSeasonDuration = new ComboBox();
            numDiscountBeforeEnd = new NumericUpDown();
            numDiscount = new NumericUpDown();
            labelDiscont = new Label();
            label = new Label();
            buttonSaveOptions = new Button();
            labelWrittenOffGoods = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            labelFilterProductsFalse = new Label();
            comboBoxFiterProductFalse = new ComboBox();
            labelResult = new Label();
            menuStripWarehouseProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscountBeforeEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            SuspendLayout();
            // 
            // labelwarehouse
            // 
            labelwarehouse.AutoSize = true;
            labelwarehouse.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelwarehouse.Location = new Point(12, 57);
            labelwarehouse.Name = "labelwarehouse";
            labelwarehouse.Size = new Size(106, 41);
            labelwarehouse.TabIndex = 0;
            labelwarehouse.Text = "Склад:";
            // 
            // menuStripWarehouseProducts
            // 
            menuStripWarehouseProducts.ImageScalingSize = new Size(20, 20);
            menuStripWarehouseProducts.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem2, toolStripMenuItem1, filterToolStripMenuItemFilter, exitToolStripMenuItemOutput, changeAccountToolStripMenuItem, принятьПоставкуToolStripMenuItem });
            menuStripWarehouseProducts.Location = new Point(0, 0);
            menuStripWarehouseProducts.Name = "menuStripWarehouseProducts";
            menuStripWarehouseProducts.Size = new Size(848, 28);
            menuStripWarehouseProducts.TabIndex = 1;
            menuStripWarehouseProducts.Text = "Меню";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { addCardToolStripMenuItem, NewCategoryToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(90, 24);
            toolStripMenuItem3.Text = "Добавить";
            // 
            // addCardToolStripMenuItem
            // 
            addCardToolStripMenuItem.Name = "addCardToolStripMenuItem";
            addCardToolStripMenuItem.Size = new Size(168, 26);
            addCardToolStripMenuItem.Text = "Карточку ";
            // 
            // NewCategoryToolStripMenuItem
            // 
            NewCategoryToolStripMenuItem.Name = "NewCategoryToolStripMenuItem";
            NewCategoryToolStripMenuItem.Size = new Size(168, 26);
            NewCategoryToolStripMenuItem.Text = "Категорию";
            NewCategoryToolStripMenuItem.Click += newCategoryToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { changeCardToolStripMenuItem, changeCategoryToolStripMenuItem1 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(92, 24);
            toolStripMenuItem2.Text = "Изменить";
            // 
            // changeCardToolStripMenuItem
            // 
            changeCardToolStripMenuItem.Name = "changeCardToolStripMenuItem";
            changeCardToolStripMenuItem.Size = new Size(168, 26);
            changeCardToolStripMenuItem.Text = "Карточку";
            changeCardToolStripMenuItem.Click += changeCardToolStripMenuItem_Click;
            // 
            // changeCategoryToolStripMenuItem1
            // 
            changeCategoryToolStripMenuItem1.Name = "changeCategoryToolStripMenuItem1";
            changeCategoryToolStripMenuItem1.Size = new Size(168, 26);
            changeCategoryToolStripMenuItem1.Text = "Категорию";
            changeCategoryToolStripMenuItem1.Click += CategoryChangeToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { deleteCardToolStripMenuItem, DeleteCategoryToolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(79, 24);
            toolStripMenuItem1.Text = "Удалить";
            // 
            // deleteCardToolStripMenuItem
            // 
            deleteCardToolStripMenuItem.Name = "deleteCardToolStripMenuItem";
            deleteCardToolStripMenuItem.Size = new Size(168, 26);
            deleteCardToolStripMenuItem.Text = "Карточку";
            deleteCardToolStripMenuItem.Click += deleteCardToolStripMenuItem_Click;
            // 
            // DeleteCategoryToolStripMenuItem2
            // 
            DeleteCategoryToolStripMenuItem2.Name = "DeleteCategoryToolStripMenuItem2";
            DeleteCategoryToolStripMenuItem2.Size = new Size(168, 26);
            DeleteCategoryToolStripMenuItem2.Text = "Категорию";
            DeleteCategoryToolStripMenuItem2.Click += deleteCategoryToolStripMenuItem2_Click;
            // 
            // filterToolStripMenuItemFilter
            // 
            filterToolStripMenuItemFilter.DropDownItems.AddRange(new ToolStripItem[] { весьСкладToolStripMenuItem, категорииToolStripMenuItem });
            filterToolStripMenuItemFilter.Name = "filterToolStripMenuItemFilter";
            filterToolStripMenuItemFilter.Size = new Size(74, 24);
            filterToolStripMenuItemFilter.Text = "Фильтр";
            // 
            // весьСкладToolStripMenuItem
            // 
            весьСкладToolStripMenuItem.Name = "весьСкладToolStripMenuItem";
            весьСкладToolStripMenuItem.Size = new Size(166, 26);
            весьСкладToolStripMenuItem.Text = "Весь склад";
            // 
            // категорииToolStripMenuItem
            // 
            категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            категорииToolStripMenuItem.Size = new Size(166, 26);
            категорииToolStripMenuItem.Text = "Категории";
            // 
            // exitToolStripMenuItemOutput
            // 
            exitToolStripMenuItemOutput.Name = "exitToolStripMenuItemOutput";
            exitToolStripMenuItemOutput.Size = new Size(67, 24);
            exitToolStripMenuItemOutput.Text = "Выход";
            // 
            // changeAccountToolStripMenuItem
            // 
            changeAccountToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            changeAccountToolStripMenuItem.Size = new Size(139, 24);
            changeAccountToolStripMenuItem.Text = "Сменить аккаунт";
            changeAccountToolStripMenuItem.Click += changeAccountToolStripMenuItem_Click;
            // 
            // принятьПоставкуToolStripMenuItem
            // 
            принятьПоставкуToolStripMenuItem.Name = "принятьПоставкуToolStripMenuItem";
            принятьПоставкуToolStripMenuItem.Size = new Size(148, 24);
            принятьПоставкуToolStripMenuItem.Text = "Принять поставку";
            принятьПоставкуToolStripMenuItem.Click += принятьПоставкуToolStripMenuItem_Click;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(602, 0);
            labelLogin.Margin = new Padding(5);
            labelLogin.Name = "labelLogin";
            labelLogin.Padding = new Padding(2);
            labelLogin.Size = new Size(68, 29);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "label1";
            // 
            // buttonHistoryShipment
            // 
            buttonHistoryShipment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHistoryShipment.BackColor = SystemColors.ControlDarkDark;
            buttonHistoryShipment.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHistoryShipment.Location = new Point(551, 57);
            buttonHistoryShipment.Name = "buttonHistoryShipment";
            buttonHistoryShipment.Padding = new Padding(2);
            buttonHistoryShipment.RightToLeft = RightToLeft.Yes;
            buttonHistoryShipment.Size = new Size(284, 51);
            buttonHistoryShipment.TabIndex = 4;
            buttonHistoryShipment.Text = "История Отгрузок";
            buttonHistoryShipment.UseVisualStyleBackColor = false;
            buttonHistoryShipment.Click += buttonHistoryShipment_Click;
            // 
            // labelSeasonalCollection
            // 
            labelSeasonalCollection.AutoSize = true;
            labelSeasonalCollection.Font = new Font("Segoe UI", 18F);
            labelSeasonalCollection.Location = new Point(12, 375);
            labelSeasonalCollection.Name = "labelSeasonalCollection";
            labelSeasonalCollection.Size = new Size(318, 41);
            labelSeasonalCollection.TabIndex = 5;
            labelSeasonalCollection.Text = "Сезонные коллекции:";
            // 
            // labelTypeProduct
            // 
            labelTypeProduct.AutoSize = true;
            labelTypeProduct.Font = new Font("Segoe UI", 13F);
            labelTypeProduct.Location = new Point(25, 432);
            labelTypeProduct.Name = "labelTypeProduct";
            labelTypeProduct.Size = new Size(131, 30);
            labelTypeProduct.TabIndex = 6;
            labelTypeProduct.Text = "Тип товара:";
            // 
            // comboBoxTypeProduct
            // 
            comboBoxTypeProduct.BackColor = SystemColors.ControlDarkDark;
            comboBoxTypeProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeProduct.FlatStyle = FlatStyle.Flat;
            comboBoxTypeProduct.FormattingEnabled = true;
            comboBoxTypeProduct.Location = new Point(162, 437);
            comboBoxTypeProduct.Name = "comboBoxTypeProduct";
            comboBoxTypeProduct.Size = new Size(181, 28);
            comboBoxTypeProduct.TabIndex = 7;
            comboBoxTypeProduct.Click += comboBoxTypeProduct_SelectedIndexChanged;
            // 
            // labelSeasonDuration
            // 
            labelSeasonDuration.AutoSize = true;
            labelSeasonDuration.Font = new Font("Segoe UI", 13F);
            labelSeasonDuration.Location = new Point(12, 480);
            labelSeasonDuration.Name = "labelSeasonDuration";
            labelSeasonDuration.Size = new Size(144, 30);
            labelSeasonDuration.TabIndex = 8;
            labelSeasonDuration.Text = "Срок сезона:";
            // 
            // comboBoxSeasonDuration
            // 
            comboBoxSeasonDuration.BackColor = SystemColors.ControlDarkDark;
            comboBoxSeasonDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeasonDuration.FlatStyle = FlatStyle.Flat;
            comboBoxSeasonDuration.FormattingEnabled = true;
            comboBoxSeasonDuration.Items.AddRange(new object[] { "1", "3", "6", "9", "12" });
            comboBoxSeasonDuration.Location = new Point(162, 485);
            comboBoxSeasonDuration.Name = "comboBoxSeasonDuration";
            comboBoxSeasonDuration.Size = new Size(181, 28);
            comboBoxSeasonDuration.TabIndex = 9;
            // 
            // numDiscountBeforeEnd
            // 
            numDiscountBeforeEnd.Location = new Point(322, 532);
            numDiscountBeforeEnd.Name = "numDiscountBeforeEnd";
            numDiscountBeforeEnd.Size = new Size(150, 27);
            numDiscountBeforeEnd.TabIndex = 10;
            // 
            // numDiscount
            // 
            numDiscount.Location = new Point(685, 539);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(150, 27);
            numDiscount.TabIndex = 11;
            // 
            // labelDiscont
            // 
            labelDiscont.AutoSize = true;
            labelDiscont.Font = new Font("Segoe UI", 14F);
            labelDiscont.Location = new Point(12, 525);
            labelDiscont.Name = "labelDiscont";
            labelDiscont.Size = new Size(304, 32);
            labelDiscont.TabIndex = 12;
            labelDiscont.Text = "Автоматическая скидка за";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 14F);
            label.Location = new Point(478, 532);
            label.Name = "label";
            label.Size = new Size(201, 32);
            label.TabIndex = 13;
            label.Text = "до конца сезона:";
            // 
            // buttonSaveOptions
            // 
            buttonSaveOptions.BackColor = SystemColors.ControlDarkDark;
            buttonSaveOptions.Location = new Point(12, 579);
            buttonSaveOptions.Name = "buttonSaveOptions";
            buttonSaveOptions.Size = new Size(179, 41);
            buttonSaveOptions.TabIndex = 14;
            buttonSaveOptions.Text = "Сохранить настройки";
            buttonSaveOptions.UseVisualStyleBackColor = false;
            buttonSaveOptions.Click += buttonSaveOptions_Click;
            // 
            // labelWrittenOffGoods
            // 
            labelWrittenOffGoods.AutoSize = true;
            labelWrittenOffGoods.Font = new Font("Segoe UI", 18F);
            labelWrittenOffGoods.Location = new Point(12, 623);
            labelWrittenOffGoods.Name = "labelWrittenOffGoods";
            labelWrittenOffGoods.Size = new Size(286, 41);
            labelWrittenOffGoods.TabIndex = 15;
            labelWrittenOffGoods.Text = "Списанные товары:";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // labelFilterProductsFalse
            // 
            labelFilterProductsFalse.AutoSize = true;
            labelFilterProductsFalse.BackColor = SystemColors.ControlLight;
            labelFilterProductsFalse.Location = new Point(685, 640);
            labelFilterProductsFalse.Name = "labelFilterProductsFalse";
            labelFilterProductsFalse.Size = new Size(60, 20);
            labelFilterProductsFalse.TabIndex = 17;
            labelFilterProductsFalse.Text = "Фильтр";
            // 
            // comboBoxFiterProductFalse
            // 
            comboBoxFiterProductFalse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiterProductFalse.FormattingEnabled = true;
            comboBoxFiterProductFalse.Location = new Point(685, 637);
            comboBoxFiterProductFalse.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiterProductFalse.Name = "comboBoxFiterProductFalse";
            comboBoxFiterProductFalse.Size = new Size(138, 28);
            comboBoxFiterProductFalse.TabIndex = 16;
            comboBoxFiterProductFalse.Click += comboBoxFiterProductFalse_SelectedIndexChanged;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(25, 964);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(50, 20);
            labelResult.TabIndex = 18;
            labelResult.Text = "label1";
            // 
            // WarehouseAdmin
            // 
            ClientSize = new Size(848, 1055);
            Controls.Add(labelResult);
            Controls.Add(labelFilterProductsFalse);
            Controls.Add(comboBoxFiterProductFalse);
            Controls.Add(labelWrittenOffGoods);
            Controls.Add(buttonSaveOptions);
            Controls.Add(label);
            Controls.Add(labelDiscont);
            Controls.Add(numDiscount);
            Controls.Add(numDiscountBeforeEnd);
            Controls.Add(comboBoxSeasonDuration);
            Controls.Add(labelSeasonDuration);
            Controls.Add(comboBoxTypeProduct);
            Controls.Add(labelTypeProduct);
            Controls.Add(labelSeasonalCollection);
            Controls.Add(buttonHistoryShipment);
            Controls.Add(labelLogin);
            Controls.Add(labelwarehouse);
            Controls.Add(menuStripWarehouseProducts);
            MainMenuStrip = menuStripWarehouseProducts;
            Name = "WarehouseAdmin";
            Text = "Склад администратора";
            menuStripWarehouseProducts.ResumeLayout(false);
            menuStripWarehouseProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscountBeforeEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private Label labelWrittenOffGoods;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label labelFilterProductsFalse;
        private ComboBox comboBoxFiterProductFalse;
        private Label labelResult;
    }
}