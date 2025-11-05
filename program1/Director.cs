using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._2
{
    public class Director : Employee
    {
        public string Department { get; set; }

        public Director(string name, decimal salary, DateTime hireDate, string department)
            : base(name, "Директор", salary, hireDate)
        {
            Department = department;
        }

        public void ApproveBudget()
        {
            Console.WriteLine($"{Name} утверждает бюджет для {Department}.");
        }

        public string GetDirectorInfo()
        {
            return base.GetEmployeeInfo() + $", отдел: {Department}";
        }
    }
}
