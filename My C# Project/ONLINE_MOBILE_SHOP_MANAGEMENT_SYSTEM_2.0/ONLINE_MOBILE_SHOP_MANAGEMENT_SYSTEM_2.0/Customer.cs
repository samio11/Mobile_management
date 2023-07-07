using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ONLINE_MOBILE_SHOP_MANAGEMENT_SYSTEM_2._0
{
    public partial class Customer : Form
    {
        string id, model, price;
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Black;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Black;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.White;
        }

        private void button2_MouseHover_1(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mobile m1 = new Mobile();
            m1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment p1 = new Payment();
            p1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Review r1 = new Review();
            r1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Show();
            Show_Sells s1 = new Show_Sells();
            s1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Show();
            Help h1 = new Help();
            h1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
           C1 c = new C1();
            c.Show();
        }
    }
}
