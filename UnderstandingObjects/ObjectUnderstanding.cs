using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingObjects
{
    public class Parent
    {
        public int id { get; set; }
    }
    public class Child : Parent
    {
        public int childid { get; set; }
    }
    public class ObjectUnderstanding
    {


        static void Main(string[] args)
        {
            Parent obj1 = new Child();
            //  Child obj2 = new Parent(); Child cannot call parent
            Parent obj3 = new Parent();
            Child obj4 = new Child();
            obj4.id = 25;
            obj4.childid = 15;


            Console.WriteLine(obj1.id);
            Console.WriteLine(obj4.id);
            Console.WriteLine(obj4.childid);
            Console.ReadKey();

        }
    }
}
