using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSession4.Examples;
namespace ProgramSession4
{
    class Program
    {
        struct Employee
        {
            /*Constructor*/
            public Employee(int id, string name, int age, DateTime d)
            {
                EmpID = id;
                Name = name;
                Age = age;
                DOB = d;
            }

            public int EmpID;
            public string Name;
            public int Age;
            public DateTime DOB;

            public void Display()
            {
                /*Display Values of Data Members of Structure*/
            }
        }

        static void Main(string[] args)
        {
            //Circle c = new Circle();
            //c.Age = 20; //Setter part executes here
            //int StudentAge = c.Age; //Getter part executes here
            //Console.WriteLine("Enter the Score");

            //c.Score = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"You have entered score : {c.Score}");
            //c.ShowAge();

            //Constructor
            //Example e = new Example(2);
            //e.DisplayUserID();

            //student std = new student();
            //Employee emp;

            //Shape s = new Shape();
            //s.Add(20, 30);
            //s.Sub(50, 20);i
            //s.CircleArea(4);

            Consume c = new Consume(1);
            c.Add();
            c.Multiply();
            c.Jack();
           
            Customer cs = new Customer(1);
            cs.Add();

            int a = 4;
            int k = a.Square();
            k = a.Tri(4);

            double d = 2;
            double res = d.Area();
            Console.ReadKey();
        }
    }
}
