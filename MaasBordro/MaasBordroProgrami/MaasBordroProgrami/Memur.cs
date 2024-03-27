using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroProgrami
{
    public class Memur : Personel
    {
        private int _calismaSaati;
        public decimal SaatlikUcret { get; set; } = 500;

        public decimal Maas { get; set; } = 0;

        public int Derece { get; set; }

        //public Memur(int derece)
        //{
        //    Derece = derece;
        //    SaatlikUcret = 500;
        //}

        public int CalismaSaati
        {
            get { return _calismaSaati; }
            set { _calismaSaati = value > 180 ? 180 : value; } 
        }


        public override decimal MaasHesapla(int CalismaSaati)
        {
             

            if (CalismaSaati <= 180)
            {
                Maas = CalismaSaati * SaatlikUcret;
            }
            else
            {
                double EkMesai = ((CalismaSaati-180) * 1.5) * Convert.ToDouble(SaatlikUcret);
                
                Maas=Convert.ToDecimal(EkMesai)+(180*SaatlikUcret);
            }

            return Maas;
           
        }
    }
}
