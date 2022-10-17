--as SQL AS Operatörü (Takma İsim Verme) demek.
--drop = tablo veya veri tabanı oluşturunca hepsini siler. ama genelde kullanılmaz. Drop database Abc. yorum satırı -- 
--tablodaki bütün verileri gösterir execute ye basınca
select * from Employees
--Çalışanların ad ve soyadlarıyla birlikte yaşlarını raporlayınız.
select e.FirstName,e.LastName,DATEDIFF(YEAR,BirthDate,GETDATE()) as 'Yaş' from Employees e
-- employess e diye tanımlandı(kolaylık). * yerine istenilen yazılır
--DATEDIFF(YEAR,BirthDate.GETDATE())--doğum tarihi hesaplıyor

--Ürünlerimizin ıd leri adları miktarları fiyatları ve fiyatlarına %18 kdv eklenmiş halini yaz kolona kdv li fiyat ekle
select * from Products

select pr.SupplierID,pr.ProductName,pr.UnitsInStock,pr.UnitPrice,pr.UnitPrice*1.18 as 'KDV li fiyat' from Products pr

--KARGOLAR TABLOSUNDA YER ALAN ID AD TEL BİLGİLERİNİ RAPORLAYIN
SELECT * FROM Shippers
--TARİHSEL İFADELER
--Günün tarihini alma
--GETDATE Günün tarihini ve zaman bilgisini döndürür. Kullanımı: GETDATE() fonksiyonu herhangi bir argument almaz. 
--GETDATE yazmanız yeterli olucaktır.
select GETDATE()
--Bir tarihin günün ayını yılını alma
select day(GETDATE())--günü
select MONTH(GETDATE())--Ay
select YEAR(GETDATE())--YIL

--Verilen bir tarihe bir zaman dilimi ekleme
select DATEADD(YEAR,10,GETDATE())--10 YIL EKLEDİ
select DATEADD(MONTH,10,GETDATE())--10AY EKLENDİ

--İki tarih arasındaki farkı alma
--DATEDIFF Belirtilen iki tarih arasındaki zaman aralıklarının sayısını belirten bir Variant (Long) döndürür.
select DATEDIFF (YEAR,'05.05.1998',GETDATE())--yaş

--ÖZEL TARİHSEL FONKSİYONLAR--
Select DATENAME (MONTH, GETDATE())--Ayı verir
Select DATENAME (DAYOFYEAR, GETDATE())--KAÇINCI GÜN
Select DATENAME (WEEK, GETDATE())--KAÇINCI HAFTA

--Where SQL de Where nedir?sql where nedir ile ilgili görsel sonucu SQL Where komutu belirtilen koşula göre verileri filtrelemek için 
--kullanılır. Where cümleciği koşul ( şart) belirtmek için kullanılan bir komuttur.

--ürün ücretleri 30 dan büyük olanları listele
select p.ProductName,p.UnitPrice from Products p 
where UnitPrice > 30 --30 dan büyük olanlar

--Londrada yaşayan personellerin adını soyadını birleştirerek ad soyad kolonu oluştur
select ep.LastName+''+ep.FirstName as 'adsoyad',ep.City  from Employees ep -- + ile birleştirilir
where City ='London'

--kategori ıd si 5 olmayan ürünlerin adlarını ve kategori ıd lerini gösterin ve ismini türkçeye çevirin
select  pr.ProductID,PR.CategoryID,pr.ProductName as 'ÜRÜN ADI'from Products pr 
Where CategoryID !='5'

--01.01.1993 tarihinden sonra işe girmiş personellerin adını soyadını ve işe giriş tarihini raporlayınız.
select * from Employees
select e.LastName,e.FirstName,e.HireDate from Employees e
where e.HireDate>'01.01.1993'

-- order
--mart ayında alınmış olan siparişlerin orderıd ve orderdate kolonlarındaki değerleri listeleyin

--SQL Server'da Datename fonksiyonu verilen tarihin istenen bölümünü almak için kullanılan bir fonksiyondur. İlk parametrede hangi 
--bilgiyi çekecek isek o değeri parametre olarak giriyoruz. Gireceğimiz ikinci parametre ise bilgisini almak istediğimiz tarih değeridir.
select * from Orders 
select o.OrderID, o.OrderDate from Orders o
where DATENAME(MONTH,OrderDate)='March'


--MANTIKSAL OPERATÖRLER

--Ürünler arasında stok miktarı 20 ile 50 olan ürünleri listeleyin
 
 select * from Products
 select pr.UnitsInStock from Products pr
 where UnitsInStock>=20 and UnitsInStock<=50 -- and kullanılır

 --yaşı 50 den büyük ingilterede oturmayan çalışanların adlarını ve yaşlarını 
 --raporlayın ancak isimler tablosu şu formatta olacak mesela sena ekincioğlu 
--ise s.ekincioğlu

select * from Employees 
select LEFT (e.FirstName,1)+'.'+ e.LastName as'AdSoyad',e.Country,DATEDIFF(YEAR,e.BirthDate,GETDATE()) as'Yas' from Employees e
where DATEDIFF(YEAR,BirthDate,GETDATE())>50 and Country!='UK'

--1997 dahil yılından sonra alınmış kargo ücreti (freight) 20 den büyük ve 
--fransaya gönderilmemiş siparişlerin sipariş tarihlerini teslim tarihlerini 
--ve kargo ücretlerini raporlayın 
select * from Orders
select o.Freight, OrderID,OrderDate,o.ShippedDate from Orders o
where Freight>'20'and ShipCountry!='France'and YEAR(OrderDate)>=1997

--henüz müşteriye ulaşılmamış siparişleri listeleyiniz
select * from Orders 
where ShippedDate is null--is null boş olanlar

--is not null boş olmayanlar

-- kimseye rapor vermeyen personelin adını soyadını ve unvanını yazın ancak
-- isim formatı f.mehmet şeklinde olacak

select * from Employees
select left(e.FirstName,1)+'.'+e.LastName as 'AdSoyad',e.Title from Employees e where ReportsTo is null

 
 --sadece 3,5,7,4,12,8 ıd no larını ifadelerini içermeyen ürünleri listele
 select * from [Order Details] 
 where ProductID not in (3,5,7,4,12,8)-- içermeyen not in demek


 --*********ORDER BY********-- 
 --Sıralama demek
 --buyukten küçüğe (Z-A) Desc
 --Kucukten buyuğe (A-Z)asc varsayılan


 select LastName , FirstName from Employees order by FirstName desc

 --Müşterilerin ıd lerini, şirket adlarını, ülkelerini listeleyiniz ancak şikret fransız şirketi olacak
 --ıd leri tersten sıralanacak

 select * from Customers 
 select cs.CustomerID,cs.CompanyName,cs.Country from Customers cs 
 where Country=' France' ORDER BY CustomerID desc -- where koşulu her zaman order by dan önce kullanılır. 

 --ürünlerimizin adlarını ücretlerini stok miktarlarını gösteriniz. stok miktarları 50 den büyük olacak ve 
 --ürün ücretine göre ucuzdan pahalıya sıralama gerçekleşecek(varsayılan - asc)

select * from Products
select pr.ProductName,pr.UnitPrice,pr.UnitsInStock from Products pr
where UnitsInStock>50 order by UnitPrice asc

--en ucuz 10 ürünü gösterin
select * from Products
select top 10 ProductName,UnitPrice from Products order by UnitPrice asc

--en fazla kargo ücreti ödenen siparişin ıd sini ve ödenme miktarını gösterin
select * from Orders
select top 1 OrderID,freight from Orders order by Freight desc

--satış detay tablosunda ürün ıd, ürün fiyatı ve miktarı gelsin ama ürün ıd ye göre sıralı gelsin
select * from [Order Details]
select od.ProductID,od.UnitPrice,od.Quantity from [Order Details] od order by ProductID asc

--arasında BETWEEN belli değerler arasında kullanılır

--stok miktarı 20 den büyük 49 dan küçük olan ürünleri listeyelin

select * from Products

select pr.ProductName from Products pr
where UnitsInStock between 20 and 49 -- ikisi arasında dahil oluyor

--01.01.1997 ile 06.06.1998 tarihleri arasındaki siparişleri listeleyin ve 
--tersten sıralamayı ekle

select * from [Order Details]

select od.OrderDate from Orders od where od.OrderDate  between '06.06.1998' and '01.01.1997'  order by od.OrderDate asc

--eklenti yapmak
--tablolar arasında arama gerçekleştirmek istiyorsan (baş harfi a olan gibi)
--bunları bulabilmemiz için kullanılan kelime like

select CompanyName from Customers
where CompanyName like 'A%'--BAŞINDA DEMEK

select CompanyName from Customers
where CompanyName like '%A'--SONUNDA DEMEK

select CompanyName from Customers
where CompanyName like '%A%'--İÇİNDE DEMEK

select CompanyName from Customers
where CompanyName like '[^A]%'--İÇİNDE A OLMAYAN DEMEK

select CompanyName from Customers
where CompanyName like '[A-B]%'--BAŞINDA A VEYA B ARASINDA OLAN

select CompanyName from Customers
where CompanyName like 'A[^n]%'--BAŞINDA A olup içinde n olmayan


--ülkesi ingiltere olmayan adı a ile başlayıp soyadı r ile biten doğum tarihi 1985 den önce olan 
--çalışan kimdir
select * from Employees
select FirstName,LastName,BirthDate from Employees
where FirstName like 'A%' and LastName like '%R'and YEAR (BirthDate)<1985

--japoncayı akıcı dille konuşan kişi
select * from Employees
select LastName, Notes from Employees 
where Notes like '%Japan%'

--COUNT = SAYMAK

--STOKTA KAÇ ÜRÜN VAR 

SELECT COUNT (ProductID) FROM Products
WHERE UnitsInStock>0

--1996 yılından sonra alınmış kaç adet sipariş vardır
select count (OrderDate) from Orders

--kaç ülkede müşteri bulunmaktadır
select count (DISTINCT Country ) from Customers

