namespace DiamonApp.forms
{
    partial class DeleteCard
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
            labelDeleteCategory = new Label();
            label1 = new Label();
            comboBoxName = new ComboBox();
            buttonDeleteCategory = new Button();
            SuspendLayout();
            // 
            // labelDeleteCategory
            // 
            labelDeleteCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDeleteCategory.AutoSize = true;
            labelDeleteCategory.Font = new Font("Microsoft Sans Serif", 18F);
            labelDeleteCategory.Location = new Point(200, 25);
            labelDeleteCategory.Name = "labelDeleteCategory";
            labelDeleteCategory.Size = new Size(220, 29);
            labelDeleteCategory.TabIndex = 1;
            labelDeleteCategory.Text = "Удалить карточку";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(142, 143);
            label1.Name = "label1";
            label1.Size = new Size(87, 40);
            label1.TabIndex = 16;
            label1.Text = "Название \r\nкарточки:";
            // 
            // comboBoxName
            // 
            comboBoxName.BackColor = SystemColors.ControlDarkDark;
            comboBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(261, 160);
            comboBoxName.Margin = new Padding(3, 2, 3, 2);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(190, 23);
            comboBoxName.TabIndex = 17;
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.BackColor = SystemColors.ScrollBar;
            buttonDeleteCategory.FlatStyle = FlatStyle.Flat;
            buttonDeleteCategory.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteCategory.Location = new Point(212, 276);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(194, 46);
            buttonDeleteCategory.TabIndex = 18;
            buttonDeleteCategory.Text = "Удалить";
            buttonDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // DeleteCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 450);
            Controls.Add(buttonDeleteCategory);
            Controls.Add(comboBoxName);
            Controls.Add(label1);
            Controls.Add(labelDeleteCategory);
            Name = "DeleteCard";
            Text = "Удалить карточку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDeleteCategory;
        private Label label1;
        private ComboBox comboBoxName;
        private Button buttonDeleteCategory;
    }
}