using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplicationSession1.sravanthi;
namespace TestApplicationSession1
{
    class Program
    {
        public struct Student
        {
            public string Name;
            public int Age;
            public char Gender;
        }

        static void Main(string[] args)
        {
            //Using Non Static Member of a Class
            basicprograming b = new basicprograming();
            int i = b.Add(20, 30);

            // Using Static Member of a Class.
            int k = basicprograming.Addition(30, 40);

            Console.WriteLine("Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine($"Addition of {num1} and {num2} is {result}");
            Console.WriteLine("Addition of {num1} and {num2} is {result}");
            Console.WriteLine("Addition of {0} and {1} is {2}", num1, num2, result);


            Student std = new Student();
            Console.WriteLine("Please enter the Name : ");
            std.Name = Console.ReadLine();
            Console.WriteLine("Please enter the Age : ");
            std.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Gender : ");
            std.Gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"You have entered {std.Name} - {std.Gender} - {std.Age}");

            Console.ReadKey();
        }

        public  void GetData()
        {

        }


    }
}
