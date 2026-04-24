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
    /// <summary>
    /// Форма приёмки товаров на склад
    /// </summary>
    public partial class AcceptanceOfGoodsForm : Form
    {
        private DataGridView dgvWarehouse;
        private string UserLogin;

        /// <summary>
        /// Инициализирует форму приёмки товаров
        /// </summary>
        public AcceptanceOfGoodsForm(string userLogin)
        {
            InitializeComponent();
            UserLogin = userLogin;
            labelLogin.Text = Resources.LoginInMenu + userLogin;
            CreateDataGridView();
            LoadProducts();
            comboBoxName.Click += comboBoxName_SelectedIndexChanged;

            Logger.UserAction(UserLogin, "Открыта форма приёмки товаров");
        }

        /// <summary>
        /// Создаёт и настраивает DataGridView для отображения товаров
        /// </summary>
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

        /// <summary>
        /// Загружает список принятых товаров в таблицу
        /// </summary>
        public void LoadProducts()
        {
            Logger.UserAction(UserLogin, "Загрузка списка товаров в DataGridView");
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

        /// <summary>
        /// Настраивает заголовки столбцов DataGridView
        /// </summary>
        private void SetupColumns()
        {
            if (dgvWarehouse.Columns[Resources.NameEng] != null)
                dgvWarehouse.Columns[Resources.NameEng].HeaderText = Resources.NameRus;

            if (dgvWarehouse.Columns[Resources.CountEng] != null)
                dgvWarehouse.Columns[Resources.CountEng].HeaderText = Resources.CountRus;

            if (dgvWarehouse.Columns[Resources.PriceEng] != null)
                dgvWarehouse.Columns[Resources.PriceEng].HeaderText = Resources.PriceRus;

            if (dgvWarehouse.Columns[Resources.ProviderNameEng] != null)
                dgvWarehouse.Columns[Resources.ProviderNameEng].HeaderText = Resources.ProviderNameRus;

            if (dgvWarehouse.Columns[Resources.LoginEmployeeEng] != null)
                dgvWarehouse.Columns[Resources.LoginEmployeeEng].HeaderText = Resources.LoginEmployeeRus;
        }

        /// <summary>
        /// Добавляет товар в корзину приёмки
        /// </summary>
        private void buttonAddToBusket_Click(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Нажата кнопка добавления товара в корзину приёмки");

            using (var db = new AllDB())
            {
                if (comboBoxName.SelectedItem == null)
                {
                    Logger.UserAction(UserLogin, "Ошибка: не выбрано название товара");
                    MessageBox.Show(Resources.EnterProductName);
                    return;
                }

                if (!int.TryParse(numCount.Text, out int quantity) || quantity <= 0)
                {
                    Logger.UserAction(UserLogin, $"Ошибка: некорректное количество '{numCount.Text}'");
                    MessageBox.Show(Resources.NumberCount);
                    return;
                }

                if (string.IsNullOrWhiteSpace(comboBoxProviderName.Text))
                {
                    Logger.UserAction(UserLogin, "Ошибка: не указан поставщик");
                    MessageBox.Show(Resources.EnterTheProvider);
                    return;
                }

                if (!int.TryParse(numPrice.Text, out int quant) || quant <= 0)
                {
                    Logger.UserAction(UserLogin, $"Ошибка: некорректная цена '{numPrice.Text}'");
                    MessageBox.Show(Resources.PurchasePrice);
                    return;
                }

                Logger.UserAction(UserLogin, $"Добавление товара: '{comboBoxName.Text}', Количество: {numCount.Value}, Цена: {numPrice.Value}, Поставщик: '{comboBoxProviderName.Text}'");

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

                Logger.UserAction(UserLogin, $"Товар '{comboBoxName.Text}' успешно добавлен в корзину приёмки");
                LoadProducts();
            }
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
        /// Смена аккаунта
        /// </summary>
        private void сменитьАккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Смена аккаунта из формы приёмки товаров");
            var newAuthorizationForm = new Authorization();
            newAuthorizationForm.Show();
            Hide();
        }

        /// <summary>
        /// Подтверждает приёмку товаров и обновляет склад
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Нажата кнопка подтверждения приёмки товаров");

            using (var db = new AllDB())
            {
                if (!db.ProductsOnAcceptance.Any())
                {
                    Logger.UserAction(UserLogin, "Ошибка: корзина приёмки пуста");
                    MessageBox.Show(Resources.BusketIsEmpty);
                    return;
                }

                int acceptedCount = 0;
                foreach (var product in db.ProductsOnAcceptance)
                {
                    var newProduct = db.Products.FirstOrDefault(p => p.Name == product.Name);
                    if (newProduct != null)
                    {
                        newProduct.Rest += product.Count;
                        newProduct.PurchasePrice = product.Price;
                        acceptedCount++;
                    }
                }
                db.SaveChanges();

                Logger.UserAction(UserLogin, $"Подтверждена приёмка товаров. Принято позиций: {acceptedCount}");

                MessageBox.Show(Resources.Success);

                foreach (var product in db.ProductsOnAcceptance)
                {
                    db.ProductsOnAcceptance.Remove(product);
                }
                db.SaveChanges();
                LoadProducts();
            }
        }

        /// <summary>
        /// Возврат на предыдущую форму
        /// </summary>
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Возврат на предыдущую форму из формы приёмки товаров");
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

        /// <summary>
        /// Импорт товаров из JSON файла
        /// </summary>
        private void buttonImport_Click(object sender, EventArgs e)
        {
            Logger.UserAction(UserLogin, "Нажата кнопка импорта товаров из JSON");

            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Logger.UserAction(UserLogin, $"Выбран файл: {openFileDialog.FileName}");

                        string jsonContent = File.ReadAllText(openFileDialog.FileName);
                        var products = JsonConvert.DeserializeObject<List<ProductsOnAcceptanceClass>>(jsonContent);

                        Logger.UserAction(UserLogin, $"Найдено товаров в JSON: {products?.Count ?? 0}");

                        using (var db = new AllDB())
                        {
                            foreach (var product in products)
                            {
                                db.ProductsOnAcceptance.Add(new ProductsOnAcceptanceClass
                                {
                                    Name = product.Name,
                                    Count = product.Count,
                                    Price = product.Price,
                                    ProviderName = product.ProviderName,
                                    LoginEmployee = UserLogin,
                                });
                            }
                            db.SaveChanges();
                        }

                        Logger.UserAction(UserLogin, $"Импортировано {products?.Count ?? 0} товаров из JSON");
                        MessageBox.Show($"{Resources.Import}: {products?.Count ?? 0} {Resources.Products}");
                        LoadProducts();
                    }
                    catch (Exception ex)
                    {
                        Logger.UserAction(UserLogin, $"Ошибка при импорте JSON: {ex.Message}");
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }
    }
}