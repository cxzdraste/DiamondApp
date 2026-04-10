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
            //buttonHistoryShipment.Click += ButtonHistoryShipment_Click;
            addCardToolStripMenuItem.Click += AddCardToolStripMenuItem_Click;
            //changeCardToolStripMenuItem.Click += ChangeCardToolStripMenuItem_Click;
            //deleteCardToolStripMenuItem.Click += deleteCardToolStripMenuItem_Click;
            //searchShipmentToolStripMenuItem.Click+= SearchShipmentToolStripMenuItem_Click;
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
        private void категориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newFormAddCategory = new AddCategory(userLogin);
            newFormAddCategory.Show();
            Hide();
        }
        //private void ButtonHistoryShipment_Click(object sender, EventArgs e)
        //{
        //    var historyForm = new HistoryShipment(userLogin);
        //    historyForm.Show();
        //    Hide();
        //}
        //private void ChangeCardToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var changeCardForm = new ChangeCard(dgvWarehouse);
        //    changeCardForm.Show();
        //}
        //private void deleteCardToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var deleteCardDelete = new DeleteCard(dgvWarehouse);
        //    deleteCardDelete.Show();
        //}
        //private void SearchShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var findShipmentForm = new FindShipment();
        //    findShipmentForm.Show();
        //}
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
        private void InitializeComponent()
        {
            labelwarehouse = new Label();
            menuStripWarehouseProducts = new MenuStrip();
            toolStripMenuItem3 = new ToolStripMenuItem();
            addCardToolStripMenuItem = new ToolStripMenuItem();
            категориюToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            changeCardToolStripMenuItem = new ToolStripMenuItem();
            категориюToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            deleteCardToolStripMenuItem = new ToolStripMenuItem();
            категориюToolStripMenuItem2 = new ToolStripMenuItem();
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
            labelwarehouse.Size = new Size(115, 36);
            labelwarehouse.TabIndex = 0;
            labelwarehouse.Text = "Склад:";
            // 
            // menuStripWarehouseProducts
            // 
            menuStripWarehouseProducts.ImageScalingSize = new Size(20, 20);
            menuStripWarehouseProducts.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem2, toolStripMenuItem1, searchtoolStripMenuItem, filterToolStripMenuItemFilter, exitToolStripMenuItemOutput, changeAccountToolStripMenuItem });
            menuStripWarehouseProducts.Location = new Point(0, 0);
            menuStripWarehouseProducts.Name = "menuStripWarehouseProducts";
            menuStripWarehouseProducts.Size = new Size(732, 28);
            menuStripWarehouseProducts.TabIndex = 1;
            menuStripWarehouseProducts.Text = "Меню";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { addCardToolStripMenuItem, категориюToolStripMenuItem });
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
            // категориюToolStripMenuItem
            // 
            категориюToolStripMenuItem.Name = "категориюToolStripMenuItem";
            категориюToolStripMenuItem.Size = new Size(168, 26);
            категориюToolStripMenuItem.Text = "Категорию";
            категориюToolStripMenuItem.Click += категориюToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { changeCardToolStripMenuItem, категориюToolStripMenuItem1 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(92, 24);
            toolStripMenuItem2.Text = "Изменить";
            // 
            // changeCardToolStripMenuItem
            // 
            changeCardToolStripMenuItem.Name = "changeCardToolStripMenuItem";
            changeCardToolStripMenuItem.Size = new Size(168, 26);
            changeCardToolStripMenuItem.Text = "Карточку";
            // 
            // категориюToolStripMenuItem1
            // 
            категориюToolStripMenuItem1.Name = "категориюToolStripMenuItem1";
            категориюToolStripMenuItem1.Size = new Size(168, 26);
            категориюToolStripMenuItem1.Text = "Категорию";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { deleteCardToolStripMenuItem, категориюToolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(79, 24);
            toolStripMenuItem1.Text = "Удалить";
            // 
            // deleteCardToolStripMenuItem
            // 
            deleteCardToolStripMenuItem.Name = "deleteCardToolStripMenuItem";
            deleteCardToolStripMenuItem.Size = new Size(168, 26);
            deleteCardToolStripMenuItem.Text = "Карточку";
            // 
            // категориюToolStripMenuItem2
            // 
            категориюToolStripMenuItem2.Name = "категориюToolStripMenuItem2";
            категориюToolStripMenuItem2.Size = new Size(168, 26);
            категориюToolStripMenuItem2.Text = "Категорию";
            // 
            // searchtoolStripMenuItem
            // 
            searchtoolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchShipmentToolStripMenuItem, найтиToolStripMenuItem });
            searchtoolStripMenuItem.Name = "searchtoolStripMenuItem";
            searchtoolStripMenuItem.Size = new Size(66, 24);
            searchtoolStripMenuItem.Text = "Поиск";
            // 
            // searchShipmentToolStripMenuItem
            // 
            searchShipmentToolStripMenuItem.Name = "searchShipmentToolStripMenuItem";
            searchShipmentToolStripMenuItem.Size = new Size(206, 26);
            searchShipmentToolStripMenuItem.Text = "Найти отгрузку ";
            // 
            // найтиToolStripMenuItem
            // 
            найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            найтиToolStripMenuItem.Size = new Size(206, 26);
            найтиToolStripMenuItem.Text = "Поиск карточки ";
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
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(486, 0);
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


    }
}
