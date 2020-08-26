using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patient_db
{
    public static class SqlBaglantisi
    {
        public static SqlConnection getConnection()
        {
            SqlConnection cnn;
            try
            {
                //Eğer program server olarak ayarlandı ise kullanılacak connection string.
                cnn = new SqlConnection("Data Source=HAYDAR\\SQLEXPRESS;Initial Catalog=PatientDB;User ID=sa;Password=htlk8285@;");
                cnn.Open();
            }
            catch
            {                
                cnn = null;
            }

            return cnn;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public static SqlCommand getCommand(string query)
        {
            SqlCommand cmd = new SqlCommand(query, getConnection());
            return cmd;
        }

        public static string trimPhone(this string phone)
        {
            phone = phone.Remove(0, 1);
            phone = phone.Remove(4, 1);
            phone = phone.Remove(4, 1);
            phone = phone.Remove(7, 1);
            return phone;
        }

        public static void CreateXmlFromSqlTable(string QueryTableName, string DataSetName, string DataTableName)
        {
            SqlDataAdapter adapter;
            DataSet ds = new DataSet(DataSetName);
            DataTable dt = new DataTable(DataTableName);

            SqlCommand cmd = getCommand("select * from " + QueryTableName + "");

            try
            {
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                ds.Tables.Add(dt);
                ds.WriteXml(QueryTableName + "" + ".xml");
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
