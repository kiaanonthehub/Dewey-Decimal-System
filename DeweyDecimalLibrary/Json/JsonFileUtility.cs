using DeweyDecimalLibrary.Models;
using System.Text.Json;

namespace DeweyDecimalLibrary.Json
{
    public class JsonFileUtility
    {
        // file names
        public static string SortingCallNosFile =   "SortingCallNumbersLeaderboard.json";
        public static string IdentifyingAreasFile = "IdentifyingAreasLeaderboard.json";
        public static string FindingCallNosFile =   "FindingCallNumbersLeaderboard.json";

        // creates the json file
        public static void CreateJsonFile(string filename)
        {

            // instantiate random object
            Random rnd = new Random();

            // initialised list with random pre populated data
            List<ModelHighScore> initializeHighScore = new List<ModelHighScore>()
            {
                new ModelHighScore( "Kiaan",     rnd.Next(1, 101)),
                new ModelHighScore( "Ebrahim",   rnd.Next(1, 101)),
                new ModelHighScore( "Trent",     rnd.Next(1, 101)),
                new ModelHighScore( "Tyrese",    rnd.Next(1, 101)),
                new ModelHighScore( "Abdullah",  rnd.Next(1, 101)),
                new ModelHighScore( "Tyler",     rnd.Next(1, 101)),
                new ModelHighScore( "Dhiya",     rnd.Next(1, 101))
            };

            File.WriteAllText(filename, JsonSerializer.Serialize(initializeHighScore));
        }

        // appends data to existing json file
        public static void AppendScores(ModelHighScore highScore, string filename)
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

        // checks to see if the json file exists before it can be used
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
