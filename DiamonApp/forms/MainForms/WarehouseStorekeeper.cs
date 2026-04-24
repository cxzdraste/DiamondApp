using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamonApp.forms.differentFunctionsForms;
using DiamondApp.forms.differentFunctionsForms;
using DiamondApp.Resourses;
using System.Data;

namespace Draft_Diamond_BD
{
    /// <summary>
    /// Форма кладовщика
    /// </summary>
    public partial class WarehouseStorekeeper : Form
    {
        private DataGridView dgvWarehouseTrue;
        private DataGridView dgvWarehouseFalse;
        private string userLogin;

        /// <summary>
        /// Инициализирует форму кладовщика
        /// </summary>
        public WarehouseStorekeeper(string login)
        {
            InitializeComponent();
            userLogin = login;
            labelLogin.Text = Resources.LoginInMenu + userLogin;
            FilterProducts();
            CreateDataGridViewTrue();
            CreateDataGridViewFalse();
            LoadProductsTrue();
            весьСкладToolStripMenuItem.Click += (s, e) => LoadProductsTrue();
            exitToolStripMenuItemOutput.Click += Exit_Click;
            createShipmentToolStripMenuItem.Click += CreateShipmentToolStripMenuItem_Click;
            сменитьАккаунтToolStripMenuItem.Click += changeAccountToolStripMenuItem_Click;

            Logger.UserAction(userLogin, "Открыта форма кладовщика");
        }

        /// <summary>
        /// Создаёт DataGridView для просроченных товаров
        /// </summary>
        private void CreateDataGridViewTrue()
        {
            dgvWarehouseFalse = new DataGridView
            {
                Location = new System.Drawing.Point(10, 450),
                Size = new System.Drawing.Size(820, 250),
                Margin = new Padding(10, 10, 10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
            };
            Controls.Add(dgvWarehouseFalse);
        }

        /// <summary>
        /// Создаёт DataGridView для активных товаров
        /// </summary>
        private void CreateDataGridViewFalse()
        {
            dgvWarehouseTrue = new DataGridView
            {
                Location = new System.Drawing.Point(10, 120),
                Size = new System.Drawing.Size(820, 250),
                Margin = new Padding(10, 10, 10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
            };
            Controls.Add(dgvWarehouseTrue);
        }

        /// <summary>
        /// Фильтрация товаров по категориям в меню
        /// </summary>
        private void FilterProducts()
        {
            Logger.UserAction(userLogin, "Фильтрация продуктов по категориям");
            using (var db = new AllDB())
            {
                var categoriesBases = db.Categories.ToList();

                for (var i = 0; i < categoriesBases.Count; i++)
                {
                    var categories = categoriesBases[i].NamesOfCategory;
                    foreach (var category in categories)
                    {
                        var alreadyExists = false;
                        foreach (ToolStripMenuItem existingItem in категорииToolStripMenuItem.DropDownItems)
                        {
                            if (existingItem.Text == category)
                            {
                                alreadyExists = true;
                                break;
                            }
                        }
                        if (alreadyExists)
                        {
                            continue;
                        }
                        var menuItem = new ToolStripMenuItem(category);
                        menuItem.Click += (s, e) =>
                        {
                            Logger.UserAction(userLogin, $"Фильтрация по категории: {category}");
                            using (var db = new AllDB())
                            {
                                var products = db.Products.Where(p => p.Category == category).Select(p => new
                                {
                                    p.Name,
                                    p.UniteOfMeasure,
                                    p.PurchasePrice,
                                    p.Category,
                                    p.Rest,
                                    p.Creator,
                                }).ToList();
                                dgvWarehouseTrue.DataSource = products;
                            }
                        };
                        категорииToolStripMenuItem.DropDownItems.Add(menuItem);
                    }
                }
            }
        }

        /// <summary>
        /// Проверяет и обновляет статус просроченных товаров
        /// </summary>
        private void ExpirationDateCheck()
        {
            using (var db = new AllDB())
            {
                foreach (var product in db.Products)
                {
                    if (product.EndDateOfTheDay < DateTime.Today)
                    {
                        product.Status = false;
                        Logger.UserAction(userLogin, $"Товар '{product.Name}' просрочен. Статус изменён на false");
                        db.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Загружает активные товары
        /// </summary>
        public void LoadProductsTrue()
        {
            Logger.UserAction(userLogin, "Загрузка активных товаров");
            using (var db = new AllDB())
            {
                ExpirationDateCheck();
                var productsTrue = db.Products.Where(p => p.Status == true).Select(p => new
                {
                    p.Name,
                    p.UniteOfMeasure,
                    p.PurchasePrice,
                    p.Category,
                    p.Rest,
                    p.EndDateOfTheDay,
                    p.UntilTheEndOfTheSeason,
                    p.Discount,
                    p.FinalyPrice,
                }).ToList();
                dgvWarehouseTrue.DataSource = productsTrue;
                SetupColumnsTrue();
                LoadProductsFalse();
            }
        }

        /// <summary>
        /// Настраивает заголовки столбцов для активных товаров
        /// </summary>
        private void SetupColumnsTrue()
        {
            if (dgvWarehouseTrue.Columns[Resources.NameEng] != null)
                dgvWarehouseTrue.Columns[Resources.NameEng].HeaderText = Resources.NameRus;

            if (dgvWarehouseTrue.Columns[Resources.UniteOfMeasureEng] != null)
                dgvWarehouseTrue.Columns[Resources.UniteOfMeasureEng].HeaderText = Resources.UniteOfMeasureRus;

            if (dgvWarehouseTrue.Columns[Resources.PurchasePriceEng] != null)
                dgvWarehouseTrue.Columns[Resources.PurchasePriceEng].HeaderText = Resources.PurchasePriceRus;

            if (dgvWarehouseTrue.Columns[Resources.CategoryEng] != null)
                dgvWarehouseTrue.Columns[Resources.CategoryEng].HeaderText = Resources.CategoryRus;

            if (dgvWarehouseTrue.Columns[Resources.RestEng] != null)
                dgvWarehouseTrue.Columns[Resources.RestEng].HeaderText = Resources.RestRus;

            if (dgvWarehouseTrue.Columns[Resources.EndDateOfTheDayEng] != null)
                dgvWarehouseTrue.Columns[Resources.EndDateOfTheDayEng].HeaderText = Resources.EndDateOfTheDayRus;

            if (dgvWarehouseTrue.Columns[Resources.UntilTheEndOfTheSeasonEng] != null)
                dgvWarehouseTrue.Columns[Resources.UntilTheEndOfTheSeasonEng].HeaderText = Resources.UntilTheEndOfTheSeasonRus;

            if (dgvWarehouseTrue.Columns[Resources.DiscountEng] != null)
                dgvWarehouseTrue.Columns[Resources.DiscountEng].HeaderText = Resources.DiscountRus;

            if (dgvWarehouseTrue.Columns[Resources.FinalyPriceEng] != null)
                dgvWarehouseTrue.Columns[Resources.FinalyPriceEng].HeaderText = Resources.FinalyPriceRus;
        }

        /// <summary>
        /// Загружает просроченные товары
        /// </summary>
        public void LoadProductsFalse()
        {
            Logger.UserAction(userLogin, "Загрузка просроченных товаров");
            using (var db = new AllDB())
            {
                var productsFalse = db.Products.Where(p => p.Status == false);
                if (productsFalse.Any())
                {
                    var productsload = productsFalse.Select(p => new
                    {
                        p.Name,
                        p.UniteOfMeasure,
                        p.Category,
                        p.Rest,
                        p.EndDateOfTheDay,
                        p.FinalyPrice,
                    }).ToList();
                    dgvWarehouseFalse.DataSource = productsload;
                    SetupColumnsFalse();
                }
                decimal sum = 0;
                foreach (var product in productsFalse)
                {
                    sum += product.FinalyPrice;
                }
                labelResult.Text = Resources.Result + sum;
                Logger.UserAction(userLogin, $"Сумма просроченных товаров: {sum}");
            }
        }

        /// <summary>
        /// Настраивает заголовки столбцов для просроченных товаров
        /// </summary>
        private void SetupColumnsFalse()
        {
            if (dgvWarehouseFalse.Columns[Resources.NameEng] != null)
                dgvWarehouseFalse.Columns[Resources.NameEng].HeaderText = Resources.NameRus;

            if (dgvWarehouseFalse.Columns[Resources.UniteOfMeasureEng] != null)
                dgvWarehouseFalse.Columns[Resources.UniteOfMeasureEng].HeaderText = Resources.UniteOfMeasureRus;

            if (dgvWarehouseFalse.Columns[Resources.CategoryEng] != null)
                dgvWarehouseFalse.Columns[Resources.CategoryEng].HeaderText = Resources.CategoryRus;

            if (dgvWarehouseFalse.Columns[Resources.FinalyPriceEng] != null)
                dgvWarehouseFalse.Columns[Resources.FinalyPriceEng].HeaderText = Resources.FinalyPriceFalseRus;

            if (dgvWarehouseFalse.Columns[Resources.RestEng] != null)
                dgvWarehouseFalse.Columns[Resources.RestEng].HeaderText = Resources.RestRus;

            if (dgvWarehouseFalse.Columns[Resources.EndDateOfTheDayEng] != null)
                dgvWarehouseFalse.Columns[Resources.EndDateOfTheDayEng].HeaderText = Resources.EndDateOfTheDayRus;
        }

        /// <summary>
        /// Открывает форму создания отгрузки
        /// </summary>
        private void CreateShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Открытие формы создания отгрузки");
            var createform = new CreatingShipmentForm(userLogin);
            createform.Show();
            Hide();
        }

        /// <summary>
        /// Выход из приложения
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Выход из приложения");
            Application.Exit();
        }

        /// <summary>
        /// Смена аккаунта
        /// </summary>
        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Смена аккаунта");
            var newAuthorization = new Authorization();
            newAuthorization.Show();
            Close();
        }

        /// <summary>
        /// Фильтрация просроченных товаров по категории
        /// </summary>
        private void comboBoxFiterProductFalse_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFiterProductFalse.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var category in db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory)
                {
                    comboBoxFiterProductFalse.Items.Add(category);
                }
                comboBoxFiterProductFalse.SelectedIndexChanged += (s, e) =>
                {
                    Logger.UserAction(userLogin, $"Фильтрация просроченных товаров по категории: {comboBoxFiterProductFalse.SelectedItem}");
                    using (var db = new AllDB())
                    {
                        var selectedCategory = comboBoxFiterProductFalse.SelectedItem.ToString();
                        var products = db.Products.Where(p => p.Category == selectedCategory && p.Status == false).Select(p => new
                        {
                            p.Name,
                            p.UniteOfMeasure,
                            p.Category,
                            p.Rest,
                            p.EndDateOfTheDay,
                            p.FinalyPrice,
                        }).ToList();
                        if (!products.Any())
                        {
                            MessageBox.Show(Resources.FalseProductNotExist);
                            return;
                        }
                        dgvWarehouseFalse.DataSource = products;
                        SetupColumnsFalse();
                    }
                    ;
                };
            }
        }

        /// <summary>
        /// Открывает форму приёмки поставки
        /// </summary>
        private void принятьПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Открытие формы приёмки поставки");
            var newAcceptanceOfGoods = new AcceptanceOfGoodsForm(userLogin);
            newAcceptanceOfGoods.Show();
            Hide();
        }
    }
}