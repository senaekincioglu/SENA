select * from TBL_Kitap where KitapTarih<'2015-05-24'--yýl ay gün
select * from TBL_Kitap where KitapFiyat>9 or KitapYayýnEvi='Merkür'-- kitap fiyatý 9 dan büyük olanlarý ya da kitap yayýn evi = merkür olanlarý getirir
--kitap adlarýný alfabetik sýraya göre istiyorsak order by asc olur ve asc yazmamýza gerek yok.
--tersine istiyorsak desc yazýlýr.
select * from TBL_Kitap where KitapFiyat>9 or KitapYayýnEvi='Merkür' order by KitapAd asc
--kitap adlarýný alfabetik sýraya göre istiyorsak order by asc olur ve asc yazmamýza gerek yok.
--tersine istiyorsak desc yazýlýr.
select * from TBL_Kitap where KitapYayýnEvi in ('Merkür','Ay','Jüpiter')

--kitap fiyatý 8 den büyük 20 den küçük olan sorguyu yazýn
select * from TBL_Kitap where KitapFiyat>8 and KitapFiyat<20

--kitap fiyatý 8 ile 20 arasýnda olan sorguyu yazýn
select * from TBL_Kitap where KitapFiyat between 8 and 20
------ÖRNEKLER-----
--yeni database oluþturma : 
create database okulum
--yeni tablo oluþturma
create table TblOgrenci
(
 ogrNo int not null primary key,--(birincil anahtar) -- not null boþ geçilemez. null olsa boþ geçilebilir
 ogrAdi varchar(15),
 ogrSoyadi varchar(20),
 ogrAdres varchar (50),
 ogrSinif varchar (2),
 ogrÝlce varchar(20) default 'seyhan', -- ogr ilçe adlý sütunda varsayýlan deðer ilk deðer olarak atanýr.  
 ogrsinav1 tinyint check (ogrsinav1>0),
 ogrsinav2 int ,
 constraint chks2 check (ogrsinav2>=0 and ogrsinav2<=100)
)
alter table TblOgrenci add devamsizlik tinyint,
ogrKayitTarih smalldatetime, ogrBorc tinyint
alter table TblOgrenci add check (devamsizlik<=20)
alter table TblOgrenci alter column ogrAdres varchar(160)

select * from TBL_Kitap where KitapAd like '%a%' -- içinde a olan

select * from TBL_Kitap where KitapAd like 'b%' -- b ile baþlayan

select * from TBL_Kitap where KitapAd like '%e'--e ile biten