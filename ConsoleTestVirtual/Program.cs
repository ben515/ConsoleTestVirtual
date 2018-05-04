using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestVirtual
{
    class A
    {
        public void Print()
        {
            Console.WriteLine("This is A.print");
        }
    }
    class B :A
    {
        public new void Print()
        {
            Console.WriteLine("This is B.Print");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new B();
            obj.Print();
            Console.ReadKey();

        }
    }
}
