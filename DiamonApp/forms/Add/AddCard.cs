using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamondApp.Resourses;

namespace Draft_Diamond_BD
{
    public partial class AddCard : Form
    {
        string LoginAdmin;
        public AddCard(string loginAdmin)
        {
            InitializeComponent();
            comboBoxUniteOfMeasure.Click += comboBoxUniteOfMeasure_SelectedIndexChanged;
            comboBoxCategory.Click += comboBoxCategory_SelectedIndexChanged;
            LoginAdmin = loginAdmin;
        }

        private void comboBoxUniteOfMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUniteOfMeasure.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var unite in db.UniteOfMeasures.FirstOrDefault(p => p.Id == 1).UnitesOfMeasure)
                {
                    comboBoxUniteOfMeasure.Items.Add(unite);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите название товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxUniteOfMeasure.SelectedItem == null)
            {
                MessageBox.Show("Выберите единицу измерения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(numPurchasePrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену закупки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AllDB())
            {
                var newProduct = new ProductClass(
                    textBoxName.Text.Trim(),
                    (string)comboBoxUniteOfMeasure.SelectedItem,
                    price,
                    comboBoxCategory.Text,
                    0,
                    LoginAdmin,
                    DateTime.Today,
                    0,
                    0,
                    0,
                    true
                );

                db.Products.Add(newProduct);
                db.SaveChanges();

                MessageBox.Show($"{Resources.AddProduct}");
                textBoxName.Clear();
                comboBoxUniteOfMeasure.SelectedItem = null;
                Close();
                var newWarehouseAdmin = new WarehouseAdmin(LoginAdmin);
                newWarehouseAdmin.Show();
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var category in db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory)
                {
                    comboBoxCategory.Items.Add(category);
                }
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WarehouseAdmin(LoginAdmin).Show();
            Hide();
        }
    }
}

