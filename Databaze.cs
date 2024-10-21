using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Databaze
    {
        private List<Pojistenec> zaznamy;

        public Databaze()
        {
            zaznamy = new List<Pojistenec>();
        }
        /// <summary>
        /// Přidá nový záznam do listu
        /// </summary>
        /// <param name="jmeno">string Jméno</param>
        /// <param name="prijmeni">string Přijímení</param>
        /// <param name="vek">int Věk</param>
        /// <param name="telCislo">string Tel. číslo</param>
        public void PridejZaznam(string jmeno, string prijmeni, int vek, string telCislo)
        {
            zaznamy.Add(new Pojistenec(jmeno, prijmeni, vek, telCislo));

            Console.WriteLine();
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }
        /// <summary>
        /// Vrátí celý záznam o pojištěnci
        /// </summary>
        /// <returns></returns>
        public List<Pojistenec> VratVsechnyZaznamy()
        {
            return zaznamy;
        }

        /// <summary>
        /// Vrátí celý záznam dle zadaného jména a příjímení
        /// </summary>
        /// <param name="jmeno">string Jméno</param>
        /// <param name="prijmeni">string příjmení</param>
        /// <returns></returns>
        public List<Pojistenec> NajdiZaznam(string jmeno, string prijmeni)
        {
            return zaznamy.Where(p =>
                p.Jmeno.Equals(jmeno, StringComparison.OrdinalIgnoreCase) &&
                p.Prijmeni.Equals(prijmeni, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
