using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingPolymorphism
{
    public class Job
    {
        //Over loading example
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        //---------------------------------
        public virtual double Area()
        {
            return 0;
        }

    }

    public class IT_Job
    {

    }

    public class UnderstandingPolymorphism
    {
        static void Main(string[] args)
        {

        }
    }
}
