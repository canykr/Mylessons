-- sub query
-- Sipariþ detaylarýndan, Finlandiya'ya gönderilen sipariþlerin toplam satýþ tutarýný hesaplayan bir alt sorgu kullanýlýyor.
select SUM(od.UnitPrice * od.Quantity)
from dbo.OrderDetails as od
where od.OrderID in (select o.OrderID from dbo.Orders as o where o.ShipCountry='Finland')

-- Finlandiya'ya gönderilen sipariþlerin sipariþ ID'lerini getiren sorgu.
select o.OrderID from dbo.Orders as o where o.ShipCountry='Finland'

-- Kategori Adý, ürün sayýsý
-- Kategori ve ürün sayýsýný hesaplamak için alt sorgu kullanýlacak.

select c.*,(select COUNT(p.ProductID) FROM dbo.Products p where p.CategoryID=c.CategoryID) as [Toplam Ürün Sayýsý] from dbo.Categories as c

--Kategori Adý,Ürün Sayýsý,kaç paralýk satýþ yapýlmýþ
select c.*,(select COUNT(p.ProductID) FROM dbo.Products p where p.CategoryID=c.CategoryID) as [Toplam Ürün Sayýsý],
(select SUM(od.UnitPrice * od.Quantity) from dbo.OrderDetails as od 
inner join dbo.Products as p on p.ProductID=od.ProductID
where p.CategoryID=c.CategoryID) as [Toplam Satýþ Tutarý]

from dbo.Categories c



