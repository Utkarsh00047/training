CREATE DATABASE "Tour and Travels";

CREATE TABLE CONTINENTS
	(
		contID INT PRIMARY KEY,
        contName VARCHAR(25)
    )
;
insert into CONTINENTS(contID,contName) values (1,'asia'),
(2,'europe')


CREATE table COUNTRIES
	(
		ctryID integer not null primary key,
		ctryName VARCHAR(45) unique,
		id_cont INTEGER NOT NULL,
        FOREIGN KEY(id_cont) REFERENCES CONTINENTS(contID),
		)
;

insert into COUNTRIES (ctryID, ctryName,id_cont) values (1,'India',1),(2,'france',2)


CREATE table CITIES 
	(
		id integer not null primary key,
		name VARCHAR(60),
        id_country integer not null,
        FOREIGN KEY(id_country) references COUNTRIES(ctryID)    )
;
insert into CITIES (id, name, id_country) values (1,'kanpur',1),(2,'paris',2)



CREATE TABLE POSITIONS (
	posID INTEGER NOT NULL  PRIMARY KEY,
	posName VARCHAR(45) NOT NULL UNIQUE,
    posBaseSalary bigint NOT NULL
);

insert into POSITIONS(posID,posName,posBaseSalary) values (1,'assistent',10000),(2,'onboarding manager',20000)

CREATE TABLE EMPLOYEES (
	empID INTEGER NOT NULL  PRIMARY KEY,
    empName VARCHAR(45) NOT NULL,
    empSurname VARCHAR(60) NOT NULL,
    position_id INTEGER NOT NULL, 
	FOREIGN KEY(position_id) REFERENCES POSITIONS(posID),
	empSalary bigint,
    empAccountNo VARCHAR(50),
    empStartDate date NOT NULL,
    empPhoneNo VARCHAR(20),

);

insert into EMPLOYEES(empID,empName,empSurname,position_id,empSalary,empAccountNo,empStartDate,empPhoneNo) values (1,'Utkarsh','gupta',1,10000,1111111111111,'2000-07-22','8303006960'),(2,'abhishek','gupta',2,20000,1111111111111,'2000-07-21','8303006961')

CREATE TABLE FLIGHTS (
	fliID INTEGER NOT NULL PRIMARY KEY,
    fliStartPoint INTEGER NOT NULL,
    fliEndPoint INTEGER NOT NULL,
    fliClass Varchar(50),
    fliPrice bigint,
    FOREIGN KEY (fliStartPoint) REFERENCES CITIES(id),
	FOREIGN KEY (fliEndPoint) REFERENCES CITIES(id),
	);

	insert into FLIGHTS(fliID,fliStartPoint,fliEndPoint,fliClass,fliPrice) values (1,1,2,'economy',10000),(2,2,1,'business',10000),(3,1,2,'economy',10000)

	CREATE TABLE CUSTOMERS (
	custID INTEGER NOT NULL  PRIMARY KEY,
    custName VARCHAR(50) NOT NULL,
    custSurname VARCHAR(50) NOT NULL,
	);

	insert into CUSTOMERS (custID,custName,custSurname) values (1,'Cust1','surname1'),(2,'Cust2','surname2')



	CREATE TABLE HOTELS (
	hotID INTEGER NOT NULL PRIMARY KEY,
	hotLocID INTEGER NOT NULL,
    hotPricePerNight bigint,
    hotTelephoneNo VARCHAR(20),
    hotContactEmail VARCHAR(45),
    FOREIGN KEY (hotLocID) REFERENCES CITIES (id),
	);

	insert into HOTELS(hotID,hotLocID,hotPricePerNight,hotTelephoneNo,hotContactEmail) values (1,1,1000,'1111111111111','hotel1@hotel.com'),(2,2,1000,'1111111111111','hotel2@hotel.com')
	
	CREATE TABLE PACKAGES (
	packID INTEGER NOT NULL PRIMARY KEY,
    packTitle VARCHAR(30) NOT NULL,
    packLocationID INTEGER NOT NULL,
    packHotelID INTEGER NULL,
    packDuration varchar(50) NOT NULL,
    packPrice bigint NULL,
    packStartDate DATE NOT NULL,
    packEndDate DATE NOT NULL,
    packDiscountAmnt bigint,
    packFlightNo VARCHAR(30) NULL,
    FOREIGN KEY (packLocationID) REFERENCES CITIES (id),
    FOREIGN KEY (packHotelID) REFERENCES HOTELS (hotID) ,
	);  
	insert into PACKAGES(packID,packTitle,packLocationID,packHotelID,packDuration,packPrice,packStartDate,packEndDate,packDiscountAmnt,packFlightNo)
	values (1,'title1',1,1,'10 days',10000,'2000-07-22','2000-07-25',500,1),(2,'title2',2,2,'10 days',10000,'2000-07-20','2000-07-25',500,2),(3,'title3',2,2,'10 days',10000,'2000-07-20','2000-07-25',500,2)

	CREATE TABLE BOOKINGS (
	bookID INTEGER NOT NULL PRIMARY KEY,
    bookCustomerID INTEGER NOT NULL,
    bookPackageID INTEGER NOT NULL,
    FOREIGN KEY (bookCustomerID) REFERENCES CUSTOMERS(custID),
	FOREIGN KEY (bookPackageID) REFERENCES PACKAGES(packID)
	);

	insert into BOOKINGS(bookID,bookCustomerID,bookPackageID) values (1,1,1),(2,2,2)

	create procedure check_package
		as 
		select c.packID
		from PACKAGES as c 
		inner join BOOKINGS as a
		on c.packID = a.bookID;
	
	EXEC check_package

	create procedure package_booked
	as 
	select a.packID from PACKAGES as a
	inner join BOOKINGS as b
	on a.packID = b.bookID

	exec package_booked



	create procedure check_cust_id
	as
	select a.custID from CUSTOMERS as a
	inner join BOOKINGS as  b
	on a.custID=b.bookID

	EXEC check_cust_id

	create procedure package_not_booked
	as 
	select a.packID from PACKAGES as a
	left join BOOKINGS as b
	on a.packID = b.bookID where b.bookID is NULL

	exec package_not_booked

	
	



