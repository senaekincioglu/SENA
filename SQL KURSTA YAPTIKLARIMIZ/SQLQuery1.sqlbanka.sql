Create Table Musteriler(
ID int Primary Key identity(1,1) not null,
Ad nvarchar(50),
Soyad nvarchar(50),
Yas int,
HesapTurID int,
Durum nvarchar(10));

Create Table MusteriBilgi(
ID int Primary Key identity(1,1) not null,
MusteriID int,
Adres nvarchar(150),
Telefon nvarchar(11),
Email nvarchar(100),
Bakiye float);

Create Table Havale(
ID int Primary Key identity(1,1) not null,
AliciID int,
GondericiID int,
Tutar float,
Durum nvarchar(10));

Create Table Personel(
ID int Primary Key identity(1,1) not null,
Ad nvarchar(50),
Soyad nvarchar(50),
DepartmanID int,
SubeID int,
Yetki nvarchar(10),
Durum nvarchar(10));

Create Table HesapTuru(
ID int Primary Key identity(1,1) not null,
HesapAdi nvarchar(50),
Durum nvarchar(10));

Create Table Departmanlar(
ID int Primary Key identity(1,1) not null,
DepartmanAdi nvarchar(50),
Durum nvarchar(10));

Create Table Subeler(
ID int Primary Key identity(1,1) not null,
SubeAdi nvarchar(50),
Durum nvarchar(10));

Create Table Yetkiler(
ID int Primary Key identity(1,1) not null,
YetkiAdi nvarchar(50),
Durum nvarchar(10));