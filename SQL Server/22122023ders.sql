select SupplierID, CompanyName, Country,

case 
when Country= 'USA' then 'Amerika'
when Country= 'UK' then 'Ýngiltere'
else Country
end as [Yeni Ülke]
from dbo.Suppliers

--stok miktarý 
--sýfýrdan büyük ve 10'dan küçük ise kritik stok miktarý uyarýsý versin
--sýfýr'a eþit veya küçük ise 'Stok Yok' Sonucu dönsün
--hiç birisi deðil ise 'Stok Yeterli' Sonucunu Dönsün
select ProductName,UnitsInStock,
case
when UnitsInStock<= 0 then 'Stok Yok'
when UnitsInStock >0 and UnitsInStock <10 then 'Kritik Stok Miktarý'
else 'Stok Yeterli'
end as [Stok Kontrol]

from dbo.Products


