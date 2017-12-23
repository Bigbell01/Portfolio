using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fizz_Buzz
{
    public static class Kata
    {
        public static int[] Solution(int value)
        {
            int m5 = 0;
            int m3 = 0;
            int m35 = 0;

            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    m3++;
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    m5++;
                }
                else if (i % 3 == 0 && i % 5 == 0 && i != 0)
                {
                    m35++;
                }


            }
            int[] result = new int[3] { m3, m5, m35 };
            return result;
        }
    }
}
