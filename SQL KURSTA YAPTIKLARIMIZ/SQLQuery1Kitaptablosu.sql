--Kitap tablosuna ait t�m verileri listele.
select * from TBL_Kitap 
--Kitap ad� palto olan t�m verileri listele.
select * from TBL_Kitap where KitapAd='Palto'
--Kitap ad� Toros Canavar� olan t�m verileri listele.
select * from TBL_Kitap WHERE KitapAd='Toros Canavar�'
--Kitap sayfa say�s� 150 den b�y�k olan t�m verileri listeleyin.
select * from TBL_Kitap Where KitapSayfa>150
--Kitap sayfa say�s� 150 den k���k olan t�m verileri listeleyin
select * from TBL_Kitap Where KitapSayfa<150
--Kitap Yazar� re�at nuri g�ntekin olan t�m verileri listeleyin.