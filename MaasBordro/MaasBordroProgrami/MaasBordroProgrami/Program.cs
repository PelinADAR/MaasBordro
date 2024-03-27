using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroProgrami
{
    public class Program
    {
        public static void Main()
        {
            DosyaOku dosyaOku = new DosyaOku();
            List<Personel> personelListesi = dosyaOku.PersonelListesiniGoruntule("PersonelListesi.json");

            PersonelListesiniGoruntule(personelListesi);

            MaasBordro maasBordro = new MaasBordro();
            maasBordro.MaasBordroOlusturveKaydet(personelListesi);

            Console.ReadLine();
        }

    }
}
