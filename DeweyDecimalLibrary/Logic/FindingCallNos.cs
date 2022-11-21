using DeweyDecimalLibrary.Models;
using DeweyDecimalLibrary.Other;
using DeweyDecimalLibrary.Tree_Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Logic
{
    public class FindingCallNos
    {
        //uses gets all the required information for a level from the tree
        public TreeGameLevel GetLevel()
        {
            // instantiate tree game object
            TreeGameLevel level = new TreeGameLevel();

            //the path to the answer
            List<DeweyPair> lstAnswerPath = GlobalTree.Tree.GetPathToRandom(GlobalTree.Tree.Root, 3);

            //incorrect options for each level
            List<DeweyPair> lstIncorrectChoice1 = new List<DeweyPair>();
            List<DeweyPair> lstIncorrectChoice2 = new List<DeweyPair>();
            List<DeweyPair> lstIncorrectChoice3 = new List<DeweyPair>();


            //gets options for the first level
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

            //if there are 3 or more children for a single level
            while (lstIncorrectChoice2.Count > 3)
            {
                //pick random from the children
                Random r = new Random();

                int index = r.Next(lstIncorrectChoice2.Count);

                lstIncorrectChoice2.RemoveAt(index);
            }


            //gets options for second level, if there are not enough children
            while (lstIncorrectChoice2.Count < 3)
            {
                DeweyPair r = GlobalTree.Tree.GetRandom(2);

                if (!lstAnswerPath.Contains(r) && !lstIncorrectChoice2.Contains(r))
                {
                    lstIncorrectChoice2.Add(r);
                }
            }

            //gets the children of the second level to have similar numbers in the third
            List<DeweyPair> children = GlobalTree.Tree.GetChildren(lstAnswerPath[1]);

            //gets options for third level
            while (lstIncorrectChoice3.Count < 3)
            {
                Random r = new Random();

                int index = r.Next(children.Count);

                if (!lstAnswerPath.Contains(children[index]) && !lstIncorrectChoice3.Contains(children[index]))
                {
                    lstIncorrectChoice3.Add(children[index]);
                }
            }

            //models to be used in game
            List<DeweyPairGameModel> l1 = new List<DeweyPairGameModel>();
            List<DeweyPairGameModel> l2 = new List<DeweyPairGameModel>();
            List<DeweyPairGameModel> l3 = new List<DeweyPairGameModel>();
            List<DeweyPairGameModel> ans = new List<DeweyPairGameModel>();

            //converts data models to game models
            ans = GameConverter.DeweyPairListToGameModel(lstAnswerPath);
            ans.ForEach(x => x.Correct = true);

            l1 = GameConverter.DeweyPairListToGameModel(lstIncorrectChoice1);
            l1.ForEach(x => x.Correct = false);
            l2 = GameConverter.DeweyPairListToGameModel(lstIncorrectChoice2);
            l2.ForEach(x => x.Correct = false);
            l3 = GameConverter.DeweyPairListToGameModel(lstIncorrectChoice3);
            l3.ForEach(x => x.Correct = false);

            //adds correct answers to options lists
            l1.Add(ans[0]);
            l2.Add(ans[1]);
            l3.Add(ans[2]);

            //orders options in numerical order
            l1 = l1.OrderBy(x => x.Number).ToList();
            l2 = l2.OrderBy(x => x.Number).ToList();
            l3 = l3.OrderBy(x => x.Number).ToList();

            //adds to model to be returned
            level.AnswerPath = ans;
            level.Level1Options = l1;
            level.Level2Options = l2;
            level.Level3Options = l3;

            return level;
        }
    }
}
