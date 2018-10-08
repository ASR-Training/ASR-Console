using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSession4.Examples
{
    public class InheritanceExample
    {
        private int UserID = 0;
        protected int RollNo = 0;
        public InheritanceExample(int id)
        {
            Print();
        }

        public void Print()
        {
            Console.WriteLine("Print from InheritanceExample Class");
        }
    }
    class InheritanceBase : InheritanceExample
    {
        public int baseID { get; set; }
        public InheritanceBase(int id) : base(id)
        {
            
        }
    }

    //Class is Abstract Class due to Abstract Method inside it.
    abstract class Service
    {
        //Constructor
        public Service(int id)
        {

        }

        //Simple Method
        public void Jack()
        {
            Console.WriteLine("This is Jack");
        }
        
        // Virtual Method
        public virtual void Multiply()
        {
            Console.WriteLine("Virtual Multiply");
        }

        /*
         * Abstract Method is method decorated with abstract keyword
         * Abstract Method does not have a method body
         * Abstract Method will have a body in a derived class by overrideing it.
         */
        public abstract int Add();
    }

    class Consume : Service
    {
        public Consume(int id):base(id)
        {

        }
        //Virtual Override
        public override void Multiply()
        {
            Console.WriteLine("Override Multiply");
        }

        //Abstract Override
        public override int Add()
        {
            Console.WriteLine("This is from Consume Class : Abstract Method");
            return 0;
        }
    }

    class Customer : Service
    {
        public Customer(int userID) : base(userID)
        {

        }

        public override int Add()
        {
            Console.WriteLine("This is from Customer Class : Abstract Method");
            return 1;
        }
    }

    public abstract class Car
    {
        public abstract void speed();
    }

    public class SuperCar : Car
    {
        public override void speed()
        {
            Console.WriteLine("Super Speed");
        }
    }

    public class CommercialCar : Car
    {
        public override void speed()
        {
            Console.WriteLine("Normal Speed");
        }
    }

}
