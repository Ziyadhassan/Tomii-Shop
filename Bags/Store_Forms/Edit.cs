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
    public partial class Edit : UserControl
    {
        Controller controller;
        public Edit()
        {
            InitializeComponent();
            controller = new Controller();
            flowLayoutPanel1.AutoScroll = true;
        }

        private void Show_All_btn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable data = controller.Get_All_Bags();


            int count;
            if (data == null)
            {
                MessageBox.Show("لا توجد بيانات");
                return;
            }
            else
            {
                count = data.Rows.Count;
                ModelItemList[] lists = new ModelItemList[count];

                for (int i = 0; i < count; i++)
                {
                    lists[i] = new ModelItemList();
                    lists[i].BarCode = data.Rows[i][0].ToString();
                    lists[i].Model = data.Rows[i][1].ToString();
                    lists[i].Color = data.Rows[i][2].ToString();
                    lists[i].Quntity = Convert.ToInt32(data.Rows[i][3]);
                    lists[i].Whole_Price = Convert.ToDouble(data.Rows[i][4]);
                    lists[i].Normal_Price = Convert.ToDouble(data.Rows[i][5]);
                    lists[i].Seller = data.Rows[i][6].ToString();

                    flowLayoutPanel1.Controls.Add(lists[i]);
                }
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (Search_tb.Text == "")
            {
                MessageBox.Show("الرجاء ادخال اسم الموديل");
                return;
            }

            DataTable data = controller.Get_Bags_By_Model(Search_tb.Text);

            if(data == null)
            {
                MessageBox.Show("هذه المنتج غير موجود\nالرجاء التأكد من اسم الموديل");
                return;
            }
            else
            {
                int count = data.Rows.Count;
                ModelItemList[] lists = new ModelItemList[count];

                for (int i = 0; i < count; i++)
                {
                    lists[i] = new ModelItemList();
                    lists[i].BarCode = data.Rows[i][0].ToString();
                    lists[i].Model = data.Rows[i][1].ToString();
                    lists[i].Color = data.Rows[i][2].ToString();
                    lists[i].Quntity = Convert.ToInt32(data.Rows[i][3]);
                    lists[i].Whole_Price = Convert.ToDouble(data.Rows[i][4]);
                    lists[i].Normal_Price = Convert.ToDouble(data.Rows[i][5]);
                    lists[i].Seller = data.Rows[i][6].ToString();

                    flowLayoutPanel1.Controls.Add(lists[i]);
                }
            }
        }

        private void BarCode_Search_tb_TextChanged(object sender, EventArgs e)
        {
            if (BarCode_Search_tb.Text.Length == 12)
            {
                flowLayoutPanel1.Controls.Clear();

                DataTable data = controller.Get_Bags(BarCode_Search_tb.Text);
                if (data == null)
                {
                    MessageBox.Show("هذة المنتج غير موجود");
                    return;
                }
                else
                {
                    int count = data.Rows.Count;
                    ModelItemList[] lists = new ModelItemList[count];

                    for (int i = 0; i < count; i++)
                    {
                        lists[i] = new ModelItemList();
                        lists[i].BarCode = data.Rows[i][0].ToString();
                        lists[i].Model = data.Rows[i][1].ToString();
                        lists[i].Color = data.Rows[i][2].ToString();
                        lists[i].Quntity = Convert.ToInt32(data.Rows[i][3]);
                        lists[i].Whole_Price = Convert.ToDouble(data.Rows[i][4]);
                        lists[i].Normal_Price = Convert.ToDouble(data.Rows[i][5]);
                        lists[i].Seller = data.Rows[i][6].ToString();

                        flowLayoutPanel1.Controls.Add(lists[i]);
                    }

                    BarCode_Search_tb.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable data = controller.Get_Bags(BarCode_Search_tb.Text);
            if (data == null)
            {
                MessageBox.Show("هذة المنتج غير موجود");
                return;
            }
            else
            {
                int count = data.Rows.Count;
                ModelItemList[] lists = new ModelItemList[count];

                for (int i = 0; i < count; i++)
                {
                    lists[i] = new ModelItemList();
                    lists[i].BarCode = data.Rows[i][0].ToString();
                    lists[i].Model = data.Rows[i][1].ToString();
                    lists[i].Color = data.Rows[i][2].ToString();
                    lists[i].Quntity = Convert.ToInt32(data.Rows[i][3]);
                    lists[i].Whole_Price = Convert.ToDouble(data.Rows[i][4]);
                    lists[i].Normal_Price = Convert.ToDouble(data.Rows[i][5]);
                    lists[i].Seller = data.Rows[i][6].ToString();

                    flowLayoutPanel1.Controls.Add(lists[i]);
                }

                BarCode_Search_tb.Text = "";
            }
        }
    }
}
