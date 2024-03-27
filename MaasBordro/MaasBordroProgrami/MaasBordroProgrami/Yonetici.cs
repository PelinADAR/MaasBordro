using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroProgrami
{
    public class Yonetici : Personel
    {
        private int _saatlikUcret;
        public decimal Maas { get; set; } = 0;


        public int SaatlikUcret
        {
            get { return _saatlikUcret; }
            set { _saatlikUcret = value < 500 ? 500 : value; }
        }

        public decimal Bonus { get; set; }
        public override decimal MaasHesapla(int calismaSaati)
        {
            Maas = calismaSaati*SaatlikUcret;
            return Maas+Bonus;
        }
    }
}
