using System;

namespace AccessDemo2
{
    //Case 4: consuming members of a class from the child class of different project
    internal class Four : AccessDemo1.Program
    {
        static void Main(string[] args)
        {
            Four p = new Four();
            //p.Test1();  //private
            //p.Test2();  //internal
            p.Test3();  //protected
            p.Test4();  //protected internal
            p.Test5();  //public
            Console.ReadLine();
        }
    }
}
