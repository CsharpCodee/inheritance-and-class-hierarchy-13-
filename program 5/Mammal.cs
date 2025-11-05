using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зкфсешс12._5
{
    public class Mammal : Animal
    {
        public string FurType { get; set; }
        public int GestationPeriod { get; set; } 

        public Mammal(string species, int age, string habitat, string diet, string furType, int gestationPeriod): base(species, age, habitat, diet)
        {
            FurType = furType;
            GestationPeriod = gestationPeriod;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Млекопитающее: {Species}, возраст: {Age}, среда обитания: {Habitat}, рацион: {Diet}, Тип меха: {FurType}, продолжительность беременности: {GestationPeriod} дней.");
        }
    }

}
