using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using Newtonsoft.Json;

namespace MaasBordroProgrami
{
    public class DosyaOku
    {
        static void Main(string[] args)
        {
            try
            {
                string jsonString = File.ReadAllText("PersonelListe.json");
                List<Personel> personelListesi = JsonConvert.DeserializeObject<List<Personel>>(jsonString);


                PersonelListesiniGoruntule(personelListesi);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Belirtilen dosya bulunamadı.");
            }
            catch (JsonException)
            {
                Console.WriteLine("JSON verileri işlenirken bir hata oluştu.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
            }
        }



        public static void PersonelListesiniGoruntule(List<Personel> personelListesi)
        {
            foreach (var personel in personelListesi)
            {
                Console.WriteLine($" Ad: {personel.Name}, Title: {personel.Title}");
            }
        }

    }
}
