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
using System.IO;

namespace ONLINE_MOBILE_SHOP_MANAGEMENT_SYSTEM_2._0
{
    public partial class Add_New_Employee : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["oop2"].ConnectionString;
        public Add_New_Employee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File(*.png,*.jpg) | *.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(ofd.FileName);
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into EMPLOYEE values(@name,@id,@post,@salary,@img)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@id", textBox2.Text);
            cmd.Parameters.AddWithValue("@post", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@salary", textBox4.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Employee Added Succesfully");
               // Bind();
               // reset();
            }
            else
            {
                MessageBox.Show("Employee Added Failed");
            }
            con.Close();
        }


        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            return ms.GetBuffer();
        }
        void Bind()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from EMPLOYEE";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
           /* dataGridView1.DataSource = data;


            DataGridViewImageColumn d1 = new DataGridViewImageColumn();
            d1 = (DataGridViewImageColumn)dataGridView1.Columns[1];
            d1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
           */
        }

        void reset()
        {
            textBox1.Clear();
            pictureBox2.Image = null;
            textBox2.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee e1 = new Employee();
            e1.Show();
        }
    }
}
