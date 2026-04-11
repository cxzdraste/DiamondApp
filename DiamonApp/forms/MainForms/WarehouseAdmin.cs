using DiamonApp.DataBase;
using DiamonApp.forms;
using DiamonApp.Resourses;


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
                Size = new System.Drawing.Size(700, 250),
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
                                    p.Price,
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
                    p.Price,
                    p.Category,
                    p.Rest,
                    p.Creator,
                }).ToList();
                dgvWarehouse.DataSource = products;

            }
        }

        private void AddCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCardForm = new AddCard(userLogin);
            addCardForm.Show();
            Hide();
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
            searchtoolStripMenuItem = new ToolStripMenuItem();
            searchShipmentToolStripMenuItem = new ToolStripMenuItem();
            найтиToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItemFilter = new ToolStripMenuItem();
            весьСкладToolStripMenuItem = new ToolStripMenuItem();
            категорииToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItemOutput = new ToolStripMenuItem();
            changeAccountToolStripMenuItem = new ToolStripMenuItem();
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
            labelwarehouse.Size = new Size(90, 29);
            labelwarehouse.TabIndex = 0;
            labelwarehouse.Text = "Склад:";
            // 
            // menuStripWarehouseProducts
            // 
            menuStripWarehouseProducts.ImageScalingSize = new Size(20, 20);
            menuStripWarehouseProducts.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem2, toolStripMenuItem1, searchtoolStripMenuItem, filterToolStripMenuItemFilter, exitToolStripMenuItemOutput, changeAccountToolStripMenuItem });
            menuStripWarehouseProducts.Location = new Point(0, 0);
            menuStripWarehouseProducts.Name = "menuStripWarehouseProducts";
            menuStripWarehouseProducts.Size = new Size(732, 24);
            menuStripWarehouseProducts.TabIndex = 1;
            menuStripWarehouseProducts.Text = "Меню";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { addCardToolStripMenuItem, NewCategoryToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(71, 20);
            toolStripMenuItem3.Text = "Добавить";
            // 
            // addCardToolStripMenuItem
            // 
            addCardToolStripMenuItem.Name = "addCardToolStripMenuItem";
            addCardToolStripMenuItem.Size = new Size(180, 22);
            addCardToolStripMenuItem.Text = "Карточку ";
            // 
            // NewCategoryToolStripMenuItem
            // 
            NewCategoryToolStripMenuItem.Name = "NewCategoryToolStripMenuItem";
            NewCategoryToolStripMenuItem.Size = new Size(180, 22);
            NewCategoryToolStripMenuItem.Text = "Категорию";
            NewCategoryToolStripMenuItem.Click += newCategoryToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { changeCardToolStripMenuItem, changeCategoryToolStripMenuItem1 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(73, 20);
            toolStripMenuItem2.Text = "Изменить";
            // 
            // changeCardToolStripMenuItem
            // 
            changeCardToolStripMenuItem.Name = "changeCardToolStripMenuItem";
            changeCardToolStripMenuItem.Size = new Size(180, 22);
            changeCardToolStripMenuItem.Text = "Карточку";
            changeCardToolStripMenuItem.Click += changeCardToolStripMenuItem_Click;
            // 
            // changeCategoryToolStripMenuItem1
            // 
            changeCategoryToolStripMenuItem1.Name = "changeCategoryToolStripMenuItem1";
            changeCategoryToolStripMenuItem1.Size = new Size(180, 22);
            changeCategoryToolStripMenuItem1.Text = "Категорию";
            changeCategoryToolStripMenuItem1.Click += CategoryChangeToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { deleteCardToolStripMenuItem, DeleteCategoryToolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(63, 20);
            toolStripMenuItem1.Text = "Удалить";
            // 
            // deleteCardToolStripMenuItem
            // 
            deleteCardToolStripMenuItem.Name = "deleteCardToolStripMenuItem";
            deleteCardToolStripMenuItem.Size = new Size(180, 22);
            deleteCardToolStripMenuItem.Text = "Карточку";
            deleteCardToolStripMenuItem.Click += deleteCardToolStripMenuItem_Click;
            // 
            // DeleteCategoryToolStripMenuItem2
            // 
            DeleteCategoryToolStripMenuItem2.Name = "DeleteCategoryToolStripMenuItem2";
            DeleteCategoryToolStripMenuItem2.Size = new Size(180, 22);
            DeleteCategoryToolStripMenuItem2.Text = "Категорию";
            DeleteCategoryToolStripMenuItem2.Click += deleteCategoryToolStripMenuItem2_Click;
            // 
            // searchtoolStripMenuItem
            // 
            searchtoolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchShipmentToolStripMenuItem, найтиToolStripMenuItem });
            searchtoolStripMenuItem.Name = "searchtoolStripMenuItem";
            searchtoolStripMenuItem.Size = new Size(54, 20);
            searchtoolStripMenuItem.Text = "Поиск";
            // 
            // searchShipmentToolStripMenuItem
            // 
            searchShipmentToolStripMenuItem.Name = "searchShipmentToolStripMenuItem";
            searchShipmentToolStripMenuItem.Size = new Size(166, 22);
            searchShipmentToolStripMenuItem.Text = "Найти отгрузку ";
            // 
            // найтиToolStripMenuItem
            // 
            найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            найтиToolStripMenuItem.Size = new Size(166, 22);
            найтиToolStripMenuItem.Text = "Поиск карточки ";
            // 
            // filterToolStripMenuItemFilter
            // 
            filterToolStripMenuItemFilter.DropDownItems.AddRange(new ToolStripItem[] { весьСкладToolStripMenuItem, категорииToolStripMenuItem });
            filterToolStripMenuItemFilter.Name = "filterToolStripMenuItemFilter";
            filterToolStripMenuItemFilter.Size = new Size(60, 20);
            filterToolStripMenuItemFilter.Text = "Фильтр";
            // 
            // весьСкладToolStripMenuItem
            // 
            весьСкладToolStripMenuItem.Name = "весьСкладToolStripMenuItem";
            весьСкладToolStripMenuItem.Size = new Size(133, 22);
            весьСкладToolStripMenuItem.Text = "Весь склад";
            // 
            // категорииToolStripMenuItem
            // 
            категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            категорииToolStripMenuItem.Size = new Size(133, 22);
            категорииToolStripMenuItem.Text = "Категории";
            // 
            // exitToolStripMenuItemOutput
            // 
            exitToolStripMenuItemOutput.Name = "exitToolStripMenuItemOutput";
            exitToolStripMenuItemOutput.Size = new Size(54, 20);
            exitToolStripMenuItemOutput.Text = "Выход";
            // 
            // changeAccountToolStripMenuItem
            // 
            changeAccountToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            changeAccountToolStripMenuItem.Size = new Size(112, 20);
            changeAccountToolStripMenuItem.Text = "Сменить аккаунт";
            changeAccountToolStripMenuItem.Click += changeAccountToolStripMenuItem_Click;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(486, 0);
            labelLogin.Margin = new Padding(5);
            labelLogin.Name = "labelLogin";
            labelLogin.Padding = new Padding(2);
            labelLogin.Size = new Size(55, 24);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "label1";
            // 
            // buttonHistoryShipment
            // 
            buttonHistoryShipment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHistoryShipment.BackColor = SystemColors.ControlDarkDark;
            buttonHistoryShipment.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHistoryShipment.Location = new Point(436, 85);
            buttonHistoryShipment.Name = "buttonHistoryShipment";
            buttonHistoryShipment.Padding = new Padding(2);
            buttonHistoryShipment.RightToLeft = RightToLeft.Yes;
            buttonHistoryShipment.Size = new Size(284, 51);
            buttonHistoryShipment.TabIndex = 4;
            buttonHistoryShipment.Text = "История Отгрузок";
            buttonHistoryShipment.UseVisualStyleBackColor = false;
            // 
            // WarehouseAdmin
            // 
            ClientSize = new Size(732, 629);
            Controls.Add(buttonHistoryShipment);
            Controls.Add(labelLogin);
            Controls.Add(labelwarehouse);
            Controls.Add(menuStripWarehouseProducts);
            MainMenuStrip = menuStripWarehouseProducts;
            Name = "WarehouseAdmin";
            Text = "WarehouseAdmin";
            menuStripWarehouseProducts.ResumeLayout(false);
            menuStripWarehouseProducts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void категориюToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
