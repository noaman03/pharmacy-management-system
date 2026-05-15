using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
           TxtUserName.Clear();
           TxtPassword.Clear();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string username = TxtUserName.Text.Trim();
            string password = TxtPassword.Text;

            query = "select count(*) from users";
            ds = fn.getdata(query);
            int userCount = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            if (userCount == 0)
            {
                if (username == "root" && password == "root")
                {
                    Adminstrator adminstrator = new Adminstrator();
                    adminstrator.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                query = "select userRole from users where username = @username and pass = @password";
                ds = fn.getdata(
                    query,
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password));

                if (ds.Tables[0].Rows.Count != 0)
                {
                    string role = ds.Tables[0].Rows[0]["userRole"].ToString();
                    if (role == "Administrator")
                    {
                        Adminstrator admin = new Adminstrator(username);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        pharmacist pharma = new pharmacist(username);
                        pharma.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
