CREATE VIEW [dbo].[View_UrunKategori2]
AS
SELECT 
    dbo.Products.ProductName AS [�r�n Ad�], 
    dbo.Categories.CategoryName AS [Kategori Ad�]
FROM 
    dbo.Categories 
INNER JOIN 
    dbo.Products ON dbo.Categories.CategoryID = dbo.Products.CategoryID
