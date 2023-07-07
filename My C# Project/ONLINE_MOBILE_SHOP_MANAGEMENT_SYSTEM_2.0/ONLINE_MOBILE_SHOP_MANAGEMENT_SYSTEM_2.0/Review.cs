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
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c2 = new Customer();
            c2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your review","success",MessageBoxButtons.OK);
            this.Hide();
            Customer c2 = new Customer();
            c2.Show();
        }
    }
}
