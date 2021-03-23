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
    public partial class Add_Out_Whole_Installment : Form
    {
        Controller controller;
        public Add_Out_Whole_Installment()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Factory_Name_tb.Text == "")
            {
                MessageBox.Show("الرجاء ادخال اسم المصنع");
                return;
            }
            if (Colors_tb.Text == "")
            {
                MessageBox.Show("الرجاء ادخال الالوان");
                return;
            }
            if (BarCode_tb.Text == "")
            {
                MessageBox.Show("الرجاء ادخال الباركود");
                return;
            }
            if (Model_tb.Text == "")
            {
                MessageBox.Show("الرجاء ادخال الموديل");
                return;
            }

            int quntity = Convert.ToInt32(Quantity_nUpDown.Value);
            double price = Convert.ToDouble(Price_nUpDown.Value);
            double Installment = Convert.ToDouble(Installment_nUpDown.Value);
            if (price * quntity < Installment)
            {
                MessageBox.Show("لا يمكن دفع دفعة اكبر من اجمالى السعر");
                return;
            }

            if (controller.Add_Order_Out_Factory_Whole(BarCode_tb.Text, Model_tb.Text, Factory_Name_tb.Text, Colors_tb.Text, quntity, price, price * quntity, Installment) == 1)
            {
                MessageBox.Show("تمت اضافة الشغل");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("حدث خطأ اثناء اضافة الشغل");
        }
    }
}
