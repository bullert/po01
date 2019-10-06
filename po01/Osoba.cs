using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po01
{
    class Osoba
    {
        public string Imie { get; private set; }

        public string Nazwisko { get; private set; }

        public Adres Adres { get; private set; }

        public void UstawDane(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public void UstawDane(string imie, string nazwisko, string nazwaUlilcy, int numerDomu, string numerMieszkania, string kodPocztowy, string miasto, string panstwo)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = new Adres();
            Adres.UstawDane(nazwaUlilcy, numerDomu, numerMieszkania, kodPocztowy, miasto, panstwo);
        }

        public string PrzedstawSie()
        {
            return string.Format("Nazywam się {0} {1}", Imie, Nazwisko);
        }
    }
}
