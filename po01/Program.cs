using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po01
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();

            osoba1.UstawDane("Bartłomiej", "Bullert", "Ulica", 1, "1", "11-111", "Poznań", "Polska");

            Console.WriteLine(osoba1.PrzedstawSie());
            Console.WriteLine("Adres korespondencyjny:");
            Console.WriteLine(osoba1.Adres.AdresKorespondencyjny);
            Console.ReadKey();
        }
    }
}
