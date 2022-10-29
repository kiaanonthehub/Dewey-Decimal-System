using DeweyDecimalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Other
{
    public class GameConverter
    {
        public static DeweyPairGameModel DeweyPairToGameModel(DeweyPair deweyPair)
        {
            return new DeweyPairGameModel { Number = deweyPair.Number, Description = deweyPair.Description };
        }

        public static List<DeweyPairGameModel> DeweyPairListToGameModel(List<DeweyPair> pairs)
        {
            List<DeweyPairGameModel> gmList = new List<DeweyPairGameModel>();

            pairs.ForEach(x => gmList.Add(DeweyPairToGameModel(x)));

            return gmList;
        }
    }
}
