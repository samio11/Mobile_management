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
    public partial class Oppo : Form
    {
        public Oppo()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Oppo_Phone o2 = new Oppo_Phone();
            o2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mobile m1 = new Mobile();
            m1.Show();
        }
    }
}
