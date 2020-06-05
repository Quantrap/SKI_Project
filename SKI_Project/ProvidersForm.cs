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
    public partial class ProvidersForm : Form
    {
        public ProvidersForm()
        {
            InitializeComponent();
            ShowProviders();
        }

        private void listView_Providers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_Providers.SelectedItems.Count==1)
            {
                ProviderSet provider = listView_Providers.SelectedItems[0].Tag as ProviderSet;
                textBoxName.Text = provider.Name;
                textBoxPhone.Text = provider.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxPhone.Text="";
            }
        }
        void ShowProviders()
        {
            listView_Providers.Items.Clear();
            foreach(ProviderSet provider in Program.bdSKI.ProviderSet)
            {
                ListViewItem item = new ListViewItem(new string[] {
                provider.Id.ToString(),provider.Name,provider.Phone
                });
                item.Tag = provider;
                listView_Providers.Items.Add(item);
            }
            listView_Providers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                ProviderSet provider = new ProviderSet();
                provider.Name = textBoxName.Text;
                provider.Phone = textBoxPhone.Text;
                Program.bdSKI.ProviderSet.Add(provider);
                Program.bdSKI.SaveChanges();
                ShowProviders();
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listView_Providers.SelectedItems.Count==1 && textBoxName.Text != "")
            {
                ProviderSet provider = listView_Providers.SelectedItems[0].Tag as ProviderSet;
                provider.Name = textBoxName.Text;
                provider.Phone = textBoxPhone.Text;
                Program.bdSKI.SaveChanges();
                ShowProviders();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_Providers.SelectedItems.Count == 1)
                {
                    ProviderSet provider = listView_Providers.SelectedItems[0].Tag as ProviderSet;
                    Program.bdSKI.ProviderSet.Remove(provider);
                    Program.bdSKI.SaveChanges();
                    ShowProviders();
                }
                textBoxName.Text = ""; 
                textBoxPhone.Text = "";
                
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
