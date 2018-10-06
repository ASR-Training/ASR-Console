using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSession4.Examples
{
    class student
    {
        /*Default Constructor*/
        public student()
        {

        }

        /*Data Members*/
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }

        /*Polymorphism Example*/
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition of {a} and {b} is {result}");
        }

        public void Add(string a, string b)
        {
            string result = a + b;
            Console.WriteLine($"Addition of {a} and {b} is {result}");
        }
    }
}
