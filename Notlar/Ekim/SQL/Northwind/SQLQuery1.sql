select * from [dbo].Customers;

--Customer ID'si BLAUS olan kayd�n ContactName'ine 'Alfred Schmidt' City'sine Frankfurt
begin transaction--Bu noktada geri d�nmek i�in save ald�

update Customers
set ContactName='Alfred Schmidt',City='Frankfurt'
where CustomerID='BLAUS';

Rollback--GER� D�NMEK ���N KULLANILIR
Commit--Onaylamak i�in kullan�l�r.Geri d�n�� yapamazs�n
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
/*Group by c�mlesi ayn� de�erlere sahip kay�rlar� �zet kay�tlara d�n��t�r�r.
�rnek:Herbir �lkedeki m��teri say�lar�n� veren sorgu.
Group by genellikle (Count(),Max(),Min(),Sum(),AVG())gibi fonksiyonlarda kullan�l�r ve birka� kolona g�re gruplar.*/

/*Select column_names
from Table_name 
where Condition 
GROUP by column_name(s)
ORDER By Column_name(s)*/

--Herbir �lkedeki m��teri say�lar�n� d�k�n�z
select Country,COUNT(*) as M��teri_Say�s�
from Customers
Group by Country
Order by 2 desc;

select Top 1 Country,COUNT(*) as M��teri_Say�s�--En �ok m��teri bulunan �lke
from Customers
Group by Country
Order by 2 desc;

--Orders tablosundaki ShipCountry ba��na 50'den az sipari� gelen �lkeleri sipari� adedine g�re b�y�ktem k����e yazan query
--HAVING=WHERE gibi ama gruplar� say�yor
select ShipCountry,COUNT(*) as Siparis_Adedi
FROM Orders
GROUP BY ShipCountry
HAVING COUNT(*)<50--Gruplar�n i�inde 50den k���k olanlar� 
Order by COUNT(*) desc;

--Bir tablodan di�er tabloya t�m kolonlar� kopyala:
/*INSERT INTO table2
select*from table1
where Condition*/
--Bir tablodan di�er tabloya baz� kolonlar� kopyala:
/*INSERT INTO table2(column1,column2,.....)
select column1,column2,..... from table1
where Condition*/

--Supplier tablosundan Customer tablosuna kay�t kopyalama;Data aktar�lamayan kolonlar NULL kal�r
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

Create INDEX IX_FirstLastName--Selectde bunu kullan�rsak daha h�zl� arar.
on Persons(FirstName,LastName);

Create Unique INDEX UQ_Age--Un�que �ndex olu�turur.
on Persons(Age);

DROP INDEX Persons.Uq_Age;--Indexi kald�r�r

SET Concat_Null_Yields_Null off--on yaparsan null yapar.*****
select C.CompanyName,
Address+','+PostalCode+','+City+','+Country as Adres
from Customers C;

select	GetDate()'GetDate',
FORMAT(GetDate(),'d','tr-TR') as Turkce,
FORMAT(GetDate(),'d','en-US') as Amerikan,
FORMAT(GetDate(),'d','en-GB') as �ngiliz;

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

--NORTHW�ND veri taban�nda(database) ProductWithCategory isminde view ile Products tablosundan ProductID,ProductName,SupplierID,
--UnitPrice,UnitsInStok ve Categories tablosundan CategoryName,Description kolonlar�n� listeleyin.
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
on s.SupplierID=P.SupplierID;--View klas�r�ne new view ekleyerekte yap�labilir.

--Northwind DB'sinde Orders ve Employees tablolar�n� birle�tirip OrderID,CustomerID,OrderDate,Employe(Ad-Soyad biti�ik)
--alanlar�n� i�ere OrderEmployee viewin� yaz�n�z.Sadece Ordate alan� 1998 olanlar�
Create View OrderEmployee as
select o.OrderID,o.CustomerID,o.OrderDate,e.FirstName+' '+e.LastName as �sim
from Orders o
INNER JOIN Employees e
on o.EmployeeID=e.EmployeeID
where o.OrderDate LIKE'%1998%';

select 'M��teri'as Tip, City as �ehir, Country,CONCAT('�irket Ad�:',CompanyName) as [�irket/Yetkili ad] from Customers;
Union
select 'Tedarik�i'as Tip, City as �ehir, Country,CONCAT('Yetkili Ad�:',CompanyName) as [�irket/Yetkili ad] from Customers;

--Hangi �lkelerden m��terim var?
select distinct Country from Customers;

--CTE(Common Table Expression)--Ge�ici tablo olu�turmam�z� sa�lar.
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

--Sat�� Temsilcisinin ortalama sipari� adetleri
With Sales_CTE AS
(select EmployeeID,COUNT(*)As SalesCount
from Orders where EmployeeID IS NOT NULL
GROUP BY EmployeeID
)select EmployeeID,AVG(SalesCount)from Sales_CTE
group by EmployeeID;

--Sat�� temsilcisinin y�llara g�re sipari� adetleri:
WITH Sales_CTE(SalesPersonID,SalesYear,SalesOrderID)
As
(SELECT EmployeeID,Year(OrderDate)SalesYear,OrderID
from Orders
where EmployeeID IS NOT NULL
)Select SalesPersonID,SalesYear Y�l,Count(SalesOrderID) as CountOfOrders from Sales_CTE
Group by SalesPersonID,SalesYear
ORDER BY 1,2

--Hangi sipari� toplam ka� para
select OrderID,SUM(UnitPrice*Quantity)as Toplam
from [Order Details]
Group by OrderID
Order by 2;

--Stored Procedure:SQL dilinde yaz�l�mdaki metotlara kar��l�k gelen ifadedir.K�saltmas� SP'dir.--Methodlara benziyor
--Parametreli ve parametresiz olabilir.
--Ald��� parametreleri sorgularda kullanabilir.Geriye de�er d�nd�rebilir.(OUTPUT)
--Belirli i�leri yapan sorgulari SP'ler ile bir defa yazarak s�rekli kullan�r�z.
--SP:
Create Procedure GetCategories
as
Begin 
select*from Categories;
End

--SP �a�r�lmas�:
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
SELECT STR(@sayi)+'adet kay�t bulundu' as [Bulunan Kay�tlar]
END
Else
BEGIN
PRINT 'Herhangi bir kay�t bulunmad�'
END
END

EXEC SearchCategories 'Seafood';

--Order Details tablosundan unit price ve quantity alt s�n�r�na g�re  sorgu �ekecek SP'yi yaz�n�z.
--�rnek:GetOrderDetails 10,15
Create Proc GetOrderDetails(@up int,@q int)
AS
BEGIN 
select*from [Order Details]
where UnitPrice>=@up and Quantity>=@q
Order by UnitPrice
END

Exec GetOrderDetails 10,15;

--Categories tablosuna kay�t eklemsi yapan SP'yi yaz�n�z.Parametreler:name desc pict
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

--Categories tablosundan silme i�lemi yapan SP.ID'yi al�r,silmeden �nce ve sonra t�m kay�tlar� g�sterir.

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
select 'Etkilenen sat�r say�s�:'+STR(@@ROWCOUNT);--Sat�r say�s�
END

EXEC SP_UpdateCategory 10,'Turun�giller','Portakal,mandalina','foto2.png';
select*from Categories;

Create Proc SP_GetCategoryCount(@count INT OUTPUT)--Output:Geriye de�er d�nd�rmek i�in kullan�l�r.
AS
BEGIN
select @count=COUNT(*)from Categories;
END

DECLARE @sayi int;--De�i�ken tan�mlama
EXEC SP_GetCategoryCount @sayi output;
PRINT 'Category tablosundaki kay�t say�s�:'+STR(@sayi)

Create Proc Topla(@sayi1 int,@sayi2 int,@sonuc int OUTPUT)
AS 
BEGIN
Set @sonuc=@sayi1+@sayi2
END

DECLARE @sonuc2 int;
EXEC Topla 30,45,@sonuc2 OUTPUT;
PRINT 'Say�lar�n Toplam�:'+STR(@sonuc2);--STR:Say�y� stringe �evirir.

--4 i�lem yapan SP
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
--EXEC HesapMakinesi 30,0,4,@sonuc3 OUTPUT;--S�f�ra b�lme hatas� verir.
PRINT 'SONU�:'+STR(@sonuc3);

--TRIGGER:�a�r�lmaks�z�n �artlar sa�kand���nda otomatik �al��an SQL sorgular� yazmam�z� sa�lar.
--AFTER TRIGGER:Belirli bir sorgu �al���rsa arkas�ndan �al��s�n �eklinde tan�mlad���m�z TRIGGER yap�s�d�r.
--�RNEK:Categories tablosuna her INSERT yap�ld���nda sorgu otomatik �al��s�n
--INSTEAD OF TRIGGER:Belirli bir tabloda �al��an bir sorgu �a�r�ld���nda o sorgu �al��mas�n,bizim trigger �al��s�n.

Create Trigger TR_BlockDeleteCategory--Trigger ad�
ON Categories--Hangi tabloda �al��cak
INSTEAD OF DELETE 
AS
BEGIN 
DECLARE @catadi NVARCHAR(50)
select @catadi=CategoryName from DELETED;--DELETED ge�ici tablosunu silen kay�tlar� getirir.
PRINT @catadi+' silinmeye �al���ld�.'
END

DELETE from Categories where CategoryID=10;
select*from Categories
--CategoriesBackup isimli bir tablo olu�turun.Categories tablosundan veri silmeye �al���lan veriyi
--bu yeni tabloya insert edin.Daha sonra silinmeye �al��an sat�r� silin.
Create Table [dbo].[CategoriesBackup]
(
[CategoryID] [int] NOT NULL,
[CategoryName] [nvarchar](15) NOT NULL,
[Description] [ntext] NULL,
[Picture] [image] NULL
)

Create Trigger TR_Yedek
on Categories
INSTEAD OF DELETE--Sadece 1 tane bu komutla trigger olu�turulabilir.
AS
BEGIN
DECLARE @id int,@name nvarchar(15),@desc nvarchar(15),@img varbinary(max);
Select @id=CategoryID,@name=CategoryName,@desc=Description,@img=Picture from DELETED;--DELETED silinmi� verileri tutan ge�ici tablo

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















































