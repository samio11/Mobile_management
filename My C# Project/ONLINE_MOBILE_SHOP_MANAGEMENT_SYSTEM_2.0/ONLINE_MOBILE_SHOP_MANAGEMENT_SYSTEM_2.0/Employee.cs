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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace ONLINE_MOBILE_SHOP_MANAGEMENT_SYSTEM_2._0
{
    public partial class Employee : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["oop2"].ConnectionString;
        public Employee()
        {
            //Bind();
            InitializeComponent();
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }
        void Bind()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from EMPLOYEE";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        void reset()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           //
            pictureBox1.Image = null;
            textBox1.Focus();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[4].Value);

        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream stream = new MemoryStream(photo);
            return Image.FromStream(stream);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update EMPLOYEE set employee_name = @employee_name,employee_id = @employee_id,employee_post = @employee_post,employee_salary = @employee_salary,photo = @img where employee_id = @employee_id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@employee_id", textBox2.Text);
            cmd.Parameters.AddWithValue("@employee_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@employee_post", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@employee_salary", textBox3.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Updated Succesfully");
                Bind();
                reset();
            }
            else
            {
                MessageBox.Show("Updated Failed");
            }
            con.Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Bind();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "delete from EMPLOYEE where  EMPLOYEE_NAME = @name";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", textBox1.Text);

            conn.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted succesfully", "Success", MessageBoxButtons.OK);
                Bind();
                reset();
            }
            else
            {
                MessageBox.Show("Deleted Failed", "Failur", MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Employee a1 = new Add_New_Employee();
            a1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner o2 = new Owner();
            o2.Show();
        }
    }
}
