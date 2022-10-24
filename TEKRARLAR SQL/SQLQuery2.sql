-- 
select * from TblKisiler
--her meslekte ne kadar ki�i varsa says�n ve yazd�rs�n.
select meslek ,count (ad) as 'personel say�s� 'from TblKisiler group by meslek
--her �ehirden ka� ki�i oldu�unu getir.
select sehir,count (ad) as 'say�'from TblKisiler group by sehir order by sehir asc
--bir meslek grubuna mensup ki�i say�s�n� ve o ki�ilerin toplam ne kadar maa� ald�klar�n� yaz
select meslek,count (ad) as 'ki�i say�s�',sum (maas)  as 'toplam maas' from TblKisiler group by meslek
--her bir meslek grubuna ait personelin ortalama ne kadar maa� ald�klar�n� g�ster.

select meslek,count (ad) as 'ki�i say�s�',avg (maas) as 'ortalama maa�' from TblKisiler
group by meslek

select meslek,max(maas) as 'en y�ksek maas',min(maas) as 'minimum maas' from TblKisiler group by meslek

