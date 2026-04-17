using System.Windows.Forms;

namespace DiamonApp.forms.differentFunctionsForms
{
    partial class HistoryShipmentForm
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
            labelHistoryShipment = new Label();
            menuStrip1 = new MenuStrip();
            ChangeAccountToolStripMenuItem = new ToolStripMenuItem();
            labelLogin = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            labelPeriod = new Label();
            buttonListWaredhouse = new Button();
            date1 = new DateTimePicker();
            labelПо = new Label();
            date2 = new DateTimePicker();
            buttonShow = new Button();
            comboBoxFiter = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelHistoryShipment
            // 
            labelHistoryShipment.AutoSize = true;
            labelHistoryShipment.Font = new Font("Segoe UI", 20F);
            labelHistoryShipment.Location = new Point(12, 0);
            labelHistoryShipment.Name = "labelHistoryShipment";
            labelHistoryShipment.Size = new Size(236, 37);
            labelHistoryShipment.TabIndex = 0;
            labelHistoryShipment.Text = "История отгрузок";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ChangeAccountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1032, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ChangeAccountToolStripMenuItem
            // 
            ChangeAccountToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            ChangeAccountToolStripMenuItem.Name = "ChangeAccountToolStripMenuItem";
            ChangeAccountToolStripMenuItem.Size = new Size(112, 20);
            ChangeAccountToolStripMenuItem.Text = "Сменить аккаунт";
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 14F);
            labelLogin.Location = new Point(776, 12);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(63, 25);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "label1";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // labelPeriod
            // 
            labelPeriod.AutoSize = true;
            labelPeriod.Font = new Font("Segoe UI", 11F);
            labelPeriod.Location = new Point(12, 83);
            labelPeriod.Name = "labelPeriod";
            labelPeriod.Size = new Size(66, 20);
            labelPeriod.TabIndex = 3;
            labelPeriod.Text = "Период:";
            // 
            // buttonListWaredhouse
            // 
            buttonListWaredhouse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonListWaredhouse.BackColor = SystemColors.ControlDarkDark;
            buttonListWaredhouse.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonListWaredhouse.Location = new Point(714, 70);
            buttonListWaredhouse.Name = "buttonListWaredhouse";
            buttonListWaredhouse.Padding = new Padding(2);
            buttonListWaredhouse.RightToLeft = RightToLeft.Yes;
            buttonListWaredhouse.Size = new Size(284, 51);
            buttonListWaredhouse.TabIndex = 5;
            buttonListWaredhouse.Text = "Список товаров";
            buttonListWaredhouse.UseVisualStyleBackColor = false;
            buttonListWaredhouse.Click += buttonListWaredhouse_Click;
            // 
            // date1
            // 
            date1.Location = new Point(84, 84);
            date1.Name = "date1";
            date1.Size = new Size(140, 23);
            date1.TabIndex = 6;
            // 
            // labelПо
            // 
            labelПо.AutoSize = true;
            labelПо.Location = new Point(230, 89);
            labelПо.Name = "labelПо";
            labelПо.Size = new Size(23, 15);
            labelПо.TabIndex = 7;
            labelПо.Text = "По";
            // 
            // date2
            // 
            date2.Location = new Point(259, 84);
            date2.Name = "date2";
            date2.Size = new Size(140, 23);
            date2.TabIndex = 8;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(420, 86);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(93, 23);
            buttonShow.TabIndex = 9;
            buttonShow.Text = "Показать";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // comboBoxFiter
            // 
            comboBoxFiter.FormattingEnabled = true;
            comboBoxFiter.Location = new Point(17, 124);
            comboBoxFiter.Name = "comboBoxFiter";
            comboBoxFiter.Size = new Size(121, 23);
            comboBoxFiter.TabIndex = 10;
            comboBoxFiter.Text = "Фильтр";
            // 
            // HistoryShipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 609);
            Controls.Add(comboBoxFiter);
            Controls.Add(buttonShow);
            Controls.Add(date2);
            Controls.Add(labelПо);
            Controls.Add(date1);
            Controls.Add(buttonListWaredhouse);
            Controls.Add(labelPeriod);
            Controls.Add(labelLogin);
            Controls.Add(labelHistoryShipment);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HistoryShipmentForm";
            Text = "HistoryShipmentForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHistoryShipment;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ChangeAccountToolStripMenuItem;
        private Label labelLogin;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label labelPeriod;
        private Button buttonListWaredhouse;
        private DateTimePicker date1;
        private Label labelПо;
        private DateTimePicker date2;
        private Button buttonShow;
        private ComboBox comboBoxFiter;
    }
}