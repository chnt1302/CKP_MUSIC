using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_101._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customizedesign();
        }

        private void customizedesign()
        {
            panelGuitarSubMenu.Visible = false;
            panelBassSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelGuitarSubMenu.Visible == true)
                panelGuitarSubMenu.Visible = false;
            if (panelBassSubMenu.Visible == true)
                panelBassSubMenu.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void BtnGuitar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGuitarSubMenu);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Form4());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Form5());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BtnBass_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBassSubMenu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Form6());            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Form7());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BtnAmp_Click(object sender, EventArgs e)
        {
            openChildForm(new Form9());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Form10());
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();            
        }       
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        

        private void BtnUser_Click(object sender, EventArgs e)
        {
            Form12 admin = new Form12();
            Hide();
            admin.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form10());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form6());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form5());            
        }

        private void Btnuser_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form12());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            openChildForm(new Form10());
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            openChildForm(new Form16());
        }
    }
}
