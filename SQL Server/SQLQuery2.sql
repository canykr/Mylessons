--�L��K� T�RLER�

--1. Bir'e bir ili�ki
----�li�kili tablolarda bir biriyle ili�kili maksimum birer sat�r olur.

--1. Tablo = ��renciler
----��renci Id, Ad�, Soyad�, Telefon, Email

--2. Tablo = �zl�k Bilgileri
----�zl�k Id, ��renci Id, Tc kimlik No, Do�um tarihi, Do�um Yeri, Anne Ad�, Baba Ad�

--2. Bir'e �ok ili�ki
--3.Tablo = Veliler
----Velid, ��renci Id, VeliTipi, Ad� Soyad�, �� Adresi, Telefon

--3. �ok'a �ok ili�ki
--4.Tablo = ��retmenler
----��retmen Id, Ad� Soyad�, Bran�

--5.Tablo = Dersler
----Ders Id, Ders Ad�

--6.Tablo ��retmenDers
----Id, ��retmen Id, Ders Id

select Country, City from dbo.Customers group by Country, City
select Country, City from dbo.Customers group by Country, City order by Country, City

--Kullan�m S�ras�
--from  Hangi tablonun kullan�laca��n� belirtir.
--join'ler  Birden fazla tabloyu birle�tirmek i�in kullan�l�r.
--where  Verileri belirli ko�ullara g�re filtrelemek i�in kullan�l�r.
--group by Sorgu sonu�lar�n� belirli s�tunlara g�re grupland�rmak i�in kullan�l�r.
--order by  Sorgu sonu�lar�n� belirli bir s�raya g�re s�ralamak i�in kullan�l�r.

select Country, COUNT(Country) as [Kay�t Say�s�] from dbo.Customers group by Country

select c.CategoryID, c.CategoryName, COUNT(p.CategoryID) as [�r�n Say�s�]
from dbo.Categories as c
inner join dbo.Products as p on p.CategoryID = c.CategoryID
where c.CategoryName like 'C%' and p.ProductName like 'G%'
group by c.CategoryID, c.CategoryName

select SUM(UnitsInStock) from dbo.Products Where CategoryID =5

--Hangi �lkeye ka� paral�k sat�� yap�lm��t�r.
select c.Country, SUM(s.UnitPrice * s.Quantity ) as [Sat�� Tutar�] from dbo.Customers c inner join dbo.Orders o on c.CustomerID =o.CustomerID
inner join dbo.OrderDetails s on o.OrderID=s.OrderID group by c.Country  

--en az tutar sipari� veren m��teriyi d�nen sql c�mlesini yaz�n�z.

Select o.CustomerID, SUM(s.UnitPrice * s.Quantity) as ToplamSatis From Orders o INNER JOIN OrderDetails s on o.OrderID = s.OrderID 
INNER JOIN Customers c on o.CustomerID = c.CustomerID Group By o.CustomerID Order By ToplamSatis asc


Select TOP 1 o.CustomerID,c.CompanyName,c.ContactName, SUM(s.UnitPrice * s.Quantity) as ToplamSatis From Orders o INNER JOIN OrderDetails s on o.OrderID = s.OrderID 
INNER JOIN Customers c on o.CustomerID = c.CustomerID Group By o.CustomerID,c.CompanyName,c.ContactName Order By ToplamSatis asc





 

