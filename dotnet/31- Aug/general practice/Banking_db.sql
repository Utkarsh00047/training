use banking
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
		userid INT IDENTITY(1,1) PRIMARY KEY,
        cust_name VARCHAR(25),
		cust_email VARCHAR(25),
		cust_acc_no VARCHAR(25),
		balance VARCHAR(25),
    );
	drop table cust_details
	
	select * from cust_details
	insert into cust_details values('name','email','1234567','5000')


	create table user_log(
	id int PRIMARY KEY,
	operation varchar(50),
	"date" date
	)

	--insert trigger
Create trigger user_insert
on cust_details
for insert
as insert into user_log(id,operation,date) select userid,'user inserted',GETDATE() from inserted

select * from user_log

--delete trigger
Create trigger user_delete
on cust_details
for delete
as insert into user_log(id,operation,date) select userid,'user inserted',GETDATE() from deleted

