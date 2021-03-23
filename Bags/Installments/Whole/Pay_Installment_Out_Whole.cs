using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bags.Installments.Whole
{
    public partial class Pay_Installment_Out_Whole : Form
    {
        Controller controller;
        public Pay_Installment_Out_Whole()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            int result = controller.Pay_Out_Installment_Whole(Convert.ToInt32(Order_Id_nUpDown.Value), Convert.ToDouble(Money_nUpDown.Value));

            if (result == 0)
                MessageBox.Show("حدث خطأ اثناء الدفع");
            else if (result == -1)
                MessageBox.Show("لا يمكن اتمام العملية\nالمطلوب دفعة اكبر من المتبقي");
            else if (result == -2)
                MessageBox.Show("الرجاء التاكد من رقم الدفع");
            else
                MessageBox.Show("تم الدفع");
        }
    }
}
