select SupplierID, CompanyName, Country,

case 
when Country= 'USA' then 'Amerika'
when Country= 'UK' then 'Ýngiltere'
else Country
end as [Yeni Ülke]

from dbo.Suppliers