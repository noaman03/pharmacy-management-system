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
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtMedicineID.Text != "" && TxtMedicineName.Text != "" && TxtMedicineNumber.Text != "" && TxtQuantity.Text != "" && TxtPricePerUnit.Text != "")
            {
                string mid = TxtMedicineID.Text.Trim();
                string mname = TxtMedicineName.Text.Trim();
                string mnumber = TxtMedicineNumber.Text.Trim();
                string mdate = TxtManufactureDate.Text;
                string edate = TxtExpireDate.Text;

                if (!Int64.TryParse(TxtQuantity.Text.Trim(), out Int64 quantity) ||
                    !Int64.TryParse(TxtPricePerUnit.Text.Trim(), out Int64 perunit))
                {
                    MessageBox.Show("Enter valid quantity and price values.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                query = @"insert into medic (mid, mname, mnumber, mdate, edate, quantity, perunit)
                          values (@mid, @mname, @mnumber, @mdate, @edate, @quantity, @perunit)";
                fn.setData(
                    query,
                    "Medicine added successfully.",
                    new SqlParameter("@mid", mid),
                    new SqlParameter("@mname", mname),
                    new SqlParameter("@mnumber", mnumber),
                    new SqlParameter("@mdate", mdate),
                    new SqlParameter("@edate", edate),
                    new SqlParameter("@quantity", quantity),
                    new SqlParameter("@perunit", perunit));

                clearall();
            }
            else 
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void clearall()
        {
            TxtMedicineID.Clear();
            TxtMedicineName.Clear();
            TxtMedicineNumber.Clear();
            TxtManufactureDate.ResetText(); 
            TxtExpireDate.ResetText();
            TxtQuantity.Clear();
            TxtPricePerUnit.Clear();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            clearall();
        }
    }
}
