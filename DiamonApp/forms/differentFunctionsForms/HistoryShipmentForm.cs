using System.Data;
using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamonApp.Enums;
using DiamondApp.Resourses;
using Draft_Diamond_BD;
using Newtonsoft.Json;

namespace DiamonApp.forms.differentFunctionsForms
{
    public partial class HistoryShipmentForm : Form
    {
        private DataGridView dgvWarehouse;
        private string userLogin;
        public HistoryShipmentForm(string login)
        {
            InitializeComponent();
            userLogin = login;
            labelLogin.Text = Resources.LoginInMenu + userLogin;
            CreateDataGridView();
            LoadProducts();
            comboBoxFiter.Click += (s, a) => LoadStorekeepersInFilter();
        }

        private void CreateDataGridView()
        {
            dgvWarehouse = new DataGridView
            {
                Location = new System.Drawing.Point(10, 200),
                Size = new System.Drawing.Size(1000, 250),
                Margin = new Padding(10, 10, 10, 10),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.DarkGray,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
            };
            Controls.Add(dgvWarehouse);
        }
        public void LoadProducts()
        {
            using (var db = new AllDB())
            {
                var products = db.HistoryShipment.Select(p => new
                {
                    p.DateShipment,
                    p.ProductsName,
                    p.UniteOfMeasure,
                    p.Count,
                    p.SumShipment,
                    p.Profit,
                    p.CustomerName,
                    p.CustomerPlace,
                    p.LoginStorekeeper,
                    p.Id,
                }).ToList();
                dgvWarehouse.DataSource = products;
                SetupColumns();
            }
        }
        private void LoadStorekeepersInFilter()
        {
            var startDate = date1.Value;
            var endDate = date2.Value;
            comboBoxFiter.Items.Clear();
            using (var db = new AllDB())
            {
                foreach (var empl in db.Employess.ToList())
                {
                    if (empl.Job == JobsEnumcs.Storekeeper)
                    {
                        comboBoxFiter.Items.Add(empl.Login);
                    }
                }
                comboBoxFiter.SelectedIndexChanged += (s, e) =>
                {
                    using (var db = new AllDB())
                    {
                        var selectedLogin = comboBoxFiter.SelectedItem.ToString();
                        var shipments = db.HistoryShipment.Where(p => p.LoginStorekeeper == selectedLogin &&
                        (p.DateShipment.Date >= startDate && p.DateShipment.Date <= endDate)).Select(p => new
                        {
                            p.DateShipment,
                            p.ProductsName,
                            p.UniteOfMeasure,
                            p.Count,
                            p.SumShipment,
                            p.Profit,
                            p.CustomerName,
                            p.CustomerPlace,
                            p.LoginStorekeeper,
                            p.Id,
                        }).ToList();
                        dgvWarehouse.DataSource = shipments;
                        SetupColumns();
                    }
                };
            }
        }
        private void SetupColumns()
        {
            if (dgvWarehouse.Columns["DateShipment"] != null)
                dgvWarehouse.Columns["DateShipment"].HeaderText = "Дата";

            if (dgvWarehouse.Columns["ProductsName"] != null)
                dgvWarehouse.Columns["ProductsName"].HeaderText = "Имя";

            if (dgvWarehouse.Columns["UniteOfMeasure"] != null)
                dgvWarehouse.Columns["UniteOfMeasure"].HeaderText = "Единица измерения";

            if (dgvWarehouse.Columns["Count"] != null)
                dgvWarehouse.Columns["Count"].HeaderText = "Количество";

            if (dgvWarehouse.Columns["SumShipment"] != null)
                dgvWarehouse.Columns["SumShipment"].HeaderText = "Сумма отгрузки";

            if (dgvWarehouse.Columns["Profit"] != null)
                dgvWarehouse.Columns["Profit"].HeaderText = "Прибыль";

            if (dgvWarehouse.Columns["CustomerName"] != null)
                dgvWarehouse.Columns["CustomerName"].HeaderText = "Кому";

            if (dgvWarehouse.Columns["CustomerPlace"] != null)
                dgvWarehouse.Columns["CustomerPlace"].HeaderText = "Куда";

            if (dgvWarehouse.Columns["LoginStorekeeper"] != null)
                dgvWarehouse.Columns["LoginStorekeeper"].HeaderText = "Кто создал";

            if (dgvWarehouse.Columns["Id"] != null)
                dgvWarehouse.Columns["Id"].HeaderText = "ID отгрузки";
        }

        private void buttonListWaredhouse_Click(object sender, EventArgs e)
        {
            var newWarehouseAdmine = new WarehouseAdmin(userLogin);
            newWarehouseAdmine.Show();
            Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (date1.Value.Date > date2.Value.Date)
            {
                MessageBox.Show(Resources.Data1AndData2);
                return;
            }
            using (var db = new AllDB())
            {
                var startDate = date1.Value;
                var endDate = date2.Value;
                var listShip1 = db.HistoryShipment.Where(p => p.DateShipment.Date >= startDate && p.DateShipment.Date <= endDate).Select(p => new
                {
                    p.DateShipment,
                    p.ProductsName,
                    p.UniteOfMeasure,
                    p.Count,
                    p.SumShipment,
                    p.Profit,
                    p.CustomerName,
                    p.CustomerPlace,
                    p.LoginStorekeeper,
                    p.Id,
                }).ToList();
                dgvWarehouse.DataSource = listShip1;
                SetupColumns();
            }
        }

        private void buttonExportTheReport_Click(object sender, EventArgs e)
        {
            if(dgvWarehouse.DataSource == null)
            {
                MessageBox.Show(Resources.NoDataForExport); return;
            }
            var data = dgvWarehouse.DataSource;
            var exportList = new List<object>();
            if (data is System.Collections.IEnumerable enumerable) 
            {
                foreach(var item in enumerable)
                {
                    exportList.Add(item);
                }
            }

            if(exportList.Count == 0)
            {
                MessageBox.Show(Resources.NotReadingShipments); return;
            }
            var saveFile = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = $"Отгрузки_{DateTime.Now:M}.json"
            };
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var json = JsonConvert.SerializeObject(exportList, Formatting.Indented);
                    File.WriteAllText(saveFile.FileName, json);
                    MessageBox.Show(Resources.Success);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{Resources.ErrorExport} {ex.Message}");
                }
            }
        }
    }
}
