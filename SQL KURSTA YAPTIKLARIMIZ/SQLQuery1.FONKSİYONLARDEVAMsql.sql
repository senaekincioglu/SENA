--Fonksiyonlara devam
--sum: fonksiyona parametre olarak gönderilen kolon içerisindki tüm değerleri toplayıp size geri döndürür
--select SUM (UnitPrice) from Product -- böyle yazılır

--depoda ücret bazlı olarak toplam ne kadarlık ürün kalmıştır
select * from Products
select sum (p.UnitPrice*UnitsInStock) from Products p 

--1997 yılında alınmış olan siparişlerin toplam ne kadarlık kargo ödemesi yapıldı
select sum (o.Freight) from Orders o where YEAR(o.OrderDate)=1997

--bu zamana dek ödenmiş ortalama kargo ücretiniz nedir
select sum (Freight)/count(OrderID) from Orders 

--stoğu 15 ten küçük olan kaç tane ürün vardır
select * from Products 
select count( ProductName )from Products where UnitsInStock<15 -- count sayar

--şuana kadar toplam kaç dolarlık ciro var indirim oranı (discount)
select * from [Order Details]
select sum (UnitPrice*Quantity*(1-Discount))from [Order Details]

--AVG YAPISI : ORTALAMA ALMAK İÇİN KULLANILAN YAPIDIR.

--bu zamana dek ödenmiş ortalama kargo ücretiniz nedir
select * from Products
select AVG(Freight) from Orders

--Ürünlerimizin ortalama satış fiyatı nedir
select * from Products
select AVG (UnitPrice)from Products

--ülke başına ortalama ne kadar kargo ücreti ödenmiştir
select * from Orders
select sum (Freight)/COUNT(DISTINCT ShipCountry ) from Orders -- distinc sadece farklıları yazar

--Max ve Min yapısı 
--sahip olunan değerler arasında en büyük ya da en küçük değeri almak için kullanılır ve bu 
--fonksiyonlar sadece sayısal değil metinsel ya da tarihsel ifadeler için de kullanılır 
--en yüksek bedelli ürün hangisi
select * from Products
select max( unitprice)from Products -- yanına virgül koyarsan da istediğin kolonu yazdırırsın

--en yüksek kargo miktarı nedir
select * from Orders
select max (Freight) from Orders

--müşteri ıd leri a ile k arasında olanların vermiş oldukları sipariş tarihi 01-01-1997 ile 
--06-06-1997 arasında olan siparişlere en az ne kadar kargo ücreti ödenmiştir(min)
select MIN(Freight)  from Orders where CustomerID like '[A-K]%' AND OrderDate between 
'01.01.1997' and'06.06.1997'

--en fazla satışınızda kaç dolarlık satış yapılmıştır
select * from [Order Details]
select max (Unitprice*Quantity*(1-DİSCOUNT)) from [Order Details] -- 1 YÜZDE OLARAK DÜŞÜN

--5 ten büyük en düşük satışta kaç dolarlık satış yapılmıştır
select * from [Order Details]
select min(UnitPrice*Quantity*(1-DİSCOUNT)) from [Order Details] WHERE UnitPrice>5

--in yapısı :veyalı sorgularda parantez hatalarının önüne geçmek için kullanılır. içinde olan 
--demek


--2,4-5,7 nolu çalışanların almış olduğu siparişleri gösterin

select * from orders
select OrderID,EmployeeID from Orders where EmployeeID In (2,4,5,7)

--Bir ya da iki nolu kargo firması ile taşınmış 1996 yılında bir perşembe günü alınmış sipariş 
--için ödenen azami kargo bedeli nedir (max)

select max(Freight) from Orders where ShipVia in (1,2) and year (OrderDate)=1996 and DATENAME 
(WEEKDAY,OrderDate)='Thursday'

-- --ÖDEVVV 'CACTU' 'Duman' 'Peric' ıd li müşteriler tarafınfan istenmiş 2 nolu kargo firması ile 
--taşınmamış kargo ücreti 20 ile 200 dolar arası olan siparişlere toplam ne kadarlık 
--kargo ödemesi yapılmıştır
 
 -- ÖDEV SİNEMA OTOMASYONU EN AZ 10 TABLOLU VERİ TABANAI OLUŞTUR İLİŞKİ KUR VERİ EKLE  BUGÜNKİ SORULARI
 --ONA GÖRE SORU OLUŞTUR VE YAP.
 



