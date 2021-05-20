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

namespace Bags
{
    public partial class Receipt : Form
    {
        int Order_Id;
        public Receipt(int orderid)
        {
            InitializeComponent();
            Order_Id = orderid;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Order_Receipt_Report _Report = new Order_Receipt_Report();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Bags;Integrated Security=True";

            string sql = "Select * From Orders o, Order_Items oi Where o.OrderID = oi.OrderID and o.OrderID = " + Order_Id + ";";

            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);

            sqlDataAdapter.Fill(dataSet, "Sales");
            DataTable dataTable = dataSet.Tables["Sales"];


            _Report.SetDataSource(dataSet.Tables["Sales"]);
            crystalReportViewer1.ReportSource = _Report;
            crystalReportViewer1.Refresh();
        }
    }
}
