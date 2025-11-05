using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._2
{
    public class Developer : Employee
    {
        public string ProgLanguage { get; set; }

        public Developer(string name, decimal salary, DateTime hireDate, string progLanguage)
            : base(name, "Разработчик", salary, hireDate)
        {
            ProgLanguage = progLanguage;
        }

        public void Coding()
        {
            Console.WriteLine($"{Name} пишет на {ProgLanguage}.");
        }

        public string GetDeveloperInfo()
        {
            return base.GetEmployeeInfo() + $", язык программирования: {ProgLanguage}";
        }
    }
}
