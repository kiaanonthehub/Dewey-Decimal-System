using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Logic
{
    public class MatchingCallNosDescription
    {
       
        // declare and initialise counter
        int count = 0;

        #region List Description
        public List<ModelIdentifyingCallNos> GetDescription()
        {
            // check if json file exists - if !true create json file 
            if (!JsonFileUtility.CallNumFileExists()) { JsonFileUtility.CreateCallNumFile(); }

            // create dictionary 
            Dictionary<string, string> callNums = JsonFileUtility.GetKeyValuePairs();

            // instantiate random object
            Random rnd = new Random();

            // declare temp list
            List<int> randomNums = new List<int>();

            //generate 7 unique random numbers
            while (randomNums.Count <= 6)
            {
                int n = rnd.Next(0, 10);

                if (!randomNums.Contains(n))
                {
                    randomNums.Add(n);
                }
            }

            //use list of key value objs 
            List<ModelIdentifyingCallNos> lstRandomCallNos = new List<ModelIdentifyingCallNos>();

            foreach (int num in randomNums)
            {
                // format call numebrs
                lstRandomCallNos.Add(new ModelIdentifyingCallNos { Key = $"{num}00", Value = callNums.GetValueOrDefault($"{num}00") });
            }

            return lstRandomCallNos;
        }
        #endregion

        #region List Call Numbers
        // generate 4 call numbers from the generated dictionary of 7 KeyValuePairs (description)
        public List<string> GetCallNos()
        {
            // loop through randomised dictionary and get first four random call nos
            for (int i = 0; i < 4; i++)
            {
                // gets all keys from shuffled dictionary and gets the first 4 call numbers which is then shuffled again before populating listbox 
                Global.lstCallNos.Add((string)Global.lstDescription.ToList().Select(x => x.Key).ToList().ElementAt(i));
            }

            return Global.lstCallNos;
        }

        #endregion

        #region Check Users Answer

        // check if the user input matches the dictionary key value pair
        public bool CheckAnswer(string callNo, string desc)
        {
            // populate the dictionary with the key value pairs stored in json file
            Global.dictCallNoDescription = JsonFileUtility.GetKeyValuePairs();

            // decalre temp dictionary
            Dictionary<string, string> tempDict = new Dictionary<string, string>();

            // populate temp dictionary with user input
            tempDict.Add(callNo, desc);

            // iterate through temp dictionary
            foreach (var x in tempDict)
            {
                // iterate through json dictionary - contains all listed key value pairs
                foreach (var y in Global.dictCallNoDescription)
                {
                    // check if the user pair matches the predefined pairs 
                    if (x.Key.Equals(y.Key) && x.Value.Equals(y.Value))
                    {
                        count++;

                        return true;
                    }
                }
            }
            return false;
        }

        #endregion

        #region Game Finished
        // method to check if the player has completed the game 
        public bool isGameFinished(int listboxItemsCount)
        {
            if (count == 4 || listboxItemsCount == 0)
            { return true; }
            else
            { return false; }
        }
        #endregion
    }
}
