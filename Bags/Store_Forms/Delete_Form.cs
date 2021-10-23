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
    public partial class Delete_Form : Form
    {
        string Model;
        string Color;
        Controller controller;
        public Delete_Form(string model,string color)
        {
            InitializeComponent();
            controller = new Controller();
            Model = model;
            Color = color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_Delete_btn_Click(object sender, EventArgs e)
        {
            if(controller.Delete_Bag(Model,Color)  >=1)
            {
                MessageBox.Show("تم الألغاء");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("حدث خطأ اثناء الألغاء");
                return;
            }
        }
    }
}
