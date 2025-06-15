using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Thrones
{
    internal class OyunMotoru
    {
        private Queue<Koy> kurtarilacakKoyler;
        private List<Koy> kurtarilanKoyler;
        private Koy aktifKoy;
        private Canta canta;
        // OyunMotoru içinde kullanılacak
        private Dictionary<string, List<string>> ozelKurtarmaSartlari = new Dictionary<string, List<string>>()
{
    { "Highgarden", new List<string> { "balta", "iksir" } },
    { "The Eyrie", new List<string> { "büyü kitabı", "kalkan" } },
    { "Storm's End", new List<string> { "kılıç", "iksir", "harita" } }
};


        public OyunMotoru(List<Koy> koyler)
        {
            kurtarilacakKoyler = new Queue<Koy>(koyler);
            kurtarilanKoyler = new List<Koy>();
            canta = new Canta();
        }

        public void BirSonrakiKoyuKurtar()
        {
            if (kurtarilacakKoyler.Count == 0)
            {
                Console.WriteLine("Tüm köyler kurtarıldı!");
                return;
            }

            aktifKoy = kurtarilacakKoyler.Dequeue();
            Console.WriteLine($"\n🎯 {aktifKoy.Ad} kurtarılıyor...");

            if (ozelKurtarmaSartlari.ContainsKey(aktifKoy.Ad))
            {
                Console.WriteLine($"Bu köy için özel eşya şartları var: {string.Join(", ", ozelKurtarmaSartlari[aktifKoy.Ad])}");

                foreach (var gereken in ozelKurtarmaSartlari[aktifKoy.Ad])
                {
                    if (!canta.UseItem(gereken))
                    {
                        Console.WriteLine($"❌ Gerekli eşya ({gereken}) eksik. {aktifKoy.Ad} kurtarılamadı!");
                        return; // bu köyü kurtaramazsın
                    }
                }
            }

            // Eşyaları çantaya ekle
            foreach (var esya in aktifKoy.Esyalar)
            {
                if (canta.DoluMu())
                {
                    Console.WriteLine($"Çanta dolu! {esya.Ad} eklenemiyor. Eşya çıkarılsın mı? (e/h)");
                    string secim = Console.ReadLine();
                    if (secim.ToLower() == "e")
                    {
                        canta.Pop();
                        canta.Push(esya);
                    }
                    else
                    {
                        Console.WriteLine($"{esya.Ad} alınmadı.");
                    }
                }
                else
                {
                    canta.Push(esya);
                }
            }

            kurtarilanKoyler.Add(aktifKoy);
            Console.WriteLine($"{aktifKoy.Ad} başarıyla kurtarıldı!");
        }


        public void OyunDurumuGoster()
        {
            Console.WriteLine("\n📌 Oyun Durumu:");
            Console.WriteLine("Kurtarılacak Köyler:");
            foreach (var k in kurtarilacakKoyler)
            {
                Console.WriteLine("- " + k.Ad);
            }

            Console.WriteLine("\nKurtarılan Köyler:");
            foreach (var k in kurtarilanKoyler)
            {
                Console.WriteLine("- " + k.Ad);
            }

            Console.WriteLine($"\nAktif Köy: {(aktifKoy != null ? aktifKoy.Ad : "Henüz başlamadı")}");
        }

        public Canta GetCanta() => canta;
    }
}
