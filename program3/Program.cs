using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._3
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Создание объектов
            Book book = new Book(300, "978-3-16-148410-0", "Война и мир", "Лев Толстой", 1869, "Доступна");
            Audiobook audiobook = new Audiobook("Иван Иванов", 600, "1984", "Джордж Оруэлл", 1949, "Доступна");
            DVD dvd = new DVD(120, "PG-13", "Интерстеллар", "Кристофер Нолан", 2014, "Недоступна");
            Magazine magazine = new Magazine(5, "Ежемесячно", "Наука и жизнь", "Разные авторы", 2023, "Доступна");

            // Вывод информации о каждом элементе библиотеки
            Console.WriteLine(book.GetBookInfo());
            Console.WriteLine();
            Console.WriteLine(audiobook.GetAudiobookInfo());
            Console.WriteLine();
            Console.WriteLine(dvd.GetDVDInfo());
            Console.WriteLine();
            Console.WriteLine(magazine.GetMagazineOnfo());
        }
    }
}