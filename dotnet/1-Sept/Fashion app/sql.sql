CREATE TABLE Category
	(
		cat_id INT IDENTITY(1,1) PRIMARY KEY ,
        cat_name VARCHAR(25),
		cat_code VARCHAR(25),
    );

	select * from Category

CREATE TABLE Product
(
	pro_id INT IDENTITY(1,1) PRIMARY KEY,
	Pro_name VARCHAR(25),
	Pro_quantity INT,
	pro_price INT,
	pro_des VARCHAR(500),
	cat_id INT,
	foreign key(cat_id) REFERENCES Category(cat_id),
);
select * from Product

--CREATE TABLE Mapper(
--	pro_id INT,        
--	FOREIGN KEY(pro_id) REFERENCES Product(pro_id),
--	cat_id INT,
--	FOREIGN KEY(cat_id) REFERENCES Category(cat_id),

--);
select Category.cat_id,Product.pro_id
from Category
Inner Join Product On Category.cat_id=Product.pro_id

select cat_name from Category where cat_id in(select cat_id from Product where pro_id=1)