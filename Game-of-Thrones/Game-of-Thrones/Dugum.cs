using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Thrones
{
    internal class Dugum<T>
    {
        public T Veri { get; set; }
        public Dugum<T> Sonraki { get; set; }

        public Dugum(T veri)
        {
            Veri = veri;
            Sonraki = null;
        }
    }
}
