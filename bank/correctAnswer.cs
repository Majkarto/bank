using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class correctAnswer
    {
        public bool correct(string answer)
        {

            if (int.TryParse(answer, out int liczba))
            {
                if (liczba >= 1 && liczba <= 3)
                    return true;
            }
            return false;

        }
    }


}
