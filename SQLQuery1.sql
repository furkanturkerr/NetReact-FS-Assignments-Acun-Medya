-- Yeni bir db oluþtue

Create Database CarRentalDB;

-- kullanýlacak db'ye geçiþ yap

use CarRentalDB;

Create Table Brands(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name Varchar(50) Not Null
);

Create Table Models(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name Varchar(50) Not Null,
	BrandId INT FOREIGN KEY REFERENCES Brands(Id)
);

Create Table Transmissions (
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(50) NOT NULL
);

Create Table Fuels (
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(50) NOT NULL
);

Create Table Colors (
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(50) NOT NULL
);


Create Table ModelTransmissions (
Id INT PRIMARY KEY IDENTITY(1,1),
ModelId INT FOREIGN KEY REFERENCES Models(Id),
TransmissionId INT FOREIGN KEY REFERENCES Transmissions(Id),
);

Create Table ModelFuels (
Id INT PRIMARY KEY IDENTITY(1,1),
ModelId INT FOREIGN KEY REFERENCES Models(Id),
FuelId INT FOREIGN KEY REFERENCES Fuels(Id),
);


Create Table Cars (
Id INT PRIMARY KEY IDENTITY(1,1),
Plate VARCHAR(50) NOT NULL,
Kilometer INT NOT NULL,
ModelYear INT Not NULL,
ColorId INT FOREIGN KEY REFERENCES Colors(Id),
ModelId INT FOREIGN KEY REFERENCES Models(Id),
);

-- Brands Tablosu

Insert Into Brands (Name) Values ('Toyota'),('Honda'),('BMW'),('Mercedes'),
('Ford'),('Audi'),('Hyundai'),('Nissan'),('Peugeot'),('Volswagen')

INSERT INTO Models (Name, BrandId) VALUES
('Corolla', 1), ('Civic', 2), ('320i', 3), ('C200', 4), ('Focus', 5),
('A4', 6), ('i30', 7), ('Qashqai', 8), ('208', 9), ('Golf', 10);


INSERT INTO Transmissions (Name) VALUES ('Manual'), ('Automatic'), ('CVT'), ('Semi-Automatic'),
('Dual-Clutch'), ('Tiptronic'), ('Electric'), ('Hybrid'), ('7-Speed'), ('8-Speed');

INSERT INTO Fuels (Name) VALUES ('Gasoline'), ('Diesel'), ('Electric'), ('Hybrid'), ('LPG'),
('Hydrogen'), ('Ethanol'), ('CNG'), ('Bio-Diesel'), ('Methanol');

INSERT INTO Colors (Name) VALUES ('Red'), ('Blue'), ('Black'), ('White'), ('Grey'),
('Silver'), ('Green'), ('Yellow'), ('Orange'), ('Purple');


INSERT INTO ModelTransmissions (ModelId, TransmissionId) VALUES
(1,1), (2,2), (3,3), (4,4), (5,5), (6,6), (7,7), (8,8), (9,9), (10,10);

INSERT INTO ModelFuels (ModelId, FuelId) VALUES
(1,1), (2,2), (3,3), (4,4), (5,5), (6,6), (7,7), (8,8), (9,9), (10,10);

INSERT INTO Cars (Plate, Kilometer, ModelYear, ColorId, ModelId) VALUES
('34ABC123', 50000, 2020, 1, 1),
('06DEF456', 60000, 2019, 2, 2),
('35GHI789', 70000, 2021, 3, 3),
('16JKL012', 80000, 2018, 4, 4),
('07MNO345', 90000, 2022, 5, 5),
('44PQR678', 40000, 2023, 6, 6),
('22STU901', 55000, 2020, 7, 7),
('09VWX234', 30000, 2019, 8, 8),
('01YZA567', 20000, 2021, 9, 9),
('45BCD890', 10000, 2022, 10, 10);




--Select(Veri Çekme)

Select * from Cars;     -- Tüm Arabalarý Getir

Select Name From Brands;  -- Sadece marka isimlerini getir

Select * from Cars where ModelYear > 2020 -- 2020den sonraki üretilen arabalarý getirdi

Select * From Cars Order By Kilometer ASC; -- Kilometrsi Düþük arabalarý sýralar

Select * From Cars Order By Kilometer Desc; -- Kilometrsi yüksek arabalarý sýralar


-- Group BY
-- Ýstatisksel verilere elde etmek için 

-- Cound,SLM,AVG,MIN,MAX gibifonksiyonlar kullkanýr

Select ModelYear, Count(*) as "Araba sayýsý" From Cars Group BY ModelYear; --Model ýlýna göre araba sayýsýný getir

-- DISTINCT - Benzersiz deðerleri getirme
Select Distinct ModelYear From Cars;


Select Count(*) From Cars; -- Toplam Araba sayýsý
Select SUM(Kilometer) From Cars; -- Arabalarýn toplma klometresi
Select AVG(Kilometer) fROM Cars; -- Arabalarýn ortalama klometresi


-- JOIN - iliþkili tablolardaki verileri birleþtirmek için kullanýlýr
-- INNER JOÝN => iKÝ TABLODAKÝ Eþleþen verileri döndürür
-- Left Join,Right JOin,Full JOIN => Ödev

Select c.Plate,m.Name,b.Name From dbo.Cars as c
Inner join Models as m ON c.ModelId=m.Id
Inner join Brands as b On m.BrandId=b.Id;


-- Arabalarý markasý,modeli,rengi ve yakýt türü ile birlikte listele

Select c.Plate,b.Name,m.Name,cl.Name,f.Name from Cars as c
Inner join Models as m on c.ModelId = m.Id
Inner join Brands as b on m.BrandId=b.Id
Inner join Colors as cl on c.ColorId=cl.Id
Inner join ModelFuels as mf on m.Id=mf.ModelId
Inner join Fuels as f on mf.FuelId=f.Id


--Model bazýnda en yüksek kilometreye sahip arabalarý bul

Select m.Name, Max(c.Kilometer) as MaxKilometer from Cars as c
Inner join Models as m on c.ModelId = m.Id
Group By m.Name

--Subquery

Select * from Cars Where ModelYear = (Select Max(ModelYear) From Cars); -- en yeni arabalrý getir



--HAVING group by ile oluþurulan gruplar üzerinde filtreleme yapar

--where yalnýzca satýrlara uygulanýrken, Having gruplara uygulanýr

--En az 1 modeli olan markalarý getir
 Select b.Name,Count(m.Id) as "Model Sayýsý" From Brands  as b
 Inner Join Models as m On b.Id=m.BrandId
 Group By b.Name
 HAving Count(m.Id)>=1;


  -- Farklý vites türlerini destekleyen modelleri ve kaç farklý vites tipi desteklediklerini göster
 -- en az 1 farklý vites türü olanlarý getir

 Select m.Name,count(Distinct mt.TransmissionId) as VitesSayýsý  from Models as m
 Inner Join ModelTransmissions as mt On m.Id = mt.ModelId
 Group By m.Name
 Having count(Distinct mt.TransmissionId)>=1

 --Model Yýlý 2018 ve sonrasý olan modellerde, en az 1 araba bulunanlarý getir

 Select m.Name,Count(c.Id) as ArabaSayýsý from Cars as c 
 Inner join Models as m On c.ModelId=m.Id
 Where c.ModelYear>=2018
 Group By m.Name
 Having Count(c.Id)>=1;