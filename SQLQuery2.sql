USE Northwind
select Adi, SoyAdi from Personeller

Select 'Gencay' Ad�,'Y�ld�z' Soyad�

Select Adi �simler, SoyAdi Soyisimler from Personeller

-- Bo�luk karakteri olan alias atama

Select 1453 �stanbulun Fethi
Select 1453 [�stanbulun Fethi]

-- Bo�luk karakteri olan tabloyu sorgulama
select * from Satis Detaylari
Select * from [Satis Detaylari]

--Kolonlar� birle�tirme

Select Adi,SoyAdi from Personeller
Select Adi + ' ' + SoyAdi [Personel Bilgileri] from Personeller

--Farkl� Tipte Kolonlar� Birle�tirme
Select Adi + ' ' + IseBaslamaTarihi from Personeller
Select Adi + ' ' + CONVERT(nvarchar,IseBaslamaTarihi) from Personeller
Select Adi + ' ' + CAST(IseBaslamaTarihi AS nvarchar) from Personeller


