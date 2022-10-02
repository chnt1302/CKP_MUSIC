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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;");
            MySqlDataAdapter sql = new MySqlDataAdapter("SELECT COUNT(*) FROM admin WHERE username = '" + idtext.Text + "' AND password = '" + passwordtext.Text + "'", con);
            DataTable login = new DataTable();
            sql.Fill(login);
            if (login.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("เข้าสู่ระบบเรียบร้อย");
                Form14 shop = new Form14();
                Hide();
                shop.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("ระบบผิดพลาด");
            }
        }
    }
}
