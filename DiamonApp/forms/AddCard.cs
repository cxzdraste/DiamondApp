using System;
using System.Linq;
using System.Windows.Forms;
using DiamonApp.Classes;
using DiamonApp.DataBase;
using DiamonApp.Resourses;

namespace Draft_Diamond_BD
{
    public partial class AddCard : Form
    {
        string LoginAdmin;
        public AddCard(string loginAdmin)
        {
            InitializeComponent();
            comboBoxUniteOfMeasure.Click += comboBoxUniteOfMeasure_SelectedIndexChanged;
            LoginAdmin = loginAdmin;
        }

        private void comboBoxUniteOfMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUniteOfMeasure.Items.Clear();
            comboBoxUniteOfMeasure.Items.Add(UniteOfMeasureEnum.Gramm);
            comboBoxUniteOfMeasure.Items.Add(UniteOfMeasureEnum.Unit);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new AllDB()) 
            { 
                
            }
        }
    }
}

