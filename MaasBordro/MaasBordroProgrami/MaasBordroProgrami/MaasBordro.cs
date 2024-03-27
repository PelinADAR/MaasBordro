using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace MaasBordroProgrami
{
    public class MaasBordro
    {
        public void MaasBordroOlusturveKaydet(List<Personel> personelListesi)
        {
            Console.WriteLine("Maas Bordro,"+DateTime.Now.ToString("MMM yyyy"));

            foreach (var personel in personelListesi)
            {
                if (personel is Memur)
                {
                    Memur memur = (Memur)personel;
                    Console.WriteLine($"Personel Ismi : "+ personel.Name);
                    Console.WriteLine($"Çalışma Saati : "+personel.CalismaSaati);
                    Console.WriteLine($"Ana Odeme :"+personel.Maas);

                    KlasorOluşturVeKaydet("Memur", memur);

                }
                else if (personel is Yonetici)
                {
                    Yonetici yonetici = (Yonetici)personel;
                    Console.WriteLine($"Personel Ismi : "+ personel.Name);
                    Console.WriteLine($"Çalışma Saati : "+personel.CalismaSaati);
                    Console.WriteLine($"Ana Odeme :"+personel.Maas);

                    KlasorOluşturVeKaydet("Yonetici", yonetici);
                }
                else
                {
                    Console.WriteLine($"{personel.Name} bilinmeyen bir türdedir.");
                }
            }


        }
        public static void KlasorOluşturVeKaydet(string klasorAdi, Personel personel)
        {

            Directory.CreateDirectory("PersonelListesi");
            klasorAdi = "C:\\Users\\hakan\\Desktop\\PersonelListesi";
            string dosyaYolu = $"{klasorAdi}/{personel.Name}.txt";
            using (StreamWriter writer = new StreamWriter(dosyaYolu))
            {
                writer.WriteLine($"Personel Ismi : {personel.Name}");
                writer.WriteLine($"Çalışma Saati : {personel.CalismaSaati}");
                writer.WriteLine($"Ana Ödeme : {personel.Maas}");
            }
        }

        // 10 saatten daha az çalışan personellerin ayrıntılarını gösteren metot

        public static void OnSaattenAzCalisan(List<Personel> personelListesi)
        {
            foreach (var personel in personelListesi)
            {
                if (personel.CalismaSaati<10)
                {
                    Console.WriteLine(personel.Name+" "+personel.CalismaSaati);
                }
            }
        }
    }
}
