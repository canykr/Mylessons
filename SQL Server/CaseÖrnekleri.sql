select SupplierID, CompanyName, Country,

case 
when Country= 'USA' then 'Amerika'
when Country= 'UK' then '�ngiltere'
else Country
end as [Yeni �lke]

from dbo.Suppliers