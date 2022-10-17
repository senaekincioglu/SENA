--Öğrenci tablosunu listele
select * from TBL_Ogrenci

--Öğrencilerin ad ve soyadlarıyla birlikte doğum yerini de raporlayınız.
select adi, soyadi, dyeri from TBL_Ogrenci

--bölüm tablosunda bilgisayar mühendisliği okuyanları listele.
select b.aciklama,b.aciklama from TBL_Bolum b

--Bölümü Elektrik mühensliği olanları listele
select * from TBL_Bolum 
select b.aciklama,b.badi from TBL_Bolum b where aciklama='Elektronik Mühendisliği Bölümü'

--İstanbulda doğan personellerin adını soyadını birleştirerek ad soyad kolonu oluştur
select * from TBL_Ogrenci
select ogr.adi+''+ogr.soyadi as 'adsoyad',ogr.dyeri from TBL_Ogrenci ogr where dyeri='İstanbul'

--Ders ıd si 7 olmayan derslerin ders kodunu ve kredilerini gösterin
select * from TBL_Ders
select d.dkodu,d.kredi,d.did from TBL_Ders d where did!='7'

--Öğretmen tablosunda Ogretmen Id si 2 veya 3 olan  ıd lerin doğum yerini listeleyin listeleyin
select * from TBL_Ogretmen
select ogr.dyeri from TBL_Ogretmen ogr where oid =2 or oid= 3 

--öğrenci no 8 den küçük soyadı ekincioğlu olan öğrencilerin adlarını raporlayın ancak isimler tablosu şu formatta olacak mesela sena ekincioğlu 
--ise s.ekincioğlu

select * from TBL_Ogrenci
select LEFT (ogr.adi,1)+'.'+ ogr.soyadi  as'AdSoyad',ogr.adi,ogr.soyadi from TBL_Ogrenci ogr where ono<8

--Sınava girmemiş öğrencilerin notlarını listeleyin
Select * from TBL_OgrenciDers WHERE [Not] Is not NULL

--Sadece 1 , 2 , 7  Idleri içermeyen ürünleri gösterin

SELECT * FROM TBL_OgrenciDers WHERE [not] not In (68,57,7,12,4,8)

--ders tablosunda bölüm ıd , ders adı ve ders kredisi gelsin ama bölüm ıdye göre sıralı gelsin TERSTEN
 select drs.bid, drs.dadi , drs.kredi FROM tbl_ders drs ORDER BY dadi DESC 

-- Notu 30 ile 70 arasında notları olan öğrencilerin Idlerini listeleyin
 select * from TBL_OgrenciDers where [Not] BETWEEN '30' AND '70' order by [Not] desc

 --DoğumYeri Gümüşhane olan ve adı Ö ile soyadının başlayıp sonu E ile biten öğrenciler
SELECT * FROM TBL_Ogrenci WHERE adi LIKE 'Ö%' AND soyadi LIKE '%Y' AND dyeri = 'Gümüşhane'

