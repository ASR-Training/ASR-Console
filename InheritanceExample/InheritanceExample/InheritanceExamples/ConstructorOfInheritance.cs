using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.InheritanceExamples
{
    class ConstructorOfInheritance
    {
        /*Data Members
         * Default Information for this to be initalized with constructor 
         */
        protected string Name;
        protected int UserID;

        /*Constructor*/
        /*Default Constructor*/
        public ConstructorOfInheritance()
        {

        }
        // 1
        public ConstructorOfInheritance(string _name)
        {
            Name = _name;
        }

        // 2
        public ConstructorOfInheritance(int _userID)
        {
            UserID = _userID;
        }


        /*Member Function of the Class*/
        public void DisplayWelcomeMsg()
        {
            Console.WriteLine("Welcome {0}, to Constructor of Inheritance class", Name);
        }

    }

    class ConstructorBase : ConstructorOfInheritance
    {
        /*Default Constructor*/
        public ConstructorBase()
        {

        }
        public ConstructorBase(string _name) : base(_name)
        {
            base.Name = _name;
            base.DisplayWelcomeMsg();
        }
        public ConstructorBase(int _userID) : base(_userID)
        {

        }

        /*Member Functions*/
        public void DisplayName()
        {
            Console.WriteLine($"Name from parent class is {base.Name}");
        }
    }
}
