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
    public partial class Form10 : Form
    {
        ListViewItem itm;
        string[] arl = new string[4];
        public Form10()
        {
            InitializeComponent();
            showEquipment1();
            showEquipment3();
            showEquipment5();
            showEquipment6();
            showEquipment7();
            showEquipment8();
            showEquipment9();
            day.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Delay' AND type ='Effect'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment3()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Reverb' AND type ='Effect'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView3.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment5()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Over Drive' AND type ='Effect'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView5.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment6()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Distortion' AND type ='Effect'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView6.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment7()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Wah Wah' AND type ='Effect'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView7.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment8()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Tuner' AND type ='Effect'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView8.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment9()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE brand = 'Power supply' AND type ='Effect'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView9.DataSource = ds.Tables[0].DefaultView;
        }
        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Form13 bill = new Form13();
            Hide();
            this.Close();
            bill.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form13 bill = new Form13();
            Hide();
            this.Close();
            bill.ShowDialog();
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
                    MessageBox.Show("เพิ่มสินค้าลงรายการสินค้าเรียบร้อยแล้ว", "แจ้งเตือน");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView5.CurrentRow.Selected = true;
                name.Text = dataGridView5.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
                brand.Text = dataGridView5.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                price.Text = dataGridView5.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                txtpath.Text = dataGridView5.CurrentRow.Cells["pathimage"].Value.ToString();
                if (Path.GetFileName(txtpath.Text) != "")
                {
                    string newFileName = txtpath.Text;
                    pictureBox1.Image = new Bitmap(newFileName);
                }
            }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView6.CurrentRow.Selected = true;
                name.Text = dataGridView6.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
                brand.Text = dataGridView6.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                price.Text = dataGridView6.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                txtpath.Text = dataGridView6.CurrentRow.Cells["pathimage"].Value.ToString();
                if (Path.GetFileName(txtpath.Text) != "")
                {
                    string newFileName = txtpath.Text;
                    pictureBox1.Image = new Bitmap(newFileName);
                }
            }
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView7.CurrentRow.Selected = true;
                name.Text = dataGridView7.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
                brand.Text = dataGridView7.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                price.Text = dataGridView7.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                txtpath.Text = dataGridView7.CurrentRow.Cells["pathimage"].Value.ToString();
                if (Path.GetFileName(txtpath.Text) != "")
                {
                    string newFileName = txtpath.Text;
                    pictureBox1.Image = new Bitmap(newFileName);
                }
            }
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView8.CurrentRow.Selected = true;
                name.Text = dataGridView8.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
                brand.Text = dataGridView8.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                price.Text = dataGridView8.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                txtpath.Text = dataGridView8.CurrentRow.Cells["pathimage"].Value.ToString();
                if (Path.GetFileName(txtpath.Text) != "")
                {
                    string newFileName = txtpath.Text;
                    pictureBox1.Image = new Bitmap(newFileName);
                }
            }
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataGridView9.CurrentRow.Selected = true;
                name.Text = dataGridView9.Rows[e.RowIndex].Cells["product"].FormattedValue.ToString();
                brand.Text = dataGridView9.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                price.Text = dataGridView9.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                txtpath.Text = dataGridView9.CurrentRow.Cells["pathimage"].Value.ToString();
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
    }
}
