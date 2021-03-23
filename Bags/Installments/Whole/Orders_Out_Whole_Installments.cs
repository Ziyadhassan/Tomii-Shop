using Bags.Installments.Whole;
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
    public partial class Orders_Out_Whole_Installments : UserControl
    {
        Controller controller;
        public Orders_Out_Whole_Installments()
        {
            InitializeComponent();
            controller = new Controller();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            Data_Refresh();
        }

        private void Data_Refresh()
        {
            DataTable dt = controller.Get_All_Out_Whole_Installments();

            if (dt == null)
                return;

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

        private void Add_Order_btn_Click(object sender, EventArgs e)
        {
            Add_Out_Whole_Installment _Form = new Add_Out_Whole_Installment();
            var result = _Form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Data_Refresh();
            }
        }

        private void Pay_Installment_Click(object sender, EventArgs e)
        {
            Pay_Installment_Out_Whole pay_Installment_Out_ = new Pay_Installment_Out_Whole();
            pay_Installment_Out_.Show();
        }

        private void Show_Bu_Name_btn_Click(object sender, EventArgs e)
        {
            Installment_Out_Whole_By_Name installment_Out_By_Name = new Installment_Out_Whole_By_Name();
            installment_Out_By_Name.Show();
        }

        private void Still_to_Pay_btn_Click(object sender, EventArgs e)
        {
            Still_To_Get_Out_Whole still_To_Get_Out_ = new Still_To_Get_Out_Whole();
            still_To_Get_Out_.Show();
        }

        private void Show_All_btn_Click(object sender, EventArgs e)
        {
            Data_Refresh();
        }

        private void Delete_Order_btn_Click(object sender, EventArgs e)
        {
            Delete_Order_Out_Whole_Installment delete_ = new Delete_Order_Out_Whole_Installment();
            delete_.Show();
        }
    }
}
