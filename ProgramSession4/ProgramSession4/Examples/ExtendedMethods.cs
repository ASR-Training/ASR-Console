using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSession4.Examples
{
    public static class ExtendedMethods
    {
        public static int Square(this int number)
        {
            return number * number;
        }

        public static int Tri(this int no, int k)
        {
            return 2 * no * k;
        }

        public static double Area(this double radius)
        {
            return (radius * radius) * 3.14d;
        }
    }
}
