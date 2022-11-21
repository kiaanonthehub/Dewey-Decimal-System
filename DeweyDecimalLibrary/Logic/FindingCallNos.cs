using DeweyDecimalLibrary.Models;
using DeweyDecimalLibrary.Other;
using DeweyDecimalLibrary.Tree_Structure;

namespace DeweyDecimalLibrary.Logic
{
    public class FindingCallNos
    {
        #region Set the game Level
        // uses gets all the required information for a level from the tree
        public TreeGameLevel GetLevel()
        {
            // instantiate tree game object
            TreeGameLevel level = new TreeGameLevel();

            // the path to the answer
            List<DeweyPair> lstAnswerPath = GlobalTree.Tree.GetPathToRandom(GlobalTree.Tree.Root, 3);

            // incorrect options for each level
            List<DeweyPair> lstIncorrectChoice1 = new List<DeweyPair>();
            List<DeweyPair> lstIncorrectChoice2 = new List<DeweyPair>();
            List<DeweyPair> lstIncorrectChoice3 = new List<DeweyPair>();


            // gets options for the first level
            while (lstIncorrectChoice1.Count < 3)
            {
                DeweyPair r = GlobalTree.Tree.GetRandom(1);

                if (!lstAnswerPath.Contains(r) && !lstIncorrectChoice1.Contains(r))
                {
                    lstIncorrectChoice1.Add(r);
                }
            }

            //gets the children of the first level
            lstIncorrectChoice2 = GlobalTree.Tree.GetChildren(lstAnswerPath[0]);

            //removes the correct option from the list of children
            if (lstIncorrectChoice2.Remove(lstAnswerPath[1]))
            {
                Console.WriteLine("Removed Answer");
            }

            // if there are 3 or more children for a single level
            while (lstIncorrectChoice2.Count > 3)
            {
                //pick random from the children
                Random r = new Random();

                int index = r.Next(lstIncorrectChoice2.Count);

                lstIncorrectChoice2.RemoveAt(index);
            }


            // gets options for second level, if there are not enough children
            while (lstIncorrectChoice2.Count < 3)
            {
                DeweyPair r = GlobalTree.Tree.GetRandom(2);

                if (!lstAnswerPath.Contains(r) && !lstIncorrectChoice2.Contains(r))
                {
                    lstIncorrectChoice2.Add(r);
                }
            }

            // gets the children of the second level to have similar numbers in the third
            List<DeweyPair> children = GlobalTree.Tree.GetChildren(lstAnswerPath[1]);

            // gets options for third level
            while (lstIncorrectChoice3.Count < 3)
            {
                Random r = new Random();

                int index = r.Next(children.Count);

                if (!lstAnswerPath.Contains(children[index]) && !lstIncorrectChoice3.Contains(children[index]))
                {
                    lstIncorrectChoice3.Add(children[index]);
                }
            }

            // models to be used in game
            List<DeweyPairGameModel> lvl1 = new List<DeweyPairGameModel>();
            List<DeweyPairGameModel> lvl2 = new List<DeweyPairGameModel>();
            List<DeweyPairGameModel> lvl3 = new List<DeweyPairGameModel>();
            List<DeweyPairGameModel> correctAns = new List<DeweyPairGameModel>();

            // converts data models to game models
            correctAns = GameConverter.ConvertListToGameModel(lstAnswerPath);
            correctAns.ForEach(x => x.Correct = true);

            lvl1 = GameConverter.ConvertListToGameModel(lstIncorrectChoice1);
            lvl1.ForEach(x => x.Correct = false);
            lvl2 = GameConverter.ConvertListToGameModel(lstIncorrectChoice2);
            lvl2.ForEach(x => x.Correct = false);
            lvl3 = GameConverter.ConvertListToGameModel(lstIncorrectChoice3);
            lvl3.ForEach(x => x.Correct = false);

            // adds correct answers to options lists
            lvl1.Add(correctAns[0]);
            lvl2.Add(correctAns[1]);
            lvl3.Add(correctAns[2]);

            //  orders options in numerical order
            lvl1 = lvl1.OrderBy(x => x.Number).ToList();
            lvl2 = lvl2.OrderBy(x => x.Number).ToList();
            lvl3 = lvl3.OrderBy(x => x.Number).ToList();

            //adds to model to be returned
            level.AnswerPath = correctAns;
            level.Level1Options = lvl1;
            level.Level2Options = lvl2;
            level.Level3Options = lvl3;

            return level;
        }
    #endregion
    }
}
