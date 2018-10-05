using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples.Examples
{
    class BasicMaths
    {
        public void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition of {a} and {b} is {result}");
        }

        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public void Sum()
        {
            int a = 20;
            int b = 30;
            int result = a + b;
            Console.WriteLine($"Addition of {a} and {b} is {result}");
        }

        public int Multiply()
        {
            int a = 2;
            int b = 3;
            int result = a * b;
            return result;
        }
        
    }
}
