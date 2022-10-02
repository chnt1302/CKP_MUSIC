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
    public partial class Form12 : Form
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
            cmd.CommandText = $"SELECT * FROM customerinfo WHERE username ='{Form1.globaluser}' AND password ='{Form1.globalpassword}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataEquipment.DataSource = ds.Tables[0].DefaultView;
        }
        
        public Form12()
        {
            InitializeComponent();
            showEquipment();           
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                dataEquipment.CurrentRow.Selected = true;
                nametext.Text = dataEquipment.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                surnametext.Text = dataEquipment.Rows[e.RowIndex].Cells["surname"].FormattedValue.ToString();
                addtext.Text = dataEquipment.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                teltext.Text = dataEquipment.Rows[e.RowIndex].Cells["tel"].FormattedValue.ToString();
                emailtext.Text = dataEquipment.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ยืนยันการทำรายการหรือไม่?","แจ้งตือน", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    int selectedRow = dataEquipment.CurrentCell.RowIndex;
                    int editId = Convert.ToInt32(dataEquipment.Rows[selectedRow].Cells["id"].Value);
                    MySqlConnection conn = databaseConnection();
                    String sql = "UPDATE customerinfo SET name ='" + nametext.Text + "',surname = '" + surnametext.Text + "',address = '" + addtext.Text + "',tel = '" + teltext.Text + "',email = '" + emailtext.Text + "'WHERE id = '" + editId + "'";
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
        private void Btnback_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
