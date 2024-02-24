-- sub query
-- Sipari� detaylar�ndan, Finlandiya'ya g�nderilen sipari�lerin toplam sat�� tutar�n� hesaplayan bir alt sorgu kullan�l�yor.
select SUM(od.UnitPrice * od.Quantity)
from dbo.OrderDetails as od
where od.OrderID in (select o.OrderID from dbo.Orders as o where o.ShipCountry='Finland')

-- Finlandiya'ya g�nderilen sipari�lerin sipari� ID'lerini getiren sorgu.
select o.OrderID from dbo.Orders as o where o.ShipCountry='Finland'

-- Kategori Ad�, �r�n say�s�
-- Kategori ve �r�n say�s�n� hesaplamak i�in alt sorgu kullan�lacak.

select c.*,(select COUNT(p.ProductID) FROM dbo.Products p where p.CategoryID=c.CategoryID) as [Toplam �r�n Say�s�] from dbo.Categories as c

--Kategori Ad�,�r�n Say�s�,ka� paral�k sat�� yap�lm��
select c.*,(select COUNT(p.ProductID) FROM dbo.Products p where p.CategoryID=c.CategoryID) as [Toplam �r�n Say�s�],
(select SUM(od.UnitPrice * od.Quantity) from dbo.OrderDetails as od 
inner join dbo.Products as p on p.ProductID=od.ProductID
where p.CategoryID=c.CategoryID) as [Toplam Sat�� Tutar�]

from dbo.Categories c



