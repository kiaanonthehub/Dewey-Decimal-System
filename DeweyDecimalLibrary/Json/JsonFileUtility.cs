using DeweyDecimalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Json
{
    public class JsonFileUtility
    {
        private const string filename = "Highscore.json";

        // creates the json file
        public static void CreateJsonFile()
        {
            // initialised list with pre populated data
            List<ModelHighScore> initializeHighScore = new List<ModelHighScore>()
            {
                new ModelHighScore("Kiaan",95),
                new ModelHighScore("Ebrahim",98),
                new ModelHighScore("Trent",94),
                new ModelHighScore("Serina",92)
            };

            File.WriteAllText(filename, JsonSerializer.Serialize(initializeHighScore));
        }

        // appends data to existing json file
        public static void AppendScores(ModelHighScore highScore)
        {
            List<ModelHighScore> lstHighScore = GetAllScores();

            lstHighScore.Add(highScore);

            File.WriteAllText(filename, JsonSerializer.Serialize(lstHighScore));
        }

        // returns all existing score in json file
        public static List<ModelHighScore> GetAllScores()
        {
            return JsonSerializer.Deserialize<List<ModelHighScore>>(File.ReadAllText(filename));
        }
    }
}
