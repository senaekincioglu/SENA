-- group by :
--gruplandırma işlemi için kullanılan anahtar kelimedir. asıl ortaya çıkış amacı avg,max,min,sum,
--count gibi aggregate fonksiyonlarla birlikte bağlı bulundukları kolonları da sorgu içerisine
--dahil etmektedir.

--ülkelere göre çalışan sayımız nedir?
select Country, COUNT (Country) as 'ToplamCalisan' from Employees group by Country

--Hangi katerogide kaç tane ürün var raporlayınız 
select CategoryID, COUNT(CategoryID) from Products group by CategoryID
--group by orderby dan önce kullanılır

--Çalışanlara göre almış oldukları sipariş sayılarını sıralayın
select EmployeeID, COUNT(OrderID) as 'A'from Orders group by EmployeeID order by A desc

--Ülkelere göre sipariş sayılarını sıralayınız ve en çok sipariş veren 3 ülkeyi listeleyiniz.
select top 3 ShipCountry, COUNT (OrderId)as'Sayi' from Orders group by ShipCountry order by Sayi desc

--Her bir kategoride ücret bazlı toplam ne kadarlık ürün vardır
select CategoryID ,sum(UnitPrice*UnitsInStock) as 'Toplam 'from Products 
group by CategoryID order by [Toplam ] asc

--Hangi personel kaç satışta yer almıştır
select EmployeeID, count (*) as 'Satış sayısı'  from Orders group by EmployeeID 
order by [Satış sayısı] desc

--ÖDEV Dİ--Hangi müşteri kaç kere alışveriş yapmıştır
select CustomerID,COUNT(*)as 'abc' from Orders group by CustomerID

--ÖDEVDİ--hangi tedarikçi hangi kategorideki üründen kaç dolarlık elinde vardır(mevcuttur)
select SupplierID, sum(UnitPrice*UnitsInStock)as 'toplam',count (*)as 'Urun' from Products group by
SupplierID order by SupplierID desc

--SUBQUERY YAPISI
--İÇ İÇE SELECT SORGULARIDIR İÇTEKİ SELECT SORGUSUNDAN GELEN CEVABIN DIŞTAKİ SELECT SORGUSUNA 
--DAHİL EDİLEREK BİR SONUÇ DAHİLİNDE RAPORLANMA İŞLEMİNE YARDIMCI OLUR
--having işleminin size cevap vermediği durumlarda kullanılır

--Ortalama ücretin üzerinde yer alan ürünleri gösterin (ort üstündekileri de bulmak için )
select ProductName,UnitPrice from Products where UnitPrice>(select avg (UnitPrice)from Products)

--NANCY in almış olduğu siparişlerin ıd lerini raporlayın
select OrderId,EmployeeID  from Orders where EmployeeID=(select EmployeeID from Employees 
where FirstName ='Nancy'

--Beverages kategorisine ait siparişleri listeleyin
select ProductID, ProductName from Products where CategoryID=(select CategoryID from Categories 
where CategoryName='Beverages'

--nancy andrew yada janet tarafından alınmış ve speedy express ile taşınmamış siparişleri listeleyin
SELECT OrderID,EmployeeID,ShipVia from Orders where EmployeeID in (select EmployeeID from Employees where FirstName in ('Nancy','Andrew','Janet')) and ShipVia!=(select ShipperID from 
Shippers where CompanyName!='Speedy express')order by EmployeeID


--ALT SORGULAR : BELLİ BİR SORGU İÇİNDE BAŞKA BİR SORGUYU ÇALIŞTIRMA 
--SELECT TARAFINDA VE WORD TARAFINDA İKİYE AYRILIR.

--ÜRÜNLER TABLOSUNDAKİ TEDARİKÇİ ID İLE TEDARİKÇİ TABLOSUNDAKİ TEDARİKÇİ ID Yİ EŞLEŞTİR VE TEDARİKÇİ TABLOSUNDAKİ ŞİRKET ADINI TEDARİKÇİ ID YE GÖRE ÇEK
SELECT *,(SELECT CompanyName FROM Suppliers  S WHERE P.Products.SupplierID=S.SupplierID) FROM Products P

--ÖDEV--ÜRÜNLERLE BİRLKİTE ÜRÜNÜN SATIŞ ADETİNİ LİSTELEYEN SORGU (TOPLAM İSTİYOR ORDERDETAİLS ÜRÜNLER ,Kİ TABLO BİRLEŞTİR)

--ÖDEV HANGİ SATIŞTA KAÇ ADET ÜRÜN SATILMIŞTIR BUNLARI CLASSROMA AT
