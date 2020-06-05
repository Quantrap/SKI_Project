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
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
            ShowPersonal();
        }

        private void listView_Personal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Personal.SelectedItems.Count == 1)
            {
                PersonalSet clientSet = listView_Personal.SelectedItems[0].Tag as PersonalSet;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxStatus.Text = clientSet.Status;
                textBoxSalary.Text = clientSet.Salary.ToString();
                textBoxPost.Text = clientSet.Post;
                textBoxMagazine.Text = clientSet.Magazine.ToString();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxStatus.Text = "";
                textBoxSalary.Text = "";
                textBoxPost.Text = "";
                textBoxMagazine.Text = "";
            }
        }
        void ShowPersonal()
        {
            listView_Personal.Items.Clear();
            foreach (PersonalSet clientsSet in Program.bdSKI.PersonalSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        clientsSet.Id.ToString(),clientsSet.FirstName,clientsSet.MiddleName,
                        clientsSet.LastName,clientsSet.Phone,clientsSet.Status,clientsSet.Post,clientsSet.Salary.ToString(),clientsSet.Magazine.ToString()
                    });
                item.Tag = clientsSet;
                listView_Personal.Items.Add(item);


            }
            listView_Personal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PersonalSet clientSet = new PersonalSet();
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.Phone = textBoxPhone.Text;
            clientSet.Status = textBoxStatus.Text;
            clientSet.Salary = Convert.ToInt64(textBoxSalary.Text);
            clientSet.Post = textBoxPost.Text;
            clientSet.Magazine = Convert.ToInt32(textBoxMagazine.Text);
            Program.bdSKI.PersonalSet.Add(clientSet);
            Program.bdSKI.SaveChanges();
            ShowPersonal();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listView_Personal.SelectedItems.Count==1)
            {
                PersonalSet clientSet=listView_Personal.SelectedItems[0].Tag as PersonalSet;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Status = textBoxStatus.Text;
                clientSet.Salary = Convert.ToInt64(textBoxSalary.Text);
                clientSet.Post = textBoxPost.Text;
                clientSet.Magazine = Convert.ToInt32(textBoxMagazine.Text);
                Program.bdSKI.SaveChanges();
                ShowPersonal();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_Personal.SelectedItems.Count == 1)
                {
                    PersonalSet clientSet = listView_Personal.SelectedItems[0].Tag as PersonalSet;
                    Program.bdSKI.PersonalSet.Remove(clientSet);
                    Program.bdSKI.SaveChanges();
                    ShowPersonal();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxStatus.Text = "";
                textBoxSalary.Text = "";
                textBoxPost.Text = "";
                textBoxMagazine.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {

        }
    }
}
