using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Alice", 80000, DateTime.Now, 5);
            Developer developer = new Developer("Sara", 60000, DateTime.Now, "C#");
            Director director = new Director("Kortney", 100000, DateTime.Now, "IT");
            Console.WriteLine(manager.GetEmployeeInfo());
            manager.HoldMeeting();

            developer.GetEmployeeInfo();
            developer.Coding();

            Console.WriteLine(director.GetEmployeeInfo());
            director.ApproveBudget();
        }
    }
}
