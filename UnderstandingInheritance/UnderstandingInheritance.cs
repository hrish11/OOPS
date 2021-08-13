using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{

    public class Employee
    {
        public double Salary { get ; set ; }
    }

    public class Sales_Employee: Employee
    {
        public double Sales_Salary = 1000;
        
        public virtual void Get_Salary()
        {
            double total = Salary + Sales_Salary;
            Console.WriteLine("Sales_Emp "+total);
        }
    }

    public class Tech_Employee: Sales_Employee
    {
        public double Tech_Salary = 8694.32;

        public override void Get_Salary()
        {
            double total = Salary + Sales_Salary + Tech_Salary;
            Console.WriteLine("Tech_Emp " + total);
        }

    }

    public class UnderstandingInheritance
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Salary = 11200.532;
            Sales_Employee e2 = new Sales_Employee();
            e2.Salary = 400;
            e2.Get_Salary();
            Employee e3 = new Sales_Employee();
            e3.Salary = 232.453;
            Tech_Employee e4 = new Tech_Employee();
            e4.Salary = 32132.42;
            e4.Get_Salary();
            Console.ReadKey();
        }
    }
}
