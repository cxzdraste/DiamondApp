using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamonApp.forms;
using DiamonApp.forms.differentFunctionsForms;
using DiamondApp.forms.differentFunctionsForms;
using DiamondApp.Resourses;


namespace Draft_Diamond_BD
{
    public partial class WarehouseAdmin : Form
    {
        private DataGridView dgvWarehouse;
        private string userLogin;
        public WarehouseAdmin(string login)
        {
            InitializeComponent();
            userLogin = login;
            labelLogin.Text = Resources.LoginInMenu + userLogin;
            CreateDataGridView();
            LoadProducts();
            FilterProducts();
            весьСкладToolStripMenuItem.Click += (s, a) => LoadProducts();
            exitToolStripMenuItemOutput.Click += Exit_Click;
            addCardToolStripMenuItem.Click += AddCardToolStripMenuItem_Click;
        }
        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new System.Drawing.Point(10, 150),
                Size = new System.Drawing.Size(780, 250),
                Margin = new Padding(10, 10, 10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
            };
            Controls.Add(dgvWarehouse);
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
                                dgvWarehouse.DataSource = products;
                            }
                        };
                        категорииToolStripMenuItem.DropDownItems.Add(menuItem);
                    }
                }
            }
        }
        /// <summary>
        /// Метод для работы с базой данных 
        /// </summary>
        public void LoadProducts()
        {
            using (var db = new AllDB())
            {
                var products = db.Products.Select(p => new
                {
                    p.Name,
                    p.UniteOfMeasure,
                    p.PurchasePrice,
                    p.Category,
                    p.Rest,
                    p.Creator,
                }).ToList();
                dgvWarehouse.DataSource = products;
                SetupColumns();
            }
        }
        private void SetupColumns()
        {
            if (dgvWarehouse.Columns["Name"] != null)
                dgvWarehouse.Columns["Name"].HeaderText = "Название";

            if (dgvWarehouse.Columns["UniteOfMeasure"] != null)
                dgvWarehouse.Columns["UniteOfMeasure"].HeaderText = "Единица измерения";

            if (dgvWarehouse.Columns["Price"] != null)
                dgvWarehouse.Columns["Price"].HeaderText = "Цена";

            if (dgvWarehouse.Columns["Category"] != null)
                dgvWarehouse.Columns["Category"].HeaderText = "Категория";

            if (dgvWarehouse.Columns["Rest"] != null)
                dgvWarehouse.Columns["Rest"].HeaderText = "Остаток";

            if (dgvWarehouse.Columns["Creator"] != null)
                dgvWarehouse.Columns["Creator"].HeaderText = "Кто создал";
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
        private void InitializeComponent()
        {
            labelwarehouse = new Label();
            menuStripWarehouseProducts = new MenuStrip();
            toolStripMenuItem3 = new ToolStripMenuItem();
            addCardToolStripMenuItem = new ToolStripMenuItem();
            NewCategoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            changeCardToolStripMenuItem = new ToolStripMenuItem();
            changeCategoryToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            deleteCardToolStripMenuItem = new ToolStripMenuItem();
            DeleteCategoryToolStripMenuItem2 = new ToolStripMenuItem();
            filterToolStripMenuItemFilter = new ToolStripMenuItem();
            весьСкладToolStripMenuItem = new ToolStripMenuItem();
            категорииToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItemOutput = new ToolStripMenuItem();
            changeAccountToolStripMenuItem = new ToolStripMenuItem();
            принятьПоставкуToolStripMenuItem = new ToolStripMenuItem();
            labelLogin = new Label();
            buttonHistoryShipment = new Button();
            menuStripWarehouseProducts.SuspendLayout();
            SuspendLayout();
            // 
            // labelwarehouse
            // 
            labelwarehouse.AutoSize = true;
            labelwarehouse.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelwarehouse.Location = new Point(12, 107);
            labelwarehouse.Name = "labelwarehouse";
            labelwarehouse.Size = new Size(115, 36);
            labelwarehouse.TabIndex = 0;
            labelwarehouse.Text = "Склад:";
            // 
            // menuStripWarehouseProducts
            // 
            menuStripWarehouseProducts.ImageScalingSize = new Size(20, 20);
            menuStripWarehouseProducts.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem2, toolStripMenuItem1, filterToolStripMenuItemFilter, exitToolStripMenuItemOutput, changeAccountToolStripMenuItem, принятьПоставкуToolStripMenuItem });
            menuStripWarehouseProducts.Location = new Point(0, 0);
            menuStripWarehouseProducts.Name = "menuStripWarehouseProducts";
            menuStripWarehouseProducts.Size = new Size(804, 28);
            menuStripWarehouseProducts.TabIndex = 1;
            menuStripWarehouseProducts.Text = "Меню";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { addCardToolStripMenuItem, NewCategoryToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(90, 24);
            toolStripMenuItem3.Text = "Добавить";
            // 
            // addCardToolStripMenuItem
            // 
            addCardToolStripMenuItem.Name = "addCardToolStripMenuItem";
            addCardToolStripMenuItem.Size = new Size(168, 26);
            addCardToolStripMenuItem.Text = "Карточку ";
            // 
            // NewCategoryToolStripMenuItem
            // 
            NewCategoryToolStripMenuItem.Name = "NewCategoryToolStripMenuItem";
            NewCategoryToolStripMenuItem.Size = new Size(168, 26);
            NewCategoryToolStripMenuItem.Text = "Категорию";
            NewCategoryToolStripMenuItem.Click += newCategoryToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { changeCardToolStripMenuItem, changeCategoryToolStripMenuItem1 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(92, 24);
            toolStripMenuItem2.Text = "Изменить";
            // 
            // changeCardToolStripMenuItem
            // 
            changeCardToolStripMenuItem.Name = "changeCardToolStripMenuItem";
            changeCardToolStripMenuItem.Size = new Size(168, 26);
            changeCardToolStripMenuItem.Text = "Карточку";
            changeCardToolStripMenuItem.Click += changeCardToolStripMenuItem_Click;
            // 
            // changeCategoryToolStripMenuItem1
            // 
            changeCategoryToolStripMenuItem1.Name = "changeCategoryToolStripMenuItem1";
            changeCategoryToolStripMenuItem1.Size = new Size(168, 26);
            changeCategoryToolStripMenuItem1.Text = "Категорию";
            changeCategoryToolStripMenuItem1.Click += CategoryChangeToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { deleteCardToolStripMenuItem, DeleteCategoryToolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(79, 24);
            toolStripMenuItem1.Text = "Удалить";
            // 
            // deleteCardToolStripMenuItem
            // 
            deleteCardToolStripMenuItem.Name = "deleteCardToolStripMenuItem";
            deleteCardToolStripMenuItem.Size = new Size(168, 26);
            deleteCardToolStripMenuItem.Text = "Карточку";
            deleteCardToolStripMenuItem.Click += deleteCardToolStripMenuItem_Click;
            // 
            // DeleteCategoryToolStripMenuItem2
            // 
            DeleteCategoryToolStripMenuItem2.Name = "DeleteCategoryToolStripMenuItem2";
            DeleteCategoryToolStripMenuItem2.Size = new Size(168, 26);
            DeleteCategoryToolStripMenuItem2.Text = "Категорию";
            DeleteCategoryToolStripMenuItem2.Click += deleteCategoryToolStripMenuItem2_Click;
            // 
            // filterToolStripMenuItemFilter
            // 
            filterToolStripMenuItemFilter.DropDownItems.AddRange(new ToolStripItem[] { весьСкладToolStripMenuItem, категорииToolStripMenuItem });
            filterToolStripMenuItemFilter.Name = "filterToolStripMenuItemFilter";
            filterToolStripMenuItemFilter.Size = new Size(74, 24);
            filterToolStripMenuItemFilter.Text = "Фильтр";
            // 
            // весьСкладToolStripMenuItem
            // 
            весьСкладToolStripMenuItem.Name = "весьСкладToolStripMenuItem";
            весьСкладToolStripMenuItem.Size = new Size(166, 26);
            весьСкладToolStripMenuItem.Text = "Весь склад";
            // 
            // категорииToolStripMenuItem
            // 
            категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            категорииToolStripMenuItem.Size = new Size(166, 26);
            категорииToolStripMenuItem.Text = "Категории";
            // 
            // exitToolStripMenuItemOutput
            // 
            exitToolStripMenuItemOutput.Name = "exitToolStripMenuItemOutput";
            exitToolStripMenuItemOutput.Size = new Size(67, 24);
            exitToolStripMenuItemOutput.Text = "Выход";
            // 
            // changeAccountToolStripMenuItem
            // 
            changeAccountToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            changeAccountToolStripMenuItem.Size = new Size(139, 24);
            changeAccountToolStripMenuItem.Text = "Сменить аккаунт";
            changeAccountToolStripMenuItem.Click += changeAccountToolStripMenuItem_Click;
            // 
            // принятьПоставкуToolStripMenuItem
            // 
            принятьПоставкуToolStripMenuItem.Name = "принятьПоставкуToolStripMenuItem";
            принятьПоставкуToolStripMenuItem.Size = new Size(148, 24);
            принятьПоставкуToolStripMenuItem.Text = "Принять поставку";
            принятьПоставкуToolStripMenuItem.Click += принятьПоставкуToolStripMenuItem_Click;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(558, 0);
            labelLogin.Margin = new Padding(5);
            labelLogin.Name = "labelLogin";
            labelLogin.Padding = new Padding(2);
            labelLogin.Size = new Size(68, 29);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "label1";
            // 
            // buttonHistoryShipment
            // 
            buttonHistoryShipment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHistoryShipment.BackColor = SystemColors.ControlDarkDark;
            buttonHistoryShipment.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHistoryShipment.Location = new Point(508, 85);
            buttonHistoryShipment.Name = "buttonHistoryShipment";
            buttonHistoryShipment.Padding = new Padding(2);
            buttonHistoryShipment.RightToLeft = RightToLeft.Yes;
            buttonHistoryShipment.Size = new Size(284, 51);
            buttonHistoryShipment.TabIndex = 4;
            buttonHistoryShipment.Text = "История Отгрузок";
            buttonHistoryShipment.UseVisualStyleBackColor = false;
            buttonHistoryShipment.Click += buttonHistoryShipment_Click;
            // 
            // WarehouseAdmin
            // 
            ClientSize = new Size(804, 629);
            Controls.Add(buttonHistoryShipment);
            Controls.Add(labelLogin);
            Controls.Add(labelwarehouse);
            Controls.Add(menuStripWarehouseProducts);
            MainMenuStrip = menuStripWarehouseProducts;
            Name = "WarehouseAdmin";
            Text = "Склад администратора";
            menuStripWarehouseProducts.ResumeLayout(false);
            menuStripWarehouseProducts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
