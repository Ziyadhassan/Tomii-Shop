using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bags.Store_Forms
{
    public partial class Show_Order_Details_With_Num : Form
    {
        public Show_Order_Details_With_Num(DataTable data)
        {
            InitializeComponent();

            dataGridView1.DataSource = data;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;


            dataGridView1.Columns["OrderID"].HeaderText = "رقم الأوردر";
            dataGridView1.Columns["BarCode"].HeaderText = "الباركود";
            dataGridView1.Columns["Bag_Model"].HeaderText = "الموديل";
            dataGridView1.Columns["Color"].HeaderText = "اللون";
            dataGridView1.Columns["Type_Of_Sell"].HeaderText = "نوع البع";
            dataGridView1.Columns["Single_Price"].HeaderText = "سعر القطعة";
            dataGridView1.Columns["Quntity"].HeaderText = "العدد";
            dataGridView1.Columns["Total_Price"].HeaderText = "الاجمالى";

            dataGridView1.Refresh();
        }
    }
}
