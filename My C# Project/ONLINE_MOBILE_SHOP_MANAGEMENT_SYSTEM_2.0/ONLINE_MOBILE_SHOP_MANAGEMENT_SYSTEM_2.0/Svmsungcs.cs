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
    public partial class Svmsungcs : Form
    {
        public Svmsungcs()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
          //  button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Svmsung_Phone s1 = new Svmsung_Phone();
            s1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mobile m1 = new Mobile();
            m1.Show();
        }
    }
}
