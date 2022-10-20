CREATE Database OKUL_VT
USE OKUL_VT

Create Table tb_Ogrenci
(
numara int,
ad varchar(50),
soyad varchar(50),
dogumYili smallint,
sinif varchar(5)
)
ALTER TABLE tb_Ogrenci Alter COLUMN numara nvarchar(50) NOT NULL--Veri tipini de�i�tirdik
ALTER TABLE tb_Ogrenci Alter COLUMN ad nvarchar(50) NOT NULL
ALTER TABLE tb_Ogrenci Alter COLUMN soyad nvarchar(50) NOT NULL
ALTER TABLE tb_Ogrenci Alter COLUMN dogumYili smallint NOT NULL
ALTER TABLE tb_Ogrenci Alter COLUMN sinif nvarchar(5) NOT NULL

ALTER TABLE tb_Ogrenci
ADD Constraint PK_Tb_Ogrenci
Primary Key Clustered(numara)--Primary Key yapar

ALTER TABLE tb_Ogrenci 
DROP Constraint PK_Tb_Ogrenci--Primary Keyi kald�r�r

ALTER TABLE tb_Ogrenci 
DROP COLUMN numara--Kolon silmek i�in kullan�l�r.

Alter Table tb_Ogrenci ADD numara int NOT NULL IDENTITY(1,1) PRIMARY KEY

begin transaction
INSERT INTO tb_Ogrenci
(ad,soyad,dogumYili,sinif)
Values('Kemal','�elik',1980,'D203')
Commit

select*from tb_Ogrenci
