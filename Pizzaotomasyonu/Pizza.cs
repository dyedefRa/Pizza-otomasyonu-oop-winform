using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzadeneme
{
    class Pizza
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }
        public Ebat EbatOzellikleri { get; set; }
        public Kenar KenarOzellikleri { get; set; }
        public List<string> Malzemeler { get; set; }
        public decimal Tutar
        {
            get
            {
                decimal tutarr = 0;
                tutarr = Fiyat *(decimal) EbatOzellikleri.EbatÇarpanı;
                tutarr += KenarOzellikleri.Ekleme;
                return tutarr;
            }
        
        
        }
        public override string ToString()
        {
            return $"{this.Ad}-{this.Fiyat} TL";
        }

    }
}
