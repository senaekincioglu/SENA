select * from TBL_Kitap
--Kitap tablosunda kitap yay�n evi g�ne� olan ve kitap fiyat� 8 den b�y�k olan t�m verileri listeleyin.
select * from TBL_Kitap where KitapYay�nEvi='G�ne�' and KitapFiyat>8
select * from TBL_Kitap where KitapYay�nEvi='Merk�r' and KitapFiyat>8
select * from TBL_Kitap where KitapYay�nEvi='Merk�r'
select * from TBL_Kitap where KitapYay�nEvi='Merk�r' and KitapFiyat<=4
--Kitap sayfa say�s� 200 den b�y�k olan veya Kitap fiyat� 12 den b��yk olan t�m verileri listele
select * from TBL_Kitap where KitapSayfa>200 or KitapFiyat>12
--Kitap sayfa say�s� 200  ve 200den b�y�k olan veya Kitap fiyat� 12 den b�y�k olan ya da kitap yazar� Gogol olan t�m verileri listele
select * from TBL_Kitap Where KitapSayfa>=200 or KitapFiyat>12 or KitapYazar='Gogol'
--kitap sayfa say�s� 200, 300, 220, 80 olanlar� liste.e
select * from TBL_Kitap where KitapSayfa in (200,300,220,80)
--kitap ad� i�erisinde a harfi olan b�t�n verileri listeleyin.
select * from TBL_Kitap where KitapAd like'%a%' and KitapSayfa in (75,100,200,300) and KitapFiyat>10
--kitap tablosu i�inde kitap ad� b ile ba�layan t�m verileri listeleyin.
select * from TBL_Kitap where KitapAd like 'b%'
--kitap ad� � ile biten t�m verileri listeleyin.
select * from TBL_Kitap where KitapAd like '%�'