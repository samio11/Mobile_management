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
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.microsoft.com/en-us/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.amazon.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.intel.com/content/www/us/en/homepage.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://about.google/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner o1 = new Owner();
            o1.Show();
        }
    }
}
