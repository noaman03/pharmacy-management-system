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
using System.Xml.Linq;

namespace PharmacyManagement.AdminstratorUC
{
    public partial class UC_profile : UserControl
    {
        function fn = new function();
        String query;
        public String ID
        {
            set { UsernameLabel.Text = value; }
        }
        public UC_profile()
        {
            InitializeComponent();
        }

        private void UC_profile_Load(object sender, EventArgs e)
        {

        }
        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = @username";
            DataSet ds = fn.getdata(query, new SqlParameter("@username", UsernameLabel.Text.Trim()));

            if (ds.Tables[0].Rows.Count == 0)
            {
                return;
            }

            DataRow profile = ds.Tables[0].Rows[0];
            TxtUserRole.Text = profile["userRole"].ToString();
            TxtName.Text = profile["names"].ToString();
            TxtMobileNumber.Text = profile["mobile"].ToString();
            TxtDOB.Text = profile["dob"].ToString();
            Email.Text = profile["email"].ToString();
            TxtPassword.Text = profile["pass"].ToString();
        }

        private void TxtUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void clearall()
        {
            TxtName.Clear();
            TxtMobileNumber.Clear();
            TxtDOB.ResetText();
            Email.Clear();
            TxtPassword.Clear();
            TxtUserRole.SelectedIndex = -1;


        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string role = TxtUserRole.Text.Trim();
            string name = TxtName.Text.Trim();
            string dob = TxtDOB.Text;
            string email = Email.Text.Trim();
            string username = UsernameLabel.Text.Trim();
            string pass = TxtPassword.Text;

            if (!Int64.TryParse(TxtMobileNumber.Text.Trim(), out Int64 mobile))
            {
                MessageBox.Show("Enter a valid mobile number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            query = @"update users
                      set userRole = @role,
                          names = @name,
                          mobile = @mobile,
                          dob = @dob,
                          email = @email,
                          pass = @password
                      where username = @username";
            fn.setData(
                query,
                "Profile updated successfully.",
                new SqlParameter("@role", role),
                new SqlParameter("@name", name),
                new SqlParameter("@mobile", mobile),
                new SqlParameter("@dob", dob),
                new SqlParameter("@email", email),
                new SqlParameter("@password", pass),
                new SqlParameter("@username", username));
        }
    }

}
