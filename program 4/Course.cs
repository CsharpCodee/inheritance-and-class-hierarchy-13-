using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._4
{
    public abstract class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price {  get; set; }

        public Course(string title, string desription, string author, decimal price) 
        {
            Title= title;
            Description = desription;
            Author = author;
            Price = price;
        }
        public virtual string GetInfo()
        {
            return $"Название: {Title}, Описание: {Description}, автор: {Author}, ценa: {Price} рублей/мес.";
        }
        public abstract string StartLearning();
    }
}
