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
    public partial class Customer_Purchase : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["oop2"].ConnectionString;
        public Customer_Purchase()
        {
           // bind();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "update CRAFT set PHONE_MODEL = @phone_model,PHONE_ID = @phone_id,PHONE_PRICE = @phone_price,PHONE_PURCHASE_DATE = @purchase,PAYMENT_STATUS = @status where PHONE_MODEL = @phone_model";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@phone_model", textBox1.Text);
            cmd.Parameters.AddWithValue("@phone_id", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone_price", textBox3.Text);
            cmd.Parameters.AddWithValue("@purchase", textBox4.Text);
            cmd.Parameters.AddWithValue("@status",comboBox1.SelectedItem);
            conn.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Updated succesfully", "Success", MessageBoxButtons.OK);
                bind();
                reset();
            }
            else
            {
                MessageBox.Show("Updated Failed", "Failur", MessageBoxButtons.OK);
            }
            conn.Close();
        }
        void bind()
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT * FROM CRAFT";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void reset()
        {
            textBox1.Clear();
            comboBox1.SelectedItem = null;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bind();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "delete from CRAFT where  PHONE_MODEL = @phone_model";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@phone_model", textBox1.Text);

            conn.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted succesfully", "Success", MessageBoxButtons.OK);
                bind();
                reset();
            }
            else
            {
                MessageBox.Show("Deleted Failed", "Failur", MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner o1 = new Owner();
            o1.Show();
        }
    }
}
