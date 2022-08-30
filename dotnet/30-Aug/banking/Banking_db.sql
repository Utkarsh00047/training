CREATE TABLE admin_details
	(
		id INT PRIMARY KEY,
        admin_name VARCHAR(25),
		admin_email VARCHAR(25),
		admin_pass VARCHAR(25),
    );

	INSERT into admin_details values(1,'admin name','email@admin.com','12345')
	select * from admin_details


CREATE TABLE cust_details
	(
		id INT IDENTITY(1,1) PRIMARY KEY,
        cust_name VARCHAR(25),
		cust_email VARCHAR(25),
		cust_acc_no VARCHAR(25),
		balance VARCHAR(25),
    );
	
	select * from cust_details
	insert into cust_details values('name','email','1234567','5000')

