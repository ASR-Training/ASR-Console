using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.InheritanceExamples
{
    /* Types of Inheritance
     * 1. Single
     * 2. Multi-Level
     * 3. Multiple - Not Supported in C#
     * 4. Heirarchial - Not Supported in C#
     */

    /* Below is the Example of Single Inheritance
     */
    class BaseClass
    {

    }

    class DerivedClass : BaseClass
    {

    }
    /*----------Single Inheritance Ends Here----------------*/

    /*----------Multi-Level Inheritance---------------------*/
    class Level_1
    {

    }
    class Level_2 : Level_1
    {

    }
    class Level_3 : Level_2
    {

    }
    class Level_4 : Level_3
    {

    }
    /*-----------Multi-Level Inheritance Ends Here-------------*/

    /*One Parent/Base class can be derived to different Child/Derived Classes*/
    class Parent1
    { }

    class Child1: Parent1
    { }

    class Child2: Parent1
    { }

}
