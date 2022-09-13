CREATE DATABASE car
use car
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
select * from emp

insert into emp (emp_name,emp_cost,emp_email,designation) values ('name 1',100,'email1@email.com','worker'),
('name 2',102,'email2@email.com','senior worker'),
('name 3',103,'email3@email.com','superviser'),
('name 4',104,'email4@email.com','QA')
select * from emp

create table part(
	part_id int IDENTITY(1,1),
	part_code varchar(25) primary key,
	part_name varchar(25),
	part_cost int,
)

insert into part(part_code,part_name,part_cost) values ('p001','tyre',1000),
('p002','break',2000),
('p003','engine',3000),
('p004','wheel',500)
select * from part

create table product(
	PRO_ID int IDENTITY(1,1),
	pro_code varchar(25) primary key,
	man_p_cost int,
	total_cost int, --all part cost + man_p_cost
	selling_p int,
	selling_date date,
	profit int,
)

insert into product(pro_code,man_p_cost,total_cost,selling_p,selling_date,profit) values ('pro001',10000,16500,20000,GETDATE(),3500)

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