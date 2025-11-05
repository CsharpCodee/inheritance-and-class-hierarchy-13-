using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._2
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, decimal salary, DateTime hireDate, int teamSize): base(name, "Менеджер", salary, hireDate)
        {
            TeamSize = teamSize;
        }

        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} проводит встречу с командой.");
        }

        public string GetManagerInfo()
        {
            return base.GetEmployeeInfo() + $", размер команды: {TeamSize}";
        }
    }
}
