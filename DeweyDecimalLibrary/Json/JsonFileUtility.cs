using DeweyDecimalLibrary.Models;
using System.Text.Json;

namespace DeweyDecimalLibrary.Json
{
    public class JsonFileUtility
    {
        // file names
        public static string SortingCallNosFile =   "SortingCallNumbersLeaderboard.json";
        public static string IdentifyingAreasCallNo = "IdentifyingAreasCallNo.json";
        public static string IdentifyingAreasFile = "IdentifyingAreasLeaderboard.json";
        public static string FindingCallNosFile =   "FindingCallNumbersLeaderboard.json";

        #region Sorting Call Numbers
        // creates the json file
        public static void CreateJsonFile(string filename)
        {

            // instantiate random object
            Random rnd = new Random();

            // initialised list with random pre populated data
            List<ModelHighScore> initializeHighScore = new List<ModelHighScore>()
            {
                new ModelHighScore( "Kiaan",     rnd.Next(1, 101)),
                new ModelHighScore( "Dhiya",     rnd.Next(1, 101)),
                new ModelHighScore( "Ebrahim",   rnd.Next(1, 101)),
                new ModelHighScore( "Trent",     rnd.Next(1, 101)),
                new ModelHighScore( "Sarina",    rnd.Next(1, 101)),
                new ModelHighScore( "Tyrese",    rnd.Next(1, 101)),
                new ModelHighScore( "Abdullah",  rnd.Next(1, 101)),
                new ModelHighScore( "Tyler",     rnd.Next(1, 101)),
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
        #endregion

        #region Identifying Areas
        // check if the json file exists
        public static bool CallNumFileExists()
        {
            if (File.Exists(IdentifyingAreasCallNo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // creates the json file
        public static void CreateCallNumFile()
        {
            // declare dictionary
            Dictionary<string, string> callNums = new Dictionary<string, string>();

            // populate dictionary
            callNums.Add("000", "General Knowledge");
            callNums.Add("100", "Philosophy & Psychology");
            callNums.Add("200", "Religion");
            callNums.Add("300", "Social Sciences");
            callNums.Add("400", "Language");
            callNums.Add("500", "Natural Sciences & Mathematics");
            callNums.Add("600", "Technology (Applied Sciences)");
            callNums.Add("700", "The Arts");
            callNums.Add("800", "Literature & Rhetoric");
            callNums.Add("900", "Geography & History");

            File.WriteAllText(IdentifyingAreasCallNo, JsonSerializer.Serialize(callNums));
        }

        // retrieve json file into dictionary 
        public static Dictionary<string, string> GetKeyValuePairs()
        {
            return JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(IdentifyingAreasCallNo));
        }
        #endregion
    }
}
