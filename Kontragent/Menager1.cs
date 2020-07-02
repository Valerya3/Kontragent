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
    public partial class Menager1 : Form
    {
        public Menager1()
        {
            InitializeComponent();
            ShowMenager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Menager menager = new Menager();
            menager.FirstName = textBoxFirstName.Text;
            menager.LastName = textBoxLastName.Text;
            menager.MiddleName = textBoxMiddleName.Text;
            menager.E_mail = textBoxEmail.Text;
            Program.qwer.Menager.Add(menager);
            Program.qwer.SaveChanges();
            ShowMenager();
        }

        void ShowMenager ()
        {
            listViewMenager.Items.Clear();
            foreach (Menager menager in Program.qwer.Menager)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    menager.ID.ToString(),menager.FirstName,menager.LastName,
                    menager.MiddleName,  menager.E_mail
                });
                item.Tag = menager;
                listViewMenager.Items.Add(item);
            }
            listViewMenager.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMenager.SelectedItems.Count == 1)
            {
                Menager menager = listViewMenager.SelectedItems[0].Tag as Menager;
                menager.FirstName = textBoxFirstName.Text;
                menager.LastName = textBoxLastName.Text;
                menager.MiddleName = textBoxMiddleName.Text;
                menager.E_mail = textBoxEmail.Text;
                Program.qwer.SaveChanges();
                ShowMenager();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMenager.SelectedItems.Count == 1)
                {
                    Menager menager = listViewMenager.SelectedItems[0].Tag as Menager;
                    Program.qwer.Menager.Remove(menager);
                    Program.qwer.SaveChanges();
                    ShowMenager();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
