using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******TAŞ,KAĞIT,MAKAS OYUNU************");
            Console.WriteLine("----------------------------------------");
            while (true)
            {
                Console.WriteLine("Seçiminizi yapın (Taş, Kağıt, Makas)");
                string kulsecim = Console.ReadLine();
                if (kulsecim == "cıkıs")
                {
                    break;
                }

                string bilgisayarsecim = Bilgisayarsecim();
                Console.WriteLine("Bilgisayar Seçimi:" + bilgisayarsecim);
                string sonuc = Sonuc(kulsecim, bilgisayarsecim);

                Console.WriteLine(sonuc);
            }

            Console.WriteLine("OYUN BİTTİ!!!");
            Console.ReadLine();
        }

        static string Bilgisayarsecim()
        {
            string[] secenekler = { "taş", "kağıt", "makas" };
            Random random = new Random();
            int rastgeleIndex = random.Next(secenekler.Length);
            return secenekler[rastgeleIndex];
        }
        static string Sonuc(string kulsecim, string bilgisayarsecim)
        {
            if (kulsecim == bilgisayarsecim)
            {
                return "Berabere!";
            }
            else if ((kulsecim == "taş" && bilgisayarsecim == "makas") ||
                     (kulsecim == "kağıt" && bilgisayarsecim == "taş") ||
                     (kulsecim == "makas" && bilgisayarsecim == "kağıt"))
            {
                return "Kazandınız!";
            }
            else
            {
                return "Kaybettiniz!";
            }
        }

    }
}
