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
        }

        static void Main(string[] args)
        {
            Student[] s = new Student[3];
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("Enter Name: ");
                s[i].Name = Console.ReadLine();
                Console.Write("enter sub1: ");
                int sub1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter sub2: ");
                int sub2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter sub3:");
                int sub3 = Convert.ToInt32(Console.ReadLine());
                int total = sub1 + sub2 + sub3;
                Console.WriteLine($" addition of {sub1}-{sub2}-{sub3} is {total} ");
                float avg = (total / 3);
                Console.WriteLine($"avg is {avg}");
                if (sub1 < 35 || sub2 < 35 || sub3 < 35)
                {
                    Console.WriteLine("fail");
                }
                else
                    Console.WriteLine("pass");
                if (avg <= 65)
                {
                    Console.WriteLine("distinction");

                }
                else if (avg >= 70)
                {
                    Console.WriteLine("state");

                }


                Console.ReadKey();
            }


        }
    }

}
