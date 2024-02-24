SELECT*
FROM dbo.Categories
-- dbo.Categories tablosundaki t�m kolonlar� ve sat�rlar� listeler

select CategoryID, CategoryName
from dbo.Categories
--dbo.Categories tablosundaki CategoryID, CategoryName kolonlar�na ait t�m sat�rlar� listeler

select [CustomerID], [ShipCountry]
from [dbo].[Orders]

--select [Ad� Soyad�], adres from dbo.[m��teri tablosu]

select *
from Northwind2.dbo.Employees
select*
from [Northwind2].[dbo].[Employees]

select FirstName as [Ad�], LastName as [Soyad� ..]
from dbo.Employees

--TOP komutu ile istedi�imiz say�daki ilk kay�tlar� getirebiliriz.
select top 3
    *
from dbo.Employees
select top 3
    FirstName, LastName
from dbo.Employees
SELECT TOP(3)
    *
from dbo.Employees

-- select c�mlesindeki tabloya as keyword'� ile k�sa takma adlar verilebilir.
select c.CompanyName, c.Country
from dbo.Customers as c

-- distinc komutu ile yinelenen sat�rlar� kald�rarak liste alabiliriz.
select distinct Country
from dbo.Customers

--where keyword'� ile tablo i�indeki verilerde filtreleme yapabiliriz
--�lkesi Germany olan t�m m��terileri listeler
select *
from dbo.Customers
where Country='Germany'
select *
from dbo.Categories
where CategoryID =5
select *
from dbo.Categories
where CategoryID = '5'

--�lkesi Germany olmayan t�m m��terileri listeler
select *
from dbo.Customers
where Country<>'Germany'
select *
from dbo.Categories
where CategoryID<>5

select *
from dbo.Customers
where Country='Germany' and Country='France'
select *
from dbo.Customers
where Country='Germany' or Country='France'
select *
from dbo.Customers
where Country='Mexico' and City='Mexico D.F.'

select *
from dbo.Customers
where Country='Mexico' and City='Mexico D.F.'and (PostalCode='05021' or PostalCode='05022')

--Region kolonu NULL olan kay�tlar� listeler
select *
from dbo.Customers
where Region is null

--Region kolonu NULL olmayyan kolonlar� listeler
select *
from dbo.Customers
where Region is not null

select *
from dbo.Customers
where Region is null or Region=''

select *
from dbo.OrderDetails
where UnitPrice > 50
select *
from dbo.OrderDetails
where UnitPrice < 50
select *
from dbo.OrderDetails
where UnitPrice >= 50
select *
from dbo.OrderDetails
where UnitPrice <= 50
select *
from dbo.OrderDetails
where UnitPrice > 50 and UnitPrice<60

--Sipari� detaylar�nda indirim yapllan kay�tlar� listeleyeyn sql c�mlecigini yaz.
select *
from OrderDetails
where Discount>0

select *
from dbo.Employees
where BirthDate is null
select *
from dbo.Employees
where BirthDate is not null
select *
from dbo.Employees
where BirthDate = '19520219'
select *
from dbo.Employees
where BirthDate > '19520219'
select *
from dbo.Employees
where BirthDate > '1955-03-04 00:00:00.000'
select *
from dbo.Employees
where BirthDate > '1955-03-04'
select *
from dbo.Employees
where BirthDate > '01.30.1955'
--ay-g�n-y�l �eklinde yaz�l�rsa kabul eder.

--like (x) ile biten,(x) ile ba�layan i�inde (x) ge�en gibi filtreler uygulamak i�in kullan�l�r.
select *
from Employees
where [Address] like '7%'
-- 7 ile ba�layan kay�tlar� listeler.
select *
from Employees
where [Address] like '%d.'-- d. ile biten kay�tlar� listeler.
select *
from Employees
where [Address] like '%Ave%'
-- i�inde Ave kelimesi ge�en kay�tlar� listeler.
select *
from Employees
where [Address] like '%e%'-- i�inde e harfi ge�en kay�tlar� listeler.


--
select *
from dbo.Customers
where Country='Germany' or Country = 'France'
-- in komutu ile de�eri i�eren kay�tlar� listeler.
select *
from dbo.Customers
where Country in ('Germany','France')
select *
from dbo.OrderDetails
where Quantity in (4,8)

--between komutu iki de�er aras�ndaki kay�tlar� listeler
select *
from dbo.OrderDetails
where Quantity>=4 and Quantity<=10
select *
from dbo.OrderDetails
where Quantity between 4 and 10

select ProductName as [�r�n Ad�], (UnitPrice * UnitsInStock) as [Tutar]
from dbo.Products
select FirstName, LastName, FirstName + ' '+ LastName
from dbo.Employees
select FirstName, LastName, FirstName + 5 as [Ad� Soyad�]
from dbo.Employees
--art� operat�r� e�er sol ve sa�da ayn� tipte veri yoksa hata verir.

select *
from dbo.Customers
order by CompanyName
select *
from dbo.Customers
order by CompanyName asc
select *
from dbo.Customers
order by CompanyName desc

select *
from dbo.Customers
where Country='Germany'
order by CompanyName
select *
from dbo.Customers
where Country='Germany'
order by CompanyName,ContactName
select *
from dbo.Customers
order by Country,City desc

--sipari�in �r�n �dsi,�r�m birim fiyat�,miktar� ve tutar� alanlar�n� bana d�nen sql c�mlecigini yaz�n�z.
-- select ProductID as [�r�n Kodu], UnitPrice as [Birim Fiyat], Quantity as [Miktar], Unitprice * Quantity as [Tutar] from bdo.OrderDetails order by (UnitPrice * Quantity)desc 

SELECT ProductID, ProductName, UnitPrice, UnitsInStock, (UnitPrice * UnitsInStock) AS TotalValue
FROM Products;