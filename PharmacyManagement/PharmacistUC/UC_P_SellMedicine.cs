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
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        public UC_P_SellMedicine()
        {
            InitializeComponent();
            InitializeDataGridViewColumns();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            ListBoxMedicine.Items.Clear();
            query = "select mname from medic where quantity > 0";
            ds = fn.getdata(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ListBoxMedicine.Items.Clear();
            query = "select mname from medic where mname like @medicineName and quantity > 0";
            ds = fn.getdata(query, new SqlParameter("@medicineName", txtSearch.Text.Trim() + "%"));

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ListBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtNumberOfUnits.Clear();

            String name = ListBoxMedicine.GetItemText(ListBoxMedicine.SelectedItem);

            TxtMedicineName.Text = name;
            query = "select mid, eDate, perUnit from medic where mname = @medicineName";
            ds = fn.getdata(query, new SqlParameter("@medicineName", name));

            if (ds.Tables[0].Rows.Count == 0)
            {
                clearAll();
                return;
            }

            TxtMedicineID.Text = ds.Tables[0].Rows[0][0].ToString();
            TxtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            TxtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();

        }

        private void TxtNumberOfUnits_TextChanged(object sender, EventArgs e)
        {
            if (TxtNumberOfUnits.Text != "")
            {
                if (!Int64.TryParse(TxtPricePerUnit.Text, out Int64 unitPrice) ||
                    !Int64.TryParse(TxtNumberOfUnits.Text, out Int64 noOfUnit))
                {
                    txtTotalPrice.Clear();
                    return;
                }

                Int64 totalAmount = unitPrice * noOfUnit;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }
        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;
        int valueAmount;
        String valueId;
        protected Int64 noOfunit;
       

        private void InitializeDataGridViewColumns()
        {
            // Ensure columns are only added if they don't already exist
            if (guna2DataGridView1.Columns.Count == 0)
            {
                guna2DataGridView1.Columns.Add("MedicineID", "Medicine ID");
                guna2DataGridView1.Columns.Add("MedicineName", "Medicine Name");
                guna2DataGridView1.Columns.Add("ExpireDate", "Expire Date");
                guna2DataGridView1.Columns.Add("PricePerUnit", "Price Per Unit");
                guna2DataGridView1.Columns.Add("NumberOfUnits", "Number Of Units");
                guna2DataGridView1.Columns.Add("TotalPrice", "Total Price");
            }
        }
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (TxtMedicineID.Text != "")
            {
                if (!Int64.TryParse(TxtNumberOfUnits.Text.Trim(), out Int64 unitsToSell) || unitsToSell <= 0)
                {
                    MessageBox.Show("Enter a valid number of units.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!int.TryParse(txtTotalPrice.Text, out int itemTotal))
                {
                    MessageBox.Show("Enter a valid number of units.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string medicineId = TxtMedicineID.Text.Trim();

                query = "select quantity from medic where mid = @medicineId";
                ds = fn.getdata(query, new SqlParameter("@medicineId", medicineId));

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Selected medicine was not found.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                    return;
                }

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - unitsToSell;

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = TxtMedicineID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = TxtMedicineName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = TxtExpireDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = TxtPricePerUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = TxtNumberOfUnits.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;


                    
                    totalAmount = totalAmount + itemTotal;


                    TotalLabel.Text = "EGP." + totalAmount.ToString();

                    
                    query = "update medic set quantity = @quantity where mid = @medicineId";
                    fn.setData(
                        query,
                        "Medicine added.",
                        new SqlParameter("@quantity", newQuantity),
                        new SqlParameter("@medicineId", medicineId));

                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock. \n Only " + quantity + "Left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_P_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btnPurchase_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            if (int.TryParse(row.Cells[5].Value?.ToString(), out int selectedAmount) &&
                Int64.TryParse(row.Cells[4].Value?.ToString(), out Int64 selectedUnits))
            {
                valueAmount = selectedAmount;
                valueId = row.Cells[0].Value?.ToString();
                noOfunit = selectedUnits;
            }
        }

        private void TxtExpireDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(valueId))
            {
                if (guna2DataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a cart item first.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                guna2DataGridView1.Rows.RemoveAt(guna2DataGridView1.SelectedRows[0].Index);

                query = "select quantity from medic where mid = @medicineId";
                ds = fn.getdata(query, new SqlParameter("@medicineId", valueId));

                if (ds.Tables[0].Rows.Count == 0)
                {
                    return;
                }

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity + noOfunit;

                query = "update medic set quantity = @quantity where mid = @medicineId";
                fn.setData(
                    query,
                    "Medicine removed from cart.",
                    new SqlParameter("@quantity", newQuantity),
                    new SqlParameter("@medicineId", valueId));
                totalAmount = totalAmount - valueAmount;

                TotalLabel.Text = "EGP." + totalAmount.ToString();
                valueId = null;
                valueAmount = 0;
                noOfunit = 0;
                UC_P_SellMedicine_Load(this, null);
            }

        }
        private void clearAll()
        {
            TxtMedicineID.Clear();
            TxtMedicineName.Clear();
            TxtExpireDate.ResetText();
            TxtPricePerUnit.Clear();
            TxtNumberOfUnits.Clear();

        }




    }
}
