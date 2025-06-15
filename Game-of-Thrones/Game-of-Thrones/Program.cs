using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Thrones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oyun = new OyunDunyasi();
            var motor = new OyunMotoru(oyun.Koyler);
            BST bst = new BST();

            while (true)
            {
                Console.WriteLine("\n========= OYUN MENÜSÜ =========");
                Console.WriteLine("1 - Bir sonraki köyü kurtar");
                Console.WriteLine("2 - Çantayı görüntüle");
                Console.WriteLine("3 - Eşya kullan");
                Console.WriteLine("4 - Çantada eşya ara (BST)");
                Console.WriteLine("5 - Çantadaki eşyaları A-Z sırala (BST)");
                Console.WriteLine("6 - Oyun ilerlemesini göster");
                Console.WriteLine("7 - Oyundaki tüm eşyaları listele");
                Console.WriteLine("8 - Oyundaki tüm köyleri listele");
                Console.WriteLine("0 - Çıkış");
                Console.Write("Seçim: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        motor.BirSonrakiKoyuKurtar();
                        break;

                    case "2":
                        motor.GetCanta().Goster();
                        break;

                    case "3":
                        Console.Write("Kullanılacak eşya adı: ");
                        string kullan = Console.ReadLine();
                        motor.GetCanta().UseItem(kullan);
                        break;

                    case "4":
                        Console.WriteLine("BST ağacı oluşturuluyor...");
                        bst = new BST();
                        var temp = motor.GetCanta().GetTepe(); // eklenmeli: GetTepe() metodu
                        while (temp != null)
                        {
                            bst.Ekle(temp.Veri);
                            temp = temp.Sonraki;
                        }

                        Console.Write("Aranacak eşya adı: ");
                        string aranacak = Console.ReadLine();
                        Console.WriteLine(bst.Ara(aranacak) ? "Eşya bulundu!" : "Eşya bulunamadı.");
                        break;

                    case "5":
                        Console.WriteLine("BST sıralama:");
                        bst.Sirala();
                        break;

                    case "6":
                        motor.OyunDurumuGoster();
                        break;

                    case "7":
                        oyun.KoyleriListele();
                        break;

                    case "8":
                        oyun.TumEsyalariGoster();
                        break;


                    case "0":
                        Console.WriteLine("Oyun kapatılıyor...");
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }
            }
        }
    }
}
