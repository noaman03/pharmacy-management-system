using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.AdminstratorUC
{
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole='administrator'";
            ds=fn.getdata(query);
            setlabel(ds,adminLabel);

            query = "select count(userRole) from users where userRole='pharmacist'";
            ds = fn.getdata(query);
            setlabel(ds, pharmaLabel);

        }
        private void setlabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0) 
            {
                lbl.Text= ds.Tables[0].Rows[0][0].ToString();
            } 
            else
            {
                lbl.Text = "0";
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this,null);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pharmaLabel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
