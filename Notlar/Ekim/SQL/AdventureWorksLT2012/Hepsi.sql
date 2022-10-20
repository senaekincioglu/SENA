select name from SalesLT.Product

select  Firstname from SalesLT.Customer

select distinct Firstname from SalesLT.Customer--D�ST�NCT HER B�R�NDEN B�RER TANE YAZAR.TEKRARI ENGELLER

select count(*)from SalesLT.Customer;--COUNT L�STE BOYUTUNU G�STER�R

select * from SalesLT.Customer where FirstName='Henry';--�smi henry olanlar� bulur

select distinct FirstName from SalesLT.Customer where FirstName='Henry';

select*from SalesLT.Customer order by FirstName--Normal s�ralama

select*from SalesLT.Customer order by FirstName desc--tersten s�ralama

select*from SalesLT.Customer order by 6--6.s�t�na g�re s�ralar

--UNION ve UNION ALL---Birle�tirme

select SalesOrderID from SalesLT.SalesOrderHeader UNION select SalesOrderID from SalesLT.SalesOrderDetail--Tekrars�z birle�tirir

select SalesOrderID from SalesLT.SalesOrderHeader UNION ALL select SalesOrderID from SalesLT.SalesOrderDetail order by 1--Tekrarlar�da birle�tirir

select ProductID from SalesLT.Product UNION select ProductID from SalesLT.SalesOrderDetail

select*from SalesLT.Product where Name in('Road-650 Red, 60','Road-650 Red, 62','Road-650 Red, 44')

select *from SalesLT.Product where Color='Red' or Color='White'

select*from SalesLT.Product where ProductCategoryID in (6,27)

select*from SalesLT.Product WHERE Name='Road-450 Red, 44' AND ProductID=756 AND Color='Red';

select*from SalesLT.Product WHERE Name='Road-450 Red, 44' AND(ProductID=756 OR Color='Brown');

select distinct Color from SalesLT.Product

select*from SalesLT.Product where ProductID=756 or 1=1--1=1 HER�EY� GET�R�R.

--KAR�ILA�TIRMA OPERAT�RLER�

select*from SalesLT.Product WHERE ProductID<710

select ProductID from SalesLT.Product order by 1

select min(ProductID) from SalesLT.Product--minimim de�er
select max(ProductID) from SalesLT.Product--maksimum de�er

select LEN(name),name from SalesLT.Product order by 1--metnin uzunlu�una g�re s�ralama

select ProductID,Color,Weight from SalesLT.Product Order by 2,1--Yaz�m s�ras�na g�re s�ralar �nce color sonra product �d

select ProductID,Color,Weight from SalesLT.Product Order by 2,1 desc

select*from SalesLT.Product where ProductID>700

select*from SalesLT.Product where ProductID=706

select*from SalesLT.Product where ProductID!=706

--LIKE ile sorgu olu�taribilmek i�in Joker karakter kullan�lmal�d�r.
--%=Bir veya birden fazla harfin yerine ge�er
--_ Bir tek harf ya da rakam
-- [Harf]Herhangi bir harf ya da rakam.
--[^^Harf]Herhangi bir harf yerine gelmeyecek harfler
--[A-Z] A ile Z aras�ndaki harfleri belirtir
select*from SalesLT.Product where Name LIKE '%ad%'--i�inde ad olanlar
select*from SalesLT.Product where Name LIKE '_o%'--2.harfi o olanlar
select*from SalesLT.Product where Name LIKE 'C%'--Ba� harfi C olanlar
select*from SalesLT.Product where Name LIKE '_____'--5 HARFL� OLANLAR
select*from SalesLT.Product where Name LIKE '[AC]%'--Ba� harfi A veya C olanlar
select*from SalesLT.Product where Name LIKE '%8'--Sonu 8 ile bitenler
select*from SalesLT.Product where Name LIKE '[A-D]%'--Ba� harfi A ve D aras�nda olanlar A-B-C-D
select*from SalesLT.Product where Name LIKE '%[%]%'--��inde % ge�enler

--Between and
select*from SalesLT.Product where ProductID between 700 and 710

select*from SalesLT.Product where ProductModelID between 18 and 33

select*from SalesLT.Product where size IS null --bo� olanlar

select ISNULL(Size,2),Size from SalesLT.Product where Size='0'

select Firstname+' '+Middlename+' '+Lastname from SalesLT.Customer--Tek sutunda yazma

select ISNULL(Firstname,'')+' '+ISNULL(Middlename,'')+' '+ISNULL(Lastname,'') from SalesLT.Customer--NULL olanlar i�in bo�luk b�rak�r

select Firstname+' '+Middlename+' '+Lastname as AdSoyad from SalesLT.Customer--as kolon ad� verir.

select distinct FirstName,MiddleName,LastName,
upper(ISNULL(Firstname,'')+' '+ISNULL(Middlename,'')+' '+ISNULL(Lastname,''))
as AdSoyad from SalesLT.Customer WHERE FirstName='Henry' order by FirstName,LastName--*****upper b�y�k harfe �evirir.*********

select * from SalesLT.Customer WHERE FirstName='Henry'

select c.CustomerID from SalesLT.Customer c --K�saltma yapt�k SALESTLT.Customer=c oldu
UNION select SOH.CustomerID from SalesLT.SalesOrderHeader SOH

select p.ProductID from SalesLT.Product p UNION ALL select sod.ProductID from SalesLT.SalesOrderDetail sod

select distinct Grup.UrunKodu from
(select p.ProductID UrunKodu from SalesLT.Product p 
UNION ALL select sod.ProductID UrunKodu from SalesLT.SalesOrderDetail sod)Grup

select*from SalesLT.Product WHERE ProductNumber in('FR-R92R-58','SO-B909-L','SO-B909-L')
and Color in('Black','White')

select*from SalesLT.Product WHERE COLOR in('Black','White')

select * from SalesLT.Product where ProductCategoryID in('6','27')

select*from SalesLT.Product d where Name LIKE '%Road%'

select distinct p.Size FROM SalesLT.Product p 

select*from SalesLT.Product where Name='Sport-100 Helmet, Red' and ProductID=707 and Color='Red'

select MIN(ProductID) as MinimumDeger from SalesLT.Product where ProductID<700

select MAX(ProductID)  MaximumDeger from SalesLT.Product where ProductID<750

select LEN(Name) Uzunluk,Name from SalesLT.Product ORDER BY 1 DESC

select*from SalesLT.Product Order by Color desc ,ProductID desc

select*from SalesLT.Product WHERE ProductModelID BETWEEN 18 and 33

select*from SalesLT.Customer where MiddleName IS NULL

select*from SalesLT.Customer where MiddleName IS NOT NULL

SELECT ISNULL(Size,2)Size1,Size Size2 from SalesLT.Product

SELECT TOP 5 PERCENT*FROM SalesLT.Customer

--INNER JOIN tablolar� birle�tirir.
select sod.ProductID,P.Name,sod.* 
from SalesLT.Product P INNER JOIN SalesLT.SalesOrderDetail sod 
on sod.ProductID=P.ProductID

--Left Join:Soldaki tablodan t�m kay�tlar�,sa�daki tablodan e�le�en kay�tlar� getirir
select sod.ProductID,P.ProductID,P.Name,sod.*
from SalesLT.Product P LEFT JOIN SalesLT.SalesOrderDetail sod 
on sod.ProductID=P.ProductID
order by 2

select count(*) from  SalesLT.Product

--Right Join:Sa�daki tablodan t�m kay�tlar�,soldaki tablodan e�le�en kay�tlar� getirir
select sod.ProductID,P.ProductID,P.Name,sod.*
from SalesLT.Product P RIGHT JOIN SalesLT.SalesOrderDetail sod 
on sod.ProductID=P.ProductID

select* from SalesLT.Product where Name between 'A'and 'C'--C dahil de�il 

select* from SalesLT.Product where Name between 'A'and 'CZ'--C dahil

select* from SalesLT.Product WHERE Weight <=900 order by Weight

select Color,ISNULL(Color,'Brown')from SalesLT.Product order by Weight--�snull null lara de�er atar.

select Name,Color,ProductNumber,Name+Color+ProductNumber as Birlesim from SalesLT.Product
SET Concat_NULL_YIELDS_NULL OFF--NULLARI YOK SAYAR

UPDATE SalesLT.Product 
Set Size='12'
where ISNULL(Size,0.1)='0.1'

UPDATE SalesLT.Product 
Set Size='12'
where Size IS NULL

UPDATE SalesLT.Product 
Set Size=NULL
where Size='12'

SELECT TOP 5 Size 
from SalesLT.Product 
ORDER BY Size Desc

--Klasik Join Inner Joinle ayn�
select sod.ProductID,P.Name,sod.*
from SalesLT.Product P,SalesLT.SalesOrderDetail sod 
where sod.ProductID=P.ProductID
--INNER Join
select sod.ProductID,P.Name,sod.*
from SalesLT.Product P INNER JOIN
SalesLT.SalesOrderDetail sod 
ON sod.ProductID=P.ProductID
--LEFT JOIN
select sod.ProductID,P.Name,sod.*
from SalesLT.Product P LEFT JOIN
SalesLT.SalesOrderDetail sod 
ON sod.ProductID=P.ProductID
--RIHGT JOIN
select sod.ProductID,P.Name,sod.*
from SalesLT.Product P RIGHT JOIN
SalesLT.SalesOrderDetail sod 
ON sod.ProductID=P.ProductID

--FULL OUTER JOIN:Hem right join,hem left join hepsini getirir.
select sod.ProductID,P.Name,sod.*
from SalesLT.Product P FULL OUTER JOIN
SalesLT.SalesOrderDetail sod 
ON sod.ProductID=P.ProductID

CREATE TABLE Kullanicilar--Yeni table kodla olu�turma
(
KullaniciID INT NOT NULL,
Ad varchar(50),
Soyad varchar(50),
KullanciAd varchar(20)
)

ALTER TABLE Kullanicilar--Tabloda de�i�iklik yapmak i�in kullan�l�r. 
ADD Constraint  PKC_KullaniciID
Primary Key(KullaniciID)--Kullan�c�ID yi primary key yapan kod sat�r�

ALTER TABLE Kullanicilar
ADD KayitTarihi SmallDateTime

ALTER TABLE Kullanicilar
ADD DEFAULT (GetDate())
for KayitTarihi

ALTER TABLE Kullanicilar
ADD Sehir varchar(20)--Sehir ekleme

ALTER TABLE Kullanicilar
ADD DEFAULT('Istanbul')
for Sehir--Hi�bir�ey girilmezse yaz�ca�� de�eri belirleme

select MIN(ORDERDATE)
from SalesLT.SalesOrderHeader--En k���k (eski) tarih

select*from SalesLT.SalesOrderHeader 
WHERE OrderDate='2004-06-01 00:00:00.000'--En eski tarihteki kay�tlar

select*from SalesLT.SalesOrderHeader h 
INNER JOIN SalesLT.SalesOrderDetail d
on h.SalesOrderID=d.SalesOrderID
WHERE OrderDate=(select MIN(OrderDate)OrderDate
from SalesLT.SalesOrderHeader)
--De�i�ik bir �rnek
-- INNER JOIN
select OrderDate, ShipDate, h.CustomerID,
c.FirstName, c.LastName,d.ProductID,
p.ProductID,p.Name UrunAd�, ct.Name KategoriAd�
from salesLT.SalesOrderHeader h
INNER JOIN salesLT.SalesOrderDetail d
ON h.SalesOrderID =d.SalesOrderID
INNER JOIN salesLT.Customer c
ON c.CustomerID = h.CustomerID
INNER JOIN salesLT.Product p
ON d.ProductID = p.ProductID
INNER JOIN salesLT.ProductCategory ct
ON ct.ProductCategoryID=p.ProductCategoryID
WHERE OrderDate IN
(SELECT ORDERDATE OrderDate
FROM salesLT.SalesOrderHeader)

--Klasik Sorgu
select OrderDate, ShipDate, h.CustomerID,
c.FirstName, c.LastName,d.ProductID,
p.ProductID,p.Name UrunAd�, ct.Name KategoriAd�
from salesLT.SalesOrderHeader h,
salesLT.SalesOrderDetail d,
salesLT.Customer c,
salesLT.Product p,
salesLT.ProductCategory ct
WHERE h.SalesOrderID =d.SalesOrderID AND 
c.CustomerID = h.CustomerID AND
d.ProductID = p.ProductID AND
ct.ProductCategoryID=p.ProductCategoryID
AND OrderDate IN
(SELECT ORDERDATE OrderDate
FROM salesLT.SalesOrderHeader)
--Productta ve sodta ortak olanlar
select*from SalesLT.Product p
where EXISTS
(SELECT sod.ProductID from SalesLT.SalesOrderDetail sod where sod.ProductID =p.ProductID)

--Productta olup sodta olmayanlar
select*from SalesLT.Product p
where NOT EXISTS
(select sod.ProductID from SalesLT.SalesOrderDetail sod where sod.ProductID=P.ProductID)

select ROW_NUMBER()OVER (ORDER BY ProductID) as Sat�r_No,*from SalesLT.Product p--ROW_NUMBER()OVER (ORDER BY ProductID)=sat�r no verir.
where NOT EXISTS
(select sod.ProductID from SalesLT.SalesOrderDetail sod where sod.ProductID=P.ProductID)

--select * INTO yeni_product from SalesLT.Product--Yeni tablo olu�turup kay�tlar� i�ine koydu

select * INTO #yeni_product2 from SalesLt.Product--Ge�ici tablo olu�turdu.

select*from #yeni_product2

SELECT min(OrderDate)
FROM SalesLT.SalesOrderHeader

select distinct soh.OrderDate as SiparisTarihi,
sod.ProductID as UrunNo,OrderDate 
from SalesLT.SalesOrderHeader soh
INNER JOIN SalesLT.SalesOrderDetail sod
on soh.SalesOrderID=sod.SalesOrderID
--where OrderDate='2004-06-01 00:00:00.000'
where OrderDate in (select OrderDate from SalesLT.SalesOrderHeader)

select soh1.CustomerID,soh1.SalesOrderID,soh1.OrderDate
from SalesLT.SalesOrderHeader soh1
where soh1.OrderDate=(select min(soh2.OrderDate)
from SalesLT.SalesOrderHeader soh2
where soh1.CustomerID=soh2.CustomerID)

select distinct SOH.OrderDate as [SiparisTarihi],SOD.ProductID as [UrunKodu],
Round(SOD.UnitPrice,2) AS Fiyat--Fiyat� noktadan sonra 2 hane olarak belirledik
from SalesLT.SalesOrderHeader SOH
INNER JOIN SalesLT.SalesOrderDetail SOD 
on SOH.SalesOrderID=SOD.SalesOrderID
where OrderDate='2004-06-01'

select count(*) as Kac_musteri from SalesLT.Customer--Ka� m��teri var
--Stoktaki �r�nlerin toplam tutar�
Select Sum(ListPrice) from SalesLT.Product
--Ortalama birim fiyat
select Sum(ListPrice)/COUNT(*) from SalesLT.Product

Select AVG(ListPrice) from SalesLT.Product
--En d���k birim fiyat
Select MIN(ListPrice) from SalesLT.Product
--En y�ksek brim fiyat
Select MAX(ListPrice) from SalesLT.Product
--En y�ksek brim fiyatl� �r�n�n ad� ve fiyati
select Name,ListPrice from SalesLT.Product 
where ListPrice=(select MAX(ListPrice) from SalesLT.Product)
--M��terileri CustomerID'ye g�re s�ral� yaz�n�z.
select*from SalesLT.Customer Order by CustomerID
--Hangi sat�� temsilcisinin ka� m��terisi var
select SalesPerson,COUNT(SalesPerson)AS M��teri_say�s�
from SalesLT.Customer
GROUP BY SalesPerson
ORDER BY 2 desc
--En az m��teriye sahip sat�c� ad� ve m��teri say�s�
Select top 1 SalesPerson,COUNT(SalesPerson) AS M��teri_say�s� 
from SalesLT.Customer
GROUP BY SalesPerson
ORDER BY 2 
--80'den fazla m��terisi olan sat�� temsilciler ve m��teri say�lar�
select SalesPerson,COUNT(SalesPerson)AS M��teri_say�s�
from SalesLT.Customer
GROUP BY SalesPerson
HAVING COUNT(SalesPerson)>80
ORDER BY 2 desc
--Her katogerideki �r�nlerin toplmam mal de�eri
select c.Name,Sum(p.ListPrice)as Liste_Fiyati
from SalesLT.Product p
INNER JOIN SalesLT.ProductCategory c
on c.ProductCategoryID=p.ProductCategoryID
GROUP BY c.Name 
Order by 2 desc
--Her bir s�t�nda ka�ar adet sipari� verilmi�
select sod.ProductID,p.Name,SUM(sod.OrderQty)as Siparis_Adedi
from SalesLT.Product p
INNER JOIN SalesLT.SalesOrderDetail sod
ON p.ProductID=sod.ProductID
Group by sod.ProductID,p.Name
Order by 3 desc
--Yukar�daki sorguya ek olarak 1998 5.ay ve sonras�ndaki sipari�leri filtrelesin
select sod.ProductID,p.Name,SUM(sod.OrderQty)as Siparis_Adedi
from SalesLT.Product p
INNER JOIN SalesLT.SalesOrderDetail sod
ON p.ProductID=sod.ProductID
INNER JOIN SalesLT.SalesOrderHeader soh
on soh.SalesOrderID=sod.SalesOrderID
WHERE soh.OrderDate>='1998-05-01 00:00:00.000'
Group by sod.ProductID,p.Name
Order by 3 desc
--CategoryID'si NULL olan kay�t say�s�n� getir
select Count(*)from SalesLT.Product p
where p.ProductCategoryID IS NULL






