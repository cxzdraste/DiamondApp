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
    public partial class DeleteCard : Form
    {
        public string LoginAdmin;
        public DeleteCard(string loginAdmin)
        {
            InitializeComponent();
            LoginAdmin = loginAdmin;
            comboBoxName.Click += comboBoxName_SelectedIndexChanged;
            buttonDeleteCategory.Click += buttonDeleteCategory_Click;
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            using (var db = new AllDB())
            {
                var id = new Guid();
                foreach (var name in db.Products.ToList())
                {
                    if(name.Name == comboBoxName.Text)
                    {
                        id = name.Id;
                        break;
                    }
                }
                var card = db.Products.FirstOrDefault(p => p.Id == id);
                db.Products.Remove(card);
                db.SaveChanges();
                MessageBox.Show($"{Resources.Success}");
                new WarehouseAdmin(LoginAdmin).Show();
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxName.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var name in db.Products)
                {
                    comboBoxName.Items.Add(name.Name);
                }
            }
        }
    }
}
