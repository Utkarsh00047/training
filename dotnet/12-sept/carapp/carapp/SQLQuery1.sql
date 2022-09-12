CREATE DATABASE car

create table admin(
		admin_id INT primary key,
		admin_name varchar(25),
		admin_pass varchar(25),
)

insert into admin(admin_id,admin_name,admin_pass) values (1,'admin','12345')

create table emp(
	emp_id int IDENTITY(1,1) primary key,
	emp_name varchar(25),
	emp_cost int,
	emp_email varchar(25),
	designation varchar(25),
)

insert into emp (emp_id,emp_name,emp_cost,emp_email,designation) values (1,'name 1',100,'email1@email.com','worker'),
(2,'name 2',102,'email2@email.com','senior worker'),
(3,'name 3',103,'email3@email.com','superviser'),
(4,'name 4',104,'email4@email.com','QA')

create table part(
	part_id int IDENTITY(1,1),
	part_code varchar(25) primary key,
	part_name varchar(25),
	part_cost int,
)

insert into part(part_id,part_code,part_name,part_cost) values (1,'p001','tyre',1000),
(2,'p002','break',2000),
(3,'p003','engine',3000),
(4,'p004','wheel',500)

create table product(
	PRO_ID int IDENTITY(1,1),
	pro_code int primary key,
	man_p_cost int,
	total_cost int, --all part cost + man_p_cost
	selling_p int,
	selling_date date,
	profit int,
)

insert into product(PRO_ID,pro_code,man_p_cost,total_cost,selling_p,selling_date,profit) values (1,'pro001',10000,16500,20000,GETDATE(),3500)

create table working_hours(
		emp_id int,
		FOREIGN KEY (emp_id) REFERENCES emp(emp_id),
		working_date date,
		total_w_hours int,
		day_payout int,
)

insert into working_hours(emp_id,working_date,total_w_hours,day_payout) values(1,GETDATE(),7,700)

create table salary(
		emp_id int,
		FOREIGN KEY (emp_id) REFERENCES emp(emp_id),
		salary_date date,
)