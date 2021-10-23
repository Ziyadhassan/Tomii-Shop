using Bags.Installments.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bags.Installments
{
    public partial class Order_From_Factory_Installments : UserControl
    {
        Controller controller;
        public Order_From_Factory_Installments()
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
            DataTable dt = controller.Get_All_Factory_Installments();

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
            Add_Factory_Order_Installment _Form = new Add_Factory_Order_Installment();
            var result = _Form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Data_Refresh();
            }
        }

        private void Pay_Installment_Click(object sender, EventArgs e)
        {
            Pay_Installment_To_Factory pay_Installment = new Pay_Installment_To_Factory();
            pay_Installment.Show();
        }

        private void Show_Bu_Name_btn_Click(object sender, EventArgs e)
        {
            Installment_From_Factory_By_Name name = new Installment_From_Factory_By_Name();
            name.Show();
        }

        private void Still_to_Pay_btn_Click(object sender, EventArgs e)
        {
            Still_To_Pay_To_Factroy still_To_Pay_ = new Still_To_Pay_To_Factroy();
            still_To_Pay_.Show();
        }

        private void Show_All_btn_Click(object sender, EventArgs e)
        {
            Data_Refresh();
        }

        private void Delete_Order_btn_Click(object sender, EventArgs e)
        {
            Delete_Order_From_Factory_Installments delete_ = new Delete_Order_From_Factory_Installments();
            delete_.Show();
        }
    }
}
