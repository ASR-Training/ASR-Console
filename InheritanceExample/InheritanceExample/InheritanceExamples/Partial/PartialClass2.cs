using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.InheritanceExamples.Partial
{
    public partial class MyPartialClass : Parent2
    {
        public MyPartialClass(string name)
        {
            
        }
        public void Method2()
        {
            Console.WriteLine("Partial Class from PartialClass2");
        }
    }


}
