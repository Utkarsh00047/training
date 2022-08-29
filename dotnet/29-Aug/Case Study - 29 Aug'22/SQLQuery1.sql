CREATE DATABASE "Hospital";

CREATE TABLE Doctor
	(
		docId INT ,
        docName VARCHAR(25),
		docEmail VARCHAR(25) PRIMARY KEY,
		docDepartment VARCHAR(25) ,
    );

	--Insert Doctor

	Insert Into Doctor (docId,docName,docEmail,docDepartment) values (1,'DocName1','DocEmail1','department1'),
	(2,'DocName2','DocEmail2','department2'),
	(3,'DocName3','DocEmail3','department3'),
	(4,'DocName4','DocEmail4','department4'),
	(5,'DocName5','DocEmail5','department5')

	select * from Doctor

CREATE TABLE patient
	(
		patientId INT,
        patientName VARCHAR(25),
		patientEmail VARCHAR(25) PRIMARY KEY,
		docEmail VARCHAR(25),
        FOREIGN KEY(docEmail) REFERENCES Doctor(docEmail),
    );

	--insert patient
	Insert Into patient (patientId,patientName,patientEmail,docEmail) values (1, 'Name1','PatientEmail1','DocEmail1'),
	(2, 'PatientName2','PatEmail2','DocEmail2'),
	(3, 'PatientName3','PatEmail3','DocEmail3'),
	(4, 'PatientName4','PatEmail4','DocEmail4'),
	(5, 'PatientName5','PatEmail5','DocEmail5')
		select * from patient

CREATE TABLE BookBed
	(
		bedID INT,
        bedCode VARCHAR(25),
		patientEmail VARCHAR(25),
        FOREIGN KEY(patientEmail) REFERENCES patient(patientEmail),
		price INT,
    );

	--insert booking of bed

	Insert Into BookBed (bedID,bedCode,patientEmail,price) values (1,'bed001','PatientEmail1',1000),
	(2,'bed002','PatEmail2',2000),
	(3,'bed003','PatEmail3',3000),
	(4,'bed004','PatEmail4',4000),
	(5,'bed005','PatEmail5',5000)

	select * from BookBed

	--patient trigger

	create table patient_log(
	id int PRIMARY KEY,
	operation varchar(50),
	"date" date
	)
	  CREATE TRIGGER patient_registration
	    on patient
		for insert
		as
		insert into patient_log(id,operation,date) select patientId,'Record inserted',GETDATE() from inserted

		select * from patient_log

