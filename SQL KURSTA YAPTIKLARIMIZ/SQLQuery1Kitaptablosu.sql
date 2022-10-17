--Kitap tablosuna ait tüm verileri listele.
select * from TBL_Kitap 
--Kitap adý palto olan tüm verileri listele.
select * from TBL_Kitap where KitapAd='Palto'
--Kitap adý Toros Canavarý olan tüm verileri listele.
select * from TBL_Kitap WHERE KitapAd='Toros Canavarý'
--Kitap sayfa sayýsý 150 den büyük olan tüm verileri listeleyin.
select * from TBL_Kitap Where KitapSayfa>150
--Kitap sayfa sayýsý 150 den küçük olan tüm verileri listeleyin
select * from TBL_Kitap Where KitapSayfa<150
--Kitap Yazarý reþat nuri güntekin olan tüm verileri listeleyin.