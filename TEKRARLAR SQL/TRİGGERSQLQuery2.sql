--kitap2 tablosuna yeni bir kitap eklediði zaman tetikleyiciyi çalýþtýrsýn.
use Kitaplik
create trigger Deneme
on TblKitap2
after insert
as
begin
select 'Yeni bir kitap kaydý yapýldý'
end

insert into TblKitap2 values ('Ýnsan ne ile yaþar','Hikaye','eeee','Yeþil')

--yeni bir kitap kaydý yapýldýðý zaman nutuk kitabýnýn rengini yeþil yapsýn
use Kitaplik
create trigger Ekleme2
on TblKitap2
after insert
as
begin
select kitapad,kitaprenk,kitaprenk='yeþil' from TblKitap2 where kitapad='nutuk' 
insert into TblKitap2 values ('sevgi neredeyse tanrý oradadýr','hikaye','ggg','sarý')

--güncelleme iþlemi yapýldýktan sonra bu uyarýyý versin
use Kitaplik
create trigger guncelleme
on TblKitap2
after update
as
begin
select 'Guncelleme iþlemi gerçekleþti'
end

update TblKitap2 set kitapad='nutuk' where kitapad='müfettis'

--update iþlemi yapýlýnca sayacý arttýrsýn
create trigger SayacGuncelle
on TblKitap2
after update
as
begin
update TblGuncelleme set sayac=sayac+1
end

update TblKitap2 set kitaprenk='turuncu' where kitaprenk='yeþil'

--silme iþlemi gerçekleþtiði anda þunu yazsýn (tetiklesin)
create trigger SilmeKontrol
on TblKitap2
after delete
as
begin
select 'Kayýt tablodan silindi'
end

delete from TblKitap2 where kitaptur='roman'


--güncelleme tablosunda sayacý 1 azaltsýn
--kitap iki tablosunda silme iþlemi yaptýktan sonra 

create trigger SilmeKontrol2
on TblKitap2
after delete
as
begin
update TblGuncelleme set sayac=sayac-1
end

delete from TblKitap2 where kitapozet='sfsdf'

--instead of tetikleyiciler
--tetikleyiciler ile birlikte kullanýlan kontrol amaçlý kullanýlan sql komutudur
--acaba iþlemi yapýyor mu gibi.
--kontrol amaçlýdýr instead of kullanýlýr.
create trigger insdeneme
on TblKitap2
instead of insert
as
begin
select 'Ekleme iþleminde sorun yok'
end

insert into TblKitap2 values ('Palto','Hikaye','vvv','Gri')
--ekleme iþlemini gerçekleþtirmez komutlarý yazar
 
 --(update yerine)
create trigger insdeneme2
on TblKitap2
instead of update
as 
begin
select 'Kayýt güncellenebilir'
end

update TblKitap2 set kitapad='bbbbb' where kitapad='sevgi neredeyse tanrý oradadýr'

--silme yerine
create trigger insdeneme3
on TblKitap2
instead of delete
as
begin
select 'Kayýt silinebilir'
end

delete from TblKitap2 where kitapad='bbbbb'
