select * from [dbo].Customers;

--Customer ID'si BLAUS olan kaydýn ContactName'ine 'Alfred Schmidt' City'sine Frankfurt
begin transaction--Bu noktada geri dönmek için save aldý

update Customers
set ContactName='Alfred Schmidt',City='Frankfurt'
where CustomerID='BLAUS';

Rollback--GERÝ DÖNMEK ÝÇÝN KULLANILIR
Commit--Onaylamak için kullanýlýr.Geri dönüþ yapamazsýn
select * from [dbo].Customers where CustomerID='BLAUS';

begin transaction
update Customers
set ContactName='Juan'
where Country='Mexico';
Rollback
Commit
select * from [dbo].Customers where Country='Mexico';

--DELETE FROM Table_name where condition

begin transaction
delete from [Order Details] where OrderID in 
(select OrderID from Orders where CustomerID in 
(select CustomerID from Customers where ContactName = 'Juan'))
delete from Orders where OrderID in 
(select OrderID from Orders where CustomerID in 
(select CustomerID from Customers where ContactName = 'Juan'))
delete from Customers where ContactName = 'Juan';
commit
select * from [dbo].Customers where ContactName = 'Juan';
/*Group by cümlesi ayný deðerlere sahip kayýrlarý özet kayýtlara dönüþtürür.
Örnek:Herbir ülkedeki müþteri sayýlarýný veren sorgu.
Group by genellikle (Count(),Max(),Min(),Sum(),AVG())gibi fonksiyonlarda kullanýlýr ve birkaç kolona göre gruplar.*/

/*Select column_names
from Table_name 
where Condition 
GROUP by column_name(s)
ORDER By Column_name(s)*/

--Herbir ülkedeki müþteri sayýlarýný dökünüz
select Country,COUNT(*) as Müþteri_Sayýsý
from Customers
Group by Country
Order by 2 desc;

select Top 1 Country,COUNT(*) as Müþteri_Sayýsý--En çok müþteri bulunan ülke
from Customers
Group by Country
Order by 2 desc;

--Orders tablosundaki ShipCountry baþýna 50'den az sipariþ gelen ülkeleri sipariþ adedine göre büyüktem küçüðe yazan query
--HAVING=WHERE gibi ama gruplarý sayýyor
select ShipCountry,COUNT(*) as Siparis_Adedi
FROM Orders
GROUP BY ShipCountry
HAVING COUNT(*)<50--Gruplarýn içinde 50den küçük olanlarý 
Order by COUNT(*) desc;

--Bir tablodan diðer tabloya tüm kolonlarý kopyala:
/*INSERT INTO table2
select*from table1
where Condition*/
--Bir tablodan diðer tabloya bazý kolonlarý kopyala:
/*INSERT INTO table2(column1,column2,.....)
select column1,column2,..... from table1
where Condition*/

--Supplier tablosundan Customer tablosuna kayýt kopyalama;Data aktarýlamayan kolonlar NULL kalýr
begin transaction
INSERT INTO Customers(CustomerID,ContactName,CompanyName,City,Country)
select SupplierID,ContactName,CompanyName,City,Country from Suppliers;
commit

select*from Customers where ContactName='Charlotte Cooper'

create table Persons(
PersonID int IDENTITY(1,1) Primary Key,
FirstName varchar(255),
LastName varchar(255),
Age INT);

Create INDEX IX_FirstLastName--Selectde bunu kullanýrsak daha hýzlý arar.
on Persons(FirstName,LastName);

Create Unique INDEX UQ_Age--Unüque ýndex oluþturur.
on Persons(Age);

DROP INDEX Persons.Uq_Age;--Indexi kaldýrýr

SET Concat_Null_Yields_Null off--on yaparsan null yapar.*****
select C.CompanyName,
Address+','+PostalCode+','+City+','+Country as Adres
from Customers C;

select	GetDate()'GetDate',
FORMAT(GetDate(),'d','tr-TR') as Turkce,
FORMAT(GetDate(),'d','en-US') as Amerikan,
FORMAT(GetDate(),'d','en-GB') as Ýngiliz;

select c.CompanyName,o.OrderID,p.ProductName,cat.CategoryName,d.Quantity
from Orders o Inner Join Customers c
ON o.CustomerID=c.CustomerID
Inner Join [Order Details] d
ON D.OrderID=o.OrderID
Inner Join Products p
on p.ProductID=d.ProductID
Inner Join Categories cat
on cat.CategoryID=p.CategoryID;

/*exec sp_who2
KILL 55*/--Buga giren komutu kapatma

SELECT COUNT(*) FROM Orders
where CustomerID='VINET';

--NORTHWÝND veri tabanýnda(database) ProductWithCategory isminde view ile Products tablosundan ProductID,ProductName,SupplierID,
--UnitPrice,UnitsInStok ve Categories tablosundan CategoryName,Description kolonlarýný listeleyin.
/*Create View ProductWithCategory as
select ProductID,ProductName,SupplierID,UnitPrice,UnitsInStock,c.CategoryName,c.Description
from Products p
INNER JOIN Categories c
on p.CategoryID=c.CategoryID*/

--Drop View ProductWithCategory--View silindi

Create View ProductWithCategory as
select ProductID,ProductName,p.SupplierID,s.CompanyName AS Tedarikci,s.Phone,UnitPrice,UnitsInStock,c.CategoryName,c.Description
from Products p
INNER JOIN Categories c
on p.CategoryID=c.CategoryID
INNER JOIN Suppliers s
on s.SupplierID=P.SupplierID;--View klasörüne new view ekleyerekte yapýlabilir.

--Northwind DB'sinde Orders ve Employees tablolarýný birleþtirip OrderID,CustomerID,OrderDate,Employe(Ad-Soyad bitiþik)
--alanlarýný içere OrderEmployee viewiný yazýnýz.Sadece Ordate alaný 1998 olanlarý
Create View OrderEmployee as
select o.OrderID,o.CustomerID,o.OrderDate,e.FirstName+' '+e.LastName as Ýsim
from Orders o
INNER JOIN Employees e
on o.EmployeeID=e.EmployeeID
where o.OrderDate LIKE'%1998%';

select 'Müþteri'as Tip, City as Þehir, Country,CONCAT('Þirket Adý:',CompanyName) as [Þirket/Yetkili ad] from Customers;
Union
select 'Tedarikçi'as Tip, City as Þehir, Country,CONCAT('Yetkili Adý:',CompanyName) as [Þirket/Yetkili ad] from Customers;

--Hangi ülkelerden müþterim var?
select distinct Country from Customers;

--CTE(Common Table Expression)--Geçici tablo oluþturmamýzý saðlar.
With AzKalanUrunler_CTE AS(
select p.productName,p.UnitsInStock,p.CategoryID
from Products p
where p.UnitsInStock<50
)SELECT ProductName,UnitsInStock
from AzKalanUrunler_CTE;

With Sales_CTE(
SalesPersonID,SalesOrderID,SalesYear)
as
(
select  EmployeeID,OrderID,YEAR([OrderDate])
from Orders
where EmployeeID IS NOT NULL
)select *from Sales_CTE;

--Satýþ Temsilcisinin ortalama sipariþ adetleri
With Sales_CTE AS
(select EmployeeID,COUNT(*)As SalesCount
from Orders where EmployeeID IS NOT NULL
GROUP BY EmployeeID
)select EmployeeID,AVG(SalesCount)from Sales_CTE
group by EmployeeID;

--Satýþ temsilcisinin yýllara göre sipariþ adetleri:
WITH Sales_CTE(SalesPersonID,SalesYear,SalesOrderID)
As
(SELECT EmployeeID,Year(OrderDate)SalesYear,OrderID
from Orders
where EmployeeID IS NOT NULL
)Select SalesPersonID,SalesYear Yýl,Count(SalesOrderID) as CountOfOrders from Sales_CTE
Group by SalesPersonID,SalesYear
ORDER BY 1,2

--Hangi sipariþ toplam kaç para
select OrderID,SUM(UnitPrice*Quantity)as Toplam
from [Order Details]
Group by OrderID
Order by 2;

--Stored Procedure:SQL dilinde yazýlýmdaki metotlara karþýlýk gelen ifadedir.Kýsaltmasý SP'dir.--Methodlara benziyor
--Parametreli ve parametresiz olabilir.
--Aldýðý parametreleri sorgularda kullanabilir.Geriye deðer döndürebilir.(OUTPUT)
--Belirli iþleri yapan sorgulari SP'ler ile bir defa yazarak sürekli kullanýrýz.
--SP:
Create Procedure GetCategories
as
Begin 
select*from Categories;
End

--SP Çaðrýlmasý:
Execute NORTHWND.dbo.GetCategories;


Alter Procedure GetCategories
as
Begin 
select d.*from Categories d;
End

Create Procedure GetOrders
as
Begin 
select*from Orders;
End

EXEC GetOrders;--Execute NORTHWND.dbo.GetOrders

Create Proc SearchCategories(@name NVARCHAR(50))
AS
BEGIN
DECLARE @sayi int;
Select @sayi=COUNT(*)
from Categories where CategoryName=@name;
if(@sayi>0)
BEGIN
select*from Categories where CategoryName=@name;
SELECT STR(@sayi)+'adet kayýt bulundu' as [Bulunan Kayýtlar]
END
Else
BEGIN
PRINT 'Herhangi bir kayýt bulunmadý'
END
END

EXEC SearchCategories 'Seafood';

--Order Details tablosundan unit price ve quantity alt sýnýrýna göre  sorgu çekecek SP'yi yazýnýz.
--Örnek:GetOrderDetails 10,15
Create Proc GetOrderDetails(@up int,@q int)
AS
BEGIN 
select*from [Order Details]
where UnitPrice>=@up and Quantity>=@q
Order by UnitPrice
END

Exec GetOrderDetails 10,15;

--Categories tablosuna kayýt eklemsi yapan SP'yi yazýnýz.Parametreler:name desc pict
Create Proc SP_AddCategory
(
@name nvarchar(15),@desc ntext,@pict image
)
As
Begin
Insert Into Categories(CategoryName,Description,Picture)
values (@name,@desc,@pict)
End

Exec SP_AddCategory 'Sebzeler','Patates sogan','foto.png'
Exec SP_AddCategory 'Meyveler','Mandalina,portakal','foto2.png'
select*from Categories

--Categories tablosundan silme iþlemi yapan SP.ID'yi alýr,silmeden önce ve sonra tüm kayýtlarý gösterir.

Create Proc SP_RemoveCategory(@ID int)
as
Begin
Select*from Categories
delete from Categories 
where CategoryID=@ID
select*from Categories;
END

EXEC SP_RemoveCategory 9;

Create Proc SP_UpdateCategory(@ID int,@name nvarchar(15),@desc ntext,@pict image)
AS
BEGIN
UPDATE Categories
SET CategoryName=@name,Description=@desc,Picture=@pict
where CategoryID=@ID
select 'Etkilenen satýr sayýsý:'+STR(@@ROWCOUNT);--Satýr sayýsý
END

EXEC SP_UpdateCategory 10,'Turunçgiller','Portakal,mandalina','foto2.png';
select*from Categories;

Create Proc SP_GetCategoryCount(@count INT OUTPUT)--Output:Geriye deðer döndürmek için kullanýlýr.
AS
BEGIN
select @count=COUNT(*)from Categories;
END

DECLARE @sayi int;--Deðiþken tanýmlama
EXEC SP_GetCategoryCount @sayi output;
PRINT 'Category tablosundaki kayýt sayýsý:'+STR(@sayi)

Create Proc Topla(@sayi1 int,@sayi2 int,@sonuc int OUTPUT)
AS 
BEGIN
Set @sonuc=@sayi1+@sayi2
END

DECLARE @sonuc2 int;
EXEC Topla 30,45,@sonuc2 OUTPUT;
PRINT 'Sayýlarýn Toplamý:'+STR(@sonuc2);--STR:Sayýyý stringe çevirir.

--4 iþlem yapan SP
Create Proc HesapMakinesi(@sayi1 int,@sayi2 int,@islem int,@sonuc int OUTPUT)
AS 
BEGIN
if(@islem=1)
Set @sonuc=@sayi1+@sayi2
if(@islem=2)
Set @sonuc=@sayi1-@sayi2
if(@islem=3)
Set @sonuc=@sayi1*@sayi2
if(@islem=4)
Set @sonuc=@sayi1/@sayi2
END

DECLARE @sonuc3 int;
EXEC HesapMakinesi 30,45,2,@sonuc3 OUTPUT;
--EXEC HesapMakinesi 30,0,4,@sonuc3 OUTPUT;--Sýfýra bölme hatasý verir.
PRINT 'SONUÇ:'+STR(@sonuc3);

--TRIGGER:Çaðrýlmaksýzýn þartlar saðkandýðýnda otomatik çalýþan SQL sorgularý yazmamýzý saðlar.
--AFTER TRIGGER:Belirli bir sorgu çalýþýrsa arkasýndan çalýþsýn þeklinde tanýmladýðýmýz TRIGGER yapýsýdýr.
--ÖRNEK:Categories tablosuna her INSERT yapýldýðýnda sorgu otomatik çalýþsýn
--INSTEAD OF TRIGGER:Belirli bir tabloda çalýþan bir sorgu çaðrýldýðýnda o sorgu çalýþmasýn,bizim trigger çalýþsýn.

Create Trigger TR_BlockDeleteCategory--Trigger adý
ON Categories--Hangi tabloda çalýþcak
INSTEAD OF DELETE 
AS
BEGIN 
DECLARE @catadi NVARCHAR(50)
select @catadi=CategoryName from DELETED;--DELETED geçici tablosunu silen kayýtlarý getirir.
PRINT @catadi+' silinmeye çalýþýldý.'
END

DELETE from Categories where CategoryID=10;
select*from Categories
--CategoriesBackup isimli bir tablo oluþturun.Categories tablosundan veri silmeye çalýþýlan veriyi
--bu yeni tabloya insert edin.Daha sonra silinmeye çalýþan satýrý silin.
Create Table [dbo].[CategoriesBackup]
(
[CategoryID] [int] NOT NULL,
[CategoryName] [nvarchar](15) NOT NULL,
[Description] [ntext] NULL,
[Picture] [image] NULL
)

Create Trigger TR_Yedek
on Categories
INSTEAD OF DELETE--Sadece 1 tane bu komutla trigger oluþturulabilir.
AS
BEGIN
DECLARE @id int,@name nvarchar(15),@desc nvarchar(15),@img varbinary(max);
Select @id=CategoryID,@name=CategoryName,@desc=Description,@img=Picture from DELETED;--DELETED silinmiþ verileri tutan geçici tablo

INSERT INTO CategoriesBackup
(CategoryID,CategoryName,Description,Picture)
values(@id,@name,@desc,@img);
Delete from Categories where CategoryID=@id;
END
--2.YOL
ALTER TRIGGER TR_Yedek
on Categories
INSTEAD OF DELETE 
AS 
BEGIN
INSERT INTO CategoriesBackup
(CategoryID,CategoryName,Description,Picture)
select CategoryID,CategoryName,Description,Picture from DELETED
Declare @id int
Select @id=CategoryID from DELETED
Delete from Categories  where CategoryID=@id;
END

delete from Categories  where CategoryID=8;
SELECT*FROM Categories
select*from CategoriesBackup















































