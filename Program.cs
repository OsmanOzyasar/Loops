using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("1 ile 20 arasındaki sayılar:");
            for (int a = 2; a <20; a++)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("1 ile 20 arsındaki çift sayılar:");
            for (int b = 2; b < 20; b += 2)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("------------------------------------------");
            
            int terimSayisi = 0;

            int ilkTerim = 51;
            int sonTerim = 149;

            for (int c = ilkTerim; c <= sonTerim; c++)
            {
                terimSayisi++;
            }

            int result = (terimSayisi * (ilkTerim + sonTerim)) / 2;
            Console.Write("50 ile 150 arasındaki terim sayısı:");
            Console.WriteLine(terimSayisi);
            Console.Write("50 ile 150 arasındaki sayıların toplamı:");
            Console.WriteLine(result);

            Console.WriteLine("--------------------------------------------");

            List<int> ciftSayılar = new List<int>();
            List<int> tekSayılar = new List<int>();

            for (int d = 2; d < 120; d++)
            {
                if (d % 2 == 0)
                {
                    ciftSayılar.Add(d);
                }
                else 
                {
                    tekSayılar.Add(d);
                }
            }

            int toplam1 = 0;
            for (int i = 0; i < ciftSayılar.Count; i++)
            {
                toplam1 += ciftSayılar[i];
            }

            Console.WriteLine("Çift Sayıların toplamı: " + toplam1);

            int toplam2 = 0;
            for (int i = 0; i < tekSayılar.Count; i++)
            {
                toplam2 += tekSayılar[i];
            }

            Console.WriteLine("Tek Sayıların Toplamı: " + toplam2);
        }
    }
}