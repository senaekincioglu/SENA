-- 1- Speedy Expres ile ta��nm�� Nancy'nin alm�� oldu�u, pazartesi g�nleri Dumon ya da Alfki ID'li m��teriler taraf�ndan verilmi� olan 
--sipari�ler.

go
create view Siparisler
as
select O.OrderID,O.OrderDate,S.CompanyName,e.FirstName,c.CustomerID from Orders o 
inner join Customers c on o.CustomerID=c.CustomerID
inner join Employees e on e.EmployeeID=o.EmployeeID
inner join Shippers s on s.ShipperID=o.ShipVia
where e.FirstName='Nancy' and DATENAME(WEEKDAY,OrderDate)='Monday' and s.CompanyName='Speedy Express' and c.CustomerID in ('ALFKI','DUMON')
GO
select * from Siparisler
