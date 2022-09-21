using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Other
{
    // global class that contains properties which can be accessed throughout the 
    public static class Global
    {
        public static int CountdownTime { get; set; } = 60;
        public static int BonusPoints { get; set; } = 0;
        public static int Points { get; set; } = 0;
        public static bool UpdateUserControl { get; set; } = false;

        public static bool SortCallingNos { get; set; } = false;
        public static bool IdentifyingAreas { get; set; } = false;
        public static bool FindCallingNos { get; set; } = false;
        public static bool SaveScore { get; set; } = false;
        public static string Username { get; set; } = null;
    }
}
