using System;
using System.Linq;
using System.Windows.Forms;
using DiamonApp;
using DiamonApp.DataBase;
using DiamonApp.Enums;
using DiamondApp.Resourses;
using DiamondApp.Hash;

namespace Draft_Diamond_BD
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            enter.Click += enter_Click;
            btnRegister.Click += btnRegister_Click;
            
        }
        private void enter_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text.Trim();
            var password = SimpleHash.HashSHA256(txtPassword.Text.Trim());

            using (var db = new AllDB())
            {
                var user = db.Employess.FirstOrDefault(w => w.Login == login);

                if (user != null)
                {
                    if (user.Password == password)
                    {
                        if (user.Job == JobsEnumcs.Administrator)
                        {
                            var warehouseAdminForm = new WarehouseAdmin(user.Login);
                            warehouseAdminForm.Show();
                        }
                        else
                        {
                            var warehouseStorekeeperForm = new WarehouseStorekeeper(user.Login);
                            warehouseStorekeeperForm.Show();
                        }
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show(Resources.ErrorPassword);
                        MessageBox.Show($"{user.Password},,,,,{password}");
                    }
                }
                else
                {
                    MessageBox.Show(Resources.ErrorLogin);
                }
            }
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerform = new Registration();
            registerform.Show();
            Hide();
        }
    }
}