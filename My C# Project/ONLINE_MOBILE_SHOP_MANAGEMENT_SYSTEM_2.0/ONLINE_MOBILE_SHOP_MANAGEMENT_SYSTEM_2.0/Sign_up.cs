using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ONLINE_MOBILE_SHOP_MANAGEMENT_SYSTEM_2._0
{
    public partial class Sign_up : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["oop2"].ConnectionString;
        public Sign_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "insert into CUSTOMER VALUES(@name,@age,@gender,@email,@password)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name",textBox1.Text);
            cmd.Parameters.AddWithValue("@age",numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@gender",comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@password", textBox3.Text);

            conn.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("New Customer Added Succesfully", "Success", MessageBoxButtons.OK);
                MessageBox.Show("Thank You Sir", "Success", MessageBoxButtons.OK);
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
                
            }
            else
            {
                MessageBox.Show("New Customer Added Failed", "Failur", MessageBoxButtons.OK);
                MessageBox.Show("Sorry Sir! Plese fill the form properly", "Success", MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }
    }
}
