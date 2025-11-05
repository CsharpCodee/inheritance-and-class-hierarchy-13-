using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practic12._3
{
    public class Book: LibraryItem
    {
        public int Pages {  get; set; }
        public string ISBN { get; set; }
        public Book(int pages,string isbn, string title, string author, int yearOfPublication, string availabilityStatus) :base(title,author,yearOfPublication,availabilityStatus)
        {
            Pages = pages;
            ISBN = isbn;
        }
        public string GetBookInfo()
        {
            return base.GetLibraryItemInfo()+ $"\n{Pages} страниц, ISBN: {ISBN}";
        }
    }
}
