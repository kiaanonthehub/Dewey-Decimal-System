using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Models
{
    public class BookModel : IComparable<BookModel>
    {
        public string CallNumber { get; set; }

        public BookModel(string callNumber)
        {
            CallNumber = callNumber;
        }

        public int CompareTo(BookModel other)
        {
            return CallNumber.CompareTo(other.CallNumber);
        }
    }
}
