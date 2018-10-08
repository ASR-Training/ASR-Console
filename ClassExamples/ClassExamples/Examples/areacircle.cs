using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassExamples.Examples;

namespace ClassExamples
{
    class Areacircle
    {
        static void Start(string[] args)
        {
            circle obj2 = new circle();

            obj2.Calculate(20, (3.14));
            decimal a = obj2.Cal(60, (3.14));
            Console.WriteLine($"area of the circle  from Return Method is {a}");
            obj2.Calcy();
            int b = obj2.Calcu();
            Console.WriteLine($"area of the circle from Return Method is {b}");
            Console.ReadKey();
        }
    }
}
