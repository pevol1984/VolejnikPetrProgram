using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PojistneUdalosti
{
    internal class UzivatelskeRozhrani
    {
        private Databaze MyDB { get; set; }

        /// <summary>
        /// Konstruktor pro vytvoření instance Uživatelského rozhraní s novou databází
        /// </summary>
        public UzivatelskeRozhrani ()
        {
            MyDB = new Databaze ();
        }

        /// <summary>
        /// Metoda Uzivatelského rozhraní pro volbu akcí
        /// </summary>
        public void VyberVolbu()
        {
            char volba = '0';

            while (volba > 0) 
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Evidence pojistenych");
                Console.WriteLine("---------------------");
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                //výpis možností
                Console.WriteLine("1 - Pridat nového pojisteného");
                Console.WriteLine("2 - Vypsat vsechny pojistené");
                Console.WriteLine("3 - Vyhledat pojisteného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                //reakce na volbu
                switch (volba)
                {
                    case '1'://přidání pojištěného
                        Console.WriteLine();
                        Console.WriteLine();    
                        Console.WriteLine("Zadejte jméno pojisteného:");
                        string jmeno = Console.ReadLine();
                        //Ověření vyplnění jména, nesmí být prázdné.
                        if (jmeno != "")
                        { 
                            Console.WriteLine("Zadejte príjmení:");    
                            string prijmeni = Console.ReadLine();    
                            Console.WriteLine("Zadejte telefonní císlo:");    
                            string telefonniCislo = Console.ReadLine();    
                            Console.WriteLine("Zadejte vek:");    
                            string vek = Console.ReadLine();
                            //Vytvoření databáze a přidání nového pojičtěnce do databáze
                            Console.WriteLine();        
                            MyDB.Pridej(new Pojistenec (jmeno, prijmeni, telefonniCislo, vek));    
                            Console.WriteLine("Data byla uložena. Pokracujte libovolnou klávesou...");
                        }
                        else
                            Console.WriteLine("Jméno musí být vyplněno!");
                    break;    

                    case '2'://výpis všech pojištěných
                        Console.WriteLine();    
                        Console.WriteLine();    
                        //Zobrazení seznamu databáze    
                        MyDB.Vypis();    
                        Console.WriteLine();    
                        Console.WriteLine("Pokracujte libovolnou klávesou...");    
                    break;    

                    case '3'://vyhledání pojištěného
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Pro vyhledání zadejte jméno:");
                        string j=Console.ReadLine();
                        Console.WriteLine("Pro vyhledání zadejte příjmení:");
                        string v = Console.ReadLine();
                        List<Pojistenec> vypsaniPojistencu = MyDB.VyhledejPojistence(j,v);
                        foreach (Pojistenec p in vypsaniPojistencu)
                        {
                            Console.WriteLine(p);
                        }
                        Console.WriteLine(vypsaniPojistencu);
                    break;   

                    case '4'://ukončení programu
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Konec...");
                    break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Neplatná volba, zadejte prosím znovu.");
                    break;

                }
            }

        }
    }
}
