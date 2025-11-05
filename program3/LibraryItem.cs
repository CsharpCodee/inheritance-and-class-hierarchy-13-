using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._3
{
    public class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public string AvailabilityStatus { get; set; }


        public LibraryItem(string title, string author, int yearOfPublication, string availabilityStatus) 
        {
            Title = title;
            Author = author;
            YearOfPublication = yearOfPublication;
            AvailabilityStatus = availabilityStatus;
        }
        public string GetLibraryItemInfo()
        {
            return $"Название: {Title}, автор: {Author}, год издания: {YearOfPublication}, доступна: {AvailabilityStatus}";
        }
    }
}
