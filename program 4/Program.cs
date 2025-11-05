using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Course videoCourse = new VideoCourse(10, 300,"Основы python", "Изучите python с нуля", "Александр Быков", 4401m);
            Course textCourse = new TextCourse(5, 15000, "Data Science", "Введение в науку о данных", "Анна Гакова", 6309m);
            Course interactiveCourse = new InteractiveCourse(20, "Quiz-based", "Веб-дизайн", "Создание веб-сайтов с нуля", "Клара Дозорова", 5849m);

            Course[] courses = { videoCourse, textCourse, interactiveCourse };

            foreach (var course in courses)
            {
                Console.WriteLine(course.GetInfo());
                Console.WriteLine(course.StartLearning());
                Console.WriteLine();
            }
        }
    }
}