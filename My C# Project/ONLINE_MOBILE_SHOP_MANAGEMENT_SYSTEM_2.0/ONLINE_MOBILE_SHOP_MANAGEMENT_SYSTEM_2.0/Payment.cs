using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ONLINE_MOBILE_SHOP_MANAGEMENT_SYSTEM_2._0
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bkash.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://nagad.com.bd/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.dutchbanglabank.com/rocket/rocket.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.islamibankbd.com/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
           Customer c1 = new Customer();
            c1.Show();
        }
    }
}
