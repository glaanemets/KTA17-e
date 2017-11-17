using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Linna resto\nNarva mnt 5b");
            float[] hinnad = new float[20];
            float kogusumma = 0;
            int i = 0;
            Console.WriteLine("------");
            while (true)
            {
                Console.Write("Sisesta hind:");
                hinnad[i] = float.Parse(Console.ReadLine());
                if(hinnad[i] == -1)
                    break;

                i++;
            }
            Console.WriteLine("-----");
            for (int j = 0; j < i; j++)
                kogusumma += hinnad[j];

            Console.WriteLine($"Kogu summa:{kogusumma}");
            Console.WriteLine($"15% kogu summast:€{Math.Round((kogusumma * 0.15), 2)}");
            Console.WriteLine($"Summa maksmisele:€{Math.Round((kogusumma * 0.85), 2)}");
            Console.ReadLine();
        }
    }
}
