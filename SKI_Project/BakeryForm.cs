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
    public partial class BakeryForm : Form
    {
        public BakeryForm()
        {
            InitializeComponent();
            ShowBakery();
        }

        private void listView_Bakery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Bakery.SelectedItems.Count == 1)
            {
                BakerySet bakery = listView_Bakery.SelectedItems[0].Tag as BakerySet;
                textBoxName.Text = bakery.Name;
                textBoxProfit.Text = Convert.ToString(bakery.Profit);
            }
            else
            {
                textBoxName.Text = "";
                textBoxProfit.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BakerySet bakery = new BakerySet();
            bakery.Name = textBoxName.Text;
            bakery.Profit = Convert.ToInt32(textBoxProfit.Text);
            Program.bdSKI.BakerySet.Add(bakery);
            Program.bdSKI.SaveChanges();
            ShowBakery();
        }
        void ShowBakery()
        {
            listView_Bakery.Items.Clear();
            foreach(BakerySet bakery in Program.bdSKI.BakerySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        bakery.Id.ToString(),bakery.Name,bakery.Profit.ToString()
                    });
                item.Tag = bakery;
                listView_Bakery.Items.Add(item);
            }
            listView_Bakery.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView_Bakery.SelectedItems.Count == 1)
            {
                BakerySet bakery = listView_Bakery.SelectedItems[0].Tag as BakerySet;
                bakery.Name = textBoxName.Text;
                bakery.Profit = Convert.ToInt32(textBoxProfit.Text);
                Program.bdSKI.SaveChanges();
                ShowBakery();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_Bakery.SelectedItems.Count == 1)
                {
                    BakerySet bakery = listView_Bakery.SelectedItems[0].Tag as BakerySet;
                    Program.bdSKI.BakerySet.Remove(bakery);
                    Program.bdSKI.SaveChanges();
                    ShowBakery();
                }
                textBoxName.Text = "";
                textBoxProfit.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
