------------------------STORED PROCEDURE-------------
--select, insert , update, delete gibi komutları çalıştırabilmek kapsitesine sahip bir mekanizmadır. oldukça hızlı ve bir o kadar da 
--güvenli yapılardır. hızlıdır çünkü server ın ön belleğinde çalışmaya hazır bir şekilde çağrılmayı beklerler.
--güvenlidir çünkü parametre mantığı ile çalışır ve size dışardan gelen değerlerin nasıl işlenmesini isterseniz o kadarını işler
--çok sık kullanılan bir yapıdır özellikle web uygulamalarında çokta rastlanmaktadır. dış dünya ile etkileşimin en yüksek olduğu
--rekor web platformudur. dışarda gelecek olan saldırılara karşı mümkün olduğunca güçlüdür.
--view sanal bu değil. en çok bu kullanılır.

--kargo ekleyen bir prosedür tasarlayınız

go
create proc KargoEkleyici1
(
   @ad nvarchar (20),
   @tel nvarchar(20)
)
as 
insert into Shippers (CompanyName,Phone)
values (@ad,@tel)
go

KargoEkleyici1 'Mng kargo, 5458853265'
select * from Shippers

--dışarda girilen değer kadar ürünlere zam yapan bir prosedür tasarla. zam yapan olsun (unitprice - product)
go
create proc  ZamYapan
(
@miktar money
)
as
update Products set UnitPrice=@miktar
go

select * from Products

--dışarda girilen kategori adına ait ürünleri listeleyen bir prosedür tasarla
--sorgu yap kategori adında

go
create proc Kategoriyegöre
(
  @katadı nvarchar(15)
)
as
select * from Products p inner join Categories c on p.CategoryID=c.CategoryID
where c.CategoryName=@katadı
go
Kategoriyegöre 'Beverages '
select * from Categories

--dışarda girilen akrgo firması tarafından taşınmış  ve yine dışardan girilen akrgo ödemesi değer arasındaki siparişleri 
--listeleyen bir prosedür tasarlayınız

go 
create proc SiparişGetirici
(
    @KargoAdı nvarchar(15),
	@minUcret money,
	@maxUcret money


)
as 
select OrderID,CompanyName,Freight from Orders o 
inner join Shippers s on o.ShipVia=s.ShipperID
where s.CompanyName=@KargoAdı and
Freight between @minUcret and @maxUcret
go
SiparişGetirici 'United Package' ,10,100
select * from Shippers

--dışarda girilen karakterleri içerisinde barındıran müşteri adına sahip müşterilerce verilmiş siparişleri listeleyen prosedürleri tasarlayınız
--prosedür müşteri siparişleri
go
create proc MusteriSiparisleri
(
   @musteri nvarchar(30)
)
as 
select * from Customers c 
inner join Orders o on c.CustomerID=o.CustomerID
where c.CompanyName like @musteri
go
MusteriSiparisleri'%kk%'


--stok miktarı dışardan girilen iki değer arasında olan ürün ücreti dışardan girilen iki değer arasında olan, toptancı firma adı 
--dışardan girilen harfi barındıran ürünlerin adlarını, fiyatların toptancı şirket adlarını ve fiyatlarını,fiyatların kdv eklenmiş 
--halini gösteren prosedür yap

go
create proc UrunleriDetaylıGetir
(
   @minStok smallint ,
   @maxStok smallint ,
   @minUcret money,
   @maxUcret money,
   @toptan nvarchar(30)

)
as
select ProductName, UnitPrice,UnitPrice*1,18 as 'kdv li',CompanyName from Products p 
inner join Suppliers s on p.SupplierID=s.SupplierID
where p.UnitsInStock between  @minStok and  @maxStok and p.UnitPrice between  @minUcret and @maxUcret and s.CompanyName like @toptan
go
UrunleriDetaylıGetir 10,40,40,110,'%ltd%'

--dışarda girilen çalışan ıd si tarafından alınmış siparişleri listeleyiniz ancak dışardan kaç adet çalışan ıd geldiği 
--bilinmemektedir. employees

--DECLARE büyükçe bir sorgunun zamanaşımı içinde az sayıda satırın bir kullanıcı tarafından çekilmesi için kullanılabilecek 
--göstericilerin bildirimini yapmakta kullanılır. FETCH[fetch(7)] kullanılarak veri ister metin ister ikilik biçimde 
--göstericiden döndürülebilir
go
create proc  calısanagöre
(
  @abc nvarchar (max)
)
as
declare @sorgu nvarchar (max) 
set @sorgu= ('select OrderID,OrderDate,EmployeeID from Orders
where EmployeeID in ('+@abc+') order by EmployeeID')
Execute (@sorgu)
go
calısanagöre '1,5,7'

--dışarıdan girilen kategorinin adını ve tanımını ekleyen prosedürü yazın 
go
create proc KategoriEkle1
(
   @Adi nvarchar(20),
   @aciklama nvarchar(20)
)
as 
insert into Categories (CategoryName,Description) 
values (@Adi,@aciklama) 
go
Execute KategoriEkle1 'AAAA','BBBB'
SELECT * FROM Categories


--dışarıdan girilen kategorinin adını ve tanımını ekleyen prosedürü yazın AYNI KATEGORİ ADI VARSA UYARI VERİP EKLETMEYEN KAYDI YAZIN
go
alter proc KategoriEkle

   @Adi nvarchar(20),
   @aciklama nvarchar(20)
as 
if(not exists (select * from Categories where CategoryName=@Adi)
begin
insert into Categories (CategoryName,Description) 
values (@Adi,@aciklama)
end  
else
begin
print 'böyle kayıt var'
end
go
select * from Categories
KategoriEkle 'Beverages','aaa'

--ürün ıd ve stoğu ile dısarda verilen stok değerini değiştiren (güncelleyen) storedlerini yazın.

go
create proc urunGuncelleyen
(
@urunId int,
  @stok smallint
)
as
update Products set UnitsInStock=UnitsInStock+@stok 
where ProductID=@urunId 

go

urunGuncelleyen 5,30
select * from Products where ProductID=5


--ürün adı ile ürünü silen stored klasörü
go
create proc UrunSilme
(
   @urunadi nvarchar(20)
)
as
delete Products where ProductName=@urunadi
go
select * from Products
UrunSilme 'Abccc'
insert into Products (ProductName) values ('Abccc')

-----------FONKSİYONLAR------
--BİR TAKIM İŞLEMLERDEN BİZE BİR DİZİ DEĞER DÖNDÜREN NESNELERE DENİR.

--İKİ TİP VARDIR. SCALER VE TABLE 
--SCALER : TEK SATIR TEK DÜTUN DEĞER DÖNDÜDÜR. Bİ DEĞER 
--TABLE : GERİYE BİR TABLO DÖNDÜRÜR. BÜTÜN TABLODAKİ
--DEZAVANTAJI : İNSERT UPDATE VE DELETE GİBİ İŞLEMELR GERÇEKLEŞTİRİLEMEZ.

--DIŞARDA GİRİLEN İKİ DEĞERİ TOPLAYAN VE BİZE GERİ DÖNDÜREN FONKSİYON YAZALIM.
go
create function ToplamaYap
(
   @sayi1 int,
   @sayi2 int
)
returns int
as
begin
return @sayi1+@sayi2
end
go
select dbo.ToplamaYap(10,5) as 'Ortalama'
 
 --dışardan girilen 3 sayının ortalamasını geri döndüren bir fonksiyon tasarlayınız.
 go
 create function ToplamaYapÜçSayı
 (
    @sayi1 float,
	@sayi2 float,
	@sayi3 float
 )
 returns float
 as
 begin
 return (@sayi1+@sayi2+@sayi3)/3
 end
 go
 select dbo.ToplamaYapÜçSayı(10,20,30) as'Ortalama'
 --parametre olarak ad ve soyad bilgisini alan bir fonksiyon tasarlayınız. bu fonksiyonu adın ilk üç harfini, soyadının son 
 --üç harfini alsın ve aralarına 1. sonuna ise @hotmail.com koyarak ve tamamını küçük har yaparak geri döndürsün
 --değişkene atamak için declare kullanılır.
 go
 create function AdSoyadmail
 (
   @ad nvarchar(20),
   @soyad nvarchar(30)
 )
 returns nvarchar (19)
 as
 begin
 declare @birlestir varchar(19)
 set @birlestir =LOWER (left (@ad,3)+'.'+RIGHT (@soyad,3)+'@hotmail.com')
 return @birlestir
 end 
 go
 select dbo.AdSoyadmail('Sena','Ekincioğlu') as 'Mail'

 --ürün tablosundaki ürüne kdv ekleyip gösteren fonksiyonu yaz

 go
 create function KDV
 (
  @kdv money
 )
 returns money
 as
 begin
 return @kdv*1.18
 end
 go
 select ProductName, UnitPrice,dbo.KDV(UnitPrice)as 'Kdv li' from Products

