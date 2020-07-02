using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontragent
{
    public partial class FizL1 : Form
    {
        public FizL1()
        {
            InitializeComponent();
            ShowFizL(); 
            ShowMenager();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FizL fizL = new FizL();
            fizL.INN = textBoxINN.Text;
            fizL.FirstName = textBoxFirstName.Text;
            fizL.LastName = textBoxLastName.Text;
            fizL.MiddleName = textBoxMiddleName.Text;
            fizL.Gender = comboBoxGender.Text;
            fizL.E_mail = textBoxEmail.Text;
            fizL.IDMenager= Convert.ToInt32(comboBoxMenager.SelectedItem.ToString().Split('.')[0]);
            Program.qwer.FizL.Add(fizL);
            Program.qwer.SaveChanges();
            ShowFizL();
        }

        void ShowMenager()
        {
            comboBoxMenager.Items.Clear();
            foreach (Menager menager in Program.qwer.Menager)
            {
                string[] item = { menager.ID.ToString() + ".",menager.FirstName, menager.LastName, menager.MiddleName };
                comboBoxMenager.Items.Add(string.Join(" ", item));
            }
        }

        
        void ShowFizL()
        {
            listViewFizL.Items.Clear();
            foreach (FizL fizL in Program.qwer.FizL)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    fizL.ID.ToString(),fizL.INN, fizL.FirstName,fizL.LastName,
                    fizL.MiddleName, fizL.Gender, fizL.E_mail, 
                    fizL.IDMenager.ToString() +"."+
                    fizL.Menager.FirstName+ " "+
                    fizL.Menager.LastName+ " "+
                    fizL.Menager.MiddleName,

                });
                item.Tag = fizL;
                listViewFizL.Items.Add(item);
            }
            listViewFizL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewFizL.SelectedItems.Count == 1)
            {
                FizL fizL = listViewFizL.SelectedItems[0].Tag as FizL;
                fizL.INN = textBoxINN.Text;
                fizL.FirstName = textBoxFirstName.Text;
                fizL.LastName = textBoxLastName.Text;
                fizL.MiddleName = textBoxMiddleName.Text;
                fizL.Gender = comboBoxGender.Text;
                fizL.E_mail = textBoxEmail.Text;
                fizL.IDMenager = Convert.ToInt32(comboBoxMenager.SelectedItem.ToString().Split('.')[0]);
                Program.qwer.SaveChanges();
                ShowFizL();
            }
        }

        private void listViewFizL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFizL.SelectedItems.Count == 1)
            {
                FizL fizL = listViewFizL.SelectedItems[0].Tag as FizL;
                textBoxINN.Text = fizL.INN;
                textBoxFirstName.Text = fizL.FirstName;
                textBoxLastName.Text = fizL.LastName;
                textBoxMiddleName.Text = fizL.MiddleName;
                comboBoxGender.Text = fizL.Gender;
                textBoxEmail.Text = fizL.E_mail;
                comboBoxMenager.Text = fizL.IDMenager.ToString();

            }
            else
            {
                textBoxINN.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                comboBoxGender.Text = "";
                textBoxEmail.Text = "";
                comboBoxMenager.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFizL.SelectedItems.Count == 1)
                {
                    FizL fizL = listViewFizL.SelectedItems[0].Tag as FizL;
                    Program.qwer.FizL.Remove(fizL);
                    Program.qwer.SaveChanges();
                    ShowFizL();
                }
                textBoxINN.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                comboBoxGender.Text = "";
                textBoxEmail.Text = "";
                comboBoxMenager.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelINN_Click(object sender, EventArgs e)
        {

        }

        private void textBoxINN_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMenager_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMenager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FizL1_Load(object sender, EventArgs e)
        {

        }
    }
}
