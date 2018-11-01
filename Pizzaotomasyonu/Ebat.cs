using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzadeneme
{
    class Ebat
    {
        public string Ebattürü { get; set; }
        public double EbatÇarpanı { get; set; }
        public override string ToString()
        {
            return $"{this.Ebattürü}- {this.EbatÇarpanı}";
        }
    }
}
