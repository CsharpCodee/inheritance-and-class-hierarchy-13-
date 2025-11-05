using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._2
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, string position, decimal salary, DateTime hireDate)
        {
            Name = name;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
        }
        public string GetEmployeeInfo()
        {
            return $"Имя: {Name}, должность: {Position}, зарплата: {Salary}, дата приема на работу: {HireDate.ToShortDateString()}";
        }
    }
}
