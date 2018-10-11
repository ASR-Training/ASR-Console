using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.InheritanceExamples
{
    abstract class AbstractExample
    {
        /*Cannot create instance of the absract class or cannot create the object of abstract class*/
        /*In order to create instace(object) of the abstract class we have to initialize it with derived class*/
        public AbstractExample()
        {

        }

        /* Abstract Method
         * 1 -  It will always be public
         * 2 - Should be used in derived class
         * 3 - Should use override keyword in derived to use abstract method.
         * 4 - Abstract Method does not have Body
         * 5 - Abstract Method will always be in abstract class.
         * 6 - Abstract class can be inherided form other abstract class as well as simple class
         * 7 - Abstract class can contain properties and other methods as well.
         */

        /*Point 1 and 4 Example*/
        public abstract void PrintMsg();

    }

    /*Point 6 Example*/
    abstract class AbstractExample1 : AbstractExample
    {
        public abstract void Display();
    }

    /*Point 2 and 3 Example*/
    class consumeAbstract : AbstractExample
    {
        public override void PrintMsg()
        {
            // Do something
            Console.WriteLine("Printing using abstract example object");
        }
    }

    class Simple
    {
        public int userID { get; set; }
    }

    class consumeAbstract2 : AbstractExample1
    {
        public override void PrintMsg()
        {
            // Do something
        }

        public override void Display()
        {
            // Do something
        }
    }

    /*Understanding Abstract Class by an example*/
    abstract class Animal
    {
        public abstract void Description();
    }

    class Dog : Animal
    {
        private const string name = "Dog";
        public override void Description()
        {
            Console.WriteLine($"Name of animal is {name}");
        }
    }

    class Cat : Animal
    {
        private const string name = "Cat";
        public override void Description()
        {
            Console.WriteLine($"Name of animal is {name}");
        }
    }
}
