using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Thrones
{
    internal class Koy
    {
        public string Ad { get; set; }
        public List<Esya> Esyalar { get; set; }

        public Koy(string ad, List<Esya> esyalar)
        {
            Ad = ad;
            Esyalar = esyalar;
        }
    }
}
