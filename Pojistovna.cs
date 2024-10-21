using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Pojistovna
    {
        private Databaze databaze;

        public Pojistovna()
        {
            databaze = new Databaze();
        }
        /// <summary>
        /// Vypíše úvodní obrazovku samotné aplikace
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
            Console.WriteLine();
        }
        /// <summary>
        /// Požádá uživatele o zadání veškerých údajů potřebných pro přidání nového uživatele
        /// </summary>
        public void PridejZaznam()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte jméno znovu:");
            }
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte přijmení znovu:");
            }

            Console.WriteLine("Zadejte telefonní číslo:");
            string telCislo;
            while (string.IsNullOrWhiteSpace(telCislo = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte telefonní číslo znovu:");
            }

            int vek;
            while (true)
            {
                Console.WriteLine("Zadejte věk:");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out vek))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neplatný věk. Zadejte prosím znovu.");
                }
            }
            databaze.PridejZaznam(jmeno, prijmeni, vek, telCislo);
        }
        /// <summary>
        /// Vypíše všechny existující záznamy uložených pojištěnců
        /// </summary>
        public void VypisVsechnyZaznamy()
        {
            List<Pojistenec> vsechnyZaznamy = databaze.VratVsechnyZaznamy();

            if (vsechnyZaznamy.Count == 0)
            {
                Console.WriteLine("Databáze neobsahuje žádné záznamy.");
            }
            else
            {
                foreach (var pojistenec in vsechnyZaznamy)
                {
                    Console.WriteLine(pojistenec.ToString());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
        }

        /// <summary>
        /// Vyhledá konkrétní záznam uloženého pojištěnce na základě zadaného Jména a příjmení
        /// </summary>
        public void VyhledejZaznam()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni = Console.ReadLine();

            List<Pojistenec> nalezeneZaznamy = databaze.NajdiZaznam(jmeno, prijmeni);

            if (nalezeneZaznamy.Count == 0)
            {
                Console.WriteLine("Pojištěnec s uvedeným jménem a příjmením nebyl nalezen.");
            }
            else
            {
                Console.WriteLine("Nalezení pojištěnci:");
                foreach (var pojistenec in nalezeneZaznamy)
                {
                    Console.WriteLine(pojistenec.ToString());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
        }

    }
}
