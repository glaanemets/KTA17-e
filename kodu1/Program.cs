using System;

namespace kodu1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int kArv = 100, rArv = random.Next(0, 100);
            Console.WriteLine("See on arvamismäng\nPaku mingit arvu vahemikus 1-99");
            while (true)
            {
                Console.Write("Paku arvu: ");
                kArv = int.Parse(Console.ReadLine());
                if (kArv < rArv)
                {
                    Console.WriteLine("Arv liiga väike");
                }
                else if (kArv > rArv)
                {
                    Console.WriteLine("Arv liiga suur");
                }
                else if (kArv == rArv)
                {
                    Console.WriteLine($"Pakkusid õigesti {kArv}");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
