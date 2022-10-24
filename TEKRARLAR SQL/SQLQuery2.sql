-- 
select * from TblKisiler
--her meslekte ne kadar kiþi varsa saysýn ve yazdýrsýn.
select meslek ,count (ad) as 'personel sayýsý 'from TblKisiler group by meslek
--her þehirden kaç kiþi olduðunu getir.
select sehir,count (ad) as 'sayý'from TblKisiler group by sehir order by sehir asc
--bir meslek grubuna mensup kiþi sayýsýný ve o kiþilerin toplam ne kadar maaþ aldýklarýný yaz
select meslek,count (ad) as 'kiþi sayýsý',sum (maas)  as 'toplam maas' from TblKisiler group by meslek
--her bir meslek grubuna ait personelin ortalama ne kadar maaþ aldýklarýný göster.

select meslek,count (ad) as 'kiþi sayýsý',avg (maas) as 'ortalama maaþ' from TblKisiler
group by meslek

select meslek,max(maas) as 'en yüksek maas',min(maas) as 'minimum maas' from TblKisiler group by meslek

