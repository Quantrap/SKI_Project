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
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
            ShowBakery();
            ShowMagazines();
            ShowSales();
        }

        private void listView_Sales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_Sales.SelectedItems.Count==1)
            {
                SalesSet supplySet = listView_Sales.SelectedItems[0].Tag as SalesSet;
                comboBoxBakery.SelectedIndex = comboBoxBakery.FindString(supplySet.IdBakery.ToString());
                comboBoxMagazine.SelectedIndex = comboBoxMagazine.FindString(supplySet.IdMagazine.ToString());
                textBoxPieces.Text = supplySet.Pieces.ToString();
            }
            else
            {
                comboBoxBakery.SelectedItem = null;
                comboBoxMagazine.SelectedItem = null;
                textBoxPieces.Text = "";
            }
        }
        void ShowMagazines()
        {
            comboBoxMagazine.Items.Clear();
            foreach (MagazineSet clientsSet in Program.bdSKI.MagazineSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.City};
                comboBoxMagazine.Items.Add(string.Join(" ", item));
            }
        }
        void ShowBakery()
        {
            comboBoxBakery.Items.Clear();
            foreach (BakerySet clientsSet in Program.bdSKI.BakerySet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.Name};
                comboBoxBakery.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSales()
        {
            listView_Sales.Items.Clear();
            foreach(SalesSet sales in Program.bdSKI.SalesSet)
            {
                ListViewItem item = new ListViewItem(new string[] {

                    sales.Id.ToString(),
                    sales.BakerySet.Name+" "+sales.BakerySet.Id,
                    sales.MagazineSet.City+" Id: "+sales.MagazineSet.Id,
                    sales.Pieces.ToString()+" кг(шт)",
                    sales.SumProfit.ToString()
                    });
                item.Tag = sales;
                listView_Sales.Items.Add(item);
            }
            listView_Sales.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxBakery.SelectedItem!=null && comboBoxMagazine.SelectedItem!=null && textBoxPieces.Text!="")
            {
                SalesSet supplySet = new SalesSet();
                supplySet.IdMagazine = Convert.ToInt32(comboBoxMagazine.SelectedItem.ToString().Split('.')[0]);
                supplySet.IdBakery = Convert.ToInt32(comboBoxBakery.SelectedItem.ToString().Split('.')[0]);
                supplySet.Pieces = Convert.ToDouble(textBoxPieces.Text);
                Program.bdSKI.SalesSet.Add(supplySet);
                supplySet.SumProfit = Convert.ToInt64(supplySet.Pieces * supplySet.BakerySet.Profit);
                Program.bdSKI.SaveChanges();
                ShowSales();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxBakery.SelectedItem != null && comboBoxMagazine.SelectedItem != null && textBoxPieces.Text != "" && listView_Sales.SelectedItems.Count == 1)
            {
                SalesSet supplySet = listView_Sales.SelectedItems[0].Tag as SalesSet;
                supplySet.IdMagazine = Convert.ToInt32(comboBoxMagazine.SelectedItem.ToString().Split('.')[0]);
                supplySet.IdBakery = Convert.ToInt32(comboBoxBakery.SelectedItem.ToString().Split('.')[0]);
                supplySet.Pieces = Convert.ToDouble(textBoxPieces.Text);
                supplySet.SumProfit = Convert.ToInt64(supplySet.Pieces * supplySet.BakerySet.Profit);
                Program.bdSKI.SaveChanges();
                ShowSales();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_Sales.SelectedItems.Count == 1)
                {
                    SalesSet clientSet = listView_Sales.SelectedItems[0].Tag as SalesSet;
                    Program.bdSKI.SalesSet.Remove(clientSet);
                    Program.bdSKI.SaveChanges();
                    ShowSales();
                }
                comboBoxBakery.SelectedItem = null;
                comboBoxMagazine.SelectedItem = null;
                textBoxPieces.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
