using Projekt;

internal class Program
{
    private static void Main(string[] args)
    {
        Pojistovna aplikace = new Pojistovna();
        char volba = '0';

        while (volba != '4')
        {
            aplikace.VypisUvodniObrazovku();
            volba = Console.ReadKey().KeyChar;

            Console.WriteLine();
            switch (volba)
            {
                case '1':
                    aplikace.PridejZaznam();
                    break;
                case '2':
                    aplikace.VypisVsechnyZaznamy();
                    break;
                case '3':
                    aplikace.VyhledejZaznam();
                    break;
                case '4':
                    Console.WriteLine("Libovolnou klávesou ukončíte program...");
                    break;
                default:
                    Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                    break;
            }
            Console.ReadKey();
        }
    }
}