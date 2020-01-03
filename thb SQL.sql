USE master;
GO

CREATE DATABASE THB;
GO

USE THB;
GO

CREATE TABLE ADMIN_ACCOUNTS (
Admin_ID INT NOT NULL IDENTITY(1,1)
	CONSTRAINT PK_ADMINS PRIMARY KEY,
Admin_Username NVARCHAR(50) NOT NULL,
Admin_Password NVARCHAR (60) NOT NULL,
Admin_Name NVARCHAR(40) NOT NULL,
Admin_Status INT NOT NULL,);


CREATE TABLE CUSTOMER (
Customer_ID INT NOT NULL IDENTITY(1,1) 
	CONSTRAINT PK_CUSTOMER PRIMARY KEY,
Cust_Name NVARCHAR(40) NOT NULL,
Cust_Address NVARCHAR(40) NOT NULL,
Cust_Email NVARCHAR(30) NOT NULL,
Cust_Contact_Number INT NOT NULL,
);

CREATE TABLE ORDERS (
Order_Number INT NOT NULL IDENTITY(1,1) 
	CONSTRAINT PK_ORDERS PRIMARY KEY,
Order_Date DATETIME NOT NULL,
Cust_ID INT NOT NULL
	CONSTRAINT FK_CUSTOMER FOREIGN KEY
		REFERENCES CUSTOMER(Customer_ID),
Vendor_ID INT NOT NULL
	CONSTRAINT FK_ADMIN FOREIGN KEY
		REFERENCES ADMIN_ACCOUNTS(Admin_ID),
);

CREATE TABLE PRODUCTS (
Product_ID INT NOT NULL IDENTITY(1,1)
	CONSTRAINT PK_PRODUCTS PRIMARY KEY,
Product_Name NVARCHAR(50) NOT NULL,
Product_Price SMALLMONEY NOT NULL,
Product_Type VARCHAR(20) NOT NULL,
Product_Image IMAGE NOT NULL,
);

CREATE TABLE ORDER_QUANTITY (
Ordered_Number INT NOT NULL,
Prod_ID INT NOT NULL,
Quantity INT NOT NULL,
	CONSTRAINT PK_ORDER_QUANTITY PRIMARY KEY (Ordered_Number,Prod_ID),
	CONSTRAINT FK_ORDER_QUANTITY FOREIGN KEY (Ordered_Number)
		REFERENCES ORDERS (Order_Number),
	CONSTRAINT FK_PRODUCT_QUANTITY FOREIGN KEY (Prod_ID)
		REFERENCES PRODUCTS (Product_ID)
);