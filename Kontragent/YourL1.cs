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
    public partial class YourL1 : Form
    {
        public YourL1()
        {
            InitializeComponent();
            ShowYourL();
            ShowMenager();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            YourL yourL = new YourL();
            yourL.INN = textBoxINN.Text;
            yourL.Name = textBoxName.Text;
            yourL.Adress = textBoxAdress.Text;
            yourL.E_mail = textBoxEmail.Text;
            yourL.IDMenager = Convert.ToInt32(comboBoxMenager.SelectedItem.ToString().Split('.')[0]);
            Program.qwer.YourL.Add(yourL);
            Program.qwer.SaveChanges();
            ShowYourL();
        }

        void ShowMenager()
        {
            comboBoxMenager.Items.Clear();
            foreach (Menager menager in Program.qwer.Menager)
            {
                string[] item = { menager.ID.ToString() + ".", menager.FirstName, menager.LastName, menager.MiddleName };
                comboBoxMenager.Items.Add(string.Join(" ", item));
            }
        }

        void ShowYourL()
        {
            listViewYourL.Items.Clear();
            foreach (YourL yourL in Program.qwer.YourL)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    yourL.ID.ToString(),yourL.INN, yourL.Name, yourL.Adress,
                    yourL.E_mail,
                    yourL.IDMenager.ToString() +"."+
                    yourL.Menager.FirstName+ " "+
                    yourL.Menager.LastName+ " "+
                    yourL.Menager.MiddleName,

                });
                item.Tag = yourL;
                listViewYourL.Items.Add(item);
            }
            listViewYourL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewYourL.SelectedItems.Count == 1)
            {
                YourL yourL = listViewYourL.SelectedItems[0].Tag as YourL;
                yourL.INN = textBoxINN.Text;
                yourL.Name = textBoxName.Text;
                yourL.Adress = textBoxAdress.Text;
                yourL.E_mail = textBoxEmail.Text;
                yourL.IDMenager = Convert.ToInt32(comboBoxMenager.SelectedItem.ToString().Split('.')[0]);
                Program.qwer.SaveChanges();
                ShowYourL();
            }
        }

        private void listViewYourL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewYourL.SelectedItems.Count == 1)
            {
                YourL yourL = listViewYourL.SelectedItems[0].Tag as YourL;
                textBoxINN.Text = yourL.INN;
                textBoxName.Text = yourL.Name;
                textBoxAdress.Text = yourL.Adress;
                textBoxEmail.Text = yourL.E_mail;
                comboBoxMenager.Text = yourL.IDMenager.ToString();

            }
            else
            {
                textBoxINN.Text = "";
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxEmail.Text = "";
                comboBoxMenager.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewYourL.SelectedItems.Count == 1)
                {
                    YourL yourL = listViewYourL.SelectedItems[0].Tag as YourL;
                    Program.qwer.YourL.Remove(yourL);
                    Program.qwer.SaveChanges();
                    ShowYourL();
                }
                textBoxINN.Text = "";
                textBoxName.Text = "";
                textBoxAdress.Text = "";
                textBoxEmail.Text = "";
                comboBoxMenager.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMenager_Click(object sender, EventArgs e)
        {

        }
    }
}
