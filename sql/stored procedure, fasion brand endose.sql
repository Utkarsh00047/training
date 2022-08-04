
CREATE TABLE brand_info(
  id bigint PRIMARY KEY,
  "name" varchar(50)
);

insert into brand_info(id,"name") values(1,'brand1'),
(2,'brand2'),
(3,'brand3'),
(4,'brand4'),
(5,'brand5'),
(6,'brand6'),
(7,'brand7'),
(8,'brand8'),
(9,'brand9'),
(10,'brand10'),
(11,'brand11')




CREATE TABLE celeb_name(
  id bigint PRIMARY KEY,
  fullname varchar(50)
);

insert into celeb_name(id,fullname) values (1,'celeb1'),
(2,'celeb1'),
(3,'celeb1'),
(4,'celeb1'),
(5,'celeb1'),
(6,'celeb1'),
(7,'celeb1'),
(8,'celeb1'),
(9,'celeb1'),
(10,'celeb1'),
(11,'celeb11')


CREATE TABLE endorsement(
  id bigint PRIMARY KEY,
  celeb_id bigint,
  brand_id bigint,
  FOREIGN KEY (celeb_id) REFERENCES celeb_name(id),
  FOREIGN KEY (brand_id) REFERENCES	brand_info(id),
);

insert into endorsement(id,celeb_id,brand_id) values (1,1,1),
(2,1,1),
(3,2,2),
(4,2,2),
(5,3,3),
(6,3,3),
(7,1,1),
(8,1,1),
(9,1,1)
select * from endorsement

--brands which are not endorsed by celeb
CREATE PROCEDURE not_endorsed
AS begin
SELECT brand_info.id, brand_info.name
FROM brand_info
LEFT JOIN endorsement
ON brand_info.id = endorsement.brand_id where endorsement.brand_id is NULL
end

exec not_endorsed;


select brand_id from endorsement as e group by brand_id having COUNT(brand_id)>=2

--common brands endorsed by celebrity
CREATE PROCEDURE common_endorsed
AS begin
select b.id, b.name, COUNT(e.brand_id) As 'Total Count' from brand_info as b inner join endorsement as e on b.id = e.brand_id group by b.id,b.name having COUNT(b.id)>=2
end
exec common_endorsed;

--brands not endorced by celebrity
CREATE PROCEDURE not_endorsed_by_celeb
AS begin
select c.id,c.fullname from celeb_name as c left join endorsement as e on c.id = e.celeb_id where e.celeb_id is NULL
end
exec not_endorsed_by_celeb