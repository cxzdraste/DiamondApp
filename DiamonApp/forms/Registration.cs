using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamonApp.Enums;
using DiamondApp.Resourses;
using DiamondApp.Hash;
using Draft_Diamond_BD;

namespace DiamonApp
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            buttonRegister.Click += btnCreate_Click;
            btnAuthorization.Click += btnAuthorization_Click;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text.Trim();
            var password = textBoxPassword.Text.Trim();
            var name = textBoxName.Text.Trim();
            var surname = textBoxSurname.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show(Resources.EnterTheCorrectInformation); 
                return;
            }
            using (var db = new AllDB())
            {
                var existingUser = db.Employess.FirstOrDefault(w => w.Login == login);
                if (existingUser != null)
                {
                    MessageBox.Show(Resources.SuchLogin); 
                    return;
                }
                var newWorker = new EmployeeClass(name, surname, login, SimpleHash.HashSHA256(password), JobsEnumcs.Storekeeper);
                
                db.Employess.Add(newWorker);
                db.SaveChanges();
            }
            MessageBox.Show(Resources.Success); 
            new Authorization().Show();
            Hide();
        }
        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            new Authorization().Show();
            Hide();
        }
    }
}

