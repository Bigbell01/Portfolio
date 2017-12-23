using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_angle_of_a_triangle
{
    public static class Kata
    {
        public static int OtherAngle(int a, int b)
        {
            return 180 - (a + b);
        }
    }
}
