using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamondApp.Resourses;
using Draft_Diamond_BD;

namespace DiamonApp.forms.differentFunctionsForms
{

    public partial class CreatingShipmentForm : Form
    {
        private DataGridView dgvWarehouse;
        private string UserLogin;
        public CreatingShipmentForm(string userLogin)
        {
            InitializeComponent();
            UserLogin = userLogin;
            CreateDataGridView();
            LoadProducts();
            comboBoxName.Click += comboBoxName_SelectedIndexChanged;
            comboBoxUniteOfMeasure.Click += comboBoxUniteOfMeasure_SelectedIndexChanged;
            buttonAddToBusket.Click += buttonAddToBusket_Click;
            buttonShipment.Click += buttonShipment_Click;
        }

        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new System.Drawing.Point(470, 120),
                Size = new System.Drawing.Size(500, 350),
                Margin = new Padding(10, 10, 10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
            };
            Controls.Add(dgvWarehouse);
        }

        public void LoadProducts()
        {
            using (var db = new AllDB())
            {
                var shipments = db.ProductsOnShipments.Select(p => new
                {
                    p.Name,
                    p.Count,
                    p.CustomerName,
                    p.CustomerPlace,
                    p.LoginStorekeeper,
                }).ToList();
                dgvWarehouse.DataSource = shipments;
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

        private void buttonAddToBusket_Click(object sender, EventArgs e)
        {
            using (var db = new AllDB())
            {
                if (comboBoxName.SelectedItem == null)
                {
                    MessageBox.Show("Выберите название товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBoxUniteOfMeasure.SelectedItem == null || !(comboBoxUniteOfMeasure.Text == db.Products.FirstOrDefault(p => p.Name == comboBoxName.Text).UniteOfMeasure))
                {
                    MessageBox.Show("Выберите единицу измерения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(numCount.Text, out int quantity) || quantity <= 0 || quantity > db.Products.FirstOrDefault(p => p.Name == comboBoxName.Text).Rest)
                {
                    MessageBox.Show("Введите корректное количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(comboBoxCustomerName.Text))
                {
                    MessageBox.Show("Введите получателя (Кому)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(comboBoxCustomerName.Text))
                {
                    MessageBox.Show("Введите адрес доставки (Куда)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var productOnShipment = new ProductsOnShipmentClass
                (
                    comboBoxName.Text,
                    (int)numCount.Value,
                    numSumProduct.Value,
                    comboBoxCustomerName.Text,
                    comboBoxCustomerPlace.Text,
                    UserLogin
                );
                db.ProductsOnShipments.Add(productOnShipment);
                db.SaveChanges();
                LoadProducts();
            }
        }

        private void buttonShipment_Click(object sender, EventArgs e)
        {
            using (var db = new AllDB()) 
            {
                if (!db.ProductsOnShipments.Any())
                {
                    MessageBox.Show("Корзина пуста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal sumShipment = 0;
                decimal sumProduct = 0;
                var productsNameOnShipment = new StringBuilder();
                foreach(var product in db.ProductsOnShipments)
                {
                    var newProduct = db.Products.FirstOrDefault(p => p.Name == product.Name);
                    newProduct.Rest = newProduct.Rest - (double)numCount.Value;
                    productsNameOnShipment.Append($"{newProduct.Name};");
                    sumShipment += newProduct.Price;
                    sumShipment += numSumProduct.Value;
                    if (newProduct.Rest == 0)
                    {
                        db.ProductsOnShipments.Remove(product);
                    }

                    db.SaveChanges();
                }
                var newHistoryShipment = new HistoryShipment
                    (
                        productsNameOnShipment.ToString(),
                        db.UniteOfMeasures.FirstOrDefault(p => p.UnitesOfMeasure[0] == "Штуки").ToString(),
                        DateTime.Today,
                        (int)numCount.Value,
                        sumShipment,
                        sumProduct - sumShipment,
                        comboBoxCustomerName.Text,
                        comboBoxCustomerPlace.Text,
                        UserLogin
                    );
                db.HistoryShipment.Add(newHistoryShipment);
                db.SaveChanges();
                MessageBox.Show($"{Resources.Success}");
                foreach(var product in db.ProductsOnShipments)
                {
                    db.ProductsOnShipments.Remove(product);
                    db.SaveChanges();
                }
                new WarehouseStorekeeper(UserLogin).Show();
                Close();
            }
        }
    }
}
