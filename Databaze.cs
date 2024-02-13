using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PojistneUdalosti
{
    internal class Databaze
    {
        private List<Pojistenec> DB;

        /// <summary>
        /// Konstruktor pro vytvoření nové databáze se seznamem pojištěnců
        /// </summary>
        public Databaze()
        {
            DB = new List<Pojistenec>();
        }
        /// <summary>
        /// Metoda pro přidání pojištěnce do listu databáze
        /// </summary>
        /// <param name="z"></param>
        public void Pridej(Pojistenec z)
        { 
            DB.Add(z);
        }
        /// <summary>
        /// Metoda pro výpis záznamů z listu databáze
        /// </summary>
        public void Vypis()
        {
            DB.ForEach(x=> Console.WriteLine(x));
        }

        /// <summary>
        /// Metoda pro vyhledání pojištěnce v seznamu dle jména a příjmení
        /// </summary>
        /// <param name="p"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public List<Pojistenec> VyhledejPojistence(string p, string v)
        {
            List<Pojistenec> nalezene = new List<Pojistenec>();
            foreach (Pojistenec z in DB)
            {
                if ( p == z.Jmeno && v==z.Prijmeni)
                    nalezene.Add(z);
            }
            return nalezene;
        }
    }
}
