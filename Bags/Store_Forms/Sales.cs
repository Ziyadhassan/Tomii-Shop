using Bags.Store_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bags
{
    public partial class Sales : UserControl
    {
        Controller controller;
        public Sales()
        {
            InitializeComponent();
            controller = new Controller();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            From_Date.Format = DateTimePickerFormat.Custom;
            From_Date.CustomFormat = "dd / MM / yyyy";
            
            To_Date.Format = DateTimePickerFormat.Custom;
            To_Date.CustomFormat = "dd / MM / yyyy";

        }

        public bool Two_Dates(DateTime start, DateTime end)
        {
            if (start > end)
            {
                MessageBox.Show("ادخل تواريخ صحيحة");
                return false;
            }
            return true;
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            if (Two_Dates(From_Date.Value, To_Date.Value))
            {
                DataTable data = controller.Get_Sales(From_Date.Value, To_Date.Value);
                dataGridView1.Columns.Clear();
                if (data == null)
                {
                    MessageBox.Show("لا توجد مبيعات في هذة الفترة");
                    return;
                }

                else
                {
                    dataGridView1.DataSource = data;

                    dataGridView1.Columns["OrderID"].HeaderText = "الرقم";
                    dataGridView1.Columns["Ord_Date"].HeaderText = "التاريخ";
                    dataGridView1.Columns["Ord_Time"].HeaderText = "التوقيت";
                    dataGridView1.Columns["Total_Price"].HeaderText = "الاجمالى";
                    dataGridView1.Refresh();
                }
            }
        }

        private void Show_With_ID_btn_Click(object sender, EventArgs e)
        {
            Show_Order_Detalis order = new Show_Order_Detalis();
            order.Show();
        }

        private void Delete_Order_btn_Click(object sender, EventArgs e)
        {
            Delete_Sales_Order delete_ = new Delete_Sales_Order();
            delete_.Show();
        }
    }
}
