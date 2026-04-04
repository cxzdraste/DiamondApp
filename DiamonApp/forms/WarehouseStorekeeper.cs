using DiamonApp.DataBase;
using System.Data;
using DiamonApp.Resourses;

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
            labelLogin.Text = userLogin;
            CreateDataGridView();
            LoadProducts();
            весьСкладToolStripMenuItem.Click += (s, e) => LoadProducts();
            кольцоToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Ring);
            серьгиToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Earring);
            браслетToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Bracelet);
            кольеToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Necklace);
            брошьToolStripMenuItem.Click += (s, e) => FilterProducts(Resources.Brooch);
            exitToolStripMenuItemOutput.Click += Exit_Click;
            //searchToolStripMenuItem.Click += SearchToolStripMenuItem_Click;
            //createShipmentToolStripMenuItem.Click += CreateShipmentToolStripMenuItem_Click;
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
        private void FilterProducts(string category)
        {
            using (var db = new AllDB())
            {
                var products = db.Products
                    .Where(p => p.Name.Contains(category))
                    .Select(p => new
                    {
                        p.Name,
                        p.UniteOfMeasure,
                        p.Price,
                        p.Category,
                        p.Rest,
                    }).ToList();
                dgvWarehouse.DataSource = products;
                SetupColumns();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void LoadProducts()
        {
            using (var db = new AllDB())
            {
                dgvWarehouse.DataSource = db.Products
                    .Select(p => new {p.Name, p.UniteOfMeasure, p.Price, p.Category, p.Rest })
                    .ToList();
            }
        }
       
        private void SetupColumns()
        {

            if (dgvWarehouse.Columns["Name"] != null)
                dgvWarehouse.Columns["Name"].HeaderText = "Название";

            if (dgvWarehouse.Columns["Count"] != null)
                dgvWarehouse.Columns["Count"].HeaderText = "Количество";

            if (dgvWarehouse.Columns["Price"] != null)
                dgvWarehouse.Columns["Price"].HeaderText = "Цена";

            if (dgvWarehouse.Columns["Rest"] != null)
                dgvWarehouse.Columns["Rest"].HeaderText = "Остаток";

        }
        //private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var searchForm = new SearchCard();
        //    searchForm.Show();
        //}
        //private void CreateShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var createform = new CreatingShipment(userLogin);
        //    createform.Show();
        //}
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
