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
    public partial class Store : UserControl
    {
        Controller controller;
        public Store()
        {
            InitializeComponent();
            controller = new Controller();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void Search_All_btn_Click(object sender, EventArgs e)
        {
            DataTable data = controller.Get_All_Bags();

            if (data == null)
            {
                MessageBox.Show("لا توجد بيانات");
                return;
            }

            dataGridView1.DataSource = ReverseDataTableColumns(data);

            
            dataGridView1.Columns["Bag_Model"].HeaderText = "الموديل";
            dataGridView1.Columns["BarCode"].HeaderText = "الباركود";
            dataGridView1.Columns["Color"].HeaderText = "اللون";
            dataGridView1.Columns["Quantity"].HeaderText = "العدد";
            dataGridView1.Columns["Wholesale_Price"].HeaderText = "سعر الجملة";
            dataGridView1.Columns["Normal_Price"].HeaderText = "سعر القطاعي";
            dataGridView1.Columns["Seller"].HeaderText = "التاجر";

            dataGridView1.Refresh();
        }

        private DataTable ReverseDataTableColumns(DataTable sourceDataTable)
        {
            if (sourceDataTable.Rows.Count > 0)
            {
                DataTable dtReversed = new DataTable();
                var se = sourceDataTable.Columns.Cast<DataColumn>().Reverse().ToArray();
                dtReversed.Columns.AddRange(sourceDataTable.Columns.Cast<DataColumn>().Reverse().Select(x => new DataColumn(x.ColumnName)).ToArray());
                for (int j = 0; j < sourceDataTable.Rows.Cast<DataRow>().Select(x => x.ItemArray.Reverse()).Count(); j++)
                {
                    dtReversed.Rows.Add();
                    var row = sourceDataTable.Rows.Cast<DataRow>().Select(x => x.ItemArray.Reverse()).ElementAt(j);
                    for (int k = 0; k < row.Count(); k++)
                    {
                        dtReversed.Rows[j][k] = row.ElementAt(k);
                    }
                }
                return dtReversed;
            }
            else
            {
                return sourceDataTable;
            }
        }

        private void Search_text_Field_TextChanged(object sender, EventArgs e)
        {
            if (Search_text_Field.Text.Length == 12)
            {
                DataTable data = controller.Get_Bags(Search_text_Field.Text);
                if (data == null)
                {
                    MessageBox.Show("هذة المنتج غير موجود");
                    Search_text_Field.Text = "";
                    return;
                }
                else
                {
                    dataGridView1.DataSource = ReverseDataTableColumns(data);

                    dataGridView1.Columns["Bag_Model"].HeaderText = "الموديل";
                    dataGridView1.Columns["BarCode"].HeaderText = "الباركود";
                    dataGridView1.Columns["Color"].HeaderText = "اللون";
                    dataGridView1.Columns["Quantity"].HeaderText = "العدد";
                    dataGridView1.Columns["Wholesale_Price"].HeaderText = "سعر الجملة";
                    dataGridView1.Columns["Normal_Price"].HeaderText = "سعر القطاعي";
                    dataGridView1.Columns["Seller"].HeaderText = "التاجر";

                    dataGridView1.Refresh();
                    Search_text_Field.Text = "";
                    return;
                }
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (Search_tb.Text == "")
            {
                MessageBox.Show("الرجاء ادخال اسم الموديل");
                return;
            }

            DataTable data = controller.Get_Bags_By_Model(Search_tb.Text);

            if (data == null)
            {
                MessageBox.Show("هذه المنتج غير موجود\nالرجاء التأكد من اسم الموديل");
                return;
            }
            else
            {

                dataGridView1.DataSource = ReverseDataTableColumns(data);

                dataGridView1.Columns["Bag_Model"].HeaderText = "الموديل";
                dataGridView1.Columns["BarCode"].HeaderText = "الباركود";
                dataGridView1.Columns["Color"].HeaderText = "اللون";
                dataGridView1.Columns["Quantity"].HeaderText = "العدد";
                dataGridView1.Columns["Wholesale_Price"].HeaderText = "سعر الجملة";
                dataGridView1.Columns["Normal_Price"].HeaderText = "سعر القطاعي";
                dataGridView1.Columns["Seller"].HeaderText = "التاجر";

                dataGridView1.Refresh();
                Search_text_Field.Text = "";
                return;
            }
        }

        private void Search_Bar_btn_Click(object sender, EventArgs e)
        {
            DataTable data = controller.Get_Bags(Search_text_Field.Text);
            if (data == null)
            {
                MessageBox.Show("هذة المنتج غير موجود");
                Search_text_Field.Text = "";
                return;
            }
            else
            {
                dataGridView1.DataSource = ReverseDataTableColumns(data);

                dataGridView1.Columns["Bag_Model"].HeaderText = "الموديل";
                dataGridView1.Columns["BarCode"].HeaderText = "الباركود";
                dataGridView1.Columns["Color"].HeaderText = "اللون";
                dataGridView1.Columns["Quantity"].HeaderText = "العدد";
                dataGridView1.Columns["Wholesale_Price"].HeaderText = "سعر الجملة";
                dataGridView1.Columns["Normal_Price"].HeaderText = "سعر القطاعي";
                dataGridView1.Columns["Seller"].HeaderText = "التاجر";

                dataGridView1.Refresh();
                Search_text_Field.Text = "";
                return;
            }
        }
    }
}
