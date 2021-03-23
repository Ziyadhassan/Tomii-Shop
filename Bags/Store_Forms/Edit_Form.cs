using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bags.Insert_and_Edit
{
    public partial class Edit_Form : Form
    {
        string Model;
        string Color;
        Controller controller;
        public Edit_Form(string model, string color, int quntity, double normal_price, double whole_price, string seller)
        {
            InitializeComponent();
            controller = new Controller();
            Model = model;
            Color = color;
            quntity_nb.Value = Convert.ToDecimal(quntity);
            Normal_price_nb.Value = Convert.ToDecimal(normal_price);
            Whole_price_nb.Value = Convert.ToDecimal(whole_price);
            Seller_tb.Text = seller;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (controller.Update_Bag_Info(Model, Color, Convert.ToInt32(quntity_nb.Value), Convert.ToDouble(Whole_price_nb.Value), Convert.ToDouble(Normal_price_nb.Value), Seller_tb.Text) == 1)
            {
                MessageBox.Show("تم التعدل");
                this.Close();
                return;
            }
            MessageBox.Show("حدث خطأ");
            return;
        }
    }
}
