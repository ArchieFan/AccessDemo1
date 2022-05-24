using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //Case 2: consuming members of a class from the child class of same project
    internal class Two : Program 
    {
        static void Main()
        {
            Two p = new Two();
            //p.Test1();  //private
            p.Test2();  //internal
            p.Test3();  //protected
            p.Test4();  //protected internal
            p.Test5();  //public
            Console.ReadLine();
        }
    }
}
