using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamonApp.forms;
using DiamonApp.forms.differentFunctionsForms;
using DiamondApp.forms.differentFunctionsForms;
using DiamondApp.Resourses;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Draft_Diamond_BD
{
    public partial class WarehouseAdmin : Form
    {
        private DataGridView dgvWarehouseTrue;
        private DataGridView dgvWarehouseFalse;
        private string userLogin;
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
        }
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
        private void FilterProducts()
        {
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

        public void LoadProductsTrue()
        {
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
        public void LoadProductsFalse()
        {
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
                foreach(var product in productsFalse)
                {
                    sum += product.FinalyPrice;
                }
                labelResult.Text = Resources.Result + sum;
            }
        }
        private void ExpirationDateCheck()
        {
            using (var db = new AllDB())
            {
                foreach (var product in db.Products)
                {
                    if (product.EndDateOfTheDay < DateTime.Today)
                    {
                        product.Status = false;
                        db.SaveChanges();
                    }
                }
            }
        }
        private void CheckingForDiscount()
        {
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

        private void SetupColumnsFalse()
        {
            if (dgvWarehouseFalse.Columns["Name"] != null)
                dgvWarehouseFalse.Columns["Name"].HeaderText = "Название";

            if (dgvWarehouseFalse.Columns["UniteOfMeasure"] != null)
                dgvWarehouseFalse.Columns["UniteOfMeasure"].HeaderText = "Единица измерения";

            if (dgvWarehouseFalse.Columns["Category"] != null)
                dgvWarehouseFalse.Columns["Category"].HeaderText = "Категория";

            if (dgvWarehouseFalse.Columns["FinalyPrice"] != null)
                dgvWarehouseFalse.Columns["FinalyPrice"].HeaderText = "Убыток";

            if (dgvWarehouseFalse.Columns["Rest"] != null)
                dgvWarehouseFalse.Columns["Rest"].HeaderText = "Остаток";

            if (dgvWarehouseFalse.Columns["EndDateOfTheDay"] != null)
                dgvWarehouseFalse.Columns["EndDateOfTheDay"].HeaderText = "Сезон до";
        }
        private void SetupColumnsTrue()
        {
            if (dgvWarehouseTrue.Columns["Name"] != null)
                dgvWarehouseTrue.Columns["Name"].HeaderText = "Название";

            if (dgvWarehouseTrue.Columns["UniteOfMeasure"] != null)
                dgvWarehouseTrue.Columns["UniteOfMeasure"].HeaderText = "Единица измерения";

            if (dgvWarehouseTrue.Columns["PurchasePrice"] != null)
                dgvWarehouseTrue.Columns["PurchasePrice"].HeaderText = "Цена";

            if (dgvWarehouseTrue.Columns["Category"] != null)
                dgvWarehouseTrue.Columns["Category"].HeaderText = "Категория";

            if (dgvWarehouseTrue.Columns["Rest"] != null)
                dgvWarehouseTrue.Columns["Rest"].HeaderText = "Остаток";

            if (dgvWarehouseTrue.Columns["EndDateOfTheDay"] != null)
                dgvWarehouseTrue.Columns["EndDateOfTheDay"].HeaderText = "Сезон до";

            if (dgvWarehouseTrue.Columns["UntilTheEndOfTheSeason"] != null)
                dgvWarehouseTrue.Columns["UntilTheEndOfTheSeason"].HeaderText = "До конца сезона";

            if (dgvWarehouseTrue.Columns["Discount"] != null)
                dgvWarehouseTrue.Columns["Discount"].HeaderText = "Скидка";

            if (dgvWarehouseTrue.Columns["FinalyPrice"] != null)
                dgvWarehouseTrue.Columns["FinalyPrice"].HeaderText = "Итоговая стоимость";
        }

        private void AddCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCardForm = new AddCard(userLogin);
            addCardForm.Show();
        }
        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newFormAddCategory = new AddCategory(userLogin);
            newFormAddCategory.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newFormAuthorization = new Authorization();
            newFormAuthorization.Show();
            Hide();
        }
        private void changeCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newChangeCardForm = new ChangeCard(userLogin);
            newChangeCardForm.Show();
            Hide();
        }
        private void CategoryChangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var newChangeCategory = new ChangeCategory(userLogin);
            newChangeCategory.Show();
            Hide();
        }
        private void deleteCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newDeleteCategory = new DeleteCard(userLogin);
            newDeleteCategory.Show();
            Hide();
        }
        private void deleteCategoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var newDeleteCategory = new DeleteCategory(userLogin);
            newDeleteCategory.Show();
            Hide();
        }
        private void buttonHistoryShipment_Click(object sender, EventArgs e)
        {
            var newHistoryShipmentForm = new HistoryShipmentForm(userLogin);
            newHistoryShipmentForm.Show();
            Hide();
        }
        private void принятьПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAcceptanceOfGoods = new AcceptanceOfGoodsForm(userLogin);
            newAcceptanceOfGoods.Show();
            Hide();
        }

        private void comboBoxTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTypeProduct.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var category in db.Categories.FirstOrDefault(p => p.Id == 1).NamesOfCategory)
                {
                    comboBoxTypeProduct.Items.Add(category);
                }
            }
        }

        private void buttonSaveOptions_Click(object sender, EventArgs e)
        {
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
                foreach (var product in db.Products.Where(p => p.Category == comboBoxTypeProduct.Text).ToList())
                {
                    product.EndDateOfTheDay = today;
                    product.UntilTheEndOfTheSeason = month * 4;
                    product.DiscountBeforeEnd = discountBeforeend;
                    product.Discount = discount;
                    product.FinalyPrice = product.PurchasePrice - (product.PurchasePrice * (decimal)discount) / 100;
                    db.SaveChanges();
                }
                MessageBox.Show(Resources.Success);
                CheckingForDiscount();
                LoadProductsTrue();
            }
        }

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
                    using (var db = new AllDB())
                    {
                        var selectedCategory = comboBoxFiterProductFalse.SelectedItem.ToString();
                        var products = db.Products.Where(p => p.Category == selectedCategory && p.Status == false).Select(p => new
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
                        if (!products.Any())
                        {
                            MessageBox.Show(Resources.FalseProductNotExist);
                            return;
                        }
                        dgvWarehouseFalse.DataSource = products;
                        SetupColumnsFalse();
                    };
                };
             }
        }
    }
}
