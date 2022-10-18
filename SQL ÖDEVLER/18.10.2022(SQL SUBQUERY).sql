-- 1- Hangi m��teri ka� kere al��veri� yapm��t�r. (�DEV)
select CustomerID, COUNT(*) as 'TOPLAM' from Orders GROUP BY CustomerID 

-- 2- Hangi tedarik�i hangi kategorideki �r�nden ka� dolarl�k �r�n� mevcuttur. (�DEV)
select CategoryID,COUNT(SupplierID) as 'Tedarik�i',SUM(UnitPrice*UnitsInStock) as 'Toplam' 
from Products GROUP BY CategoryID ORDER BY Toplam desc
 
-- 3- �r�nlerle birlikte �r�n�n sat�� adetini listeleyen sorgu (SUM, OrdersDetails, Products)
select *,(select COUNT(Quantity) from [Order Details] o where p.ProductID= o.ProductID ) as 'Sat�� Adet' from Products p order by 'Sat�� Adet' asc	

-- 4- Hangi sat��tan ka� adet �r�n sat�lm���r. (COUNT, Orders, OrderDetails)
select COUNT(o.ProductID) as '�r�nID',COUNT(OrderID) as 'Sipari�ID' from [Order Details] o group by OrderID

-- 5- 'VINET' id'li m��terinin sat��lar�n� listeleyiniz. (Orders, OrderDetails) 
select * ,(select o.CustomerID from Orders o where p.OrderID = o.OrderID and o.CustomerID = 'VINET')
from [Order Details] p where OrderID in ((select o.OrderID from Orders o where o.CustomerID = 'VINET' ))

-- 6- 3 numaral� �r�n�n sat�� yap�ld��� m��terilerin id'lerini listeleyiniz. (OrderDetails, Orders)
select *,(select o.ProductID from [Order Details] o where p.OrderID = o.OrderID and ProductID = 3 ) 
as ProductId from Orders p where p.OrderID in ((select OrderID from [Order Details] where ProductID = 3))