using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamonApp.Enums;
using DiamondApp.classes;
using DiamondApp.Resourses;
using Draft_Diamond_BD;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiamondApp.forms.differentFunctionsForms
{
    public partial class AcceptanceOfGoodsForm : Form
    {
        private DataGridView dgvWarehouse;
        private string UserLogin;
        public AcceptanceOfGoodsForm(string userLogin)
        {
            InitializeComponent();
            UserLogin = userLogin;
            labelLogin.Text = Resources.LoginInMenu + userLogin;
            CreateDataGridView();
            LoadProducts();
            comboBoxName.Click += comboBoxName_SelectedIndexChanged;
        }

        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new System.Drawing.Point(510, 120),
                Size = new System.Drawing.Size(600, 350),
                Margin = new Padding(10, 10, 10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
                Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left,
            };
            Controls.Add(dgvWarehouse);
        }

        public void LoadProducts()
        {
            using (var db = new AllDB())
            {
                var acceptance = db.ProductsOnAcceptance.Select(p => new
                {
                    p.Name,
                    p.Count,
                    p.Price,
                    p.ProviderName,
                    p.LoginEmployee,
                }).ToList();
                dgvWarehouse.DataSource = acceptance;
                SetupColumns();
            }
        }
        private void SetupColumns()
        {
            if (dgvWarehouse.Columns["Name"] != null)
                dgvWarehouse.Columns["Name"].HeaderText = "Имя";

            if (dgvWarehouse.Columns["Count"] != null)
                dgvWarehouse.Columns["Count"].HeaderText = "Количество";

            if (dgvWarehouse.Columns["Price"] != null)
                dgvWarehouse.Columns["Price"].HeaderText = "Цена закупки";

            if (dgvWarehouse.Columns["ProviderName"] != null)
                dgvWarehouse.Columns["ProviderName"].HeaderText = "Поставщик";

            if (dgvWarehouse.Columns["LoginEmployee"] != null)
                dgvWarehouse.Columns["LoginEmployee"].HeaderText = "Кто принял";
        }

        private void buttonAddToBusket_Click(object sender, EventArgs e)
        {
            using (var db = new AllDB())
            {
                if (comboBoxName.SelectedItem == null)
                {
                    MessageBox.Show(Resources.EnterProductName);
                    return;
                }

                if (!int.TryParse(numCount.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show(Resources.NumberCount);
                    return;
                }

                if (string.IsNullOrWhiteSpace(comboBoxProviderName.Text))
                {
                    MessageBox.Show(Resources.EnterTheProvider);
                    return;
                }

                if (!int.TryParse(numPrice.Text, out int quant) || quant <= 0)
                {
                    MessageBox.Show(Resources.PurchasePrice);
                    return;
                }

                var productOnAcceptance = new ProductsOnAcceptanceClass
                (
                    comboBoxName.Text,
                    (double)numCount.Value,
                    numPrice.Value,
                    comboBoxProviderName.Text,
                    UserLogin
                );
                db.ProductsOnAcceptance.Add(productOnAcceptance);
                db.SaveChanges();
                LoadProducts();
            }
        }
        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxName.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var cardsName in db.Products)
                {
                    comboBoxName.Items.Add(cardsName.Name);
                }
            }
        }

        private void сменитьАккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAuthorizationForm = new Authorization();
            newAuthorizationForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AllDB())
            {
                if (!db.ProductsOnAcceptance.Any())
                {
                    MessageBox.Show(Resources.BusketIsEmpty);
                    return;
                }
                foreach (var product in db.ProductsOnAcceptance)
                {
                    var newProduct = db.Products.FirstOrDefault(p => p.Name == product.Name);
                    newProduct.Rest += (double)numCount.Value;
                    newProduct.PurchasePrice = product.Price;
                    db.SaveChanges();
                }
                MessageBox.Show(Resources.Success);
                foreach (var product in db.ProductsOnAcceptance)
                {
                    db.ProductsOnAcceptance.Remove(product);
                    db.SaveChanges();
                }
                LoadProducts();
            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new AllDB())
            {
                foreach (var emp in db.Employess)
                {
                    if (emp.Login == UserLogin)
                    {
                        if (emp.Job == JobsEnumcs.Administrator)
                        {
                            new WarehouseAdmin(UserLogin).Show();
                            Hide();
                            break;
                        }
                        new WarehouseStorekeeper(UserLogin).Show();
                        Hide();
                        break;
                    }
                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(openFileDialog.FileName);
                        var products = JsonConvert.DeserializeObject<List<ProductsOnAcceptanceClass>>(jsonContent);

                        using (var db = new AllDB())
                        {
                            foreach (var product in products)
                            {
                                db.ProductsOnAcceptance.Add( new ProductsOnAcceptanceClass
                                {
                                    Name = product.Name,
                                    Count = product.Count,
                                    Price = product.Price,
                                    ProviderName = product.ProviderName,
                                    LoginEmployee = UserLogin,
                                });
                                db.SaveChanges();
                            }
                        }
                        MessageBox.Show($"{Resources.Import}: {products.Count} {Resources.Products}");
                        LoadProducts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }
    }
}
