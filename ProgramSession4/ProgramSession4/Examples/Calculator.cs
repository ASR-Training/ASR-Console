using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSession4.Examples
{
    //Base Class or Parent Class
    class Calculator
    {
        public Calculator(int id)
        {

        }
        public virtual void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition of {a} and {b} is {result}");
        }
        public void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Substraction of {a} and {b} is {result}");
        }
    }

    // Derived Class / Child Class
    class Shape : Calculator
    {
        public Shape(int id,int k,int j) : base(id)
        {

        }
        const double pi = 3.14d;
        public void CircleArea(double rad)
        {
            double result = pi * (rad * rad);
            Console.WriteLine($"Area of Circle for {rad} radius is {result}");
        }

        public override void Add(int a, int b)
        {
            int res = 0;
            for (int i = 0; i < a; i++)
            {
                res = res + b;
            }
            Console.WriteLine($"Multiplication of {a} and {b} is {res}");

        }
    }

    class ABC : Shape
    {
        public ABC(int id, int k, int p, string name) : base(id, k, p)
        {

        }
    }
}
