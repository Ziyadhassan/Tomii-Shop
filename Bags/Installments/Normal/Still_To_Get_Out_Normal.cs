using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bags.Installments.Normal
{
    public partial class Still_To_Get_Out_Normal : Form
    {
        Controller controller;
        public Still_To_Get_Out_Normal()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            controller = new Controller();

            DataTable dt = controller.Still_To_Pay_Out_Normal();

            if (dt == null)
            {
                MessageBox.Show("لا توجد مدفوعات");
                return;
            }
            else
            {
                dt.Columns["OrderID"].ColumnName = "رقم المعاملة";
                dt.Columns["BarCode"].ColumnName = "باركود الموديل";
                dt.Columns["Model"].ColumnName = "الموديل";
                dt.Columns["Factory_Name"].ColumnName = "اسم العميل";
                dt.Columns["Quntity"].ColumnName = "العدد";
                dt.Columns["Color"].ColumnName = "اللون";
                dt.Columns["Price"].ColumnName = "السعر";
                dt.Columns["Total_Price"].ColumnName = "الاجمالى";
                dt.Columns["Installment"].ColumnName = "دفعة";
                dt.Columns["Installment_Date"].ColumnName = "التاريخ";
                dt.Columns["Installment_Time"].ColumnName = "الوقت";
                dt.Columns["Price_Left"].ColumnName = "المتبقي";


                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }
    }
}
