using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._4
{
    public class TextCourse: Course
    {
        public int NumberOfChapters {  get; set; }
        public int TotalTextVolume { get; set; }
        public TextCourse(int numberOfChapters, int totalTextVolume, string title, string desription, string author, decimal price) : base(title, desription, author, price) 
        {
            NumberOfChapters = numberOfChapters;
            TotalTextVolume = totalTextVolume;
        }
        public override string StartLearning()
        {
            return $"Начат текстовой курс: {Title}. Общий объем текста: {TotalTextVolume} слов.";
        }
    }
}
