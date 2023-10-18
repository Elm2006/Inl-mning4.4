using System;
namespace Inlämning_4.__4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kör = true;
            while (kör == true)
            {
                Console.WriteLine("Välj ett av följande alternativ.\r\n1. Subtrahera ett tal med ett annat\r\n2. Dividera ett tal med ett annat\r\n3. Avsluta programmet");
                int svar = int.Parse(Console.ReadLine());
                int tal1 = 0;
                int tal2 = 0;
                switch (svar)
                {
                    case 1:
                        Console.WriteLine("Skriv ett tal");
                        tal1=int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv ett till tal");
                        tal2=int.Parse(Console.ReadLine());
                        Console.WriteLine("Svaret på din subtraktion är "+(tal1-tal2));
                        break;
                    case 2:
                        Console.WriteLine("Skriv ett tal");
                        tal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv ett till tal");
                        tal2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Svaret på din divtion är " + (tal1 / tal2));
                        break;
                    case 3:
                        kör = false;
                        break;
                }

            }
        }
    }
}
