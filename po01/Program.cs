using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po01
{
    class Program
    {
        static List<Osoba> KsiazkaTelefoniczna;

        static void Main(string[] args)
        {
            //Osoba osoba1 = new Osoba();

            //osoba1.UstawDane("Bartłomiej", "Bullert", "Ulica", 1, "1", "11-111", "Poznań", "Polska");

            //Console.WriteLine(osoba1.PrzedstawSie());
            //Console.WriteLine("Adres korespondencyjny:");
            //Console.WriteLine(osoba1.Adres.AdresKorespondencyjny);
            //Console.ReadKey();

            KsiazkaTelefoniczna = new List<Osoba>();

            for (; ; )
            {
                Console.WriteLine("Podaj liczbę kontaktów do wprowadzenia.");

                int iloscKontaktow;
                ForceToGetEvenInt(out iloscKontaktow);

                Console.WriteLine("ok");
            }
        }

        static bool ForceToGetEvenInt(out int num)
        {
            string errMsg = "Nieprawidłowe dane wejściowe (wartość musi być dodatnią liczbą całkowitą).";

            for (; ; )
            {
                var input = Console.ReadLine();
                int inputIntValue;

                if (!int.TryParse(input, out inputIntValue))
                {
                    Console.WriteLine(errMsg);
                    continue;
                }

                if (inputIntValue <= 0)
                {
                    Console.WriteLine(errMsg);
                    continue;
                }

                num = inputIntValue;
                return true;
            }
        }
    }
}
