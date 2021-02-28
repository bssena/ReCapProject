create table Colors(
ColorId int PRIMARY KEY IDENTITY(1,1),
ColorName nvarchar(25),
)

create table Brands(
BrandId int PRIMARY KEY IDENTITY(1,1),
BrandName nvarchar(25),
)

create table Cars(
Id int PRIMARY KEY IDENTITY(1,1),
BrandId int,
ColorId int,
ModelYear nvarchar(10),
DailyPrice decimal,
Descriptions nvarchar(25),
FOREIGN KEY(BrandId) References Brands(BrandId),
FOREIGN KEY(ColorId) References Colors(ColorId)
)

INSERT INTO Colors(ColorName)
values ('Siyah'),
('Beyaz'),
('Kırmızı'),
('Mavi');

INSERT INTO Brands(BrandName)
values ('Mercedes'),
('Audi'),
('BMW'),
('Renault');

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
values ('2','1','2018','500','Audi'),
('1','3','2016','400','Mercedes'),
('4','4','2014','300','Renault'),
('3','2','2019','600','BMW'),
('1','1','2015','300','Mercedes'),
('3','1','2018','500','BMW');

select * from Cars
select*from Brands
select*from Colors