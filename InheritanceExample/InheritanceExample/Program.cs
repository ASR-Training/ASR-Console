using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceExample.InheritanceExamples;
using InheritanceExample.InheritanceExamples.Partial;
namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //A parent class can be initialized from child class constructors
            //but a child class cannot be initialized from parent class constructors
            //Initialize Base/Parent class from Derived/Child Class Constructors
            // ConstructorOfInheritance obj = new ConstructorBase();
            //ConstructorOfInheritance obj1 = new ConstructorBase("James");

            // ConstructorOfInheritance obj2 = new ConstructorBase(1);
            Dog d = new Dog();
            d.Description();
            Cat c = new Cat();
            c.Description();

            MyPartialClass p = new MyPartialClass();
            

            //ConstructorBase b = new ConstructorBase("James");
            Console.ReadKey();
        }
    }

    class AboutMe
    {
        /*
         * Data Members => Holds Raw Values
         * 1 - Variables
         * 2 - Contants
         * 3 - Properties
         */
        
        /* Below are the variables with access rights or access modifiers
         * Public - Information shared to every one
         * Protected - Information shared only to family / Friends / Close Relatives
         * Private - Information is not shared at all
         */
        public string FirstName;
        public string LastName;
        public string Gender;

        /*Can only be consumed by this class or child/derived class*/
        protected string Phone;
        protected string Address;
        protected string SSN;

        /*Can only be consumed by this class only*/
        private string mySecretes;

        /*Constructor*/
        public AboutMe()
        {
            FirstName = "James";
            LastName = "Terry";
            Gender = "Male";
            Phone = "7894561230";
            Address = "New York";
            SSN = "XXXXXXX";
            mySecretes = "hidden";
        }
    }

    class FamilyAndFriends : AboutMe
    {
        
        public void KnowAboutMe()
        {
            Console.WriteLine("phone : {0}", base.Phone);
        }
    }

}
