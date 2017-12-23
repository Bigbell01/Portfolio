using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_falling_speed_of_petals
{
    public static class Kata
    {
        public static double SakuraFall(double v)
        {
            if (v < 0)
            {
                return 0;
            }
            if (v == 0)
            {
                return 0;
            }
            else
            {
                return 400 / v;
            }
        }
    }
}
