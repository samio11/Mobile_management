using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace ONLINE_MOBILE_SHOP_MANAGEMENT_SYSTEM_2._0
{
    public partial class I_13_series : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["oop2"].ConnectionString;
        int total_price;
        public I_13_series()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File(*.png,*.jpg) | *.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into IPHONE values(@phone_id,@phone_model,@phone_price,@phone_discount,@total_price,@Phone_picture)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@phone_id", textBox1.Text);
            cmd.Parameters.AddWithValue("@phone_model", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@phone_price", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone_discount", textBox3.Text);
            cmd.Parameters.AddWithValue("@total_price", textBox4.Text);
            cmd.Parameters.AddWithValue("@phone_picture", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Inserted Succesfully");
                // Bind();
                // reset();
            }
            else
            {
                MessageBox.Show("Inserted Failed");
            }
            con.Close();
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        void reset()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedItem = null;
            pictureBox1.Image = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         /*     int phone_price1 = Convert.ToInt32(textBox2.Text);
           if (phone_price1<= 40000)
           {
               textBox3.Text = "2%";
               int discount = (int)(phone_price1 * 0.02);
               total_price = phone_price1 - discount;
               textBox4.Text = total_price.ToString();
           }
           else if (phone_price1 >= 40000 && phone_price1< 80000)
           {
               textBox3.Text = "5%";
               int discount = (int)(phone_price1 * 0.05);
               total_price = phone_price1 - discount;
               textBox4.Text = total_price.ToString();
           }
           else if (phone_price1 >= 80000 && phone_price1 < 100000)
           {
               textBox3.Text = "7%";
               int discount = (int)(phone_price1 * 0.07);
               total_price = phone_price1 - discount;
               textBox4.Text = total_price.ToString();
           }
           else if(phone_price1 >= 100000 && phone_price1 <= 150000)
           {
               textBox3.Text = "10%";
               int discount = (int)(phone_price1 * 0.10);
               total_price = phone_price1 - discount;
               textBox4.Text = total_price.ToString();
           }
            else
            {
                textBox3.Text = "13%";
                int discount = (int)(phone_price1 * 0.13);
                total_price = phone_price1 - discount;
                textBox4.Text = total_price.ToString();
            }
        */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select PHONE_ID,PHONE_MODEL,PHONE_PRICE,PHONE_DISCOUNT,TOTAL_PRICE,PHONE_PICTURE from IPHONE where PHONE_MODEL = @phone_model", con);
            cmd1.Parameters.AddWithValue("@phone_model", comboBox1.SelectedItem);

            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                textBox1.Text = rd["PHONE_ID"].ToString();
                textBox2.Text = rd["PHONE_PRICE"].ToString();
                textBox3.Text = rd["PHONE_DISCOUNT"].ToString();
                textBox4.Text = rd["TOTAL_PRICE"].ToString();

                byte[] img = (byte[])rd["PHONE_PICTURE"];
                using (MemoryStream ms = new MemoryStream(img))
                {

                    // create a Bitmap object from the MemoryStream
                    Bitmap bmp = new Bitmap(ms);

                    // display the bitmap in the picture box
                    pictureBox1.Image = bmp;
                }
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.apple.com/shop/buy-iphone/iphone-13");
        }

        private void I_13_series_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string p_id, p_model, p_price;
            p_id = textBox1.Text;
            p_model = comboBox1.SelectedItem.ToString();
            p_price = textBox4.Text;
            Craft c1 = new Craft(p_id, p_model, p_price);
            this.Hide();
            c1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Iphonecs i1 = new Iphonecs();
            i1.Show();
        }
    }
}
