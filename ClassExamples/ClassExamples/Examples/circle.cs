using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples.Examples
{
    class circle
    {
        public void Calculate(int area, Double pi)
        {
            double result = (3.14)* area * area;
            Console.WriteLine($"area of the circle  is {result}");
        }

        public int Cal(decimal area , decimal pi)
        {
            decimal result = pi * area * area;
          
            return result;
        }

        public void Calcy()
        {
            int area = 10;
             
           double result = (3.14)* area * area;
            Console.WriteLine($"area of the circle is {result}");
        }

        public int Calcu()
        {
            int area = 30;
          
            double result =(3.14)* area * area;
            return result;
        }

    }
}

