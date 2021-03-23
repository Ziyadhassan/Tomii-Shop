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
    public partial class Insert : UserControl
    {
        Controller controller;
        public Insert()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            if(BarCode_tb.Text =="")
            {
                MessageBox.Show("لا يمكن ترك خانة الباركود فارغة");
                return;
            }

            if (controller.Insert_New_Bag(BarCode_tb.Text,Name_tb.Text, Color_tb.Text, Convert.ToInt32(Qunitity.Value), Convert.ToDouble(WholePrice.Value), Convert.ToDouble(Normal_Price.Value),Seller_tb.Text) == 0)
            {
                MessageBox.Show("لا يمكن الأضافة , هذا المنتج موجود من قبل");
                return;
            }
            else
            {
                MessageBox.Show("تم الادخال");
                return;
            }
        }
    }
}
