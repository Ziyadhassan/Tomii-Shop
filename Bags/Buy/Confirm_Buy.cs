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
    public partial class Confirm_Buy : Form
    {
        string[] BarCodes;
        DataTable Data;
        Controller controller;
        double Total_Price;
        public Confirm_Buy(DataTable data, string[] barcodes)
        {
            InitializeComponent();
            controller = new Controller();

            BarCodes = barcodes;
            Total_Price = 0;

            for (int i = 0; i < data.Rows.Count; i++)
                Total_Price += Convert.ToDouble(data.Rows[i][0]);

            Total_Money_Label.Text = Total_Price.ToString();

            Data = data;
            dataGridView1.DataSource = data;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Refresh();
        }

        private void Buy_btn_Click(object sender, EventArgs e)
        {
            if (controller.Buy_Bag(Data, BarCodes, Total_Price) == 1)
                MessageBox.Show("تمت عملية الشراء بنجاح");
            else
                MessageBox.Show("حدث خطأ اثناء عملية الشراء\nالرجاء التواصل مع المصمم فورا");

            this.DialogResult = DialogResult.OK;
            this.Close();
            return;
        }
    }
}
