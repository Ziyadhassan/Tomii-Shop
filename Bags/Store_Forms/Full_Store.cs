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
    public partial class Full_Store : UserControl
    {
        public Full_Store()
        {
            InitializeComponent();

            Store_Panel.Visible = true;
            Insert_Panel.Visible = false;
            Edit_Panel.Visible = false;
            Sales_Panel.Visible = false;
        }

        private void Store_btn_Click(object sender, EventArgs e)
        {
            Store_Panel.Visible = true;
            Insert_Panel.Visible = false;
            Edit_Panel.Visible = false;
            Sales_Panel.Visible = false;
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            Store_Panel.Visible = false;
            Insert_Panel.Visible = true;
            Edit_Panel.Visible = false;
            Sales_Panel.Visible = false;
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            Store_Panel.Visible = false;
            Insert_Panel.Visible = false;
            Edit_Panel.Visible = true;
            Sales_Panel.Visible = false;
        }

        private void Sales_btn_Click(object sender, EventArgs e)
        {
            Store_Panel.Visible = false;
            Insert_Panel.Visible = false;
            Edit_Panel.Visible = false;
            Sales_Panel.Visible = true;
        }
    }
}
