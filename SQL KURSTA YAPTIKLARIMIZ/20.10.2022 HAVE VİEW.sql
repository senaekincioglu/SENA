-- --- HAVING YAPISI --- --
-- Aggerate fonksiyonlar aracılığı ile alınan sonuçlar bir where kriteri içerisinde kullanılmamaktadır. Bunun yerine (where yerine) kullandığımız anahtar kelime HAVING anahtar kelimesidir. 
-- HAVING -> GROUP BY'ın fonksiyonudur. Bu sayede filtreleme yapabilirsiniz.

-- 1- Toplam sipariş miktarı 1200'ün üzerinde olan ürünleri adlarını ve sipariş miktarlarını gösteriniz.
select SUM(od.Quantity) as 'TOPLAM MİKTAR', p.ProductName from [Order Details] od INNER JOIN Products p on p.ProductID = od.ProductID GROUP BY p.ProductName HAVING SUM(od.Quantity)>1200

-- 2- Hangi personel hangi ürünü toplam kaç dolarlık satmıştır. 1000'den büyük olanları getir.
select LEFT(e.FirstName,1)+'.'+LastName as 'Personel', p.ProductName, SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) as TOPLAM from Employees e INNER JOIN Orders o on e.EmployeeID = o.EmployeeID INNER JOIN [Order Details] od on o.OrderID = od.OrderID INNER JOIN Products p on od.ProductID = p.ProductID GROUP BY p.ProductName,e.FirstName,e.LastName HAVING SUM(od.Quantity*od.UnitPrice*(1-od.Discount))>1000 ORDER BY TOPLAM desc

-- 3- 250'den fazla sipariş taşımış olan kargo firmalarının adlarını, telefon numaralarını ve miktarlarını listeleyiniz
select s.CompanyName,s.Phone, COUNT(o.ShipVia) as SİPARİS from Shippers s INNER JOIN Orders o on s.ShipperID = o.ShipVia GROUP BY s.CompanyName, s.Phone HAVING COUNT(o.OrderID)>250

-- --- INSERT FONKSİYONLARI --- --
-- Varolan bir veri kaynağına yeni bir veri eklemek için kullanılan bir yapıdır. Eğer tablonuzdaki tüm kolonlara INSERT işlemi gerçekleştiriyorsanız tek tek kolon adlarını yazmak zorunda değilsiniz ancak dikkat edilmesi gereken nokta kolon sıralamalarını iyi biliyor olmak gerekmektedir. 
-- INSERT INTO tabloadi (kolon1,kolon2,...) VALUES (deger1,deger2,...) şeklinde kullanılır.
-- select SCOPE_IDENTITY{} -> Sorgu sayfasında 2 kişi veri girerken son id'yi getirmek için kullanılır.

-- 1- Kendinizi Personel tablosuna ekleyiniz.
INSERT INTO Employees (FirstName,LastName,BirthDate) VALUES ('Büşra','SÖYÜNMEZ','03.27.1997')
select * from Employees where FirstName='Büşra'

-- --- UPDATE FONKSİYONLARI --- --
-- Varolan bir veri kaynağındaki varolan verilerinizin yeni değerler ile güncellenmesini sağlayan yapıdır. Eğer  UPDATE işleminde WHERE kriterini unutursanız bütün verileriniz aynı değerlerle güncellenir.

 -- 1- 6 Nolu kargo firmasının Telefon numarasını (212 888 44 47) olarak güncelleyin.
 UPDATE Shippers set Phone='2128884447' WHERE ShipperID=6
 select * from Shippers

 INSERT INTO Shippers (CompanyName,Phone) VALUES ('UPS','5474563212'),('YURTİÇİ','5313358458'),('MNG','5474565412')

 -- 2- Çalışanlar tablosundaki Nancy adlı çalışanın doğum tarihini 01.01.1967 şehir bilgisini ise Erzincan olarak değiştir.
 UPDATE Employees SET BirthDate='01.01.1967', Country='Erzincan' WHERE FirstName='Nancy'
 UPDATE Employees SET BirthDate='01.01.1967', City='Erzincan' WHERE FirstName='Nancy'
 select*from Employees Where FirstName='Nancy'

-- eğer yaptıgın güncellemeyi geri almak istiyorsanız
-- begin transaction Kolonismi
-- update shippers set kolonismi='212 888 44 47'
-- rollback tran

-- Stoğu 10'dan küçük olan ürünlere %6 zam yapan kodu yazın
Rollback tran
UPDATE Products SET UnitPrice=UnitPrice*1.06 WHERE UnitsInStock<10
begin tran -- Yapılan güncellemeyi geriye almak için kullanılır.

-- --- DELETE FONKSİYONU --- --
-- Varolan verilerimizi tamamıyla silinmesi için kullanılan yapıdır. Eğer DELETE işleminde WHERE kriterini unutursanız bütün verileriniz aynı anda silinir.

-- 1- Kargo tablosundaki kargo id'leri 3'den büyük olan bütün kayıtları siliyoruz.
rollback transaction
select*from Shippers
begin tran -- Geri alma işlemini yapmak istiyorsak Begin Tran ile çalıştırmak zorundayız. Yoksa geri alma işlemi yapılamaz. İşlemi geri almak istediğimizde 
DELETE from Shippers where ShipperID>3

-- --- VIEW NESNESİ (SANAL TABLO) --- --
-- Bir sorgu içerisinde çok fazla işlem gerçekleştiriyorsanız ve üstelik buna çok sayıda ihtiyacınız varsa VIEW nesnesini kullanmanız gerekmektedir. Sorgunuzu sanal bir tabloda yapar ve her defasında artık o tablodan çekilmesini ister. Veri kaybı yaşamanın önüne geçer.
-- VIEW ile sanal tablo oluşturulur. Bizzat veri tutmaz. Tablodaki verilere select yaparak ulaşabilirsiniz. Her çalışacağı zaman COMPILE edilmez, hız kazandırır, güvenlik sağlar mesela personel tablosunda select yaparken personel maaşını herhangi bir kişinin görmemesi gerektiği noktalarda avantaj ve güvenlik sağlar.

-- Amerikalı müşterilerden alınmış siparişleri listeleyen bir sorgu tasarlayınız ve bir VIEW içinde saklayınız.
GO
CREATE VIEW Amerikalılar
AS
select c.CustomerID, c.CompanyName, o.OrderID from Orders o INNER JOIN Customers c ON o.CustomerID = c.CustomerID WHERE c.Country='USA'
GO
select * from Amerikalılar

-- 1- Speedy Expres ile taşınmış Nancy'nin almış olduğu, pazartesi günleri Dumon ya da Alfki ID'li müşteriler tarafından verilmiş olan 
--siparişler.
go
create view Siparisler
as
select O.OrderID,O.OrderDate,S.CompanyName,e.FirstName,c.CustomerID from Orders o 
inner join Customers c on o.CustomerID=c.CustomerID
inner join Employees e on e.EmployeeID=o.EmployeeID
inner join Shippers s on s.ShipperID=o.ShipVia
where e.FirstName='Nancy' and DATENAME(WEEKDAY,OrderDate)='Monday' and s.CompanyName='Speedy Express' and c.CustomerID in ('ALFKI','DUMON')
GO
select * from Siparisler

--hangi ürünü hangi müşterinin hangi personelden aldığını listeleyelim wiev olarak detaylı satış raporu
   
go
create view DetaylıSatışRaporu --product name customername 
as
select p.ProductName,e.FirstName,c.ContactName,o.OrderID from Products p 
inner join [Order Details] od on od.ProductID=p.ProductID
inner join Orders o on o.OrderID =od.OrderID 
inner join Employees e on e.EmployeeID=o.EmployeeID
inner join Customers c on c.CustomerID=o.CustomerID
go
select * from DetaylıSatışRaporu

--Kategorilerim olarak view oluştur
go
create view Kategorilerim 
as
select CategoryName from Categoris
go
--yeni oluiturduğun kolon altında kagetori ekle
insert into Kategorilerim (CategoryName) values ('Aaa')
select * from Kategorilerim

select CategoryName from Kategorilerim 
order by CategoryName asc

--ÖDEV--Beverages kategorisine ait amerikalı toptaencılar tarafından alınmış stoklarından mevcut ürünlerin adlarını ücretlerini, kdv li 
--ücretlerini
--gösteren bir view tasarlayınız (bağlı bulunduğu kolonlar asla silinmemeli ve view kodları görünmemelidir)
 
 go
 create view BBB
 as
 SELECT c.CategoryName,s.Country,(P.UnitPrice*1.18) as  'KDV Lİ FİYAT' FROM Orders o 
 inner join [Order Details] od on o.OrderID=od.OrderID
 inner join Products p on p.ProductID=od.ProductID
 inner join Categories c on p.CategoryID=c.CategoryID
 inner join Suppliers s on s.SupplierID=p.SupplierID
 where c.CategoryName='Beverages'and s.Country='USA' and p.UnitsInStock is not null
 go
SELECT * FROM BBB
