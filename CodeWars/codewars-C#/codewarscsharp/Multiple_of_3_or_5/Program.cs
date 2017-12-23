using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_of_3_or_5
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            int result = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
