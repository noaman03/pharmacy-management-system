using Guna.UI2.WinForms;
using PharmacyManagement.AdminstratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class Adminstrator : Form
    {
        public Adminstrator()
        {
            InitializeComponent();
        }
        string user="";
        public string ID 
        {
            get { return user.ToString(); } 
        }
        public Adminstrator(String username)
        {
            InitializeComponent();
            usernamelabel.Text = username;
            user = username;
            uC_ViewUser1.ID = ID;
            uC_profile1.ID = ID;
            
        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_ViewUser1.Visible = false;
            uc_AddUser1.Visible = false;
            uC_profile1.Visible = false;   
            BtnDashboard.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uc_AddUser1.Visible = true;
            uc_AddUser1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 fm= new Form1();
            fm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            uC_Dashboard1.Visible=true;
            uc_AddUser1.Visible=false;
            
            
            


        }

        private void uC_Dashboard1_Load(object sender, EventArgs e)
        {
            
        }

        private void uc_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           uC_ViewUser1.Visible=true;
           uC_ViewUser1.BringToFront(); 
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_profile1.Visible=true;
            uC_profile1.BringToFront();
        }

        private void uC_profile1_Load(object sender, EventArgs e)
        {

        }
    }
}
