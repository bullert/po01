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

            KsiazkaTelefoniczna = new List<Osoba>();
            
            Console.WriteLine("Podaj liczbę kontaktów do wprowadzenia.");

            int iloscKontaktow;
            ForceToGetPositiveInt(out iloscKontaktow);

            for (int i = 0; i < iloscKontaktow; i++)
                WprowadzKontakt();

            for (; ; )
            {
                for (int i = 0; i < iloscKontaktow; i++)
                    WypiszKontakt(i);

                var index = ForceToGetIntInRange(
                        0, iloscKontaktow, 
                        string.Format("Podaj index kontaktu z zakresu (0 - {0})", iloscKontaktow - 1)
                    );

                Console.WriteLine(new String('-', 30));
                Console.WriteLine("Lista konkaktów.");
                Console.WriteLine(new String('-', 30));

                WypiszKontakt(index);
                WypiszDaneKorespondencyjne(index);

                Console.ReadKey();
            }
        }
        
        static public void WprowadzKontakt()
        {
            Console.WriteLine(new String('-', 30));
            Console.WriteLine("Wprowadź dane kontaktu.");
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("Podaj imie:");
            string imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj nazwa ulicy:");
            string nazwaUlicy = Console.ReadLine();

            Console.WriteLine("Podaj numer domu:");
            int numerDomu;
            ForceToGetPositiveInt(out numerDomu);

            Console.WriteLine("Podaj numer mieszkania:");
            string numerMieszkania = Console.ReadLine();

            Console.WriteLine("Podaj kod pocztowy:");
            string kodPocztowy = Console.ReadLine();

            Console.WriteLine("Podaj miasto:");
            string miasto = Console.ReadLine();

            Console.WriteLine("Podaj państwo:");
            string panstwo = Console.ReadLine();

            Osoba osoba = new Osoba();
            osoba.UstawDane(
                    imie, nazwisko, nazwaUlicy, numerDomu, 
                    numerMieszkania, kodPocztowy, miasto, panstwo
                );

            KsiazkaTelefoniczna.Add(osoba);
        }

        static void WypiszKontakt(int index)
        {
            var kontakt = KsiazkaTelefoniczna[index];
            Console.WriteLine("{0}. {1} {2}", index, kontakt.Imie, kontakt.Nazwisko);
        }

        static void WypiszDaneKorespondencyjne(int index)
        {
            var kontakt = KsiazkaTelefoniczna[index];
            Console.WriteLine(kontakt.Adres.AdresKorespondencyjny);
        }

        static int ForceToGetIntInRange(int min, int max, string errMsg = null)
        {
            //string errMsg = "Nieprawidłowe dane wejściowe (wartość musi być dodatnią liczbą całkowitą).";

            for (; ; )
            {
                var input = Console.ReadLine();
                int inputIntValue;

                if (!int.TryParse(input, out inputIntValue))
                {
                    Console.WriteLine(errMsg);
                    continue;
                }

                if (inputIntValue < min || inputIntValue > max)
                {
                    Console.WriteLine(errMsg);
                    continue;
                }

                return inputIntValue;
            }
        }

        static bool ForceToGetPositiveInt(out int num)
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
