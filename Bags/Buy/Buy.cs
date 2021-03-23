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
    public partial class Buy : UserControl
    {
        Controller controller;
        public Buy()
        {
            InitializeComponent();
            controller = new Controller();
            flowLayoutPanel1.AutoScroll = true;
        }

        private void Item_tb_TextChanged(object sender, EventArgs e)
        {
            if (Item_tb.Text.Length == 12)
            {
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    var x = item as Buy_Item_Model;
                    if (x.BarCode == Item_tb.Text)
                    {
                        MessageBox.Show("هذة المنتج موجود في السلة");
                        return;
                    }
                }

                DataTable data = controller.Get_Bags(Item_tb.Text);
                if (data == null)
                {
                    MessageBox.Show("هذة المنتج غير موجود");
                    return;
                }
                else
                {
                    if(Convert.ToInt32( data.Rows[0][3] )== 0)
                    {
                        MessageBox.Show("لا يمكن اضافة هذة المنتج في السلة\nلا يوجد منة في المخزن ");
                        return;
                    }

                    int count = data.Rows.Count;
                    Buy_Item_Model[] lists = new Buy_Item_Model[count];

                    for (int i = 0; i < count; i++)
                    {
                        lists[i] = new Buy_Item_Model();
                        lists[i].Index = flowLayoutPanel1.Controls.Count + 1;
                        lists[i].BarCode = data.Rows[i][0].ToString();
                        lists[i].ModelName = data.Rows[i][1].ToString();
                        lists[i].Color = data.Rows[i][2].ToString();
                        lists[i].MaxQuntity = Convert.ToInt32(data.Rows[i][3]);
                        lists[i].Whole_Price = Convert.ToDouble(data.Rows[i][4]);
                        lists[i].Normal_Price = Convert.ToDouble(data.Rows[i][5]);
                        lists[i].Total_Price = Convert.ToDouble(data.Rows[i][5]);
                        lists[i].Chosen_Quntity = 1;


                        flowLayoutPanel1.Controls.Add(lists[i]);
                    }

                    Item_tb.Text = "";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                MessageBox.Show("السلة فارغة");
                return;
            }

            Delete_Item_From_Cart delete_Item_ = new Delete_Item_From_Cart();
            var result = delete_Item_.ShowDialog();

            if (result == DialogResult.OK)
            {
                int deletedIndex = delete_Item_.ReturnIndex;
                try
                {
                    flowLayoutPanel1.Controls.RemoveAt(deletedIndex - 1);

                    int y = 1;
                    foreach (Control item in flowLayoutPanel1.Controls)
                    {
                        var x = item as Buy_Item_Model;
                        x.Index = y;
                        y++;
                    }

                }
                catch
                {
                    MessageBox.Show("الرجاء ادخال رقم صحيح");
                    return;
                }

            }
        }

        private void Buy_btn_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                MessageBox.Show("السلة فارغة");
                return;
            }

            DataTable data = new DataTable("المنتجات");

            data.Columns.Add("الاجمالى", typeof(double));
            data.Columns.Add("العدد", typeof(int));
            data.Columns.Add("سعر القطعة", typeof(Double));
            data.Columns.Add("النوع", typeof(string));
            data.Columns.Add("اللون", typeof(string));
            data.Columns.Add("الموديل", typeof(string));

            int i = 0;
            string[] barcodes = new string[flowLayoutPanel1.Controls.Count];
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                var x = item as Buy_Item_Model;

                if (x.Whole_or_Normal)
                    data.Rows.Add(x.Total_Price, x.Chosen_Quntity, x.Normal_Price, "قطاعي", x.Color, x.ModelName);
                else
                    data.Rows.Add(x.Total_Price, x.Chosen_Quntity, x.Whole_Price, "جملة", x.Color, x.ModelName);

                barcodes[i] = x.BarCode;
                i++;
            }

            Confirm_Buy confirm_Buy = new Confirm_Buy(data, barcodes);
            var result =  confirm_Buy.ShowDialog();

            if(result == DialogResult.OK)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            return;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Credit_Form credit_Form = new Credit_Form();
            credit_Form.Show();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                var x = item as Buy_Item_Model;
                if (x.BarCode == Item_tb.Text)
                {
                    MessageBox.Show("هذة المنتج موجود في السلة");
                    return;
                }
            }

            DataTable data = controller.Get_Bags(Item_tb.Text);
            if (data == null)
            {
                MessageBox.Show("هذة المنتج غير موجود");
                return;
            }
            else
            {
                if (Convert.ToInt32(data.Rows[0][3]) == 0)
                {
                    MessageBox.Show("لا يمكن اضافة هذة المنتج في السلة\nلا يوجد منة في المخزن\nالعدد = 0 ");
                    return;
                }

                int count = data.Rows.Count;
                Buy_Item_Model[] lists = new Buy_Item_Model[count];

                for (int i = 0; i < count; i++)
                {
                    lists[i] = new Buy_Item_Model();
                    lists[i].Index = flowLayoutPanel1.Controls.Count + 1;
                    lists[i].BarCode = data.Rows[i][0].ToString();
                    lists[i].ModelName = data.Rows[i][1].ToString();
                    lists[i].Color = data.Rows[i][2].ToString();
                    lists[i].MaxQuntity = Convert.ToInt32(data.Rows[i][3]);
                    lists[i].Whole_Price = Convert.ToDouble(data.Rows[i][4]);
                    lists[i].Normal_Price = Convert.ToDouble(data.Rows[i][5]);
                    lists[i].Total_Price = Convert.ToDouble(data.Rows[i][5]);
                    lists[i].Chosen_Quntity = 1;


                    flowLayoutPanel1.Controls.Add(lists[i]);
                }

                Item_tb.Text = "";
            }
        }
    }
}
