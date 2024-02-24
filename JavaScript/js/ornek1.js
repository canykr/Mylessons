 //js yorum satırı
 var degisken1=56; // tarayıcının genelinde erişilebilen bir değişken haline gelir.
 let degisken2=""; // tanımlandığı blok içerisinde erişilebilir.
const degisken3= 123; //sadece bir sefer değer ataması yapılarak tekrar değer ataması yapılmasını engeller.



degisken1=34;
 degisken2="Can Yakar"
 console.log(degisken2);

 let toplam= degisken1+ degisken3
 console.log(toplam);

 let adiSoyadi="Can" + " " + "Yakar";
 console.log("adiSoyadi degiskeni=",adiSoyadi);

 degisken1++;
 console.log(degisken1);
 degisken1 += 5;
 console.log(degisken1);
 degisken1= (5*2) + 4;
 console.log(degisken1);

 let sayi=123;
 let ondalikliSayi= 35123.54;
 let metin = "asdas";
 let trueFalse=true;
 let trueFalse2=false;

 let tarih= new Date("2024-01-12");

 //renkler dizisi
 let renkler= ["kırmızı","beyaz","mavi"];
 let sayilar=[34,52];
 console.log("dizi:",renkler);

 let kisi = {adi: "Can", soyadi: "Yakar",dogumTarihi:new Date("1997-01-14")};
 let kisi2= {adi: "Can2", soyadi: "Yakar2",dogumTarihi:new Date("1997-01-14")};
 
 console.log("Kişi:",kisi);

 let kisiler=[kisi,kisi2];
 console.log(kisiler);

 let kisi3= {adi: "Can2", soyadi: "Yakar2",dogumTarihi:new Date("1997-01-14")};
 kisi3.yas=19;
 
 console.log("KişiYeni:", kisi3)
