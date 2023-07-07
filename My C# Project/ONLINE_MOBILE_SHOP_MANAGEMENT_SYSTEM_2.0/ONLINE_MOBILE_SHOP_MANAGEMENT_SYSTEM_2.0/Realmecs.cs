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
    public partial class Realmecs : Form
    {
        public Realmecs()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.realme.com/bd/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Realme_PHONE r1 = new Realme_PHONE();
            r1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mobile m1 = new Mobile();
            m1.Show();
        }
    }
}
