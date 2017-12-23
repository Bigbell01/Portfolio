using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_negative
{
    public static class Kata
    {
        public static int MakeNegative(int number)
        {

            if (number == 0)
            {
                return 0;
            }
            else if (number < 0)
            {
                return number;
            }
            else
            {
                return -number;
            }
        }
    }
}
