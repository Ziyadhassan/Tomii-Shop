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
    public partial class Insert_Edit : UserControl
    {
        public Insert_Edit()
        {
            InitializeComponent();
            insert1.Visible = true;
            edit1.Visible = false;
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            insert1.Visible = false;
            edit1.Visible = true;
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            insert1.Visible = true;
            edit1.Visible = false;
        }
    }
}
