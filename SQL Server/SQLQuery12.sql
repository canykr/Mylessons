CREATE VIEW [dbo].[View_UrunKategori2]
AS
SELECT 
    dbo.Products.ProductName AS [Ürün Adý], 
    dbo.Categories.CategoryName AS [Kategori Adý]
FROM 
    dbo.Categories 
INNER JOIN 
    dbo.Products ON dbo.Categories.CategoryID = dbo.Products.CategoryID
