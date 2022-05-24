using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    // Case 1: consuming members of a class from the same class
    public class Program
    {
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }

        internal void Test2()
        {
            Console.WriteLine("internal Method");
        }

        protected void Test3()
        {
            Console.WriteLine("protected Method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("protected internal Method");
        }

        public void Test5()
        {
            Console.WriteLine("public Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1();  //private
            p.Test2();  //internal
            p.Test3();  //protected
            p.Test4();  //protected internal
            p.Test5();  //public
            Console.ReadLine();

        }
    }
}
