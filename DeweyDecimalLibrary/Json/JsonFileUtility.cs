using DeweyDecimalLibrary.Models;
using System.Text.Json;

namespace DeweyDecimalLibrary.Json
{
    public class JsonFileUtility
    {
        public static string SortingCallNosFile = "SortingCallNumbersLeaderboard.json";

        // creates the json file
        public static void CreateJsonFile(string filename)
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
        public static void AppendScores(ModelHighScore highScore , string filename)
        {
            List<ModelHighScore> lstHighScore = GetAllScores(filename);

            lstHighScore.Add(highScore);

            File.WriteAllText(filename, JsonSerializer.Serialize(lstHighScore));
        }

        // returns all existing score in json file
        public static List<ModelHighScore> GetAllScores(string filename)
        {
            return JsonSerializer.Deserialize<List<ModelHighScore>>(File.ReadAllText(filename));
        }
        public static bool FileExists(string fileName)
        {
            if (File.Exists(fileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
