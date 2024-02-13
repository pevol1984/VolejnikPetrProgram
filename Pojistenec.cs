using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojistneUdalosti
{
    internal class Pojistenec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Vek { get; set; }
        public string TelefonniCislo { get; set; }


        /// <summary>
        /// Konstruktor pro vytvoření nového Pojištěnce
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonniCislo"></param>
        public Pojistenec(string jmeno, string prijmeni,string vek, string telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;   
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        /// <summary>
        /// metoda pro výpis Pojištěnce
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"{Jmeno}\t{Prijmeni}\t{Vek}\t{TelefonniCislo}";
        }
    }
}
