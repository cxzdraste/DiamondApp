using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamonApp.forms;
using DiamonApp.forms.differentFunctionsForms;
using DiamondApp.forms.differentFunctionsForms;
using DiamondApp.Resourses;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Draft_Diamond_BD
{
    /// <summary>
    /// Форма администратора склада
    /// </summary>
    public partial class WarehouseAdmin : Form
    {
        private DataGridView dgvWarehouseTrue;
        private DataGridView dgvWarehouseFalse;
        private string userLogin;

        /// <summary>
        /// Инициализирует форму администратора склада
        /// </summary>
        public WarehouseAdmin(string login)
        {
            InitializeComponent();
            userLogin = login;
            labelLogin.Text = Resources.LoginInMenu + userLogin;
            CreateDataGridViewTrue();
            CreateDataGridViewFalse();
            LoadProductsTrue();
            FilterProducts();
            весьСкладToolStripMenuItem.Click += (s, a) => LoadProductsTrue();
            exitToolStripMenuItemOutput.Click += Exit_Click;
            addCardToolStripMenuItem.Click += AddCardToolStripMenuItem_Click;

            Logger.UserAction(userLogin, "Открыта форма администратора склада");
        }

        /// <summary>
        /// Создаёт DataGridView для активных товаров
        /// </summary>
        private void CreateDataGridViewTrue()
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
        /// Создаёт DataGridView для просроченных товаров
        /// </summary>
        private void CreateDataGridViewFalse()
        {
            dgvWarehouseFalse = new DataGridView
            {
                Location = new System.Drawing.Point(10, 670),
                Size = new System.Drawing.Size(820, 250),
                Margin = new Padding(10, 10, 10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
            };
            Controls.Add(dgvWarehouseFalse);
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
        /// Проверяет и применяет скидки к активным товарам
        /// </summary>
        private void CheckingForDiscount()
        {
            Logger.UserAction(userLogin, "Проверка и применение скидок");
            using (var db = new AllDB())
            {
                var activeProducts = db.Products.Where(p => p.Status == true).ToList();

                foreach (var product in activeProducts)
                {
                    int weeksUntilEnd = (int)((product.EndDateOfTheDay - DateTime.Today).TotalDays / 7);
                    if (weeksUntilEnd <= (int)numDiscountBeforeEnd.Value)
                    {
                        product.Discount = (double)numDiscount.Value;
                        product.FinalyPrice = product.PurchasePrice - (product.PurchasePrice * (decimal)product.Discount / 100);
                        Logger.UserAction(userLogin, $"Товару '{product.Name}' применена скидка {product.Discount}%");
                    }
                    else
                    {
                        product.Discount = 0;
                        product.FinalyPrice = product.PurchasePrice;
                    }
                }
                db.SaveChanges();
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
        /// Открывает форму добавления карточки товара
        /// </summary>
        private void AddCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Открытие формы добавления карточки товара");
            var addCardForm = new AddCard(userLogin);
            addCardForm.Show();
        }

        /// <summary>
        /// Открывает форму добавления категории
        /// </summary>
        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Открытие формы добавления категории");
            var newFormAddCategory = new AddCategory(userLogin);
            newFormAddCategory.Show();
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
            var newFormAuthorization = new Authorization();
            newFormAuthorization.Show();
            Hide();
        }

        /// <summary>
        /// Открывает форму изменения карточки товара
        /// </summary>
        private void changeCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Открытие формы изменения карточки товара");
            var newChangeCardForm = new ChangeCard(userLogin);
            newChangeCardForm.Show();
            Hide();
        }

        /// <summary>
        /// Открывает форму изменения категории
        /// </summary>
        private void CategoryChangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Открытие формы изменения категории");
            var newChangeCategory = new ChangeCategory(userLogin);
            newChangeCategory.Show();
            Hide();
        }

        /// <summary>
        /// Открывает форму удаления карточки товара
        /// </summary>
        private void deleteCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Открытие формы удаления карточки товара");
            var newDeleteCategory = new DeleteCard(userLogin);
            newDeleteCategory.Show();
            Hide();
        }

        /// <summary>
        /// Открывает форму удаления категории
        /// </summary>
        private void deleteCategoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Открытие формы удаления категории");
            var newDeleteCategory = new DeleteCategory(userLogin);
            newDeleteCategory.Show();
            Hide();
        }

        /// <summary>
        /// Открывает историю отгрузок
        /// </summary>
        private void buttonHistoryShipment_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Открытие истории отгрузок");
            var newHistoryShipmentForm = new HistoryShipmentForm(userLogin);
            newHistoryShipmentForm.Show();
            Hide();
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

        /// <summary>
        /// Загружает категории в комбобокс типа товара
        /// </summary>
        private void comboBoxTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Загрузка категорий в комбобокс типа товара");
            comboBoxTypeProduct.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var category in db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory)
                {
                    comboBoxTypeProduct.Items.Add(category);
                }
            }
        }

        /// <summary>
        /// Сохраняет настройки сезона для выбранной категории
        /// </summary>
        private void buttonSaveOptions_Click(object sender, EventArgs e)
        {
            Logger.UserAction(userLogin, "Сохранение настроек сезона для категории");

            if (comboBoxTypeProduct.SelectedItem is null)
            {
                MessageBox.Show(Resources.EnterTheCategory);
                return;
            }

            if (comboBoxTypeProduct.SelectedItem is null)
            {
                MessageBox.Show(Resources.EnterSeason);
                return;
            }
            using (var db = new AllDB())
            {
                int month;
                int discountBeforeend = (int)numDiscountBeforeEnd.Value;
                double discount = (double)numDiscount.Value;
                int.TryParse(comboBoxSeasonDuration.Text, out month);
                var today = DateTime.Today.AddMonths(month);
                int productCount = 0;
                foreach (var product in db.Products.Where(p => p.Category == comboBoxTypeProduct.Text).ToList())
                {
                    product.EndDateOfTheDay = today;
                    product.UntilTheEndOfTheSeason = month * 4;
                    product.DiscountBeforeEnd = discountBeforeend;
                    product.Discount = discount;
                    product.FinalyPrice = product.PurchasePrice - (product.PurchasePrice * (decimal)discount) / 100;
                    productCount++;
                    db.SaveChanges();
                }
                Logger.UserAction(userLogin, $"Обновлено {productCount} товаров в категории '{comboBoxTypeProduct.Text}'. Сезон до: {today:d}, скидка: {discount}%");
                MessageBox.Show(Resources.Success);
                CheckingForDiscount();
                LoadProductsTrue();
            }
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
    }
}