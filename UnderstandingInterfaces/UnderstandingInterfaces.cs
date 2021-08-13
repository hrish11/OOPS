using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInterfaces
{
    interface first
    {
        void run();

    }
    interface second
    {
        void run();
    }

    public class TestProgram : first, second
    {
        void first.run()
        {
            Console.WriteLine("Interface 1 method");
        }
        void second.run()
        {
            Console.WriteLine("Interface 2 method");
        }

    }

    public class UnderstandingInterfaces
    {
        static void Main(string[] args)
        {
            first obj1 = new TestProgram();
            obj1.run();

            second obj2 = new TestProgram();
            obj2.run();
            Console.ReadKey();
        }

    }
}
