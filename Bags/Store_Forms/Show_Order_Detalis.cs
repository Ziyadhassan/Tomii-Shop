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
    public partial class Show_Order_Detalis : Form
    {
        Controller controller;
        public Show_Order_Detalis()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Show_Details_btn_Click(object sender, EventArgs e)
        {
            if(Order_Num_tb.Text == "")
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
                DataTable data = controller.Get_Order_Details(Convert.ToInt32(Order_Num_tb.Text));

                if(data == null)
                {
                    MessageBox.Show("لا يوجد أوردرات بهذة الرقم");
                    return;
                }

                Show_Order_Details_With_Num order = new Show_Order_Details_With_Num(data);
                this.Close();
                order.Show();

            }
        }
    }
}
