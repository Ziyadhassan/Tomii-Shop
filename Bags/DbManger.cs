using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Bags
{
    class DBManger
    {
        static string DB_Connection_String = @"Data Source=.\SQLSERVER;Initial Catalog=Bags;Integrated Security=True";
        SqlConnection myConnection;

        public DBManger()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open(); //Open a connection with the DB

                // just for illustration when the database is opened, 
                // this should NOT be shown in GUI to the user in the final application
                // but we show it here only to make sure that the database is working
            }
            catch (Exception ex)
            {
                // this message should not appear to user in the final application
                MessageBox.Show("حدث خطا اثناء التوصيل بقاعدة البيانات");
            }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public DataTable ExecuteReader(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                // this message should not appear to user in the final application
                MessageBox.Show(e.Message);
            }
        }
    }
}
