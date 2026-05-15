using Guna.UI2.WinForms;
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
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        String currentUser = "";

        public string ID
        {
            set { currentUser = value; }
        }
        public UC_ViewUser()
        {
            InitializeComponent();
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getdata(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void label2_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like @username";
            DataSet ds = fn.getdata(query, new SqlParameter("@username", txtUserName.Text.Trim() + "%"));
            guna2DataGridView1.DataSource = ds.Tables[0];


        }
        String username;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                username = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {



                 if (!string.IsNullOrWhiteSpace(username) && !string.Equals(currentUser, username, StringComparison.OrdinalIgnoreCase))
                 {
                     query = "delete from users where username = @username";
                     fn.setData(query, "User record deleted.", new SqlParameter("@username", username));
                     UC_ViewUser_Load(this, null);
                 }
                 else
                 {
                     MessageBox.Show("You are Trying to delete \n Your Own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                 }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
