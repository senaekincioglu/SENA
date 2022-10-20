select ID,ad,soyad from DB_Test.dbo.tb_ogrenci;

select*from tb_ogrenci where ad='Veysel'

select*from tb_ogrenci where ID>2

select top 2 *from tb_ogrenci--ilk ikiyi getirir.

select ID,ad ,soyad from tb_ogrenci Order by ID

select top 3 *from tb_ogrenci order by ID desc

select*from tb_ogrenci (NOLOCK)--Büyük databeslerde kullanýlýrdý.Sorgu yaplýrken datebase i kitler.Baþka bir kiþi güncelleme yapamaz

select*from tb_ogrenci where ID between 2 and 8

select*from tb_ogrenci where ID NOT IN(5,6,7)

select*from tb_ogrenci where ID NOT BETWEEN 5 AND 7

select*from tb_ogrenci where ID IN(13,14)

Create table Kullanicilar(
KullaniciID INT NOT NULL,
Ad varchar(50),
Soyad varchar(50),
KullaniciAd varchar(20)
)
Alter table Kullanicilar
ADD CONSTRAINT PKC_KullaniciID Primary Key(KullaniciID)

create table Personeller(
PersonelID INT PRIMARY KEY NOT NULL Identity(1,1),
Ad Varchar(50) NOT NULL,
Soyad Varchar(50) NOT NULL,
KullaniciID varchar(20) NOT NULL,
Email varchar(50),
Adres varchar(255),
Sehir varchar(50)
)--Hem primary key yaptýk hemde identity verdik

ALTER TABLE Personeller
ADD Constraint UQ_PersonelEmail UNIQUE(Email)--Bensersiz deðer yapma

ALTER TABLE Personeller
ADD DEFAULT (GETDATE())
FOR KayitTarihi--Bugünün tarihini otomatik olarak atmasý için

/*select sutun_ism1[,sutun_ismi2,...
from tablo ismi1=(select sutun_ismi
from tablo_ismi where tek_satir_donduren_kosul)

select sutun_ism1[,sutun_ismi2,...
from tablo ismi=
where sutun_ismi1 IN(select sutun_ismi
from tablo_ismi where kosul)
*/
select *from tb_alan

Update tb_alan set ad='Elektrik&Elektronik'
where ID=5
--ID'si 4 olan çðretmenin telefonunu '05231112233',alanýný da Elektrik&Elektronik YAPAN SORGU
update tb_Ogretmen
set telefon='05231112233',alan=5
where ID=4

select*from tb_Ogretmen

begin transaction
delete from tb_Ogretmen
where ID=4
Rollback
Commit

select a.ad,a.soyad,s.ad Sýnýf,o.ad +' '+o.soyad Ogretmen,al.ad as Alaný
from tb_ogrenci a
INNER JOIN tb_sinif s
on s.ID=a.sinifID
INNER JOIN tb_Ogretmen o
ON o.ID=a.ogretmenID
INNER JOIN tb_alan al
on al.ID=o.alan
Order by a.ad

--VIEW:Sanal tablo oluþturmamýzý saðlar.Karmaþýk ve uzýn sorgularý view olarak tanýmladýðýmýzda sanki o detaylý 
--sorgunun sonucu bir tabloymuþ gibi veri çekebiliriz.Method oluþturur gibi düþün.

Create VIEW OgrenciOgretmen as
select o.ad+' '+o.soyad as Ogrenci,
m.ad+' '+m.soyad as Ogretmen
from tb_ogrenci o
INNER JOIN tb_Ogretmen m
ON M.ID=o.ogretmenID

select*from OgrenciOgretmen


