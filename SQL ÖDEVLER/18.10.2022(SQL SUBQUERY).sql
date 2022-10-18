-- 1- Hangi müþteri kaç kere alýþveriþ yapmýþtýr. (ÖDEV)
select CustomerID, COUNT(*) as 'TOPLAM' from Orders GROUP BY CustomerID 

-- 2- Hangi tedarikçi hangi kategorideki üründen kaç dolarlýk ürünü mevcuttur. (ÖDEV)
select CategoryID,COUNT(SupplierID) as 'Tedarikçi',SUM(UnitPrice*UnitsInStock) as 'Toplam' 
from Products GROUP BY CategoryID ORDER BY Toplam desc
 
-- 3- Ürünlerle birlikte ürünün satýþ adetini listeleyen sorgu (SUM, OrdersDetails, Products)
select *,(select COUNT(Quantity) from [Order Details] o where p.ProductID= o.ProductID ) as 'Satýþ Adet' from Products p order by 'Satýþ Adet' asc	

-- 4- Hangi satýþtan kaç adet ürün satýlmýþýr. (COUNT, Orders, OrderDetails)
select COUNT(o.ProductID) as 'ÜrünID',COUNT(OrderID) as 'SipariþID' from [Order Details] o group by OrderID

-- 5- 'VINET' id'li müþterinin satýþlarýný listeleyiniz. (Orders, OrderDetails) 
select * ,(select o.CustomerID from Orders o where p.OrderID = o.OrderID and o.CustomerID = 'VINET')
from [Order Details] p where OrderID in ((select o.OrderID from Orders o where o.CustomerID = 'VINET' ))

-- 6- 3 numaralý ürünün satýþ yapýldýðý müþterilerin id'lerini listeleyiniz. (OrderDetails, Orders)
select *,(select o.ProductID from [Order Details] o where p.OrderID = o.OrderID and ProductID = 3 ) 
as ProductId from Orders p where p.OrderID in ((select OrderID from [Order Details] where ProductID = 3))