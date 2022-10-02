using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJECT_101._1
{
    public partial class Form13 : Form
    {
        public static string globalname;
        public static string globalsurname;
        private MySqlConnection databaseConnection()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showEquipment()
        {
            globalname = nametext.Text;
            globalsurname = surnametext.Text;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM customerinfo WHERE username = '{Form1.globaluser}' AND password ='{Form1.globalpassword}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataEquipment.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment1()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM shopping_cart";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public Form13()
        {
            InitializeComponent();
            showEquipment();
            showEquipment();
            showEquipment1();
        }        
        private void Btndata_Click(object sender, EventArgs e)
        {
            
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void dataEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dataEquipment.CurrentRow.Selected = true;
            nametext.Text = dataEquipment.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            surnametext.Text = dataEquipment.Rows[e.RowIndex].Cells["surname"].FormattedValue.ToString();
            addtext.Text = dataEquipment.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
            teltext.Text = dataEquipment.Rows[e.RowIndex].Cells["tel"].FormattedValue.ToString();
            emailtext.Text = dataEquipment.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            Hide();
            this.Close();
            printPreviewDialog1.ShowDialog();
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string sql1 = "DELETE FROM shopping_cart";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            int rows1 = cmd1.ExecuteNonQuery();
            conn.Close();
            showEquipment1();            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;");
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "SELECT price FROM shopping_cart";
            MySqlDataReader dr = cmd.ExecuteReader();
            int x = 0, y = 0;
            while (dr.Read())
            {
                x = dr.GetInt32(0);
                y += x;
            }
            string a = y.ToString();
            pricetext.Text = a;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {              
                e.Graphics.DrawImage(new Bitmap(@"C:\Users\WINDOWS\Downloads\911.png"), new Point(530,980));
                e.Graphics.DrawImage(new Bitmap(@"C:\Users\WINDOWS\Downloads\0.png"), new Point(660, 980));
                e.Graphics.DrawString("CKP Music and Instrument", new Font("Century Gothic", 26, FontStyle.Bold), Brushes.Black, new Point(200, 60));
                e.Graphics.DrawString($"{"ชื่อ : "+nametext.Text+" "+surnametext.Text }", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100,160));
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, 190));
                e.Graphics.DrawString(" ชื่อสินค้า                          จำนวน                       ราคา", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(100, 220));

                MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;");
                MySqlCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandText = "SELECT name,amount,price FROM shopping_cart";
                MySqlDataReader dr = cmd.ExecuteReader();
                int y_ = 0;
                while (dr.Read())
                {
                    e.Graphics.DrawString(dr.GetString("name"), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(100, 270 + 40 * y_));
                    e.Graphics.DrawString(dr.GetString("amount"), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(480, 270 + 40 * y_));
                    e.Graphics.DrawString(dr.GetString("price"), new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(680, 270 + 40 * y_));                    
                    y_++;
                }
                conn.Close();           
                int y1 = 320;             
                e.Graphics.DrawString("ราคารวม", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, (y1 + 610)));
                e.Graphics.DrawString($"{pricetext.Text} Bath", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(600, (y1 + 610)));                
                e.Graphics.DrawString("660-543-8418 ธนาคารกรุงไทย      ", new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(120, ((y1 + 590) + 45) + 45));
                e.Graphics.DrawString("ชื่อบัญชี นายชนาธิป เคนทรภักดิ์           ", new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(120, (((y1 + 590) + 45) + 45) + 45));
            }
        }

        private void pricetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ยืนยันการทำรายการหรือไม่?", "แจ้งตือน", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    int selectedRow = dataGridView1.CurrentCell.RowIndex;
                    int deleteId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["id"].Value);
                    MySqlConnection conn = databaseConnection();
                    String sql = "DELETE FROM shopping_cart WHERE id = '" + deleteId + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("ลบสินค้าสำเร็จ");
                        showEquipment1();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
