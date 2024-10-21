using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Pojistenec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }

        public string TelCislo { get; set; }

        public Pojistenec(string jmeno, string prijmeni, int vek, string telCislo)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Vek = vek;
            this.TelCislo = telCislo;
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + Vek + " " + TelCislo;
        }
    }
}
