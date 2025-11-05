using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зкфсешс12._5
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; } 
        public string NestingType { get; set; }

        public Bird(string species, int age, string habitat, string diet, double wingSpan, string nestingType): base(species, age, habitat, diet)
        {
            WingSpan = wingSpan;
            NestingType = nestingType;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Птица: {Species}, возраст: {Age}, среда обитания: {Habitat}, рацион: {Diet}, размах крыльев: {WingSpan} метров, тип гнездования: {NestingType}.");
        }
    }
}
