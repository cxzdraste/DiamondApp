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
    /// <summary>
    /// Форма создания новой отгрузки товаров
    /// </summary>
    public partial class CreatingShipmentForm : Form
    {
        private DataGridView dgvWarehouse;
        private string UserLogin;

        /// <summary>
        /// Инициализирует форму создания отгрузки
        /// </summary>
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

            Logger.UserAction(UserLogin, "Открыта форма создания отгрузки");
        }

        /// <summary>
        /// Создаёт и настраивает DataGridView для отображения товаров в отгрузке
        /// </summary>
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

        /// <summary>
        /// Загружает список товаров в корзину отгрузки
        /// </summary>
        public void LoadProducts()
        {
            Logger.UserAction(UserLogin, "Загрузка списка отгрузок в DataGridView");
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
                SetupColumns();
            }
        }

        /// <summary>
        /// Настраивает заголовки столбцов DataGridView
        /// </summary>
        private void SetupColumns()
        {
            if (dgvWarehouse.Columns[Resources.NameEng] != null)
                dgvWarehouse.Columns[Resources.NameEng].HeaderText = Resources.NameRus;

            if (dgvWarehouse.Columns[Resources.CountEng] != null)
                dgvWarehouse.Columns[Resources.CountEng].HeaderText = Resources.CountRus;

            if (dgvWarehouse.Columns[Resources.CustomerNameEng] != null)
                dgvWarehouse.Columns[Resources.CustomerNameEng].HeaderText = Resources.CustomerNameRus;

            if (dgvWarehouse.Columns[Resources.CustomerPlaceEng] != null)
                dgvWarehouse.Columns[Resources.CustomerPlaceEng].HeaderText = Resources.CustomerPlaceRus;

            if (dgvWarehouse.Columns[Resources.LoginStorekeeperEng] != null)
                dgvWarehouse.Columns[Resources.LoginStorekeeperEng].HeaderText = Resources.LoginStorekeeperRus;
        }

        /// <summary>
        /// Загружает список товаров в комбобокс
        /// </summary>
        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Загрузка списка товаров в комбобокс");
            comboBoxName.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var cardsName in db.Products)
                {
                    comboBoxName.Items.Add(cardsName.Name);
                }
            }
        }

        /// <summary>
        /// Загружает единицы измерения в комбобокс
        /// </summary>
        private void comboBoxUniteOfMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Загрузка единиц измерения в комбобокс");
            comboBoxUniteOfMeasure.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var unite in db.UniteOfMeasures.FirstOrDefault(p => p.Id == 1).UnitesOfMeasure)
                {
                    comboBoxUniteOfMeasure.Items.Add(unite);
                }
            }
        }

        /// <summary>
        /// Добавляет товар в корзину отгрузки
        /// </summary>
        private void buttonAddToBusket_Click(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Нажата кнопка добавления товара в корзину отгрузки");

            using (var db = new AllDB())
            {
                if (comboBoxName.SelectedItem == null)
                {
                    Logger.UserAction(UserLogin, "Ошибка: не выбрано название товара");
                    MessageBox.Show(Resources.EnterProductName);
                    return;
                }

                if (comboBoxUniteOfMeasure.SelectedItem == null || !(comboBoxUniteOfMeasure.Text == db.Products.FirstOrDefault(p => p.Name == comboBoxName.Text).UniteOfMeasure))
                {
                    Logger.UserAction(UserLogin, "Ошибка: не выбрана единица измерения или не соответствует товару");
                    MessageBox.Show(Resources.ChoseUniteOfMeasure);
                    return;
                }

                if (!int.TryParse(numCount.Text, out int quantity) || quantity <= 0 || quantity > db.Products.FirstOrDefault(p => p.Name == comboBoxName.Text).Rest)
                {
                    Logger.UserAction(UserLogin, $"Ошибка: некорректное количество '{numCount.Text}'");
                    MessageBox.Show(Resources.NumberCount);
                    return;
                }

                if (string.IsNullOrWhiteSpace(comboBoxCustomerName.Text))
                {
                    Logger.UserAction(UserLogin, "Ошибка: не указан получатель");
                    MessageBox.Show(Resources.EnterRecipient);
                    return;
                }

                if (string.IsNullOrWhiteSpace(comboBoxCustomerName.Text))
                {
                    Logger.UserAction(UserLogin, "Ошибка: не указан адрес доставки");
                    MessageBox.Show(Resources.EnterAddressDelivery);
                    return;
                }

                Logger.UserAction(UserLogin, $"Добавление товара в корзину: '{comboBoxName.Text}', Количество: {numCount.Value}, Получатель: '{comboBoxCustomerName.Text}'");

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

                Logger.UserAction(UserLogin, $"Товар '{comboBoxName.Text}' успешно добавлен в корзину отгрузки");
                LoadProducts();
            }
        }

        /// <summary>
        /// Выполняет отгрузку товаров и сохраняет в историю
        /// </summary>
        private void buttonShipment_Click(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Нажата кнопка отгрузки товаров");

            using (var db = new AllDB())
            {
                if (!db.ProductsOnShipments.Any())
                {
                    Logger.UserAction(UserLogin, "Ошибка: корзина отгрузки пуста");
                    MessageBox.Show(Resources.BusketIsEmpty);
                    return;
                }

                decimal sumShipment = 0;
                decimal sumProduct = 0;
                var productsNameOnShipment = new StringBuilder();
                int shippedCount = 0;

                foreach (var product in db.ProductsOnShipments)
                {
                    var newProduct = db.Products.FirstOrDefault(p => p.Name == product.Name);
                    if (newProduct != null)
                    {
                        newProduct.Rest = newProduct.Rest - (double)numCount.Value;
                        productsNameOnShipment.Append($"{newProduct.Name};");
                        sumShipment += newProduct.PurchasePrice;
                        sumShipment += numSumProduct.Value;
                        shippedCount++;

                        if (newProduct.Rest == 0)
                        {
                            db.ProductsOnShipments.Remove(product);
                        }
                    }
                    db.SaveChanges();
                }

                Logger.UserAction(UserLogin, $"Отгружено товаров: {shippedCount}, Общая сумма: {sumShipment}");

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

                Logger.UserAction(UserLogin, $"Отгрузка успешно завершена и добавлена в историю");

                MessageBox.Show($"{Resources.Success}");
                foreach (var product in db.ProductsOnShipments)
                {
                    db.ProductsOnShipments.Remove(product);
                    db.SaveChanges();
                }
                new WarehouseStorekeeper(UserLogin).Show();
                Close();
            }
        }

        /// <summary>
        /// Возврат на форму кладовщика
        /// </summary>
        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Возврат на форму WarehouseStorekeeper из формы создания отгрузки");
            new WarehouseStorekeeper(UserLogin).Show();
            Hide();
        }
    }
}