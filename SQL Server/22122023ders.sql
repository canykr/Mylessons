select SupplierID, CompanyName, Country,

case 
when Country= 'USA' then 'Amerika'
when Country= 'UK' then '�ngiltere'
else Country
end as [Yeni �lke]
from dbo.Suppliers

--stok miktar� 
--s�f�rdan b�y�k ve 10'dan k���k ise kritik stok miktar� uyar�s� versin
--s�f�r'a e�it veya k���k ise 'Stok Yok' Sonucu d�ns�n
--hi� birisi de�il ise 'Stok Yeterli' Sonucunu D�ns�n
select ProductName,UnitsInStock,
case
when UnitsInStock<= 0 then 'Stok Yok'
when UnitsInStock >0 and UnitsInStock <10 then 'Kritik Stok Miktar�'
else 'Stok Yeterli'
end as [Stok Kontrol]

from dbo.Products


