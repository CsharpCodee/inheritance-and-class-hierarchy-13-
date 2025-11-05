using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._3
{
    public class Magazine : LibraryItem
    {
        public int Numberissue {  get; set; }
        public string Periodicity {  get; set; }
        public Magazine(int numberissue, string periodicity, string title, string author, int yearOfPublication, string availabilityStatus) : base(title, author, yearOfPublication, availabilityStatus)
        {
            Numberissue = numberissue;
            Periodicity = periodicity;
        }
        public string GetMagazineOnfo()
        {
            return base.GetLibraryItemInfo() + $"\nНомер выпуска: {Numberissue}, периодичность: {Periodicity}.";
        }
    }
}
