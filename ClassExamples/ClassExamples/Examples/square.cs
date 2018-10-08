using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassExamples.Examples;

namespace ClassExamples

{
    class square
    {
        static void Start(string[] args)
        {
            areaofthesquare obj1 = new areaofthesquare();

            obj1.Multiplication(20);
            int a = obj1.Mult(60);
            Console.WriteLine($"area of the square  from Return Method is {a}");
            obj1.Multy();
            int b = obj1.Multiply();
            Console.WriteLine($"area of the square from Return Method is {b}");
            Console.ReadKey();
        }
    }
}
