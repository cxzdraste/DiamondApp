namespace DiamonApp.forms
{
    partial class DeleteCategory
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
            labelNameCategory = new Label();
            comboBoxName = new ComboBox();
            buttonDeleteCategory = new Button();
            SuspendLayout();
            // 
            // labelDeleteCategory
            // 
            labelDeleteCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDeleteCategory.AutoSize = true;
            labelDeleteCategory.Font = new Font("Microsoft Sans Serif", 18F);
            labelDeleteCategory.Location = new Point(204, 28);
            labelDeleteCategory.Name = "labelDeleteCategory";
            labelDeleteCategory.Size = new Size(241, 29);
            labelDeleteCategory.TabIndex = 2;
            labelDeleteCategory.Text = "Удалить категорию";
            // 
            // labelNameCategory
            // 
            labelNameCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNameCategory.AutoSize = true;
            labelNameCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameCategory.Location = new Point(114, 152);
            labelNameCategory.Name = "labelNameCategory";
            labelNameCategory.Size = new Size(91, 40);
            labelNameCategory.TabIndex = 17;
            labelNameCategory.Text = "Название \r\nкатегории:";
            // 
            // comboBoxName
            // 
            comboBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxName.BackColor = SystemColors.ControlDarkDark;
            comboBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(234, 153);
            comboBoxName.Margin = new Padding(3, 2, 3, 2);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(190, 23);
            comboBoxName.TabIndex = 18;
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDeleteCategory.BackColor = SystemColors.ScrollBar;
            buttonDeleteCategory.FlatStyle = FlatStyle.Flat;
            buttonDeleteCategory.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteCategory.Location = new Point(204, 331);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(194, 46);
            buttonDeleteCategory.TabIndex = 19;
            buttonDeleteCategory.Text = "Удалить";
            buttonDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // DeleteCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 450);
            Controls.Add(buttonDeleteCategory);
            Controls.Add(comboBoxName);
            Controls.Add(labelNameCategory);
            Controls.Add(labelDeleteCategory);
            Name = "DeleteCategory";
            Text = "Удалить категорию";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDeleteCategory;
        private Label labelNameCategory;
        private ComboBox comboBoxName;
        private Button buttonDeleteCategory;
    }
}