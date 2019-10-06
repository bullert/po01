using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po01
{
    class Adres
    {
        public string NazwaUlicy { get; private set; }

        public int NumerDomu { get; private set; }

        public string NumerMieszkania { get; private set; }

        public string KodPocztowy { get; private set; }

        public string Miasto { get; private set; }

        public string Panstwo { get; private set; }

        public string AdresKorespondencyjny {
            get => 
                string.Format(
                    "Ul. {0} {1}/{2}\n{3} {4}\n{5}", 
                    NazwaUlicy, NumerDomu, NumerMieszkania, 
                    KodPocztowy, Miasto, Panstwo
                );
        }

        public void UstawDane(string nazwaUlilcy, int numerDomu, string numerMieszkania, string kodPocztowy, string miasto, string panstwo)
        {
            NazwaUlicy = nazwaUlilcy;
            NumerDomu = numerDomu;
            NumerMieszkania = numerMieszkania;
            KodPocztowy = kodPocztowy;
            Miasto = miasto;
            Panstwo = panstwo;
        }
    }
}
