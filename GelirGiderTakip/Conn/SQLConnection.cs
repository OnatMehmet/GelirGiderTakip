using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GelirGiderTakip.Conn
{
    public class SQLConnectionClass
    {
        private  string SQLConnectionString = @"Server = YourServerName; Database = YourDatabaseName; Trusted_Connection = True;";
        private  SqlConnection con = new SqlConnection();
        private  SqlDataAdapter da = new SqlDataAdapter();
        private  SqlCommand com = new SqlCommand();
        public  SqlException exception = null;

        public  void Baglanti()
        {
            exception = null;
            con = new SqlConnection(SQLConnectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
                }
            }
        }

        public  object Command(string query)
        {
            exception = null;
            object obj = null;
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand

            try
            {
                obj = com.ExecuteScalar();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
            }

            return obj;
        }

        public  DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand
            da.SelectCommand = com; // // SqlCommand'ın bir select sorgusu olduğunu belirtiyoruz.
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
            }
            return dt;
        }
    }
}
