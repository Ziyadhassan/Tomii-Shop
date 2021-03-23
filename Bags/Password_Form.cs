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
    public partial class Password_Form : Form
    {
        public Password_Form()
        {
            InitializeComponent();
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            if (password_tb.Text == "101097")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("كلمة المرور خطأ");
                return;
            }
        }

        private void password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                Enter_btn_Click(sender, e);
        }
    }
}
