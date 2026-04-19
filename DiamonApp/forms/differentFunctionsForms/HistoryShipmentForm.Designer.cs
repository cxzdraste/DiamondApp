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
            labelExportTheReport = new Label();
            buttonExportTheReport = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelHistoryShipment
            // 
            labelHistoryShipment.AutoSize = true;
            labelHistoryShipment.Font = new Font("Segoe UI", 20F);
            labelHistoryShipment.Location = new Point(14, 0);
            labelHistoryShipment.Name = "labelHistoryShipment";
            labelHistoryShipment.Size = new Size(296, 46);
            labelHistoryShipment.TabIndex = 0;
            labelHistoryShipment.Text = "История отгрузок";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ChangeAccountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1044, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ChangeAccountToolStripMenuItem
            // 
            ChangeAccountToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            ChangeAccountToolStripMenuItem.Name = "ChangeAccountToolStripMenuItem";
            ChangeAccountToolStripMenuItem.Size = new Size(139, 24);
            ChangeAccountToolStripMenuItem.Text = "Сменить аккаунт";
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 14F);
            labelLogin.Location = new Point(752, 16);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(78, 32);
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
            labelPeriod.Location = new Point(14, 111);
            labelPeriod.Name = "labelPeriod";
            labelPeriod.Size = new Size(83, 25);
            labelPeriod.TabIndex = 3;
            labelPeriod.Text = "Период:";
            // 
            // buttonListWaredhouse
            // 
            buttonListWaredhouse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonListWaredhouse.BackColor = SystemColors.ControlDarkDark;
            buttonListWaredhouse.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonListWaredhouse.Location = new Point(681, 93);
            buttonListWaredhouse.Margin = new Padding(3, 4, 3, 4);
            buttonListWaredhouse.Name = "buttonListWaredhouse";
            buttonListWaredhouse.Padding = new Padding(2, 3, 2, 3);
            buttonListWaredhouse.RightToLeft = RightToLeft.Yes;
            buttonListWaredhouse.Size = new Size(325, 68);
            buttonListWaredhouse.TabIndex = 5;
            buttonListWaredhouse.Text = "Список товаров";
            buttonListWaredhouse.UseVisualStyleBackColor = false;
            buttonListWaredhouse.Click += buttonListWaredhouse_Click;
            // 
            // date1
            // 
            date1.Location = new Point(96, 112);
            date1.Margin = new Padding(3, 4, 3, 4);
            date1.Name = "date1";
            date1.Size = new Size(159, 27);
            date1.TabIndex = 6;
            // 
            // labelПо
            // 
            labelПо.AutoSize = true;
            labelПо.Location = new Point(263, 119);
            labelПо.Name = "labelПо";
            labelПо.Size = new Size(29, 20);
            labelПо.TabIndex = 7;
            labelПо.Text = "По";
            // 
            // date2
            // 
            date2.Location = new Point(296, 112);
            date2.Margin = new Padding(3, 4, 3, 4);
            date2.Name = "date2";
            date2.Size = new Size(159, 27);
            date2.TabIndex = 8;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(480, 115);
            buttonShow.Margin = new Padding(3, 4, 3, 4);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(106, 31);
            buttonShow.TabIndex = 9;
            buttonShow.Text = "Показать";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // comboBoxFiter
            // 
            comboBoxFiter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiter.FormattingEnabled = true;
            comboBoxFiter.Location = new Point(19, 165);
            comboBoxFiter.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiter.Name = "comboBoxFiter";
            comboBoxFiter.Size = new Size(138, 28);
            comboBoxFiter.TabIndex = 10;
            // 
            // labelExportTheReport
            // 
            labelExportTheReport.AutoSize = true;
            labelExportTheReport.Font = new Font("Segoe UI", 18F);
            labelExportTheReport.Location = new Point(19, 475);
            labelExportTheReport.Name = "labelExportTheReport";
            labelExportTheReport.Size = new Size(228, 41);
            labelExportTheReport.TabIndex = 11;
            labelExportTheReport.Text = "Экспорт отчета";
            // 
            // buttonExportTheReport
            // 
            buttonExportTheReport.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            buttonExportTheReport.FlatStyle = FlatStyle.Flat;
            buttonExportTheReport.Font = new Font("Segoe UI", 15F);
            buttonExportTheReport.Location = new Point(19, 519);
            buttonExportTheReport.Name = "buttonExportTheReport";
            buttonExportTheReport.Size = new Size(293, 52);
            buttonExportTheReport.TabIndex = 12;
            buttonExportTheReport.Text = "Экспортировать в json";
            buttonExportTheReport.UseVisualStyleBackColor = true;
            // 
            // HistoryShipmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 598);
            Controls.Add(buttonExportTheReport);
            Controls.Add(labelExportTheReport);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label labelExportTheReport;
        private Button buttonExportTheReport;
    }
}