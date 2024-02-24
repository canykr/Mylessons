--ÝLÝÞKÝ TÜRLERÝ

--1. Bir'e bir iliþki
----Ýliþkili tablolarda bir biriyle iliþkili maksimum birer satýr olur.

--1. Tablo = Öðrenciler
----Öðrenci Id, Adý, Soyadý, Telefon, Email

--2. Tablo = Özlük Bilgileri
----Özlük Id, Öðrenci Id, Tc kimlik No, Doðum tarihi, Doðum Yeri, Anne Adý, Baba Adý

--2. Bir'e çok iliþki
--3.Tablo = Veliler
----Velid, Öðrenci Id, VeliTipi, Adý Soyadý, Ýþ Adresi, Telefon

--3. Çok'a çok iliþki
--4.Tablo = Öðretmenler
----Öðretmen Id, Adý Soyadý, Branþ

--5.Tablo = Dersler
----Ders Id, Ders Adý

--6.Tablo ÖðretmenDers
----Id, Öðretmen Id, Ders Id

select Country, City from dbo.Customers group by Country, City
select Country, City from dbo.Customers group by Country, City order by Country, City

--Kullaným Sýrasý
--from  Hangi tablonun kullanýlacaðýný belirtir.
--join'ler  Birden fazla tabloyu birleþtirmek için kullanýlýr.
--where  Verileri belirli koþullara göre filtrelemek için kullanýlýr.
--group by Sorgu sonuçlarýný belirli sütunlara göre gruplandýrmak için kullanýlýr.
--order by  Sorgu sonuçlarýný belirli bir sýraya göre sýralamak için kullanýlýr.

select Country, COUNT(Country) as [Kayýt Sayýsý] from dbo.Customers group by Country

select c.CategoryID, c.CategoryName, COUNT(p.CategoryID) as [Ürün Sayýsý]
from dbo.Categories as c
inner join dbo.Products as p on p.CategoryID = c.CategoryID
where c.CategoryName like 'C%' and p.ProductName like 'G%'
group by c.CategoryID, c.CategoryName

select SUM(UnitsInStock) from dbo.Products Where CategoryID =5

--Hangi ülkeye kaç paralýk satýþ yapýlmýþtýr.
select c.Country, SUM(s.UnitPrice * s.Quantity ) as [Satýþ Tutarý] from dbo.Customers c inner join dbo.Orders o on c.CustomerID =o.CustomerID
inner join dbo.OrderDetails s on o.OrderID=s.OrderID group by c.Country  

--en az tutar sipariþ veren müþteriyi dönen sql cümlesini yazýnýz.

Select o.CustomerID, SUM(s.UnitPrice * s.Quantity) as ToplamSatis From Orders o INNER JOIN OrderDetails s on o.OrderID = s.OrderID 
INNER JOIN Customers c on o.CustomerID = c.CustomerID Group By o.CustomerID Order By ToplamSatis asc


Select TOP 1 o.CustomerID,c.CompanyName,c.ContactName, SUM(s.UnitPrice * s.Quantity) as ToplamSatis From Orders o INNER JOIN OrderDetails s on o.OrderID = s.OrderID 
INNER JOIN Customers c on o.CustomerID = c.CustomerID Group By o.CustomerID,c.CompanyName,c.ContactName Order By ToplamSatis asc





 

