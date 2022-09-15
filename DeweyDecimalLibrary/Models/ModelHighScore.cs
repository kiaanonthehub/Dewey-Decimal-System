using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Models
{
    public class ModelHighScore
    {
        public string Username { get; set; }
        public int Score { get; set; }
        public ModelHighScore() { }
        public ModelHighScore(string username, int score) { Username = username; Score = score; }

    }
}
