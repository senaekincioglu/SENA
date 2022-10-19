--3 numaralı ürünün satışı yapıldığı müşterinin 
--ıd lerini listeleyin

select *,(select o.ProductID from [Order Details] o where p.OrderID = o.OrderID and ProductID = 3 ) 
as ProductId from Orders p where p.OrderID in ((select OrderID from [Order Details] where 
ProductID = 3))
select CustomerID from Orders where OrderID in(select OrderID from [Order Details] where ProductID=3)

--hangi satışta kaç adet ürün satılmıştır (toplam soruyor)
select (select sum (UnitPrice Quantity(1-Discount)) from [Order Details]
OD where OD.OrderId=O OrderId) , as 'Satılanlar' from Orders O

--JOİNLER : İKİ TABLOYU İLİŞKİLİ KOLONLAR ÜZERİNDE BİRBİRİNE BAĞLAR. TABLOLARIN DENORMALİZE ŞEKİLDE SORGULAMALARINI SAĞLAR
--OUTER JOİN CROSS JOİN İNNER JOİN OLMAK ÜZERE 3 TANEDİR. 
--İNNERJOİN : iki ya da daha fazla tabloda ortak olan iki alandaki değerleri kontrol ederek tabloları birleştirir.
--İLİŞKİ KOLONLARINDA NULL OLMAYAN DEĞERLERİ İLİŞKİLENDİRME YAPARAK LİSTELEME YAPARLAR
select * from Categories 
select * from Products
--categoriıd ikisinde de olduğu için ikisinde de onu alıyorsun
select * from Products p inner join Categories c on p.CategoryID=c.CategoryID
select ProductName,CategoryName from Products p inner join Categories c on p.CategoryID=c.CategoryID
select p.ProductName,c.CategoryName,p.UnitPrice,p.UnitsInStock from Products p inner join Categories c on p.CategoryID=c.CategoryID

--ürünleri tedarikçi şirketleri adları ile listeleyiniz(
select s.CompanyName, p.ProductName from Products p inner join Suppliers s on p.SupplierID=s.SupplierID

--ürünlerin satış raporunun ürün adı, satış fiyatı, adet indirim kolonlarını raporlayın
select p.ProductName,p.UnitPrice, od.Quantity,od.discount from Products p inner join [Order Details] od on p.ProductID=od.ProductID

--hangi satışta hangi ürünler satılmıştır(ilk ikisi sonra diğeri)
select p.ProductName,o.OrderID from [Order Details] od inner join 
Products p on od.ProductID=p.ProductID inner join Orders o 
on od.OrderID=o.OrderID

--hangi personel hangi tarihte hangi müşteriye satış yapmıştır
--left (e.FirstName,1)=isimden ilk harfi alır.
select left (e.FirstName,1)+'.'+e.LastName as 'Ad Soyad' , c.CustomerID,
o.OrderDate from Customers c inner join Orders o on c.CustomerID=o.CustomerID
inner join Employees e on e.EmployeeID=o.EmployeeID 

--ÖDEV : HANGİ MÜŞTERİ HANGİ ÜRÜNDEN KAÇ DOLARLIK SATIŞ ALMIŞTIR (İNNERJOİN İLE) 4 TABLO VAR
--ÖDEV : HANGİ PERSONEL HANGİ KATEGORİDEN HANGİ ÜRÜNLERİ SATMIŞTIR (İNNERJOİN İLE)
--ÖDEV :ÜRÜNLERİMİZİN ADLARINI VE KATEGORİ ADLARINI BİR RAPORDA GÖSTERİNİZ (İNNERJOİN İLE)
--ÖDEV :BEVERALES KATEGORİSİNE AİT STOKLARDA BULUNAN ÜRÜNLERİ SIRALAYINIZ (İNNERJOİN İLE)
--ÖDEV :FEDERAL SHİP İLE TAŞINMIŞ (KARGO) NE NANCY NİN ALMIŞ OLDUĞU SİPARİŞLERİ GÖSTERİNİZ (İNNERJOİN İLE)
--ÖDEV : CAMPANY NAME ARASINDA A GEÇEN MÜŞTERİLERİN VERMİŞ OLDUĞU NANCY ANDREW YA DA 
--JANET TARAFINDA ALINMIŞ SPEDY EXĞRES İLE TAŞINMAMIŞ SİPARİŞLERİ TOPLAM NE KADARLIK KARGO ÖDEMESİ YAPILMIŞTIR
--ÖDEV : EN ÇOK (TOP) ÜRÜN ALDIĞIMIZ 3 TOPANCIYI ALMIŞ OLDUĞUMUZ ÜRÜN MİKTARINA GÖRE RAPORLAYINIZ
--ÖDEV : HER BİR ÜRÜNDEN TOPLAM NE KADARLIK SATIŞ YAPILMIŞTIR VE O ÜRÜNLER HANGİ KATEGORİLERE AİTTİR

--OUTER JOİN :3 tanedir. LEFT (OUTER) JOIN: İki tablodaki eşleşen kayıtlar ve eşleşmeyen 
--sol kayıtlar için kullanılır. RIGHT (OUTER) JOIN: İki tablodaki eşleşen kayıtlar 
--ve eşleşmeyen sağ kayıtlar için kullanılır. FULL (OUTER) JOIN: İki tablodaki 
--eşleşen kayıtlar ve eşleşmeyen sol ve sağ kayıtlar için kullanılır.
--LEFT (OUTER) JOIN: sorgudan önce yazılan tablo lefttir ve left olan tablodaki 
--tüm kayıtlar (null dahil) getirilir sol taraftaki
 --RIGHT (OUTER) JOIN: yeni bağlanan tablodaki sadece ilişkili kayıtları nul dahil 
 --getirir) ama   sağdaki tablo için boş olanları getirmez
  --FULL (OUTER) JOIN: İki tablodaki 
--eşleşen kayıtlar ve eşleşmeyen sol ve sağ kayıtlar için kullanılır.
select * from Products
select * from Products p left  outer join Categories c on c.CategoryID=p.CategoryID
select * from Categories p right outer join Products c on c.CategoryID=p.CategoryID
--ikincide categori tablosunda boşları da getirir ama sağdaki ürünler tablosunda 
--boş getirmez ama categori ıd de boş getirmez

--ürünleri ve bağlı bulundukları kategorileri listeleyiniz ancak ürünü olmayan (null)
--kategoriler de sonuca dahil edilsin
select s.CompanyName, p.ProductName from Products p inner join Suppliers s on p.SupplierID=s.SupplierID

select * from Categories c left join Products p on c.CategoryID=c.CategoryID

--right outer join : sorguda sağ taraftan alınan verilerin gelmesini(boş olmicak) 
--sol tarafta o verilerde karşılık veriler olmasa da değerlerin görünmesini sağlar
 
 --ürünleri ve bağlı bulundukları kategorileri listeleyiniz ancak kategorisi 
 --olmayan ürünler de dahil edilsin 
 select * from Categories c right outer join Products p on c.CategoryID=p.CategoryId

 --hangi ürün hangi nakliye firması ile taşınmıştır. taşınmasa bile satış görülmelidir
-- left join SQL Join türlerinden biridir. SQL left join ilk (sol) tablodaki tüm satırlar

select ord.OrderID,pr.ProductName,s.CompanyName from Shippers s left outer join Orders o on s.ShipperID=o.ShipVia inner join
[Order Details] ord on o.OrderID=ord.OrderID inner join Products pr on Pr.ProductID=ord.ProductID

select * from [Order Details]
--hangi tedarikçiden toplam kaç tl lik ürün satılmıştır(suppliers product order details)
select sum(od.UnitPrice*od.Quantity) as 'Toplam' from Suppliers s inner join Products p on s.SupplierID=p.SupplierID inner join
[Order Details] od on p.ProductID =od.ProductID
group by s.CompanyName

--kategorilerin toplam satışlarını raporlayın(farklı kategoriler var group by) indirim de var toplam satışta o yüzden indirim discountu da yazdı
select * from [Order Details]
select s.CategoryName, sum(od.UnitPrice*od.Quantity)*(1-od.Discount) as 'Toplam Satış' from Categories s inner join 
Products p on s.CategoryID=p.CategoryID inner join [Order Details] od on od.ProductID=p.ProductID group by s.CategoryName

--hangi personel hangi ürünü toplam kaç dolara satmıştır ve ad soyadı birleştir
select e.FirstName + ' '+e.LastName as 'Ad soyad',p.ProductID, sum(od.UnitPrice*od.Quantity)*(1-Discount) from Employees e inner join Orders 
o on e.EmployeeID=o.EmployeeID inner join [Order Details] od on od.OrderID=o.OrderID inner join Products p on od.ProductID=p.ProductID  group by FirstName,LastName,ProductID





