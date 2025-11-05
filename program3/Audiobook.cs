using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._3
{
    public class Audiobook: LibraryItem
    {
        public string Speaker {  get; set; }
        public int Duration { get; set; }
        public Audiobook(string speaker, int duration, string title, string author, int yearOfPublication, string availabilityStatus) :base(title, author, yearOfPublication, availabilityStatus)
        {
            Speaker = speaker;
            Duration = duration;
        }
        public string GetAudiobookInfo()
        {
            return base.GetLibraryItemInfo() + $"\nДиктор {Speaker}, длительность {Duration} минут.";
        }
    }
}
