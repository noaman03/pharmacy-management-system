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

namespace PharmacyManagement.AdminstratorUC
{
    public partial class Uc_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public Uc_AddUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string role = TxtUserRole.Text.Trim();
            string name = TxtName.Text.Trim();
            string dob = TxtDOB.Text;
            string email = Email.Text.Trim();
            string username = Txtusername.Text.Trim();
            string pass = TxtPassword.Text;

            if (string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Enter all user details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Int64.TryParse(TxtMobileNumber.Text.Trim(), out Int64 mobile))
            {
                MessageBox.Show("Enter a valid mobile number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                query = @"insert into users (userRole, names, mobile, dob, email, username, pass)
                          values (@role, @name, @mobile, @dob, @email, @username, @password)";
                fn.setData(
                    query,
                    "Sign up successful.",
                    new SqlParameter("@role", role),
                    new SqlParameter("@name", name),
                    new SqlParameter("@mobile", mobile),
                    new SqlParameter("@dob", dob),
                    new SqlParameter("@email", email),
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", pass));

                clearall();
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            TxtName.Clear();
            TxtMobileNumber.Clear();
            TxtDOB.ResetText();
            Email.Clear();
            Txtusername.Clear();
            TxtPassword.Clear();
            TxtUserRole.SelectedIndex = -1;


        }

        private void Uc_AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
