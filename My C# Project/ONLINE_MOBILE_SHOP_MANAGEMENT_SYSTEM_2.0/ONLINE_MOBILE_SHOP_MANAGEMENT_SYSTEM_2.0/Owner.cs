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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void Owner_Load(object sender, EventArgs e)
        {
           // this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home1 home1 = new Home1();
            home1.Show();   
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home1 home1 = new Home1();
            home1.Show();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Purchase p1 = new Customer_Purchase();
            p1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Purchase p1 = new Customer_Purchase();
            p1.Show();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Red;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Red;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee e1 = new Employee();
            e1.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee e1 = new Employee();
            e1.Show();
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Red;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profit_and_loose p2 = new Profit_and_loose();
            p2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profit_and_loose p2 = new Profit_and_loose();
            p2.Show();
        }

        private void panel5_Click_1(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}
