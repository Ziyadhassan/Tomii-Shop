using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bags.Installments.Factory
{
    public partial class Installment_From_Factory_By_Name : Form
    {
        Controller controller;
        public Installment_From_Factory_By_Name()
        {
            InitializeComponent();
            controller = new Controller();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void Show_Btn_Click(object sender, EventArgs e)
        {
            DataTable dt = controller.Installments_From_Factroy_By_Name(textBox1.Text);

            if(dt == null)
            {
                MessageBox.Show("لا توجد تفاصيل بهذة الاسم\nالرجاء ادخال اسم صحيح");
                return;
            }

            dt.Columns.RemoveAt(8);
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
