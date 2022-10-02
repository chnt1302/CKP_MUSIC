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

namespace PROJECT_101._1
{
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nametext.Text.Length != 0)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "INSERT INTO customerinfo (name,surname,address,tel,email,username,password) VALUES('" + nametext.Text + "','" + surnametext.Text + "','" + addtext.Text + "','" + teltext.Text + "','" + emailtext.Text + "','" + usertext.Text + "','" + passtext.Text + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                string sql1 = "INSERT INTO login (username,password) VALUES('" + usertext.Text + "','" + passtext.Text + "')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                int rows1 = cmd1.ExecuteNonQuery();
                MessageBox.Show("ทำรายการเสร็จสิ้น");
                conn.Close();
                Form1 Login = new Form1();
                Hide();
                Login.ShowDialog();
                this.Close();
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            if (surnametext.Text.Length != 0)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "INSERT INTO customerinfo (name,surname,address,tel,email,username,password) VALUES('" + nametext.Text + "','" + surnametext.Text + "','" + addtext.Text + "','" + teltext.Text + "','" + emailtext.Text + "','" + usertext.Text + "','" + passtext.Text + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                string sql1 = "INSERT INTO login (username,password) VALUES('" + usertext.Text + "','" + passtext.Text + "')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                int rows1 = cmd1.ExecuteNonQuery();
                MessageBox.Show("ทำรายการเสร็จสิ้น");
                conn.Close();
                Form1 Login = new Form1();
                Hide();
                Login.ShowDialog();
                this.Close();
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            if (addtext.Text.Length != 0)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "INSERT INTO customerinfo (name,surname,address,tel,email,username,password) VALUES('" + nametext.Text + "','" + surnametext.Text + "','" + addtext.Text + "','" + teltext.Text + "','" + emailtext.Text + "','" + usertext.Text + "','" + passtext.Text + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                string sql1 = "INSERT INTO login (username,password) VALUES('" + usertext.Text + "','" + passtext.Text + "')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                int rows1 = cmd1.ExecuteNonQuery();
                MessageBox.Show("ทำรายการเสร็จสิ้น");
                conn.Close();
                Form1 Login = new Form1();
                Hide();
                Login.ShowDialog();
                this.Close();
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            if (teltext.Text.Length != 0)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "INSERT INTO customerinfo (name,surname,address,tel,email,username,password) VALUES('" + nametext.Text + "','" + surnametext.Text + "','" + addtext.Text + "','" + teltext.Text + "','" + emailtext.Text + "','" + usertext.Text + "','" + passtext.Text + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                string sql1 = "INSERT INTO login (username,password) VALUES('" + usertext.Text + "','" + passtext.Text + "')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                int rows1 = cmd1.ExecuteNonQuery();
                MessageBox.Show("ทำรายการเสร็จสิ้น");
                conn.Close();
                Form1 Login = new Form1();
                Hide();
                Login.ShowDialog();
                this.Close();
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            if (emailtext.Text.Length != 0)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "INSERT INTO customerinfo (name,surname,address,tel,email,username,password) VALUES('" + nametext.Text + "','" + surnametext.Text + "','" + addtext.Text + "','" + teltext.Text + "','" + emailtext.Text + "','" + usertext.Text + "','" + passtext.Text + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                string sql1 = "INSERT INTO login (username,password) VALUES('" + usertext.Text + "','" + passtext.Text + "')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                int rows1 = cmd1.ExecuteNonQuery();
                MessageBox.Show("ทำรายการเสร็จสิ้น");
                conn.Close();
                Form1 Login = new Form1();
                Hide();
                Login.ShowDialog();
                this.Close();
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            if (usertext.Text.Length != 0)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "INSERT INTO customerinfo (name,surname,address,tel,email,username,password) VALUES('" + nametext.Text + "','" + surnametext.Text + "','" + addtext.Text + "','" + teltext.Text + "','" + emailtext.Text + "','" + usertext.Text + "','" + passtext.Text + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                string sql1 = "INSERT INTO login (username,password) VALUES('" + usertext.Text + "','" + passtext.Text + "')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                int rows1 = cmd1.ExecuteNonQuery();
                MessageBox.Show("ทำรายการเสร็จสิ้น");
                conn.Close();
                Form1 Login = new Form1();
                Hide();
                Login.ShowDialog();
                this.Close();
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            if (passtext.Text.Length != 0)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "INSERT INTO customerinfo (name,surname,address,tel,email,username,password) VALUES('" + nametext.Text + "','" + surnametext.Text + "','" + addtext.Text + "','" + teltext.Text + "','" + emailtext.Text + "','" + usertext.Text + "','" + passtext.Text + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                string sql1 = "INSERT INTO login (username,password) VALUES('" + usertext.Text + "','" + passtext.Text + "')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                int rows1 = cmd1.ExecuteNonQuery();
                MessageBox.Show("ทำรายการเสร็จสิ้น");
                conn.Close();
                Form1 Login = new Form1();
                Hide();
                Login.ShowDialog();
                this.Close();
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
        }
    }
}
