using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зкфсешс12._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal mammal = new Mammal("слон", 10, "савана", "трава", "толстая", 660);
            Animal bird = new Bird("орел", 5, "горы", "мясо", 2.5, "дерево");
            Animal reptile = new Reptile("игуана", 3, "тропический лес", "растения", "чешуйчатый", 30);
            Animal fish = new Fish("золотая рыбка", 1, "пресноводная", "водоросли", "гладкая", 1);

            Animal[] animals = { mammal, bird, reptile, fish};

            foreach (var animal in animals)
            {
                animal.DisplayInfo();
                animal.Eat();
                animal.MakeSound();
                Console.WriteLine();
            }
        }
    }
}
