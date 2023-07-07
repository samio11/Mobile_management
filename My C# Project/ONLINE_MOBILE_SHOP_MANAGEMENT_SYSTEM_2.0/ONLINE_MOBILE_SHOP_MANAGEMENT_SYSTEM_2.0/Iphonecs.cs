using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONLINE_MOBILE_SHOP_MANAGEMENT_SYSTEM_2._0
{
    public partial class Iphonecs : Form
    {
        public Iphonecs()
        {
            InitializeComponent();
        }

        private void Iphonecs_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Iphone_14_series i1 = new Iphone_14_series();
            i1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            I_13_series i2 = new I_13_series();
            i2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Iphone_12 i3 = new Iphone_12();
            i3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Iphone_11cs i4 = new Iphone_11cs();
            i4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            IphoneSE i5 = new IphoneSE();
            i5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mobile m1 = new Mobile();
            m1.Show();
        }
    }
}
