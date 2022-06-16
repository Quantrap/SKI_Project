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
    public partial class FormMagazine : Form
    {
        public FormMagazine()
        {
            InitializeComponent();
            ShowManager();
            ShowMagazine();
        }

        private void listView_Personal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_Magazine.SelectedItems.Count==1)
            {
                MagazineSet magazine = listView_Magazine.SelectedItems[0].Tag as MagazineSet;

                comboBoxManager.SelectedIndex = comboBoxManager.FindString(magazine.IdManager.ToString());
                textBoxCity.Text = magazine.City;
                
            }
            else
            {
                comboBoxManager.SelectedItem = null;
                comboBoxManager.SelectedItem = null;
                comboBoxManager.SelectedItem = null;
            }
        }
        void ShowManager()
        {
            comboBoxManager.Items.Clear();
            foreach (PersonalSet clientsSet in Program.bdSKI.PersonalSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName, clientsSet.Phone };
                comboBoxManager.Items.Add(string.Join(" ", item));
            }
        }
        void ShowMagazine()
        {
            listView_Magazine.Items.Clear();
            foreach(MagazineSet magazine in Program.bdSKI.MagazineSet)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                magazine.Id.ToString(),magazine.City,magazine.PersonalSet.Id.ToString()+" "+magazine.PersonalSet.FirstName+" "+magazine.PersonalSet.LastName,
                magazine.Profit.ToString()
                });
                item.Tag = magazine;
                listView_Magazine.Items.Add(item);
            }
            listView_Magazine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCity.Text != "" && comboBoxManager.SelectedItem != null)
            {
                MagazineSet magazine = new MagazineSet();
                magazine.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                magazine.City = textBoxCity.Text;
                Program.bdSKI.MagazineSet.Add(magazine);
                Program.bdSKI.SaveChanges();
                ShowMagazine();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listView_Magazine.SelectedItems.Count==1)
            {
                MagazineSet magazine = listView_Magazine.SelectedItems[0].Tag as MagazineSet;
                magazine.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                magazine.City = textBoxCity.Text;
                Program.bdSKI.SaveChanges();
                ShowMagazine();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_Magazine.SelectedItems.Count == 1)
                {
                    MagazineSet magazineSet = listView_Magazine.SelectedItems[0].Tag as MagazineSet;
                    Program.bdSKI.MagazineSet.Remove(magazineSet);
                    Program.bdSKI.SaveChanges();
                    ShowMagazine();
                }
                comboBoxManager.SelectedItem = null;
                textBoxCity.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProfit_Click(object sender, EventArgs e)
        {
            foreach (MagazineSet magazine in Program.bdSKI.MagazineSet)
            {
                magazine.Profit = 0;
                
                foreach(SalesSet sales in Program.bdSKI.SalesSet)
                {
                    if(sales.IdMagazine==magazine.Id)
                    {
                        magazine.Profit += sales.SumProfit;
                    }
                }
                foreach(PersonalSet personal in Program.bdSKI.PersonalSet)
                {
                    if (personal.Magazine == magazine.Id)
                    {
                        magazine.Profit -= personal.Salary;
                    }
                }
                
            }
            Program.bdSKI.SaveChanges();
            ShowMagazine();
        }
    }
}
