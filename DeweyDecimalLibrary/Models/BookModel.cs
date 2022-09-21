using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Models
{
    // obj model 
    public class BookModel : IComparable<BookModel>
    {
        // property
        public string CallNumber { get; set; }

        // constructor
        public BookModel(string callNumber)
        {
            CallNumber = callNumber;
        }

        // implementation
        public int CompareTo(BookModel other)
        {
            return this.CallNumber.CompareTo(other.CallNumber);
        }
    }
}
