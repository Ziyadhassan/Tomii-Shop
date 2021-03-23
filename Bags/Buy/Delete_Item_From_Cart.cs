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
    public partial class Delete_Item_From_Cart : Form
    {
        public Delete_Item_From_Cart()
        {
            InitializeComponent();
        }
        public int ReturnIndex { get; set; }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("الرجاء ادخال رقم الالغاء");
                return;
            }

            if (!textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("الرجاء ادخال ارقام فقط");
                return;
            }

            ReturnIndex = Convert.ToInt32(textBox1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
