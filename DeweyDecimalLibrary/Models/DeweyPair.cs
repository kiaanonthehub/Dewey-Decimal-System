using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Models
{
    public class DeweyPair : IComparable<DeweyPair>
    {
        public string Number { get; set; }
        public string Description { get; set; }

        public DeweyPair()
        {

        }

        public override string ToString()
        {
            return Number;
        }

        public int CompareTo(DeweyPair other)
        {
            return this.Number.CompareTo(other.Number);
        }

        public override bool Equals(object obj)
        {
            if (obj is DeweyPair)
            {
                DeweyPair o = (DeweyPair)obj;
                return this.Number.Equals(o.Number);
            }

            return base.Equals(obj);
        }

        public bool Equals(DeweyPair obj)
        {
            return this.Number.Equals(obj.Number);
        }
    }
}
