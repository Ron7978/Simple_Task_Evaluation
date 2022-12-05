using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void work()
        {
            Console.WriteLine("It Works....");
        }
    }

    class Student : Person
    {
        public override void work()
        {
            Console.WriteLine("It Studies....");
        }
    }

    class Employee : Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public override void work()
        {
            Console.WriteLine("It Earns....");
        }
    }

    class Manager: Employee
    {
        public sealed override void work()
        {
            Console.WriteLine("It manages a team....");
        }
    }

    class BranchManager : Manager
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.work();
            p1 = new Employee();
            p1.work();
            p1 = new BranchManager();
            p1.work();   
            Console.ReadLine();
        }
    }
}
