using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зкфсешс12._5
{
    public abstract class Animal
    {
        protected string Species { get; set; }
        protected int Age { get; set; }
        protected string Habitat { get; set; }
        protected string Diet { get; set; }

        public Animal(string species, int age, string habitat, string diet)
        {
            Species = species;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Species} ест {Diet}.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Species} издает звук.");
        }

        public abstract void DisplayInfo();
    }
}