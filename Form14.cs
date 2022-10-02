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
    public partial class Form14 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataEquipment.DataSource = ds.Tables[0].DefaultView;
        }
        private void resetdata()
        {
            txtname.Clear();
            txtprice.Clear();
            txtpath.Text = "";
            pictureBox1.Image = null;
        }
        public Form14()
        {
            InitializeComponent();
        }
        private void dataEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataEquipment.CurrentRow.Selected = true;
            textstock.Text = dataEquipment.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
            txtname.Text = dataEquipment.CurrentRow.Cells["product"].Value.ToString();
            txtprice.Text = dataEquipment.CurrentRow.Cells["price"].Value.ToString();
            txtpath.Text = dataEquipment.CurrentRow.Cells["pathimage"].Value.ToString();
            textbrand.Text = dataEquipment.CurrentRow.Cells["brand"].Value.ToString();
            txttype.Text = dataEquipment.CurrentRow.Cells["type"].Value.ToString();
            if (Path.GetFileName(txtpath.Text) != "")
            {
                string newFileName = txtpath.Text;
                pictureBox1.Image = new Bitmap(newFileName);
            }            
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            //showEquipment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM history";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataEquipment.DataSource = ds.Tables[0].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataEquipment.DataSource = ds.Tables[0].DefaultView;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pathimage = @"C:\Users\WINDOWS\Desktop\PROJECT C#\PROJECT C#\imageckp\" + Path.GetFileName(txtpath.Text);
            string name = txtname.Text;
            int price = Convert.ToInt32(txtprice.Text);
            Edit(pathimage, name, price);
        }
        private void textstock_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)| *.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                txtpath.Text = open.FileName;
            }
        }
        private void Edit(string pathimage, string name, int price)
        {

            int selectedRow = dataEquipment.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataEquipment.Rows[selectedRow].Cells["id"].Value);
            string newFileName = pathimage.Replace("\\", "\\\\");
            MySqlConnection conn = databaseConnection();
            string sql = "UPDATE stock SET product = '" + name + "',brand = '"+ textbrand.Text +"',type = '"+ txttype.Text +"',price = '" + price + "',amount = '"+ textstock.Text +"',pathimage = '" + newFileName + "' WHERE id = '" + editId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("แก้ไขสินค้าเสร็จแล้วครับ");
                resetdata();
                showEquipment();
            }
        }
        private void Add(string pathimage, string name, int price)
        {
            string newFileName = pathimage.Replace("\\", "\\\\");
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO stock (product,brand,type,price,amount,pathimage) VALUES ('" + name + "','"+ textbrand.Text +"','"+ txttype.Text +"','" + price + "','" + textstock.Text + "','" + newFileName + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("เพิ่มสินค้าเรียบร้อย");
                resetdata();
                showEquipment();
            }
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            string pathimage = @"C:\Users\WINDOWS\Desktop\PROJECT C#\PROJECT C#\imageckp\" + Path.GetFileName(txtpath.Text);
            string name = txtname.Text;
            int price = Convert.ToInt32(txtprice.Text);
            Add(pathimage, name, price);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ยืนยันการทำรายการหรือไม่?", "แจ้งตือน", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    int selectedRow = dataEquipment.CurrentCell.RowIndex;
                    int deleteId = Convert.ToInt32(dataEquipment.Rows[selectedRow].Cells["id"].Value);
                    MySqlConnection conn = databaseConnection();
                    String sql = "DELETE FROM stock WHERE id = '" + deleteId + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                        showEquipment();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form15 total = new Form15();
            Hide();
            total.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
