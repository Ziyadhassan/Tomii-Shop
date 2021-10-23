using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bags.Insert_and_Edit
{
    public partial class ModelItemList : UserControl
    {
        public ModelItemList()
        {
            InitializeComponent();
        }

        private string model;
        private string barcode;
        private string color;
        private double normal_price;
        private double whole_Price;
        private int quntity;
        private string seller;

        public string Model
        {
            get { return model; }
            set { model = value; Model_label.Text = model; }
        }
        public string BarCode
        {
            get { return barcode; }
            set { barcode = value; BarCode_Label.Text = barcode; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; Color_Label.Text = color; }
        }
        public double Normal_Price
        {
            get { return normal_price; }
            set { normal_price = value; Normal_price_label.Text = normal_price.ToString(); }
        }
        public double Whole_Price
        {
            get { return whole_Price; }
            set { whole_Price = value; Whole_Price_label.Text = whole_Price.ToString(); }
        }
        public int Quntity
        {
            get { return quntity; }
            set { quntity = value; Quntity_Label.Text = quntity.ToString(); }
        }

        public string Seller
        {
            get { return seller; }
            set { seller = value; Seller_label.Text = seller; }
        }

        private void ModelItemList_MouseEnter(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.White;
        }

        private void ModelItemList_MouseLeave(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete_Form _Form = new Delete_Form(Model,Color);
            _Form.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Edit_Form Edit_ = new Edit_Form(Model,Color,Quntity,normal_price,Whole_Price,seller);
            Edit_.Show();
        }

        //this.BackColor = Color.FromArgb(20, 22, 50); Enter 
        //this.BackColor = Color.FromArgb(20, 22, 31); leave
    }
}
