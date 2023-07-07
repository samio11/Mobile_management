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
    public partial class Mobile : Form
    {
        public Mobile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Iphonecs i1 = new Iphonecs();
            i1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnePlus o1 = new OnePlus();
            o1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Realmecs r1 = new Realmecs();
            r1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Xaumi x1 = new Xaumi();
            x1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Oppo oppo = new Oppo();
            oppo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vivo v1 = new Vivo();
            v1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c1 = new Customer();
            c1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Svmsungcs s1 = new Svmsungcs();
            s1.Show();
        }
    }
}
