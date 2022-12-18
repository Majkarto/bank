using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class hello
    {

        public string witam()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZTSTKICH KLIJENTÓW BANKU");
            Console.WriteLine("2 => LOGOWANIE");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
            string odp = Console.ReadLine();
            return odp;
        }
    }
}
