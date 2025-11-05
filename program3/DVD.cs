using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._3
{
    public class DVD : LibraryItem
    {
        public int Duration {  get; set; }
        public string Rating {  get; set; }
        public DVD(int duration, string rating, string title, string author, int yearOfPublication, string availabilityStatus) : base(title, author, yearOfPublication, availabilityStatus)
        {
            Duration = duration;
            Rating = rating;
        }
        public string GetDVDInfo()
        {
            return GetLibraryItemInfo() + $"\nПродолжительность: {Duration} минут, рейтинг: {Rating}.";
        }
    }
}
