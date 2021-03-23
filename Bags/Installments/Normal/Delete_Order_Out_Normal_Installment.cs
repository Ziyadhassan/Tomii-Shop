﻿using System;
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
    public partial class Delete_Order_Out_Normal_Installment : Form
    {
        Controller controller;
        public Delete_Order_Out_Normal_Installment()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (controller.Delete_Order_Out_Normal_Installment(Convert.ToInt32(numericUpDown1.Value)) >= 1)
            {
                MessageBox.Show("تم الألغاء");
                return;
            }
            else
            {
                MessageBox.Show("حدث خطأ اثناء الالغاء\nالرجاء التاكد من رقم المعاملة");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
