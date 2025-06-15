using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Thrones
{
    internal class OyunDunyasi
    {
        public List<Koy> Koyler { get; set; }

        public OyunDunyasi()
        {
            Koyler = new List<Koy>()
        {
            new Koy("Winterfell", new List<Esya> { new Esya("kılıç"), new Esya("iksir"), new Esya("harita") }),
            new Koy("King's Landing", new List<Esya> { new Esya("altın"), new Esya("bıçak"), new Esya("yiyecek") }),
            new Koy("Castle Black", new List<Esya> { new Esya("kalkan"), new Esya("balta"), new Esya("büyü kitabı") }),
            new Koy("Dragonstone", new List<Esya> { new Esya("kılıç"), new Esya("iksir"), new Esya("sandık") }),
            new Koy("Highgarden", new List<Esya> { new Esya("balta"), new Esya("iksir"), new Esya("altın") }),
            new Koy("The Eyrie", new List<Esya> { new Esya("harita"), new Esya("bıçak"), new Esya("yiyecek") }),
            new Koy("Storm's End", new List<Esya> { new Esya("kılıç"), new Esya("büyü kitabı"), new Esya("iksir") }),
        };
        }

        public void KoyleriListele()
        {
            Console.WriteLine("\n🌄 Oyundaki Tüm Köyler:");
            foreach (var koy in Koyler)
            {
                Console.WriteLine("- " + koy.Ad);
            }
        }

        public void TumEsyalariGoster()
        {
            Console.WriteLine("\n🎒 Oyundaki Tüm Eşyalar (Tekil Liste):");

            HashSet<string> esyaSeti = new HashSet<string>();

            foreach (var koy in Koyler)
            {
                foreach (var esya in koy.Esyalar)
                {
                    esyaSeti.Add(esya.Ad.ToLower());
                }
            }

            foreach (var ad in esyaSeti.OrderBy(e => e))
            {
                Console.WriteLine("- " + ad);
            }
        }



    }
}
