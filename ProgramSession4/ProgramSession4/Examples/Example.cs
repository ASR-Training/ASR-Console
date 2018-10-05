using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSession4.Examples
{
    class Example
    {
        /*Constructors*/
        /*
            1. The name of constructor is same as of class name.
            2. It is always public
            3. It has no return types.
            4. It can have parameters.
            5. There can be multiple consturctor in a class with different definitions.
        */
        public Example()
        {
            Console.WriteLine("Hello from constructor");
        }

        public Example(string values)
        {
            Console.WriteLine("Hello " + values + " ! Welcome to Example Class");
        }

        public Example(int _userID)
        {
            UserID = _userID;
        }
        /*Data Members*/
        private int UserID;

        /*Member Function*/
        public void DisplayUserID()
        {
            Console.WriteLine("User ID is {0}", UserID);
        }
    }
}
