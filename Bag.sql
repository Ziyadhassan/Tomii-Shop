Create Database Bags

GO
use Bags

Create Table Bag
(
	BarCode			VarChar(50)	  Not Null,
	Bag_Model		NVarChar(100) Not Null,
	Color			NVarChar(100) Not Null,
	Quantity		Int			  Not Null,
	Wholesale_Price Float(10)	  Not Null,
	Normal_Price	Float(10)	  Not Null,
	Seller			NVarChar(50)  Not Null

	Primary key(BarCode),
	Unique(Bag_Model,Color)
);

Create Table Orders
(
	OrderID	 Int IDENTITY(1,1),
	Ord_Date Date Not Null,
	Ord_Time Time Not Null,
	Total_Price Float(5) Not Null,

	Primary Key(OrderID),
);

Create Table Order_Items
(
	OrderID			Int			  Not Null,
	BarCode			VarChar(50)	  Not Null,
	Bag_Model		NVarChar(100) Not Null,
	Color			NVarChar(100) Not Null,
	Type_Of_Sell    NVarChar(100) Not Null,
	Single_Price	Float(10)	  Not Null,
	Quntity         Int			  Not Null,
	Total_Price		Float(10)	  Not Null,

	Foreign Key (OrderID) REFERENCES Orders
	On Delete Cascade
	On Update Cascade,
);

Create Table Order_From_Factory
(
	OrderID				Int		 IDENTITY(1,1),
	BarCode				VarChar(50)	  Not Null,
	Model				NVarChar(100) Not Null,
	Factory_Name		NVarChar(100) Not Null,
	Quntity				Int			  Not Null,
	Color				NVarChar(100) Not Null,
	Price				Float(10)	  Not Null,
	Total_Price			Float(10)	  Not Null,

	Primary Key(OrderID),
);

Create Table Order_From_Factory_Installments
(
	OrderID				Int		 Not NUll,
	Installment			Float(10) Not Null,
	Installment_Date	Date	 Not Null,
	Installment_Time	Time	 Not Null,
	Price_Left			Float(10) Not Null,

	Primary Key(OrderID,Installment_Date,Installment_Time),

	Foreign Key (OrderID) REFERENCES Order_From_Factory
	On Delete Cascade
	On Update Cascade,
);

Create Table Order_Out_Whole
(
	OrderID				Int		 IDENTITY(1,1),
	BarCode				VarChar(50)	  Not Null,
	Model				NVarChar(100) Not Null,
	Factory_Name		NVarChar(100) Not Null,
	Quntity				Int			  Not Null,
	Color				NVarChar(100) Not Null,
	Price				Float(10)	  Not Null,
	Total_Price			Float(10)	  Not Null,

	Primary Key(OrderID),
);

Create Table Order_Out_Whole_Installments
(
	OrderID				Int		 Not NUll,
	Installment			Float(10) Not Null,
	Installment_Date	Date	 Not Null,
	Installment_Time	Time	 Not Null,
	Price_Left			Float(10) Not Null,

	Primary Key(OrderID,Installment_Date,Installment_Time),

	Foreign Key (OrderID) REFERENCES Order_Out_Whole
	On Delete Cascade
	On Update Cascade,
);

Create Table Order_Out_Normal
(
	OrderID				Int		 IDENTITY(1,1),
	BarCode				VarChar(50)	  Not Null,
	Model				NVarChar(100) Not Null,
	Factory_Name		NVarChar(100) Not Null,
	Quntity				Int			  Not Null,
	Color				NVarChar(100) Not Null,
	Price				Float(10)	  Not Null,
	Total_Price			Float(10)	  Not Null,

	Primary Key(OrderID),
);

Create Table Order_Out_Normal_Installments
(
	OrderID				Int		 Not NUll,
	Installment			Float(10) Not Null,
	Installment_Date	Date	 Not Null,
	Installment_Time	Time	 Not Null,
	Price_Left			Float(10) Not Null,

	Primary Key(OrderID,Installment_Date,Installment_Time),

	Foreign Key (OrderID) REFERENCES Order_Out_Normal
	On Delete Cascade
	On Update Cascade,
);