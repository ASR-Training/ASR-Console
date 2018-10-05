using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassExamples.Examples;
namespace ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicMaths obj = new BasicMaths();
            obj.Addition(20, 30);
            int a = obj.Add(50, 60);
            Console.WriteLine($"Addition from Return Method is {a}");
            obj.Sum();
            int b = obj.Multiply();
            Console.WriteLine($"Multiplication from Return Method is {b}");
            Console.ReadKey();
        }
    }
}
