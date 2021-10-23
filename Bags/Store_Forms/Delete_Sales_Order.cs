using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bags.Store_Forms
{
    public partial class Delete_Sales_Order : Form
    {
        Controller controller;
        public Delete_Sales_Order()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (Order_Num_tb.Text == "")
            {
                MessageBox.Show("الرجاء ادخال رقم الأوردر");
                return;
            }
            else if (!Order_Num_tb.Text.All(char.IsDigit))
            {
                MessageBox.Show("الرجاء ادخال ارقام فقط");
                return;
            }
            else
            {
                if(controller.Delete_Order(Convert.ToInt32(Order_Num_tb.Text)) >= 1)
                {
                    MessageBox.Show("تمت عملية الالغاء");
                    return;
                }
                else
                {
                    MessageBox.Show("حدث خطأ اثناء عملية الالغاء\nالرجاء التاكد من ادخل رقم الاوردر صحيح");
                    return;
                }
            }
        }
    }
}
