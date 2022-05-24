using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //Case 3: consuming members of the class from non-child class of same project
    internal class Three
    {
        static void Main()
        {
            Program p = new Program();
            //p.Test1();  //private
            p.Test2();  //internal
            //p.Test3();  //protected
            p.Test4();  //protected internal
            p.Test5();  //public
            Console.ReadLine();
        }
    }
}
