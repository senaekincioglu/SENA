select * from TBL_Kitap
--Kitap tablosunda kitap yayýn evi güneþ olan ve kitap fiyatý 8 den büyük olan tüm verileri listeleyin.
select * from TBL_Kitap where KitapYayýnEvi='Güneþ' and KitapFiyat>8
select * from TBL_Kitap where KitapYayýnEvi='Merkür' and KitapFiyat>8
select * from TBL_Kitap where KitapYayýnEvi='Merkür'
select * from TBL_Kitap where KitapYayýnEvi='Merkür' and KitapFiyat<=4
--Kitap sayfa sayýsý 200 den büyük olan veya Kitap fiyatý 12 den büüyk olan tüm verileri listele
select * from TBL_Kitap where KitapSayfa>200 or KitapFiyat>12
--Kitap sayfa sayýsý 200  ve 200den büyük olan veya Kitap fiyatý 12 den büyük olan ya da kitap yazarý Gogol olan tüm verileri listele
select * from TBL_Kitap Where KitapSayfa>=200 or KitapFiyat>12 or KitapYazar='Gogol'
--kitap sayfa sayýsý 200, 300, 220, 80 olanlarý liste.e
select * from TBL_Kitap where KitapSayfa in (200,300,220,80)
--kitap adý içerisinde a harfi olan bütün verileri listeleyin.
select * from TBL_Kitap where KitapAd like'%a%' and KitapSayfa in (75,100,200,300) and KitapFiyat>10
--kitap tablosu içinde kitap adý b ile baþlayan tüm verileri listeleyin.
select * from TBL_Kitap where KitapAd like 'b%'
--kitap adý þ ile biten tüm verileri listeleyin.
select * from TBL_Kitap where KitapAd like '%þ'