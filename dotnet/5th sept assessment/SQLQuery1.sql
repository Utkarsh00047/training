create table admin_cred(
		admin_id INT IDENTITY(1,1) PRIMARY KEY ,
        admin_name VARCHAR(25),
		admin_pass VARCHAR(25),
		admin_email VARCHAR(25),
)

Insert into admin_cred (admin_name,admin_pass,admin_email) values ('admin1','12345','admin1@pizza.com')
select * from admin_cred

create table franchisee_cred(
		franchisee_id INT IDENTITY(1,1),
        franchisee_name VARCHAR(25),
		franchisee_pass VARCHAR(25),
		franchisee_email VARCHAR(25),
		franchisee_code VARCHAR(25)  PRIMARY KEY,
		franchisee_cnumber VARCHAR(25),
		franchisee_address VARCHAR(25),
		franchisee_reg_date date,
)

Insert into franchisee_cred(franchisee_name,franchisee_pass,franchisee_email,franchisee_code,franchisee_cnumber,franchisee_address,franchisee_reg_date)
values
('fran1','12345','email1@franchisee.com','f001','8303006960','address1',GETDATE()),
('fran2','12345','email2@franchisee.com','f002','8303006960','address2',GETDATE()),
('fran3','12345','email3@franchisee.com','f003','8303006960','address3',GETDATE()),
('fran4','12345','email4@franchisee.com','f004','8303006960','address4',GETDATE()),
('fran5','12345','email5@franchisee.com','f005','8303006960','address5',GETDATE())
select * from franchisee_cred

create table emp_detail(
	emp_id INT IDENTITY(1,1),
	emp_name VARCHAR(25),
	emp_email VARCHAR(25),
	emp_code VARCHAR(25)  PRIMARY KEY,
	emp_salary VARCHAR(25),
	franchisee_code VARCHAR(25),
	foreign key(franchisee_code) REFERENCES franchisee_cred(franchisee_code),
	salary_distributed_date date,
)

insert into emp_detail(emp_name,emp_email,emp_code,emp_salary,franchisee_code,salary_distributed_date)
values
('emp_nam1','email1@emp.com','emp001','5000','f001',GETDATE()),
('emp_nam2','email2@emp.com','emp002','5000','f002',GETDATE()),
('emp_nam3','email3@emp.com','emp003','5000','f003',GETDATE()),
('emp_nam4','email4@emp.com','emp004','5000','f004',GETDATE()),
('emp_nam5','email5@emp.com','emp005','5000','f005',GETDATE())

create table online_sale(
		online_order_id INT IDENTITY(1,1) PRIMARY KEY ,
        online_order_customer_name VARCHAR(25),
		online_order_franchisee_code VARCHAR(25),
		online_order_amount INT,
		online_order_date date,
		emp_code VARCHAR(25),
		foreign key(emp_code) REFERENCES emp_detail(emp_code),
		foreign key(online_order_franchisee_code) REFERENCES franchisee_cred(franchisee_code),

)

insert into online_sale(online_order_customer_name,online_order_franchisee_code,online_order_amount,online_order_date,emp_code)
values
('customer_name_online_1','f001',500,GETDATE(),'emp001'),
('customer_name_online_2','f002',500,GETDATE(),'emp002'),
('customer_name_online_3','f003',500,GETDATE(),'emp003'),
('customer_name_online_4','f004',500,GETDATE(),'emp004'),
('customer_name_online_5','f005',500,GETDATE(),'emp005')

select * from online_sale

create table offline_sale(
		offline_order_id INT IDENTITY(1,1) PRIMARY KEY ,
        offline_order_customer_name VARCHAR(25),
		offline_order_franchisee_code VARCHAR(25),
		offline_order_amount INT,
		offline_order_date date,
		emp_code VARCHAR(25),
		foreign key(emp_code) REFERENCES emp_detail(emp_code),
		foreign key(offline_order_franchisee_code) REFERENCES franchisee_cred(franchisee_code),
)
insert into offline_sale(offline_order_customer_name,offline_order_franchisee_code,offline_order_amount,offline_order_date,emp_code)
values
('customer_name_offline_1','f001',500,GETDATE(),'emp001'),
('customer_name_offline_2','f002',500,GETDATE(),'emp002'),
('customer_name_offline_3','f003',500,GETDATE(),'emp003'),
('customer_name_offline_4','f004',500,GETDATE(),'emp004'),
('customer_name_offline_5','f005',500,GETDATE(),'emp005')

select * from offline_sale

select * from offline_sale
SELECT SUM(offline_order_amount)
FROM offline_sale
WHERE offline_order_date = '2022-09-05';


