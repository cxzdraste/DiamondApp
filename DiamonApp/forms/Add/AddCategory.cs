using DiamonApp.DataBase;
using DiamonApp.Resourses;
using Draft_Diamond_BD;

namespace DiamonApp.forms
{
    public partial class AddCategory : Form
    {
        public string LoginAdmin;
        public AddCategory(string loginAdmin)
        {
            InitializeComponent();
            buttonAdd.Click += buttonAddCategory_Click;
            LoginAdmin = loginAdmin;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var newCategory = textBoxName.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show($"Введите название категории");
                return;
            }
            using(var db = new AllDB())
            {
                var flag = false;
                foreach(var category in db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory)
                {
                    if (newCategory == category.ToLower())
                    {
                        flag = true; break;
                    }
                }
                if (flag) { MessageBox.Show("Категория уже существует"); return; }
                db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory.Add(textBoxName.Text.Trim());
                MessageBox.Show(Resources.Success);
                new WarehouseAdmin(LoginAdmin).Show();
                db.SaveChanges();
                Close();
            }
        }
    }
}
