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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string globaluser;
        public static string globalpassword;
        public static string globalusername;
        public static string globalsurname;
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;");
            MySqlDataAdapter sql = new MySqlDataAdapter("SELECT COUNT(*) FROM login WHERE username = '" + idtext.Text + "' AND password = '" + passwordtext.Text + "'", con);            
            DataTable login = new DataTable();
            sql.Fill(login);
            if (login.Rows[0][0].ToString() == "1")
            {
                globaluser = idtext.Text;
                globalpassword = passwordtext.Text;
                MessageBox.Show("เข้าสู่ระบบเรียบร้อย","แจ้งเตือน");
                Form2 shop = new Form2();
                Hide();
                shop.ShowDialog();
                this.Close();
            }
            else if(login.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("ไม่พบชื่อผู้ใช้", "แจ้งเตือน");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 signup = new Form3();
            Hide();
            signup.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            Hide();
            f8.ShowDialog();
            this.Close();
        }
    }
}
