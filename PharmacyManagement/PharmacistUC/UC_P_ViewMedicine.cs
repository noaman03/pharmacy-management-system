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

namespace PharmacyManagement.PharmacistUC
{
    public partial class UC_P_ViewMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_ViewMedicine()
        {
            InitializeComponent();
        }
        

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_P_ViewMedicine_Load(this, null);
        }

        private void UC_P_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            setDataGridView(query);

        }

        private void txtUserMedicine_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like @medicineName";
            setDataGridView(query, new SqlParameter("@medicineName", txtUserMedicine.Text.Trim() + "%"));

        }
        private void setDataGridView(String query, params SqlParameter[] parameters)
        {
            DataSet ds = fn.getdata(query, parameters);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        string medicineID;
        private void guna2DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                medicineID = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(medicineID))
            {
                MessageBox.Show("Select a medicine first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are You Sure ?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medic where mid = @medicineId";
                fn.setData(query, "Medicine record deleted.", new SqlParameter("@medicineId", medicineID));
                UC_P_ViewMedicine_Load(this, null);
            }
        }
    }
}
