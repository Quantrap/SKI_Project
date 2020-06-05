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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowMagazines();
            ShowProviders();
            ShowSupplies();
        }
        void ShowMagazines()
        {
            comboBoxMagazine.Items.Clear();
            foreach (MagazineSet clientsSet in Program.bdSKI.MagazineSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.City };
                comboBoxMagazine.Items.Add(string.Join(" ", item));
            }
        }
        void ShowProviders()
        {
            comboBoxProvider.Items.Clear();
            foreach (ProviderSet clientsSet in Program.bdSKI.ProviderSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.Name };
                comboBoxProvider.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSupplies()
        {
            listView_Supply.Items.Clear();
            foreach (SupplySet sales in Program.bdSKI.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[] {

                    sales.Id.ToString(),
                    sales.ProviderSet.Name+" "+sales.ProviderSet.Id,
                    sales.MagazineSet.City+" Id: "+sales.MagazineSet.Id,
                    sales.Name,
                    sales.Pieces.ToString()+" кг(шт)",
                    sales.Price.ToString()
                    });
                item.Tag = sales;
                listView_Supply.Items.Add(item);
            }
            listView_Supply.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxProvider.SelectedItem != null && comboBoxMagazine.SelectedItem != null && textBoxPieces.Text != "" && textBoxPrice.Text!="" && textBoxName.Text!="")
            {
                SupplySet supplySet = new SupplySet();
                supplySet.IdMagazine = Convert.ToInt32(comboBoxMagazine.SelectedItem.ToString().Split('.')[0]);
                supplySet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                supplySet.Pieces = Convert.ToInt32(textBoxPieces.Text);
                supplySet.Price = Convert.ToInt64(textBoxPrice.Text);
                supplySet.Name = textBoxName.Text;
                Program.bdSKI.SupplySet.Add(supplySet);
                Program.bdSKI.SaveChanges();
                ShowSupplies();
            }
        }

        private void listView_Supply_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Supply.SelectedItems.Count == 1)
            {
                SupplySet supplySet = listView_Supply.SelectedItems[0].Tag as SupplySet;
                comboBoxProvider.SelectedIndex = comboBoxProvider.FindString(supplySet.IdProvider.ToString());
                comboBoxMagazine.SelectedIndex = comboBoxMagazine.FindString(supplySet.IdMagazine.ToString());
                textBoxPieces.Text = supplySet.Pieces.ToString();
                textBoxPrice.Text = supplySet.Price.ToString();
                textBoxName.Text = supplySet.Name;
            }
            else
            {
                comboBoxProvider.SelectedItem = null;
                comboBoxMagazine.SelectedItem = null;
                textBoxPieces.Text = "";
                textBoxPrice.Text = "";
                textBoxName.Text ="";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxProvider.SelectedItem != null && comboBoxMagazine.SelectedItem != null && textBoxPieces.Text != "" && listView_Supply.SelectedItems.Count == 1)
            {
                SupplySet supplySet = listView_Supply.SelectedItems[0].Tag as SupplySet;
                supplySet.IdMagazine = Convert.ToInt32(comboBoxMagazine.SelectedItem.ToString().Split('.')[0]);
                supplySet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                supplySet.Pieces = Convert.ToInt32(textBoxPieces.Text);
                supplySet.Price = Convert.ToInt64(textBoxPrice.Text);
                supplySet.Name = textBoxName.Text;
                Program.bdSKI.SaveChanges();
                ShowSupplies();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_Supply.SelectedItems.Count == 1)
                {
                    SupplySet clientSet = listView_Supply.SelectedItems[0].Tag as SupplySet;
                    Program.bdSKI.SupplySet.Remove(clientSet);
                    Program.bdSKI.SaveChanges();
                    ShowSupplies();
                }
                comboBoxProvider.SelectedItem = null;
                comboBoxMagazine.SelectedItem = null;
                textBoxPieces.Text = "";
                textBoxName.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
