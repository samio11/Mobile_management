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
    public partial class Xaumi : Form
    {
        public Xaumi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   button1.Visible = true;
         this.Hide();
            Xaumi_Phone x1 = new Xaumi_Phone();
            x1.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mi.com/global");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mobile m1 = new Mobile();
            m1.Show();
        }
    }
}
