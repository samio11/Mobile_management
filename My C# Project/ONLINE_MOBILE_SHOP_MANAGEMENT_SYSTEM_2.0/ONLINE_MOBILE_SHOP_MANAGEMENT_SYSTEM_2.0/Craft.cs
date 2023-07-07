using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.Data.SqlClient;

namespace ONLINE_MOBILE_SHOP_MANAGEMENT_SYSTEM_2._0
{
    public partial class Craft : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["oop2"].ConnectionString;
        public string phone_id, phone_model, phone_price;

        private void Craft_Load(object sender, EventArgs e)
        {
            textBox1.Text = phone_model.ToString();
            textBox2.Text = phone_id.ToString();
            textBox3.Text = phone_price.ToString();

            DateTime dateTime = DateTime.Now;
            textBox4.Text = dateTime.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mobile m1 = new Mobile();
            m1.Show();
        }

        public Craft(string id,string model,string price)
        {
            InitializeComponent();
            phone_id = id;
            phone_model = model;
            phone_price = price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "insert into CRAFT VALUES(@phone_model,@phone_id,@phone_price,@phone_purchase,@status)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@phone_model", textBox1.Text);
            cmd.Parameters.AddWithValue("@phone_id", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone_price", textBox3.Text);
            cmd.Parameters.AddWithValue("@phone_purchase", textBox4.Text);
            cmd.Parameters.AddWithValue("@status", textBox5.Text);
            conn.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Added phone succesfully and ready for payment", "Success", MessageBoxButtons.OK);
                this.Hide();
                Payment p1 = new Payment();
                p1.Show();
                //bind();
                //reset();
            }
            else
            {
                MessageBox.Show("Added Failed", "Failur", MessageBoxButtons.OK);
            }
            conn.Close();
        }
    }
}
