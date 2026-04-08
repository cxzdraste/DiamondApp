namespace DiamonApp.forms
{
    partial class AddCategory
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
            labelAddCategory = new Label();
            textBoxName = new TextBox();
            labelNameCategory = new Label();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // labelAddCategory
            // 
            labelAddCategory.Anchor = AnchorStyles.Top;
            labelAddCategory.AutoSize = true;
            labelAddCategory.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddCategory.Location = new Point(212, 40);
            labelAddCategory.Name = "labelAddCategory";
            labelAddCategory.Size = new Size(270, 29);
            labelAddCategory.TabIndex = 1;
            labelAddCategory.Text = "Добавить категорию";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BackColor = SystemColors.ControlDarkDark;
            textBoxName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.ForeColor = SystemColors.Window;
            textBoxName.Location = new Point(281, 131);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(201, 27);
            textBoxName.TabIndex = 5;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNameCategory
            // 
            labelNameCategory.Anchor = AnchorStyles.None;
            labelNameCategory.AutoSize = true;
            labelNameCategory.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameCategory.Location = new Point(155, 134);
            labelNameCategory.Name = "labelNameCategory";
            labelNameCategory.Size = new Size(102, 24);
            labelNameCategory.TabIndex = 6;
            labelNameCategory.Text = "Название:";
            labelNameCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ScrollBar;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(232, 287);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(220, 56);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(buttonAdd);
            Controls.Add(labelNameCategory);
            Controls.Add(textBoxName);
            Controls.Add(labelAddCategory);
            Name = "AddCategory";
            Text = "AddCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddCategory;
        private TextBox textBoxName;
        private Label labelNameCategory;
        private Button buttonAdd;
    }
}