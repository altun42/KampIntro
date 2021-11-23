// See https://aka.ms/new-console-template for more information

using Oop2;

//Engin Demiroğ
GercekMusteri müsteri1 = new GercekMusteri();
müsteri1.Id = 1;
müsteri1.MusteriNo = "15545";
müsteri1.Adi = "Engin";
müsteri1.Soyadi = "Demiroğ";
müsteri1.TcNo = "12345678912";

//Kodlama.io
TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "486443";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "123456889";


Müsteri müsteri3 = new GercekMusteri();
Müsteri müsteri4 = new TuzelMusteri() ;

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(müsteri1);
musteriManager.Ekle(musteri2);

