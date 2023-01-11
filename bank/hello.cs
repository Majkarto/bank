using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class hello
    {

        public string welcomescreen()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZTSTKICH KLIJENTÓW BANKU");
            Console.WriteLine("2 => LOGOWANIE");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.Write("WYBIERZ 1, 2 LUB 3: ");
            string odp = Console.ReadLine();
            return odp;
        }
    }
    public class badansw
    {

        public void bad()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podano złą odpowiedź");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class error
    {
        public void loginerror()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nieprawidłowy numer konta");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class displayClient
    {
        public void display(string id, string name, string accountnr, decimal accountvalue)
        {
            Console.WriteLine($"{id} | {name} | {accountnr} | {accountvalue}");
        }
    }
}
