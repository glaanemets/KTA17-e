using System;
/*programm mis pakub arve, et leida arv mis võrdub random arvuga
 * hetkel piiratud vaid 0-99 arvude vahemikus leidmisega
 * 
 * õppisin kasutama debugi
 * 
 * 
 */
namespace Kodu2
{
    class Program
    {
        static void Main(string[] args)
        {                               
            Random random = new Random();
            int rArv = random.Next(0, 100);
            int[] samm = new int[] { 25, 10, 5, 2, 1 }; //sammud, mille võrra pakutav arv muutub
            int pakuArv = 50, i = 0; //alustame keskelt, kuna max = 99
            bool pos = false;
            Console.WriteLine("See on arvamismäng\nPaku mingit arvu vahemikus 1-99");
            while (true)
            {
                Console.WriteLine($"Pakub arvu:{pakuArv}");
                if (pakuArv < rArv)
                {
                    if (i == 0)//sammu vahetus,
                    {
                        pos = true; // vahet pole kas true/false, lihtsalt selle järgi tuleb järgmised vastavalt, kas true/false
                    }
                    Console.WriteLine("Arv liiga väike");
                    pakuArv += samm[i];
                    if (pos == false && 4 > i && i > 0)//sammu vahetus, kui tingimused õiged, siis samm muutub
                    {
                        pos = true;
                        i++;
                    }
                    else if (pos == true && i < 4)//sammu vahetus, kui tingimused õiged, siis samm muutub
                    {
                        i++;
                    }
                }
                else if (pakuArv > rArv)
                {
                    if(i == 0)//sammu vahetus,
                    {
                        pos = false;
                    }
                    Console.WriteLine("Arv liiga suur");
                    pakuArv -= samm[i];
                    if (pos == true && 4 > i && i > 0)//sammu vahetus, kui tingimused õiged, siis samm muutub
                    {
                        pos = false;
                        i++;
                    }
                    else if(pos == false && i < 4)//sammu vahetus, kui tingimused õiged, siis samm muutub
                    {
                        i++;
                    }
                }
                else if (pakuArv == rArv)
                {
                    Console.WriteLine($"Pakkusid õigesti {pakuArv}");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
