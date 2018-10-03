using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationSession1.Concepts
{
    /*Class has data members and member functions/Methods */
    class Mathematics
    {
        /*
            Data Members 

            1. Variables
            2. Constants
            3. Properties
        */


        /*Variable Example*/
        public int Value1; public int Value2;
        public decimal result;


        /*Constant Example*/
        public const float pi = 3.14f;
        public const int MaxValue = 15;

        /*Properties*/
        
        //Automatic Properties
        public string Name { get; set; }
        public int Age { get; set; }

        //Custom Properties
        private string stdName;
        public string StudentName
        {
            get { return stdName; }
            set { stdName = value; }
        }


        /*
            Member Functions/Methods

            There are 4 Types of Member Functions
            1. Method Without Parameter and Without Return
            2. Method With Parameter and Without Return
            3. Method Without Parameter and With Return
            4. Method With Parameter and with Return
         */


        // 1. Method Without Parameter and Without Return
        // void keyword specifies that a method will not return any values
        // Syntax: void <Name of Method>()
        public void Add()
        {
            Value1 = 10;
            Value2 = 20;
            result = Value1 + Value2;
        }

        //2. Method With Parameter and Without Return
        //Syntax: void <Name of Method>(parameters)
        public void Addition(int a, int b)
        {
            result = a + b;
        }

        //3. Method Without Parameter and With Return
        //Syntax: ReturnType <Name of method()
        // ReturnType = Data Type (system defined data type or user defined data type)
        // This type of method will always use 'return' keyword
        // Return Type should be same as the function return

        public int Substract()
        {
            int k = 10;
            return k;
        }

        //4. Method With Parameter and with Return
        //Syntax: ReturnType <Name of method(parameters)
        public int substraction(int k)
        {
            return k;
        }
    }
}
