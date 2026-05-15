using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PharmacyManagement
{
    internal class function
    {
        private static string ConnectionString
        {
            get
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PharmacyDatabase"];
                if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
                {
                    throw new InvalidOperationException("Missing PharmacyDatabase connection string in App.config.");
                }

                return settings.ConnectionString;
            }
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public DataSet getdata(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                AddParameters(cmd, parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public void setData(string query, string msg, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                AddParameters(cmd, parameters);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            if (!string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static void AddParameters(SqlCommand cmd, SqlParameter[] parameters)
        {
            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
        }
    }
}
