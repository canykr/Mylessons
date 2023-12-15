SELECT*FROM dbo.Categories
-- dbo.Categories tablosundaki tüm kolonlarý ve satýrlarý listeler

select CategoryID,CategoryName from dbo.Categories
--dbo.Categories tablosundaki CategoryID, CategoryName kolonlarýna ait tüm satýrlarý listeler

select [CustomerID],[ShipCountry] from [dbo].[Orders]

--select [Adý Soyadý], adres from dbo.[müþteri tablosu]

select * from Northwind2.dbo.Employees
select*from [Northwind2].[dbo].[Employees]
  
select FirstName as [Adý], LastName as [Soyadý ..] from dbo.Employees

--TOP komutu ile istediðimiz sayýdaki ilk kayýtlarý getirebiliriz.
select top 3* from dbo.Employees
select top 3 FirstName,LastName from dbo.Employees
SELECT TOP(3) * from dbo.Employees

-- select cümlesindeki tabloya as keyword'ü ile kýsa takma adlar verilebilir.
select c.CompanyName, c.Country from dbo.Customers as c

-- distinc komutu ile yinelenen satýrlarý kaldýrarak liste alabiliriz.
select distinct Country from dbo.Customers

--where keyword'ü ile tablo içindeki verilerde filtreleme yapabiliriz
--ülkesi Germany olan tüm müþterileri listeler
select * from dbo.Customers where Country='Germany'
select * from dbo.Categories where CategoryID =5
select * from dbo.Categories where CategoryID = '5'

--ülkesi Germany olmayan tüm müþterileri listeler
select * from dbo.Customers where Country<>'Germany'
select * from dbo.Categories where CategoryID<>5

select * from dbo.Customers where Country='Germany' and Country='France'
select * from dbo.Customers where Country='Germany' or Country='France'
select * from dbo.Customers where Country='Mexico' and City='Mexico D.F.'

select * from dbo.Customers where Country='Mexico' and City='Mexico D.F.'and (PostalCode='05021' or PostalCode='05022')

--Region kolonu NULL olan kayýtlarý listeler
select * from dbo.Customers where Region is null

--Region kolonu NULL olmayyan kolonlarý listeler
select * from dbo.Customers where Region is not null

select * from dbo.Customers where Region is null or Region=''

select * from dbo.OrderDetails where UnitPrice > 50
select * from dbo.OrderDetails where UnitPrice < 50
select * from dbo.OrderDetails where UnitPrice >= 50
select * from dbo.OrderDetails where UnitPrice <= 50
select * from dbo.OrderDetails where UnitPrice > 50 and UnitPrice<60

--Sipariþ detaylarýnda indirim yapllan kayýtlarý listeleyeyn sql cümlecigini yaz.
select * from OrderDetails where Discount>0

select * from dbo.Employees where BirthDate is null
select * from dbo.Employees where BirthDate is not null
select * from dbo.Employees where BirthDate = '19520219'
select * from dbo.Employees where BirthDate > '19520219'
select * from dbo.Employees where BirthDate > '1955-03-04 00:00:00.000'
select * from dbo.Employees where BirthDate > '1955-03-04'
select * from dbo.Employees where BirthDate > '01.30.1955' --ay-gün-yýl þeklinde yazýlýrsa kabul eder.

--like (x) ile biten,(x) ile baþlayan içinde (x) geçen gibi filtreler uygulamak için kullanýlýr.
select * from Employees where [Address] like '7%' -- 7 ile baþlayan kayýtlarý listeler.
select * from Employees where [Address] like '%d.'-- d. ile biten kayýtlarý listeler.
select * from Employees where [Address] like '%Ave%' -- içinde Ave kelimesi geçen kayýtlarý listeler.
select * from Employees where [Address] like '%e%'-- içinde e harfi geçen kayýtlarý listeler.


--
select * from dbo.Customers where Country='Germany' or Country = 'France'
-- in komutu ile deðeri içeren kayýtlarý listeler.
select * from dbo.Customers where Country in ('Germany','France')
select * from dbo.OrderDetails where Quantity in (4,8)

--between komutu iki deðer arasýndaki kayýtlarý listeler
select * from dbo.OrderDetails where Quantity>=4 and Quantity<=10
select * from dbo.OrderDetails where Quantity between 4 and 10

select ProductName as [Ürün Adý], (UnitPrice * UnitsInStock) as [Tutar] from dbo.Products
select FirstName,LastName,FirstName + ' '+ LastName from dbo.Employees
select FirstName,LastName,FirstName + 5 as [Adý Soyadý] from dbo.Employees --artý operatörü eðer sol ve saðda ayný tipte veri yoksa hata verir.

select * from dbo.Customers order by CompanyName
select * from dbo.Customers order by CompanyName asc
select * from dbo.Customers order by CompanyName desc

select * from dbo.Customers where Country='Germany' order by CompanyName
select * from dbo.Customers where Country='Germany' order by CompanyName,ContactName
select * from dbo.Customers order by Country,City desc

--sipariþin ürün ýdsi,ürüm birim fiyatý,miktarý ve tutarý alanlarýný bana dönen sql cümlecigini yazýnýz.
-- select ProductID as [Ürün Kodu], UnitPrice as [Birim Fiyat], Quantity as [Miktar], Unitprice * Quantity as [Tutar] from bdo.OrderDetails order by (UnitPrice * Quantity)desc 

SELECT ProductID, ProductName, UnitPrice, UnitsInStock, (UnitPrice * UnitsInStock) AS TotalValue FROM Products;