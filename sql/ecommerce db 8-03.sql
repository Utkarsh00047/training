
CREATE TABLE user_info(
  id bigint PRIMARY KEY,
  email varchar(50),
  username varchar(50),
  "password" varchar(50),
  first_name varchar(50),
  last_name varchar(50)
);

CREATE TABLE user_address (
  id bigint PRIMARY KEY,
  address_line1 varchar(50),
  postal_code varchar(50),
  city varchar(50),
  country varchar(50),
  phone varchar(50),
  user_id bigint,
  FOREIGN KEY (user_id) REFERENCES user_info(id),
);


CREATE TABLE product (
  id bigint PRIMARY KEY,
  p_title varchar(50),
  sku varchar(50),
  price decimal,
  quantity bigint,
);

CREATE TABLE "order" (
  id bigint PRIMARY KEY,
  Payment_status varchar(50),
  total_discount decimal,
  total_amount decimal,
  created_date timestamp,
  user_address_id bigint,
  FOREIGN KEY ("user_address_id") REFERENCES "user_address" ("id")
);

insert into user_info(id,email,username,password,first_name,last_name) values(1,'user@user.com','username','1234567','user1','last name1'),
		(2,'user@user.com2','username2','1234567','user2','last name2'),
		(3,'user@user.com3','username3','1234567','user3','last name3'),
		(4,'user@user.com4','username4','1234567','user4','last name4'),
		(5,'user@user.com5','username5','1234567','user5','last name5'),
		(6,'user@user.com6','username6','1234567','user6','last name6')
		select * from user_info


insert into user_address(id,address_line1,postal_code,city,country,phone,user_id) values(1,'address1','208003','city1','country','123435456',1),
(2,'address2','208002','city2','country','123435456',2),
(3,'address3','208003','city3','country','123435456',3),
(4,'address4','208004','city4','country','123435456',4),
(5,'address5','208005','city5','country','123435456',5),
(6,'address6','208006','city6','country','123435456',6)

select * from user_address



insert into product(id,p_title,sku,price,quantity) values (1,'product1','123456789',111,10),
(2,'product2','123456789',112,10),
(3,'product3','123456789',113,10),
(4,'product4','123456789',114,10),
(5,'product5','123456789',115,10),
(6,'product6','123456789',116,10)
select * from product

insert into "order"(id,Payment_status,total_amount,total_discount,created_date,user_address_id) values(1,'done',1111,50,NULL,1),
(2,'done',1211,52,NULL,1),
(3,'done',1311,53,NULL,1),
(4,'done',1411,54,NULL,1),
(5,'done',1511,55,NULL,1),
(6,'done',1611,56,NULL,1)

select * from "order"

SELECT price
FROM product
WHERE price>100
GROUP BY price
ORDER BY price;

SELECT price
FROM product
WHERE price>100
GROUP BY price
HAVING price>114
ORDER BY price;


select COUNT(id) from product where price<116
select Sum(price) from product where price<116
select avg(price) from product where price<116
select min(price) from product where price<116
select max(price) from product where price<116



