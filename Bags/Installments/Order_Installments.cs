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
    public partial class Order_Installments : UserControl
    {
        public Order_Installments()
        {
            InitializeComponent();
            order_From_Factory_Installments1.Visible = true;
            orders_Out_Whole_Installments1.Visible = false;
            orders_Out_Normal_Installment1.Visible = false;
        }

        private void Order_In_btn_Click(object sender, EventArgs e)
        {
            order_From_Factory_Installments1.Visible = true;
            orders_Out_Whole_Installments1.Visible = false;
            orders_Out_Normal_Installment1.Visible = false;
        }

        private void Order_Out_Whole_Click(object sender, EventArgs e)
        {
            order_From_Factory_Installments1.Visible = false;
            orders_Out_Whole_Installments1.Visible = true;
            orders_Out_Normal_Installment1.Visible = false;
        }

        private void Order_Out_Normal_Click(object sender, EventArgs e)
        {
            order_From_Factory_Installments1.Visible = false;
            orders_Out_Whole_Installments1.Visible = false;
            orders_Out_Normal_Installment1.Visible = true;
        }
    }
}
