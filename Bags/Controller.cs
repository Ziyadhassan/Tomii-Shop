using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bags
{
    class Controller
    {
        DBManger db;

        public Controller()
        {
            db = new DBManger();
        }

        public int Insert_New_Bag(string barcode, string Model, string color, int quantity, double Wholesale_Price, double Normal_Price, string seller)
        {
            string query = "Insert into Bag Values( " +
                           "'" + barcode + "',N'" + Model +
                           "' , N'" + color + "', " + quantity + " " +
                           ", " + Wholesale_Price + " , " + Normal_Price +
                           " , N'" + seller + "');";

            return db.ExecuteNonQuery(query);
        }

        public DataTable Get_Bags(string barcode)
        {
            string query = "Select * " +
                           "From Bag as B " +
                           "Where BarCode = '" + barcode + "';";
            return db.ExecuteReader(query);
        }

        public DataTable Get_Bags_By_Model(string model)
        {
            string query = "Select * " +
                           "From Bag as B " +
                           "Where Bag_Model = N'" + model + "';";
            return db.ExecuteReader(query);
        }

        public DataTable Get_All_Bags()
        {
            string query = "Select * " +
                           "From Bag as B ; ";
            return db.ExecuteReader(query);
        }

        public int Update_Bag_Info(string Model, string color, int quantity, double Whole_Price, double Normal_Price, string seller)
        {
            string query = "Update Bag Set Quantity = " + quantity + ", " +
                           "Wholesale_Price = " + Whole_Price + ", " +
                           "Normal_Price = " + Normal_Price + " , " +
                           "Seller = N'" + seller + "' " +
                           "Where Bag_Model = N'" + Model + "' and Color =  N'" + color + "';";

            return db.ExecuteNonQuery(query);
        }

        public int Delete_Bag(string model, string color)
        {
            string query = "Delete From Bag Where Bag_Model = N'" + model + "' and Color = N'" + color + "';";

            return db.ExecuteNonQuery(query);
        }

        public int Buy_Bag(string barcode, int count)
        {
            string query = "Update Bag Set Quantity = Quantity - " + count + " Where BarCode = '" + barcode + "';";
            return db.ExecuteNonQuery(query);
        }

        public int Buy_Bag(DataTable data, string[] barcodes, double total_price)
        {
            try
            {
                for (int i = 0; i < barcodes.Length; i++)
                    this.Buy_Bag(barcodes[i], Convert.ToInt32(data.Rows[i][1]));

                string query1 = "Insert Into Orders Values('" + DateTime.Today + "', " +
                                "'" + DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss") + "', " + total_price + ");";

                db.ExecuteNonQuery(query1);

                int id = Convert.ToInt32(db.ExecuteScalar("Select Max(OrderID) From Orders"));

                for (int i = 0; i < barcodes.Length; i++)
                {
                    string query2 = "Insert Into Order_Items Values(" + id + ", " +
                                    "N'" + barcodes[i] + "', N'" + data.Rows[i][5].ToString() + "', " +
                                    "N'" + data.Rows[i][4].ToString() + "' , N'" + data.Rows[i][3].ToString() + "', " +
                                    " " + Convert.ToDouble(data.Rows[i][2]) + ", " + Convert.ToInt32(data.Rows[i][1].ToString()) + "," +
                                    " " + Convert.ToDouble(data.Rows[i][0].ToString()) + ");";
                    db.ExecuteNonQuery(query2);
                }

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public DataTable Get_Sales(DateTime From, DateTime To)
        {
            string query = "Select * From Orders Where Ord_Date >= '" + From.Date + "' and Ord_Date <= '" + To.Date + "';";
            return db.ExecuteReader(query);
        }

        public DataTable Get_Order_Details(int orderid)
        {
            string query = "Select * From Order_Items Where OrderID = " + orderid + ";";
            return db.ExecuteReader(query);
        }

        public int Delete_Order(int orderid)
        {
            string query = "Delete From Orders " +
                           "Where OrderID = " + orderid + ";";
            return db.ExecuteNonQuery(query);
        }

        //--------------- From Factory Installs
        public int Add_Order_From_Factory_Installment(string barcode, string model, string name, string colors, int quantity, double price, double totalMoney, double installment)
        {
            double left = totalMoney - installment;

            string query = "Insert Into Order_From_Factory Values(" +
                           " N'" + barcode + "' , N'" + model + "', N'" + name + "' , " + quantity + " , N'" + colors + "' , " + price + " , " + totalMoney + ");";

            if (db.ExecuteNonQuery(query) != 1)
                return 0;

            int id = Convert.ToInt32(db.ExecuteScalar("Select Max(OrderID) From Order_From_Factory"));

            string query2 = "Insert Into Order_From_Factory_Installments Values(" +
                            +id + " , " + installment + " , '" + DateTime.Today.ToShortDateString() + "' , '" + DateTime.Now.ToString("hh:mm:ss") + "'," + left + ");";

            return db.ExecuteNonQuery(query2);
        }

        public int Pay_New_Installment_To_Factory(int orderid, double installment)
        {
            string query1 = "Select Max(Total_Price) " +
                            "From Order_From_Factory " +
                            "Where OrderID = " + orderid + ";";

            double total_money = Convert.ToDouble(db.ExecuteScalar(query1));

            if (total_money == 0)
                return -2;

            string query2 = "Select Sum(Installment) " +
                            "From Order_From_Factory_Installments " +
                            "Where OrderID = " + orderid + " and Installment_Date <= '" + DateTime.Today.ToShortDateString() + "';";

            double total_paid = Convert.ToDouble(db.ExecuteScalar(query2));

            if (installment > total_money - total_paid)
                return -1;

            double left = total_money - total_paid - installment;

            string query3 = "Insert Into Order_From_Factory_Installments Values(" +
                            +orderid + " , " + installment + " , '" + DateTime.Today.ToShortDateString() + "' , '" + DateTime.Now.ToString("hh:mm:ss") + "'," + left + ");";

            return db.ExecuteNonQuery(query3);
        }

        public DataTable Get_All_Factory_Installments()
        {
            string query = "Select * " +
                           "From Order_From_Factory as o ,Order_From_Factory_Installments as oi " +
                           "Where o.OrderID = oi.OrderID";
            return db.ExecuteReader(query);
        }

        public DataTable Still_To_Pay_To_Factory()
        {
            string query = "Select ff.BarCode,ff.Model, ff.OrderID,ff.Factory_Name,ff.Quntity,ff.Color,ff.Price,ff.Total_Price,hh.Installment,hh.Installment_Date,hh.Installment_Time,hh.Price_Left " +
                           "From Order_From_Factory ff, (Select o.OrderID,Min(oi.Price_Left) as Price_Left " +
                           "From Order_From_Factory o , Order_From_Factory_Installments oi " +
                           "Where o.OrderID = oi.OrderID " +
                           "Group by o.OrderID " +
                           "Having Min(Price_Left) != 0) as bb, Order_From_Factory_Installments hh " +
                           "Where bb.OrderID = ff.OrderID and bb.Price_Left = hh.Price_Left and ff.OrderID = hh.OrderID";

            return db.ExecuteReader(query);
        }

        public DataTable Installments_From_Factroy_By_Name(string name)
        {
            string query = "Select * " +
                           "From Order_From_Factory as o ,Order_From_Factory_Installments as oi " +
                           "Where o.OrderID = oi.OrderID and Factory_Name = '" + name + "';";
            return db.ExecuteReader(query);
        }

        public int Delete_Order_From_Factory_Installment(int orderid)
        {
            string query = "Delete From Order_From_Factory " +
                           "Where OrderID = " + orderid + ";";
            return db.ExecuteNonQuery(query);
        }



        //------------- Out Installments Whole
        public int Add_Order_Out_Factory_Whole(string barcode, string model, string name, string colors, int quantity, double price, double totalMoney, double installment)
        {
            double left = totalMoney - installment;

            string query = "Insert Into Order_Out_Whole Values(" +
                           " N'" + barcode + "' , N'" + model + "', N'" + name + "' , " + quantity + " , N'" + colors + "' , " + price + " , " + totalMoney + ");";

            if (db.ExecuteNonQuery(query) != 1)
                return 0;

            int id = Convert.ToInt32(db.ExecuteScalar("Select Max(OrderID) From Order_Out_Whole"));

            string query2 = "Insert Into Order_Out_Whole_Installments Values(" +
                            +id + " , " + installment + " , '" + DateTime.Today.ToShortDateString() + "' , '" + DateTime.Now.ToString("hh:mm:ss") + "'," + left + ");";

            return db.ExecuteNonQuery(query2);
        }

        public int Pay_Out_Installment_Whole(int orderid, double installment)
        {
            string query1 = "Select Max(Total_Price) " +
                            "From Order_Out_Whole " +
                            "Where OrderID = " + orderid + ";";

            double total_money = Convert.ToDouble(db.ExecuteScalar(query1));

            if (total_money == 0)
                return -2;

            string query2 = "Select Sum(Installment) " +
                            "From Order_Out_Whole_Installments " +
                            "Where OrderID = " + orderid + " and Installment_Date <= '" + DateTime.Today.ToShortDateString() + "';";

            double total_paid = Convert.ToDouble(db.ExecuteScalar(query2));

            if (installment > total_money - total_paid)
                return -1;

            double left = total_money - total_paid - installment;

            string query3 = "Insert Into Order_Out_Whole_Installments Values(" +
                            +orderid + " , " + installment + " , '" + DateTime.Today.ToShortDateString() + "' , '" + DateTime.Now.ToString("hh:mm:ss") + "'," + left + ");";

            return db.ExecuteNonQuery(query3);
        }

        public DataTable Get_All_Out_Whole_Installments()
        {
            string query = "Select * " +
                           "From Order_Out_Whole as o ,Order_Out_Whole_Installments as oi " +
                           "Where o.OrderID = oi.OrderID";
            return db.ExecuteReader(query);
        }

        public DataTable Still_To_Pay_Out_Whole()
        {
            string query = "Select ff.BarCode,ff.Model,ff.OrderID,ff.Factory_Name,ff.Quntity,ff.Color,ff.Price,ff.Total_Price,hh.Installment,hh.Installment_Date,hh.Installment_Time,hh.Price_Left " +
                           "From Order_Out_Whole ff, (Select o.OrderID,Min(oi.Price_Left) as Price_Left " +
                           "From Order_Out_Whole o , Order_Out_Whole_Installments oi " +
                           "Where o.OrderID = oi.OrderID " +
                           "Group by o.OrderID " +
                           "Having Min(Price_Left) != 0) as bb, Order_Out_Whole_Installments hh " +
                           "Where bb.OrderID = ff.OrderID and bb.Price_Left = hh.Price_Left and ff.OrderID = hh.OrderID";

            return db.ExecuteReader(query);
        }

        public DataTable Installments_Out_Whole_By_Name(string name)
        {
            string query = "Select * " +
                           "From Order_Out_Whole as o ,Order_Out_Whole_Installments as oi " +
                           "Where o.OrderID = oi.OrderID and Factory_Name = '" + name + "';";
            return db.ExecuteReader(query);
        }

        public int Delete_Order_Out_Whole_Installment(int orderid)
        {
            string query = "Delete From Order_Out_Whole " +
                           "Where OrderID = " + orderid + ";";
            return db.ExecuteNonQuery(query);
        }

        //------------- Out Installments Normal

        public int Add_Order_Out_Factory_Normal(string barcode, string model, string name, string colors, int quantity, double price, double totalMoney, double installment)
        {
            double left = totalMoney - installment;

            string query = "Insert Into Order_Out_Normal Values(" +
                            " N'" + barcode + "' , N'" + model + "', N'" + name + "' , " + quantity + " , N'" + colors + "' , " + price + " , " + totalMoney + ");";

            if (db.ExecuteNonQuery(query) != 1)
                return 0;

            int id = Convert.ToInt32(db.ExecuteScalar("Select Max(OrderID) From Order_Out_Normal"));

            string query2 = "Insert Into Order_Out_Normal_Installments Values(" +
                            +id + " , " + installment + " , '" + DateTime.Today.ToShortDateString() + "' , '" + DateTime.Now.ToString("hh:mm:ss") + "'," + left + ");";

            return db.ExecuteNonQuery(query2);
        }

        public int Pay_Out_Installment_Normal(int orderid, double installment)
        {
            string query1 = "Select Max(Total_Price) " +
                            "From Order_Out_Normal " +
                            "Where OrderID = " + orderid + ";";

            double total_money = Convert.ToDouble(db.ExecuteScalar(query1));

            if (total_money == 0)
                return -2;

            string query2 = "Select Sum(Installment) " +
                            "From Order_Out_Normal_Installments " +
                            "Where OrderID = " + orderid + " and Installment_Date <= '" + DateTime.Today.ToShortDateString() + "';";

            double total_paid = Convert.ToDouble(db.ExecuteScalar(query2));

            if (installment > total_money - total_paid)
                return -1;

            double left = total_money - total_paid - installment;

            string query3 = "Insert Into Order_Out_Normal_Installments Values(" +
                            +orderid + " , " + installment + " , '" + DateTime.Today.ToShortDateString() + "' , '" + DateTime.Now.ToString("hh:mm:ss") + "'," + left + ");";

            return db.ExecuteNonQuery(query3);
        }

        public DataTable Get_All_Out_Normal_Installments()
        {
            string query = "Select * " +
                           "From Order_Out_Normal as o ,Order_Out_Normal_Installments as oi " +
                           "Where o.OrderID = oi.OrderID";
            return db.ExecuteReader(query);
        }

        public DataTable Still_To_Pay_Out_Normal()
        {
            string query = "Select ff.BarCode,ff.Model,ff.OrderID,ff.Factory_Name,ff.Quntity,ff.Color,ff.Price,ff.Total_Price,hh.Installment,hh.Installment_Date,hh.Installment_Time,hh.Price_Left " +
                           "From Order_Out_Normal ff, (Select o.OrderID,Min(oi.Price_Left) as Price_Left " +
                           "From Order_Out_Normal o , Order_Out_Normal_Installments oi " +
                           "Where o.OrderID = oi.OrderID " +
                           "Group by o.OrderID " +
                           "Having Min(Price_Left) != 0) as bb, Order_Out_Normal_Installments hh " +
                           "Where bb.OrderID = ff.OrderID and bb.Price_Left = hh.Price_Left and ff.OrderID = hh.OrderID";

            return db.ExecuteReader(query);
        }

        public DataTable Installments_Out_Normal_By_Name(string name)
        {
            string query = "Select * " +
                           "From Order_Out_Normal as o ,Order_Out_Normal_Installments as oi " +
                           "Where o.OrderID = oi.OrderID and Factory_Name = '" + name + "';";
            return db.ExecuteReader(query);
        }

        public int Delete_Order_Out_Normal_Installment(int orderid)
        {
            string query = "Delete From Order_Out_Normal " +
                           "Where OrderID = " + orderid + ";";
            return db.ExecuteNonQuery(query);
        }
    }
}
