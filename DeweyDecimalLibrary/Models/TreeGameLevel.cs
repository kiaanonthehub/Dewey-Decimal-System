using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Models
{
    public class TreeGameLevel
    {
        public List<DeweyPairGameModel> AnswerPath { get; set; }
        public List<DeweyPairGameModel> Level1Options { get; set; }
        public List<DeweyPairGameModel> Level2Options { get; set; }
        public List<DeweyPairGameModel> Level3Options { get; set; }
    }
}
