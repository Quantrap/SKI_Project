using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKI_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "worker") 
            { 
                buttonPersonal.Enabled = false;
                buttonMagazine.Enabled = false;
                buttonSupply.Enabled = false;
                buttonProviders.Enabled = false;
            }
            if(FormAuthorization.users.type=="manager")
            {
                buttonMagazine.Enabled = false;
                buttonProviders.Enabled = false;
            }
            labelHello.Text += FormAuthorization.users.login;
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            Form personalForm = new FormPersonal();
            personalForm.Show();
        }

        private void buttonMagazine_Click(object sender, EventArgs e)
        {
            Form formMagazine = new FormMagazine();
            formMagazine.Show();
        }

        private void buttonBakery_Click(object sender, EventArgs e)
        {
            Form bakeryForm = new BakeryForm();
            bakeryForm.Show();
        }

        private void buttonProviders_Click(object sender, EventArgs e)
        {
            Form formProviders = new ProvidersForm();
            formProviders.Show();
        }

        private void buttonSupply_Click(object sender, EventArgs e)
        {
            Form supplyForm = new FormSupply();
            supplyForm.Show();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            Form salesForm = new FormSales();
            salesForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
