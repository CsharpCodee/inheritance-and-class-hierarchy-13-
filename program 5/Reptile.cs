using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зкфсешс12._5
{
    public class Reptile: Animal
    {
        public string SkinType { get; set; }
        public double Temperature { get; set; } 

        public Reptile(string species, int age, string habitat, string diet, string skinType, double temperature): base(species, age, habitat, diet)
        {
            SkinType = skinType;
            Temperature = temperature;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Рептилия: {Species}, возраст: {Age}, среда обитания: {Habitat}, рацион: {Diet}, тип кожи: {SkinType}, температура среды: {Temperature}°C.");
        }
    }
}

