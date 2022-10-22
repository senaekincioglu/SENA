select * from TBL_Kitap where KitapTarih<'2015-05-24'--y�l ay g�n
select * from TBL_Kitap where KitapFiyat>9 or KitapYay�nEvi='Merk�r'-- kitap fiyat� 9 dan b�y�k olanlar� ya da kitap yay�n evi = merk�r olanlar� getirir
--kitap adlar�n� alfabetik s�raya g�re istiyorsak order by asc olur ve asc yazmam�za gerek yok.
--tersine istiyorsak desc yaz�l�r.
select * from TBL_Kitap where KitapFiyat>9 or KitapYay�nEvi='Merk�r' order by KitapAd asc
--kitap adlar�n� alfabetik s�raya g�re istiyorsak order by asc olur ve asc yazmam�za gerek yok.
--tersine istiyorsak desc yaz�l�r.
select * from TBL_Kitap where KitapYay�nEvi in ('Merk�r','Ay','J�piter')

--kitap fiyat� 8 den b�y�k 20 den k���k olan sorguyu yaz�n
select * from TBL_Kitap where KitapFiyat>8 and KitapFiyat<20

--kitap fiyat� 8 ile 20 aras�nda olan sorguyu yaz�n
select * from TBL_Kitap where KitapFiyat between 8 and 20
------�RNEKLER-----
--yeni database olu�turma : 
create database okulum
--yeni tablo olu�turma
create table TblOgrenci
(
 ogrNo int not null primary key,--(birincil anahtar) -- not null bo� ge�ilemez. null olsa bo� ge�ilebilir
 ogrAdi varchar(15),
 ogrSoyadi varchar(20),
 ogrAdres varchar (50),
 ogrSinif varchar (2),
 ogr�lce varchar(20) default 'seyhan', -- ogr il�e adl� s�tunda varsay�lan de�er ilk de�er olarak atan�r.  
 ogrsinav1 tinyint check (ogrsinav1>0),
 ogrsinav2 int ,
 constraint chks2 check (ogrsinav2>=0 and ogrsinav2<=100)
)
alter table TblOgrenci add devamsizlik tinyint,
ogrKayitTarih smalldatetime, ogrBorc tinyint
alter table TblOgrenci add check (devamsizlik<=20)
alter table TblOgrenci alter column ogrAdres varchar(160)

select * from TBL_Kitap where KitapAd like '%a%' -- i�inde a olan

select * from TBL_Kitap where KitapAd like 'b%' -- b ile ba�layan

select * from TBL_Kitap where KitapAd like '%e'--e ile biten