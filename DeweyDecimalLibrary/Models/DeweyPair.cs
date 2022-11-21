﻿using System;
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

        public int CompareTo(DeweyPair other)
        {
            return this.Number.CompareTo(other.Number);
        }

    }
}
