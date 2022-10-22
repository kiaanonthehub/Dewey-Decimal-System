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

        public static bool Game1 { get; set; } = false;
        public static bool Game2 { get; set; } = false;
        public static bool Game3 { get; set; } = false;

        // declare generic collections
        public static List<ModelIdentifyingCallNos> lstDescription = new List<ModelIdentifyingCallNos>();
        public static List<string> lstCallNos = new List<string>();
        public static Dictionary<string, string> dictCallNoDescription = new Dictionary<string, string>();

    }
}
