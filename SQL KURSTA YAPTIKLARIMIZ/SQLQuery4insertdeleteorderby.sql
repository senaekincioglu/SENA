select * from TBL_Kitap
insert into TBL_Kitap values (20,'Ýnsan ne ile yaþar','Tolstoy',110,5,'2016-08-12','MaviBulut')
--kitap no, kitap ad, kitap sayfa, kitap yayýnevi girilecek kitap sayfasý bilinmiyor mesela
--bunun için kullaným : insert into tabloadý(alanlar)values (veriler)
insert into TBL_Kitap (KitapNo,KitapAd,KitapSayfa,KitapYayýnEvi) values (21,'Suç ve ceza',1250,'2016-07-19','Merkür')
update TBL_Kitap set KitapAd='beyaz gemiler' where KitapAd	='Beyaz Diþ'
--Kitap fiyatý 5 lira altýnda olan kitaplarýn fiyatýný 5 yap.
update TBL_Kitap set KitapFiyat=5 where KitapFiyat<5
--kitap no 8 olan verileri sil
delete from TBL_Kitap where KitapNo=8
--kitap tablosunda kitap sayfa sayýsý 220 den büyük olan veya kitapfiyatý 10 dan büyük olanlarý sil
delete from TBL_Kitap where KitapSayfa>220 or KitapFiyat>10
insert into TBL_Kitap values (5,'Siyah Lale','Alexander Duman',220,7,'2015-05-05','Jüpiter')
--tabloda tekrar eden layýtlarýn gelmesini istemiyorsan disticrt kullanýlýr
select distinct KitapAd from TBL_Kitap
--Sýralama iþlemi order by ile yapýlýr.
--Kitap adýný sýrala küçükten büyüðe
select * from TBL_Kitap order by KitapAd asc
--Kitap yazarý sýrala büyükten küçüðe
select * from TBL_Kitap order by KitapYazar desc

