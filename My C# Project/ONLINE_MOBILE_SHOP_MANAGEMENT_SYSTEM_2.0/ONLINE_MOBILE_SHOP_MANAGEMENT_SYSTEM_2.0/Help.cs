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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://www.facebook.com/samio.hasan.37");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c2 = new Customer();
            c2.Show();
        }
    }
}
