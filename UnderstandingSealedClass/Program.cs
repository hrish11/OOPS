using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingSealedClass
{

    class Test3
    {
         int Test3_Property = 10;
      //  Test1 test1 = new Test1(); //Cannot access Private, Protected, Protected Internal class outside of their inner class
     //   Test2 test2 = new Test2(); //Cannot access Private, Protected, Protected Internal class outside of their inner class
        Test3 test3 = new Test3(); 
      //  Test4 test4 = new Test4();///Cannot access Private, Protected, Protected Internal class outside of their inner class
        Test5 test5 = new Test5();
        
        
    }
    sealed class Test5:Test3 //Cannot inherit from sealed class
    {
      //  sealed int Test5_Property=0;
     //   Test1 test1 = new Test1();
      //  Test2 test2 = new Test2();
        Test3 test3 = new Test3();
            //test3.Test3_Property = 10;
     //   Test4 test4 = new Test4();
        Test5 test5 = new Test5();
    }

    static class Test6
    {
        //  public int Test6_Property { get; set; } Compiletime_Error: Cannot declare instance member in static class
    //    Test1 test1 = new Test1();
     //   Test2 test2 = new Test2();
    //    Test3 test3 = new Test3();
    //    Test4 test4 = new Test4();
     //   Test5 test5 = new Test5();
      //  Test7 test7 = new Test7(); // Cannot create instance of static class even though it iself is an static class
    }
    static class Test7
    {
          public static int Test6_Property { get; set; }
     //   Test1 test1 = new Test1();
     //   Test2 test2 = new Test2();
   //     Test3 test3 = new Test3();
       // Test4 test4 = new Test4();
      //  Test5 test5 = new Test5();
    }
    public class Program
    {
        private class Test1:Test2 //private modifier can be only decalred inside a class as inner class 
        {
            public int Test1_Property { get; set; }
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();
            Test3 test3 = new Test3();
            Test4 test4 = new Test4();
            Test5 test5 = new Test5();
        }
        private class Test8 : Test1 //private modifier can be only decalred inside a class as inner class 
        {
            public int Test8_Property { get; set; }
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();
            Test3 test3 = new Test3();
            Test4 test4 = new Test4();
            Test5 test5 = new Test5();
        }
        protected class Test2 //protected modifier can be only decalred inside a class as inner class 
        {
            public int Test2_Property { get; set; }
            Test1 test1 = new Test1();
            //test1.Test1_Property Cannot Access properties of private class
            Test2 test2 = new Test2();
            Test3 test3 = new Test3();
            Test4 test4 = new Test4();
            Test5 test5 = new Test5();
        }

        protected internal class Test4 //internal class modifier can be only decalred inside a class as inner class 
        {
            public int Test4_Property { get; set; }
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();
            Test3 test3 = new Test3();
            Test4 test4 = new Test4();
            Test5 test5 = new Test5();
            //Test6 test6 = new Test6(); Compile_time Error: Cannot create instance of static class
        }


        static void Main(string[] args)
        {
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();
            Test3 test3 = new Test3();
            Test4 test4 = new Test4();
            Test5 test5 = new Test5();
         //   Test6 test6 = new Test6();
         //   Test7 test6 = new Test7();

        }
    }
}
