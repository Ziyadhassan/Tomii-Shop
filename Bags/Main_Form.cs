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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            Full_Store_Panel.Visible = false;
            Order_Installments_Panel.Visible = false;
            Buy_Panel.Visible = true;
        }

        private void Store_btn_Click(object sender, EventArgs e)
        {
            Password_Form _Form = new Password_Form();
            var result = _Form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Full_Store_Panel.Visible = true;
                Buy_Panel.Visible = false;
                Order_Installments_Panel.Visible = false;
            }
        }

        private void Buy_btn_Click(object sender, EventArgs e)
        {
            Full_Store_Panel.Visible = false;
            Order_Installments_Panel.Visible = false;
            Buy_Panel.Visible = true;
        }

        private void Out_In_Order_btn_Click(object sender, EventArgs e)
        {
            Password_Form _Form = new Password_Form();
            var result = _Form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Order_Installments_Panel.Visible = true;
                Full_Store_Panel.Visible = false;
                Buy_Panel.Visible = false;
            }
        }
    }
}
