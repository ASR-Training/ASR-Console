using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSession4.Examples
{
    class Circle
    {
        /*Constuctor*/
        public Circle()
        {

        }

        /*Data Members*/
        private int age; //This is a variable
        public int Age //This is a property
        {
            //Property Giving Values
            get
            {
                return age;
            }

            //Property Taking Values
            set
            {
                age = value;
            }
        }

        private int score;
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                if (value > 150)
                {
                    Console.WriteLine("Incorrect value supplied");
                    score = 0;
                }
                else
                {
                    score = value;
                }
            }
        }


        /*Member Function*/
        public void ShowAge()
        {
            Console.WriteLine($"Age is {age}");
        }
    }
}
