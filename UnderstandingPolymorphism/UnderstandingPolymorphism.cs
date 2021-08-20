using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingPolymorphism
{
    public class Job
    {
        //Overloading example
        public void Add(int a, int b, int c)// 1st 
        {
            Console.WriteLine(a + b + c);
        }
        public void Add(int a, int b)// 2nd overloaded method
        {
            Console.WriteLine(a + b);
        }
        //---------------------------------
        //Overridding example
        internal virtual void Area()
        {
            Console.WriteLine("BaseArea"); ;
        }

    }

    public class IT_Job: Job
    {
        //Overloading example in child class

        public void Add(int a, int b, int c, int d)// 2nd overloaded method in child class
        {
            Console.WriteLine(a + b + c + d);
        }
        //---------------------------------
        //Overridding example in child class
        internal override void Area()
        {
            Console.WriteLine("ChildArea");
        }
    }

    public class UnderstandingPolymorphism
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parent Class with Parent obj instance");
            Job job = new Job();
            job.Add(1, 2);
            job.Add(1, 2, 3);
            job.Area();

            Console.WriteLine("Child Class with Parent obj instance");
            Job job1 = new IT_Job();
            job1.Add(1, 2);
            job1.Add(1, 2, 3);
            //job1.Add(1, 3, 4, 5); Parent class cannot access Child method or variables.
            job1.Area();

            Console.WriteLine("Child Class with Child obj instance");
            IT_Job itjob = new IT_Job();
            itjob.Add(5, 6);
            itjob.Add(5, 6, 7);
            itjob.Add(5, 6, 7, 8);
            itjob.Area();

            //IT_Job itjob1 = new Job(); Compile time error. Child instance cannot call parent constructor. 

            Console.ReadKey();
        }
    }
}
