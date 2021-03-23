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
    public partial class Buy_Item_Model : UserControl
    {
        public Buy_Item_Model()
        {
            InitializeComponent();
            Normal_Chosen.Checked = true;
        }



        private int index;
        private string barcode;
        private string Model;
        private string color;
        private double Whole_price;
        private double Normal_price;
        private int Max_quntity;
        private int chosen_Quntity;
        private double Total_price;
        private bool Whole_or_normal;

        public string BarCode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        public string ModelName
        {
            get { return Model; }
            set { Model = value; Model_Label.Text = ModelName; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; Color_Label.Text = color; }
        }
        public double Whole_Price
        {
            get { return Whole_price; }
            set { Whole_price = value; }
        }
        public double Normal_Price
        {
            get { return Normal_price; }
            set { Normal_price = value; Money_label.Text = Normal_price.ToString(); }
        }
        public int MaxQuntity
        {
            get { return Max_quntity; }
            set { Max_quntity = value; Chosen_Quntity_nUpDown.Maximum = Max_quntity; }
        }
        public int Chosen_Quntity
        {
            get { return chosen_Quntity; }
            set { chosen_Quntity = value; }
        }
        public double Total_Price
        {
            get { return Total_price; }
            set { Total_price = value; TotalPrice_Label.Text = Total_Price.ToString(); }
        }
        public int Index
        {
            get { return index; }
            set { index = value; Index_Label.Text = index.ToString(); }
        }
        public bool Whole_or_Normal
        {
            // true means 'Normal' and False means 'Whole'
            get { return Whole_or_normal; }
            set { Whole_or_normal = value; }
        }


        private void Chosen_Quntity_nUpDown_ValueChanged(object sender, EventArgs e)
        {
            Chosen_Quntity = Convert.ToInt32(Chosen_Quntity_nUpDown.Value);
            if (Normal_Chosen.Checked == true)
                Total_Price = Chosen_Quntity * Normal_Price;
            else
                Total_Price = Chosen_Quntity * Whole_Price;
        }

        private void Normal_Chosen_CheckedChanged(object sender, EventArgs e)
        {
            if (Normal_Chosen.Checked == true)
            {
                Money_label.Text = Normal_price.ToString();
                Total_Price = Chosen_Quntity * Normal_Price;
                Whole_Chosen.Checked = false;
                Whole_or_Normal = true;
            }
        }

        private void Whole_Chosen_CheckedChanged(object sender, EventArgs e)
        {
            if (Whole_Chosen.Checked == true)
            {
                Money_label.Text = Whole_price.ToString();
                Total_Price = Chosen_Quntity * Whole_Price;
                Normal_Chosen.Checked = false;
                Whole_or_Normal = false; 
            }
        }
    }
}
