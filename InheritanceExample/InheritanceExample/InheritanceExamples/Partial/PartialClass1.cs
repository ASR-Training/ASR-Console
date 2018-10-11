using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.InheritanceExamples.Partial
{
    public partial class MyPartialClass : Parent2
    {
        public MyPartialClass()
        { }

        public void Method1()
        {
            Console.WriteLine("Partial Class from PartialClass1");
        }
    }


}
