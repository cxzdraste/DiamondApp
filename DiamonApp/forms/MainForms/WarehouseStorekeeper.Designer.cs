namespace Draft_Diamond_BD
{
    partial class WarehouseStorekeeper
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
            label1 = new Label();
            labelLogin = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            createShipmentToolStripMenuItem = new ToolStripMenuItem();
            фильтрToolStripMenuItem = new ToolStripMenuItem();
            весьСкладToolStripMenuItem = new ToolStripMenuItem();
            категорииToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItemOutput = new ToolStripMenuItem();
            сменитьАккаунтToolStripMenuItem = new ToolStripMenuItem();
            принятьПоставкуToolStripMenuItem = new ToolStripMenuItem();
            labelWrittenOffGoods = new Label();
            labelFilterProductsFalse = new Label();
            comboBoxFiterProductFalse = new ComboBox();
            labelResult = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(121, 36);
            label1.TabIndex = 0;
            label1.Text = "Склад:";
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 12F);
            labelLogin.Location = new Point(605, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(64, 25);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "label2";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, createShipmentToolStripMenuItem, фильтрToolStripMenuItem, exitToolStripMenuItemOutput, сменитьАккаунтToolStripMenuItem, принятьПоставкуToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(854, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // createShipmentToolStripMenuItem
            // 
            createShipmentToolStripMenuItem.Name = "createShipmentToolStripMenuItem";
            createShipmentToolStripMenuItem.Size = new Size(144, 24);
            createShipmentToolStripMenuItem.Text = "Создать отгрузку ";
            // 
            // фильтрToolStripMenuItem
            // 
            фильтрToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { весьСкладToolStripMenuItem, категорииToolStripMenuItem });
            фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            фильтрToolStripMenuItem.Size = new Size(74, 24);
            фильтрToolStripMenuItem.Text = "Фильтр";
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
            // сменитьАккаунтToolStripMenuItem
            // 
            сменитьАккаунтToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            сменитьАккаунтToolStripMenuItem.Name = "сменитьАккаунтToolStripMenuItem";
            сменитьАккаунтToolStripMenuItem.Size = new Size(139, 24);
            сменитьАккаунтToolStripMenuItem.Text = "Сменить аккаунт";
            // 
            // принятьПоставкуToolStripMenuItem
            // 
            принятьПоставкуToolStripMenuItem.Name = "принятьПоставкуToolStripMenuItem";
            принятьПоставкуToolStripMenuItem.Size = new Size(148, 24);
            принятьПоставкуToolStripMenuItem.Text = "Принять поставку";
            принятьПоставкуToolStripMenuItem.Click += принятьПоставкуToolStripMenuItem_Click;
            // 
            // labelWrittenOffGoods
            // 
            labelWrittenOffGoods.AutoSize = true;
            labelWrittenOffGoods.Font = new Font("Segoe UI", 18F);
            labelWrittenOffGoods.Location = new Point(12, 389);
            labelWrittenOffGoods.Name = "labelWrittenOffGoods";
            labelWrittenOffGoods.Size = new Size(286, 41);
            labelWrittenOffGoods.TabIndex = 16;
            labelWrittenOffGoods.Text = "Списанные товары:";
            // 
            // labelFilterProductsFalse
            // 
            labelFilterProductsFalse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelFilterProductsFalse.AutoSize = true;
            labelFilterProductsFalse.BackColor = SystemColors.ControlLight;
            labelFilterProductsFalse.Location = new Point(695, 405);
            labelFilterProductsFalse.Name = "labelFilterProductsFalse";
            labelFilterProductsFalse.Size = new Size(60, 20);
            labelFilterProductsFalse.TabIndex = 20;
            labelFilterProductsFalse.Text = "Фильтр";
            // 
            // comboBoxFiterProductFalse
            // 
            comboBoxFiterProductFalse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxFiterProductFalse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiterProductFalse.FormattingEnabled = true;
            comboBoxFiterProductFalse.Location = new Point(695, 402);
            comboBoxFiterProductFalse.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiterProductFalse.Name = "comboBoxFiterProductFalse";
            comboBoxFiterProductFalse.Size = new Size(138, 28);
            comboBoxFiterProductFalse.TabIndex = 19;
            comboBoxFiterProductFalse.Click += comboBoxFiterProductFalse_SelectedIndexChanged;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(23, 708);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(50, 20);
            labelResult.TabIndex = 21;
            labelResult.Text = "label2";
            // 
            // WarehouseStorekeeper
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 748);
            Controls.Add(labelResult);
            Controls.Add(labelFilterProductsFalse);
            Controls.Add(comboBoxFiterProductFalse);
            Controls.Add(labelWrittenOffGoods);
            Controls.Add(labelLogin);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WarehouseStorekeeper";
            Text = "Склад кладовщика";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createShipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весьСкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItemOutput;
        private ToolStripMenuItem категорииToolStripMenuItem;
        private ToolStripMenuItem сменитьАккаунтToolStripMenuItem;
        private Label labelWrittenOffGoods;
        private Label labelFilterProductsFalse;
        private ComboBox comboBoxFiterProductFalse;
        private ToolStripMenuItem принятьПоставкуToolStripMenuItem;
        private Label labelResult;
    }
}