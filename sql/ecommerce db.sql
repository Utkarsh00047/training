CREATE TABLE Customer
    (
        Customer_id int IDENTITY(1,1) NOT NULL,
        c_pass VARCHAR(10) NOT NULL,
        Name VARCHAR(20) NOT NULL,
        Address VARCHAR(20) NOT NULL,
        Pincode VARCHAR(20) NOT NULL,
        Phone_number_s VARCHAR(20) NOT NULL,
        PRIMARY KEY (Customer_id),
    );

	CREATE TABLE Product
    (
        Product_id int IDENTITY(1,1) NOT NULL,
		P_title VARCHAR(200) NOT NULL,
        Color VARCHAR(15) NOT NULL,
        P_Size VARCHAR(20) NOT NULL,
        Gender CHAR(10) NOT NULL,
        Cost int NOT NULL,
        Available_Quantity int NOT NULL,
        PRIMARY KEY (Product_id),
    );

	CREATE TABLE Customer_order
    (
		ORDER_ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Quantity_wished int NOT NULL,
        Date_Added DATE NOT NULL,
        Product_id int NOT NULL,
		Total_amount int NOT NULL,
        FOREIGN KEY (Product_id) REFERENCES Product(Product_id)
    );
	alter table Customer_order add Customer_id int REFERENCES Customer(Customer_id)


	CREATE TABLE accounts(
		Invoice_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		Total_amount int NOT NULL,
		ORDER_ID int NOT NULL,
	    Payment_status VARCHAR(15) NOT NULL,
		FOREIGN KEY (ORDER_ID) REFERENCES Customer_order(ORDER_ID),	
	);
		alter table accounts add Customer_id int REFERENCES Customer(Customer_id)
	

		SET IDENTITY_INSERT Customer ON;

		insert into Customer (Customer_id,c_pass,Name,Address,Pincode,Phone_number_s) values(1,'12345678','Customer1','address','208003','8303006960'),
		(2,'12345678','Customer2','address2','208003','8303006962'),
		(3,'12345678','Customer3','address3','208003','8303006963'),
		(4,'12345678','Customer4','address4','208003','8303006964'),
		(5,'12345678','Customer5','address5','208003','8303006965'),
		(6,'12345678','Customer6','address6','208003','8303006966'),
		(7,'12345678','Customer7','address7','208003','8303006967'),
		(8,'12345678','Customer8','address8','208003','8303006968'),
		(9,'12345678','Customer9','address9','208003','8303006969'),
		(10,'12345678','Customer10','address10','208003','8303006970')
		select * from Customer
		SET IDENTITY_INSERT Customer OFF;

		SET IDENTITY_INSERT Product ON;

		insert into Product (Product_id,p_title,Color,P_Size,Gender,Cost,Available_Quantity) values(1,'Product1','white','Small','Male',111,10),
		(2,'Product2','white','Small','Male',112,10),
		(3,'Product3','white','Small','Male',113,10),
		(4,'Product4','white','Small','Male',114,10),
		(5,'Product5','white','Small','Male',115,10),
		(6,'Product6','white','Small','Male',116,10),
		(7,'Product7','white','Small','Male',117,10),
		(8,'Product8','white','Small','Male',118,10),
		(9,'Product9','white','Small','Male',119,10),
		(10,'Product10','white','Small','Male',1110,10)
		select * from Product

		SET IDENTITY_INSERT Product OFF;

		SET IDENTITY_INSERT Customer_order ON;

		insert into Customer_order (ORDER_ID,Quantity_wished,Date_Added,Product_id,Total_amount,Customer_id) values(1,1,'2011-08-02',1,111,1)
		select * from Customer_order
		SET IDENTITY_INSERT Customer_order OFF;

		SET IDENTITY_INSERT accounts ON;

		insert into accounts (Invoice_id,Total_amount,ORDER_ID,Payment_status,Customer_id) values(1,111,1,'done',1)

		select * from accounts
		SET IDENTITY_INSERT accounts OFF;

		
		create view Product_View1
		as
		select Name,Pincode
		from customer as c
		inner join Customer_order as o
		on c.Customer_id = o.Customer_id;

		select * from Product_View1;


		--Creating view for showing the payment method done by each customer.

		create view Payment_status
		as 
		select Name,Payment_status
		from customer as c 
		inner join accounts as a
		on c.Customer_id = a.Customer_id;

		select * from Payment_status;

		create view total_Price_view
		as 
		select ORDER_ID,Total_amount
		from accounts as c
		inner join Customer as a
		on c.Customer_id = a.Customer_id;

		select * from total_Price_view;