using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzadeneme
{
    class Siparis
    {
        public Pizza pizza { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public override string ToString()
        {
            string yazılacak;
            yazılacak = $"{pizza.Ad} - {pizza.EbatOzellikleri} - {pizza.KenarOzellikleri.Ad}";
            foreach (string item in pizza.Malzemeler)
            {
                yazılacak += $"  {item}  ,";
            }
            yazılacak.Remove(yazılacak.Length - 1, 1);
            yazılacak += $" Tutar = {this.Adet} X {pizza.Tutar} = {pizza.Tutar * this.Adet}";
            return yazılacak;
                
             
        }
    }
}
