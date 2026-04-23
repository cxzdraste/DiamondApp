using DiamonApp.DataBase;
using DiamondApp.Resourses;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    public partial class ChangeCard : Form
    {
        public string LoginAdmin;
        public ChangeCard(string loginAdmin)
        {
            InitializeComponent();
            comboBoxName.Click += comboBoxName_SelectedIndexChanged;
            comboBoxUniteOfMeasure.Click += comboBoxUniteOfMeasure_SelectedIndexChanged;
            buttonChange.Click += buttonChange_Click;
            LoginAdmin = loginAdmin;
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            using (var db = new AllDB())
            {
                var product = db.Products.FirstOrDefault(p => p.Name == comboBoxName.Text);

                if (product != null)
                {
                    product.PurchasePrice = Convert.ToDecimal(numePurchasePrise.Text);

                    if (comboBoxUniteOfMeasure.SelectedItem != null)
                    {
                        product.UniteOfMeasure = (string)comboBoxUniteOfMeasure.SelectedItem;
                    }

                    db.SaveChanges();
                    MessageBox.Show($"{Resources.Success}");
                    new WarehouseAdmin(LoginAdmin).Show();
                    Close();
                }
                else
                {
                    MessageBox.Show(Resources.NotDatabase);
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

