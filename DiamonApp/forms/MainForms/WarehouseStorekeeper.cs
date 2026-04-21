using System.Data;
using DiamonApp.DataBase;
using DiamonApp.forms.differentFunctionsForms;
using DiamondApp.Resourses;

namespace Draft_Diamond_BD
{
    public partial class WarehouseStorekeeper : Form
    {
        private DataGridView dgvWarehouse;
        private string userLogin;
        public WarehouseStorekeeper(string login)
        {
            InitializeComponent();
            userLogin = login;
            labelLogin.Text = Resources.LoginInMenu + userLogin;
            FilterProducts();
            CreateDataGridView();
            LoadProducts();
            весьСкладToolStripMenuItem.Click += (s, e) => LoadProducts();
            exitToolStripMenuItemOutput.Click += Exit_Click;
            createShipmentToolStripMenuItem.Click += CreateShipmentToolStripMenuItem_Click;
            сменитьАккаунтToolStripMenuItem.Click += changeAccountToolStripMenuItem_Click;
        }
        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new System.Drawing.Point(10, 130),
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

        private void LoadProducts()
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
            }
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
    }
}
