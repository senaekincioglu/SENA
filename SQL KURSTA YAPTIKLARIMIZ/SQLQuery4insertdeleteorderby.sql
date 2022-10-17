select * from TBL_Kitap
insert into TBL_Kitap values (20,'�nsan ne ile ya�ar','Tolstoy',110,5,'2016-08-12','MaviBulut')
--kitap no, kitap ad, kitap sayfa, kitap yay�nevi girilecek kitap sayfas� bilinmiyor mesela
--bunun i�in kullan�m : insert into tabload�(alanlar)values (veriler)
insert into TBL_Kitap (KitapNo,KitapAd,KitapSayfa,KitapYay�nEvi) values (21,'Su� ve ceza',1250,'2016-07-19','Merk�r')
update TBL_Kitap set KitapAd='beyaz gemiler' where KitapAd	='Beyaz Di�'
--Kitap fiyat� 5 lira alt�nda olan kitaplar�n fiyat�n� 5 yap.
update TBL_Kitap set KitapFiyat=5 where KitapFiyat<5
--kitap no 8 olan verileri sil
delete from TBL_Kitap where KitapNo=8
--kitap tablosunda kitap sayfa say�s� 220 den b�y�k olan veya kitapfiyat� 10 dan b�y�k olanlar� sil
delete from TBL_Kitap where KitapSayfa>220 or KitapFiyat>10
insert into TBL_Kitap values (5,'Siyah Lale','Alexander Duman',220,7,'2015-05-05','J�piter')
--tabloda tekrar eden lay�tlar�n gelmesini istemiyorsan disticrt kullan�l�r
select distinct KitapAd from TBL_Kitap
--S�ralama i�lemi order by ile yap�l�r.
--Kitap ad�n� s�rala k���kten b�y��e
select * from TBL_Kitap order by KitapAd asc
--Kitap yazar� s�rala b�y�kten k����e
select * from TBL_Kitap order by KitapYazar desc

