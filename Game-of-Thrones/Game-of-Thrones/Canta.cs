using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Thrones
{
    internal class Canta
    {
        private Dugum<Esya> tepe; // Stack'in tepesi
        private int kapasite = 10;
        private int sayac = 0;

        public void Push(Esya esya)
        {
            if (sayac >= kapasite)
            {
                Console.WriteLine("Çanta dolu! Yeni eşya eklemek için birini çıkarman gerek.");
                return;
            }

            Dugum<Esya> yeni = new Dugum<Esya>(esya)
            {
                Sonraki = tepe
            };
            tepe = yeni;
            sayac++;
            Console.WriteLine($"{esya.Ad} çantaya eklendi (push).");
        }

        public void Pop()
        {
            if (tepe == null)
            {
                Console.WriteLine("Çanta boş!");
                return;
            }

            Console.WriteLine($"{tepe.Veri.Ad} çantadan çıkarıldı (pop).");
            tepe = tepe.Sonraki;
            sayac--;
        }

        public void Goster()
        {
            Console.WriteLine("Çantadaki Eşyalar (son giren en üstte):");
            Dugum<Esya> temp = tepe;
            while (temp != null)
            {
                Console.WriteLine("- " + temp.Veri.Ad);
                temp = temp.Sonraki;
            }
            Console.WriteLine($"Toplam: {sayac}/10");
        }

        public bool UseItem(string itemName)
        {
            if (tepe == null)
            {
                Console.WriteLine("Çanta boş!");
                return false;
            }

            Dugum<Esya> onceki = null;
            Dugum<Esya> mevcut = tepe;

            while (mevcut != null)
            {
                if (mevcut.Veri.Ad.ToLower() == itemName.ToLower())
                {
                    Console.WriteLine($"{itemName} kullanıldı ve çantadan çıkarıldı.");

                    if (onceki == null)
                        tepe = mevcut.Sonraki; // baştaysa
                    else
                        onceki.Sonraki = mevcut.Sonraki;

                    sayac--;
                    return true;
                }

                onceki = mevcut;
                mevcut = mevcut.Sonraki;
            }

            Console.WriteLine($"{itemName} çantada yok!");
            return false;
        }
        public Dugum<Esya> GetTepe()
        {
            return tepe;
        }


        public bool DoluMu() => sayac >= kapasite;
        public bool BosMu() => sayac == 0;
        public int EsyaSayisi() => sayac;
    }
}
