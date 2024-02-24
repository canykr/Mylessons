USE Northwind
select Adi, SoyAdi from Personeller

Select 'Gencay' Adý,'Yýldýz' Soyadý

Select Adi Ýsimler, SoyAdi Soyisimler from Personeller

-- Boþluk karakteri olan alias atama

Select 1453 Ýstanbulun Fethi
Select 1453 [Ýstanbulun Fethi]

-- Boþluk karakteri olan tabloyu sorgulama
select * from Satis Detaylari
Select * from [Satis Detaylari]

--Kolonlarý birleþtirme

Select Adi,SoyAdi from Personeller
Select Adi + ' ' + SoyAdi [Personel Bilgileri] from Personeller

--Farklý Tipte Kolonlarý Birleþtirme
Select Adi + ' ' + IseBaslamaTarihi from Personeller
Select Adi + ' ' + CONVERT(nvarchar,IseBaslamaTarihi) from Personeller
Select Adi + ' ' + CAST(IseBaslamaTarihi AS nvarchar) from Personeller


