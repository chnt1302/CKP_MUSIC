using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJECT_101._1
{
    public partial class Form4 : Form
    {
        public static string name1;
        ListViewItem itm;
        string[] arl = new string[4];
        public static string globalday; 
        public Form4()
        {
            InitializeComponent();
            showEquipment1();
            showEquipment2();
            showEquipment3();
            showEquipment4();
            day.Text = DateTime.Now.ToString("dd/MM/yyyy");
            globalday = day.Text;
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form13 bill = new Form13();
            Hide();
            this.Close();
            bill.ShowDialog();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showEquipment1()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Fender' AND type ='Stratocaster'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataEquipment.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment2()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Fender' AND type ='Acoutic'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView3.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment3()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Fender' AND type ='Telecaster'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment4()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Fender' AND type ='Jazzmaster'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataEquipment.CurrentRow.Selected = true;
                name.Text = dataEquipment.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
                brand.Text = dataEquipment.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                price.Text = dataEquipment.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                txtpath.Text = dataEquipment.CurrentRow.Cells["pathimage"].Value.ToString();
                if (Path.GetFileName(txtpath.Text) != "")
                {
                    string newFileName = txtpath.Text;
                    pictureBox1.Image = new Bitmap(newFileName);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                int a = Convert.ToInt32(price.Text);
                arl[3] = a * numericUpDown2.Value + "";
                arl[1] = name.Text;
                arl[2] = numericUpDown2.Value.ToString();

                string p = a * numericUpDown2.Value + " ฿";
                if (numericUpDown2.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด", "ประกาศ");
                }
                else
                {
                    MessageBox.Show("เพิ่มสินค้าลงรายการสินค้าเรียบร้อยแล้ว","แจ้งเตือน");
                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;");
                    con.Open();
                    String sql = $"INSERT INTO shopping_cart (name,amount,price) VALUES ('{name.Text}','{numericUpDown2.Value}','{p}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                    String sql2 = $"INSERT INTO history (username,product,amount,price,date) VALUES ('{Form1.globaluser}','{name.Text}','{numericUpDown2.Value}','{p}','{day.Text}')";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                    int rows1 = cmd2.ExecuteNonQuery();
                    con.Close();

                }
                MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;");
                MySqlCommand cmd1 = conn.CreateCommand();
                conn.Open();
                cmd1.CommandText = $"SELECT amount FROM stock WHERE product = '{name.Text}' ";
                MySqlDataReader dr = cmd1.ExecuteReader();
                int x = 0, y = 0;
                while (dr.Read())
                {
                    x = dr.GetInt32(0);
                }
                y = (int)numericUpDown2.Value;
                int b = x - y;
                string z = b.ToString();
                conn.Close();
                conn.Open();
                String sql11 = $"UPDATE stock SET amount = {z} WHERE product = '{name.Text}' ";
                MySqlCommand cmd11 = new MySqlCommand(sql11, conn);
                int rows11 = cmd11.ExecuteNonQuery();
                conn.Close();
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form13 bill = new Form13();
            Hide();
            this.Close();
            bill.ShowDialog();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView3.CurrentRow.Selected = true;
                name.Text = dataGridView3.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
                brand.Text = dataGridView3.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                price.Text = dataGridView3.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                txtpath.Text = dataGridView3.CurrentRow.Cells["pathimage"].Value.ToString();
                if (Path.GetFileName(txtpath.Text) != "")
                {
                    string newFileName = txtpath.Text;
                    pictureBox1.Image = new Bitmap(newFileName);
                }
            }
        }  
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView1.CurrentRow.Selected = true;
                name.Text = dataGridView1.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
                brand.Text = dataGridView1.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                price.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                txtpath.Text = dataGridView1.CurrentRow.Cells["pathimage"].Value.ToString();
                if (Path.GetFileName(txtpath.Text) != "")
                {
                    string newFileName = txtpath.Text;
                    pictureBox1.Image = new Bitmap(newFileName);
                }
            }
        }

        private void datagridview2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView2.CurrentRow.Selected = true;
                name.Text = dataGridView2.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
                brand.Text = dataGridView2.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                price.Text = dataGridView2.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                txtpath.Text = dataGridView2.CurrentRow.Cells["pathimage"].Value.ToString();
                if (Path.GetFileName(txtpath.Text) != "")
                {
                    string newFileName = txtpath.Text;
                    pictureBox1.Image = new Bitmap(newFileName);
                }
            }
        }

        private void Btnback_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brand_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void txtpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }
    }
}
