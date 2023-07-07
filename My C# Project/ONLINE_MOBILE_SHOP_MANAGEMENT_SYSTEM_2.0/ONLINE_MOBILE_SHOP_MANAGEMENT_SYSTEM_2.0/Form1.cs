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
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["oop2"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
           // button1.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.Brown;
            button1.ForeColor= Color.White;
          //   button1.Show();

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select EMAIL,PASSWORD from OWNER where email = @email and password = @password";
            
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();


            if (rd.HasRows == true)
            {
                MessageBox.Show("Signin Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("You are joining as owner");
                this.Hide();
                Owner o1 = new Owner();
                o1.Show();
            }


            else
            {
                con.Close();

                SqlConnection con2 = new SqlConnection(cs);
                string query2 = "select EMAIL,PASSWORD from CUSTOMER where email = @email and password = @password";

                SqlCommand cmd2 = new SqlCommand(query2, con2);
                cmd2.Parameters.AddWithValue("@email", textBox1.Text);
                cmd2.Parameters.AddWithValue("@password", textBox2.Text);

                con2.Open();
                SqlDataReader rd1 = cmd2.ExecuteReader();


                if (rd1.HasRows == true)
                {
                    MessageBox.Show("Signin Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("You are joining as Customer");
                    this.Hide();
                   Customer c1 = new Customer();
                    c1.Show();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                con2.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up s1 = new Sign_up();
            s1.Show();
        }
    }
}
