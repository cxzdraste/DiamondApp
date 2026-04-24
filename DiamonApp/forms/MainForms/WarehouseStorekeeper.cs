using DiamonApp.DataBase;
using DiamonApp.forms.differentFunctionsForms;
using DiamondApp.forms.differentFunctionsForms;
using DiamondApp.Resourses;
using System.Data;

namespace Draft_Diamond_BD
{
    public partial class WarehouseStorekeeper : Form
    {
        private DataGridView dgvWarehouseTrue;
        private DataGridView dgvWarehouseFalse;
        private string userLogin;
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
        }
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
                foreach (var product in productsFalse)
                {
                    sum += product.FinalyPrice;
                }
                labelResult.Text = Resources.Result + sum;
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

            if (dgvWarehouseFalse.Columns["FinallyPrice"] != null)
                dgvWarehouseFalse.Columns["FinallyPrice"].HeaderText = "Убыток";

            if (dgvWarehouseFalse.Columns["EndDateOfTheDay"] != null)
                dgvWarehouseFalse.Columns["EndDateOfTheDay"].HeaderText = "Сезон до";
        }
        private void CreateShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createform = new CreatingShipmentForm(userLogin);
            createform.Show();
            Hide();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAuthorization = new Authorization();
            newAuthorization.Show();
            Close();
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
        private void принятьПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAcceptanceOfGoods = new AcceptanceOfGoodsForm(userLogin);
            newAcceptanceOfGoods.Show();
            Hide();
        }
    }
}
