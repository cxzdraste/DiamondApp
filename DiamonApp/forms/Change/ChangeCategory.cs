using DiamonApp.DataBase;
using DiamondApp.Resourses;
using Draft_Diamond_BD;

namespace DiamonApp.forms
{
    public partial class ChangeCategory : Form
    {
        public string LoginAdmin;
        public ChangeCategory(string loginAdmin)
        {
            InitializeComponent();
            comboBoxOldName.Click += comboBoxOldName_SelectedIndexChanged;
            buttonChangeCategory.Click += buttonChangeCategory_Click;
            LoginAdmin = loginAdmin;
        }

        private void comboBoxOldName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxOldName.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var item in db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory)
                {
                    comboBoxOldName.Items.Add(item);
                }
            }
        }

        private void buttonChangeCategory_Click(object sender, EventArgs e)
        {
            if (comboBoxOldName.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBoxNewName.Text))
            {
                MessageBox.Show("Введите новое название категории", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string oldCategory = comboBoxOldName.SelectedItem.ToString();
            string newCategory = comboBoxNewName.Text.Trim();

            using (var db = new AllDB())
            {
                var categoryDb = db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory;
                var index = categoryDb.IndexOf(oldCategory);
                categoryDb[index] = newCategory;

                var products = db.Products.ToList();
                foreach (var product in products)
                {
                    if (product.Category == oldCategory)
                    {
                        product.Category = newCategory;
                    }
                }

                db.SaveChanges();

                MessageBox.Show($"{Resources.Success}");
                new WarehouseAdmin(LoginAdmin).Show();
                Close();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WarehouseAdmin(LoginAdmin).Show();
            Hide();
        }
    }
}
