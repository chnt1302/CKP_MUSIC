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
    public partial class Form15 : Form
    {
        public static ListView global1;
        public Form15()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ckp_music;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void Btnback_Click(object sender, EventArgs e)
        {
            Form14 total = new Form14();
            Hide();
            total.ShowDialog();
        }
        private void showEquipment(string sql)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataEquipment.DataSource = ds.Tables[0].DefaultView;
            MySqlDataReader reader = cmd.ExecuteReader();
            int maxcolumnsum = 0;
            while (reader.Read())
            {
                maxcolumnsum += reader.GetInt32("price");

            }
            label2.Text = maxcolumnsum.ToString();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;user=root;password=;database=ckp_music");
        public void searchData(string valueToFind)
        {
            string searchQuery = "SELECT * FROM history WHERE CONCAT(username,product,amount,price,date) LIKE '%" + valueToFind + "%'";
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(searchQuery, connection);
            DataTable table = new DataTable();
            adapter3.Fill(table);
            dataEquipment.DataSource = table;
        }
        private void Form15_Load(object sender, EventArgs e)
        {
            showEquipment("SELECT * FROM history");
            searchData("");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            int day_ = 0;
            if(comboBox2.Text == "01" || comboBox2.Text == "03" || comboBox2.Text == "05" || comboBox2.Text == "07" || comboBox2.Text == "08" || comboBox2.Text == "10" || comboBox2.Text == "12")
            {
                day_ = 31;
            }
            else if (comboBox2.Text == "04" || comboBox2.Text == "06" || comboBox2.Text == "09" || comboBox2.Text == "11")
            {
                day_ = 30;
            }
            else if (comboBox2.Text == "02")
            {
                day_ = 28;
            }
            comboBox3.Items.Add("");
            
            for(int i = 1 ; i <= day_ ; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
            choosedmy();

        }
        string ch;
        private void choosedmy() 
        {
            if(comboBox1.Text != "")
            {
                ch = "%" + comboBox1.Text + "%";
            }
            if(comboBox2.Text != "")
            {
                ch = "%" + comboBox2.Text + "/" + comboBox1.Text + "%";
            }
            if(comboBox3.Text != "")
            {
                ch = "%" + comboBox3.Text + "/" + comboBox2.Text + "/" + comboBox1.Text + "%";
            }
            showEquipment("SELECT * FROM history WHERE date LIKE '"+ ch +"'");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedmy();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedmy();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            showEquipment("SELECT * FROM history WHERE username LIKE '" + "%" + textBox1.Text + "%" + "'");
        }
    }
}
