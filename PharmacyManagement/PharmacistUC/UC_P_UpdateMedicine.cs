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
    public partial class UC_P_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            if (TxtMedicineID.Text != "")
            {
                query = "select * from medic where mid = @medicineId";
                DataSet ds = fn.getdata(query, new SqlParameter("@medicineId", TxtMedicineID.Text.Trim()));

                if (ds.Tables[0].Rows.Count != 0)
                {
                    TxtMedicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    TxtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    TxtManufactureDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    TxtExpireDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    TxtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    TxtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();

                }
                else
                {
                    MessageBox.Show("No Medicine ID : " + TxtMedicineID.Text + " Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            TxtMedicineID.Clear();
            TxtMedicineName.Clear();
            TxtMedicineNumber.Clear();
            TxtManufactureDate.ResetText();
            TxtExpireDate.ResetText();
            TxtQuantity.Clear();
            TxtPricePerUnit.Clear();
            if (TxtAddQuantity.Text != "0")
            {
                TxtAddQuantity.Text = "0";
            }
            else
            {
                TxtAddQuantity.Text = "0";
            }

        }
        Int64 totalQuantity;
        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }

        private void Btnupdate_Click_1(object sender, EventArgs e)
        {
            string medicineId = TxtMedicineID.Text.Trim();
            string mname = TxtMedicineName.Text.Trim();
            string mnumber = TxtMedicineNumber.Text.Trim();
            string mdate = TxtManufactureDate.Text;
            string edate = TxtExpireDate.Text;

            if (string.IsNullOrWhiteSpace(medicineId) ||
                string.IsNullOrWhiteSpace(mname) ||
                string.IsNullOrWhiteSpace(mnumber))
            {
                MessageBox.Show("Search for a medicine before updating it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Int64.TryParse(TxtQuantity.Text.Trim(), out Int64 quantity) ||
                !Int64.TryParse(TxtAddQuantity.Text.Trim(), out Int64 addQuantity) ||
                !Int64.TryParse(TxtPricePerUnit.Text.Trim(), out Int64 unitprice))
            {
                MessageBox.Show("Enter valid quantity and price values.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            totalQuantity = quantity + addQuantity;
            query = @"update medic
                      set mname = @mname,
                          mnumber = @mnumber,
                          mdate = @mdate,
                          edate = @edate,
                          quantity = @quantity,
                          perunit = @unitprice
                      where mid = @medicineId";
            fn.setData(
                query,
                "Medicine details updated.",
                new SqlParameter("@mname", mname),
                new SqlParameter("@mnumber", mnumber),
                new SqlParameter("@mdate", mdate),
                new SqlParameter("@edate", edate),
                new SqlParameter("@quantity", totalQuantity),
                new SqlParameter("@unitprice", unitprice),
                new SqlParameter("@medicineId", medicineId));
        }
    }
}
