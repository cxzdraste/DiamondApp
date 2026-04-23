using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamonApp.DataBase;
using DiamondApp.Resourses;
using Draft_Diamond_BD;

namespace DiamonApp.forms
{
    public partial class DeleteCategory : Form
    {
        public string LoginAdmin;
        public DeleteCategory(string loginAdmin)
        {
            InitializeComponent();
            LoginAdmin = loginAdmin;
            comboBoxName.Click += comboBoxName_SelectedIndexChanged;
            buttonDeleteCategory.Click += buttonDeleteCategory_Click;
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxName.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var name in db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory)
                {
                    comboBoxName.Items.Add(name);
                }
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            using (var db = new AllDB())
            {
                if(comboBoxName.SelectedIndex == 0)
                {
                    MessageBox.Show(Resources.EnterTheCategory);
                }
                foreach (var name in db.Products)
                {
                    if (name.Category == comboBoxName.Text)
                    {
                        var product = name;
                        db.Products.Remove(product);
                    }
                }
                db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory.Remove(comboBoxName.Text);
                db.SaveChanges();
                MessageBox.Show($"{Resources.Success}");
                new WarehouseAdmin(LoginAdmin).Show();
                Hide();
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WarehouseAdmin(LoginAdmin).Show();
            Hide();
        }
    }
}
