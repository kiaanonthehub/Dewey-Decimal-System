using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Other
{
    public static class Global
    {
        public static int CountdownTime { get; set; } = 60;
        public static int BonusPoints { get; set; } = 0;

        public static bool SortCallingNos { get; set; } = false;
        public static bool IdentifyingAreas { get; set; } = false;
        public static bool FindCallingNos { get; set; } = false;

    }
}
