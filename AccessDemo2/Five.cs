using System;

namespace AccessDemo2
{
    //Case 5: consuming members of the class from non-child class of different project
    internal class Five
    {
        static void Main()
        {
            AccessDemo1.Program p = new AccessDemo1.Program();
            //p.Test1(); //private? No, not in the same class 
            //p.Test2(); //internal? No, not in the same project
            //p.Test3(); //protected? No, not a child class
            //p.Test4(); //protected internal? No, both internal and protested are not accessible
            p.Test5();
            Console.ReadLine();

        }
    }
}
