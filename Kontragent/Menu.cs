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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void battonMenager_Click(object sender, EventArgs e)
        {
            Form Menager1 = new Menager1();
            Menager1.Show();
        }

        private void battonFizL_Click(object sender, EventArgs e)
        {
            Form FizL1 = new FizL1();
            FizL1.Show();
        }

        private void battonYourL_Click(object sender, EventArgs e)
        {
            Form YourL1 = new YourL1();
            YourL1.Show();
        }
    }
}
