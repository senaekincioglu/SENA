--kitap2 tablosuna yeni bir kitap ekledi�i zaman tetikleyiciyi �al��t�rs�n.
use Kitaplik
create trigger Deneme
on TblKitap2
after insert
as
begin
select 'Yeni bir kitap kayd� yap�ld�'
end

insert into TblKitap2 values ('�nsan ne ile ya�ar','Hikaye','eeee','Ye�il')

--yeni bir kitap kayd� yap�ld��� zaman nutuk kitab�n�n rengini ye�il yaps�n
use Kitaplik
create trigger Ekleme2
on TblKitap2
after insert
as
begin
select kitapad,kitaprenk,kitaprenk='ye�il' from TblKitap2 where kitapad='nutuk' 
insert into TblKitap2 values ('sevgi neredeyse tanr� oradad�r','hikaye','ggg','sar�')

--g�ncelleme i�lemi yap�ld�ktan sonra bu uyar�y� versin
use Kitaplik
create trigger guncelleme
on TblKitap2
after update
as
begin
select 'Guncelleme i�lemi ger�ekle�ti'
end

update TblKitap2 set kitapad='nutuk' where kitapad='m�fettis'

--update i�lemi yap�l�nca sayac� artt�rs�n
create trigger SayacGuncelle
on TblKitap2
after update
as
begin
update TblGuncelleme set sayac=sayac+1
end

update TblKitap2 set kitaprenk='turuncu' where kitaprenk='ye�il'

--silme i�lemi ger�ekle�ti�i anda �unu yazs�n (tetiklesin)
create trigger SilmeKontrol
on TblKitap2
after delete
as
begin
select 'Kay�t tablodan silindi'
end

delete from TblKitap2 where kitaptur='roman'


--g�ncelleme tablosunda sayac� 1 azalts�n
--kitap iki tablosunda silme i�lemi yapt�ktan sonra 

create trigger SilmeKontrol2
on TblKitap2
after delete
as
begin
update TblGuncelleme set sayac=sayac-1
end

delete from TblKitap2 where kitapozet='sfsdf'

--instead of tetikleyiciler
--tetikleyiciler ile birlikte kullan�lan kontrol ama�l� kullan�lan sql komutudur
--acaba i�lemi yap�yor mu gibi.
--kontrol ama�l�d�r instead of kullan�l�r.
create trigger insdeneme
on TblKitap2
instead of insert
as
begin
select 'Ekleme i�leminde sorun yok'
end

insert into TblKitap2 values ('Palto','Hikaye','vvv','Gri')
--ekleme i�lemini ger�ekle�tirmez komutlar� yazar
 
 --(update yerine)
create trigger insdeneme2
on TblKitap2
instead of update
as 
begin
select 'Kay�t g�ncellenebilir'
end

update TblKitap2 set kitapad='bbbbb' where kitapad='sevgi neredeyse tanr� oradad�r'

--silme yerine
create trigger insdeneme3
on TblKitap2
instead of delete
as
begin
select 'Kay�t silinebilir'
end

delete from TblKitap2 where kitapad='bbbbb'
