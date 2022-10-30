using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Logic;
using DeweyDecimalLibrary.Models;
using DeweyDecimalLibrary.Tree_Structure;

namespace Dewey_Decimal_System.Games
{
    public partial class FindingCallNumbers : Form
    {
        private TreeGameLevel treeGameLevel;
        private bool lvl1 = true, lvl2 = false, lvl3 = false;

        public FindingCallNumbers()
        {
            InitializeComponent();
        }

        #region Form Load
        private void FindingCallNumbers_Load(object sender, EventArgs e)
        {
            // refesh the user interface to default values
            RefreshUI();

            // call method to check if files exist
            CheckFiles();

            // instantiate object
            FindingCallNos findingCallNumbers = new FindingCallNos();

            // save method call to instance
            treeGameLevel = findingCallNumbers.GetLevel();

            // write description to the user
            txbDescription.Text = treeGameLevel.AnswerPath[2].Description;

            // load buttons with descriptions
            PopulateChoice(1);
        }
        #endregion

        #region Button Click Action
        private void btnChoice1_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice1.Text);
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice2.Text);
        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice3.Text);
        }

        private void btnChoice4_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice4.Text);
        }
        #endregion

        #region Check if Files Exist
        private void CheckFiles()
        {
            //creates tree data file if it does not exist
            if (!JsonFileUtility.TreeGameDataExists())
            {
                JsonFileUtility.CreateTreeDataFile();
            }

            //creates the score file
            if (!JsonFileUtility.TreeGameScoresExists())
            {
                JsonFileUtility.CreateTreeScoreFile();
            }

            //loads the tree to a static value, better than reading the tree file every single time
            if (TreeHolder.Tree == null)
            {
                TreeHolder.Tree = JsonFileUtility.GetTree();
            }
        }
        #endregion

        #region Update Ui
        private void PopulateChoice(int i)
        {
            if (i == 1)
            {
                btnChoice1.Text = treeGameLevel.Level1Options[0].Description + "\n" + treeGameLevel.Level1Options[0].Number;
                btnChoice2.Text = treeGameLevel.Level1Options[1].Description + "\n" + treeGameLevel.Level1Options[1].Number;
                btnChoice3.Text = treeGameLevel.Level1Options[2].Description + "\n" + treeGameLevel.Level1Options[2].Number;
                btnChoice4.Text = treeGameLevel.Level1Options[3].Description + "\n" + treeGameLevel.Level1Options[3].Number;
            }
            else if (i == 2)
            {
                RefreshUI();
                btnChoice1.Text = treeGameLevel.Level2Options[0].Description + "\n" + treeGameLevel.Level1Options[0].Number;
                btnChoice2.Text = treeGameLevel.Level2Options[1].Description + "\n" + treeGameLevel.Level1Options[1].Number;
                btnChoice3.Text = treeGameLevel.Level2Options[2].Description + "\n" + treeGameLevel.Level1Options[2].Number;
                btnChoice4.Text = treeGameLevel.Level2Options[3].Description + "\n" + treeGameLevel.Level1Options[3].Number;
            }
            else if (i == 3)
            {
                RefreshUI();
                btnChoice1.Text = treeGameLevel.Level3Options[0].Description + "\n" + treeGameLevel.Level1Options[0].Number;
                btnChoice2.Text = treeGameLevel.Level3Options[1].Description + "\n" + treeGameLevel.Level1Options[1].Number;
                btnChoice3.Text = treeGameLevel.Level3Options[2].Description + "\n" + treeGameLevel.Level1Options[2].Number;
                btnChoice4.Text = treeGameLevel.Level3Options[3].Description + "\n" + treeGameLevel.Level1Options[3].Number;
            }
            else
            {
                Console.WriteLine("Populate Choice not found");
            }

        }

        // method to initialise ui components back to default
        private void RefreshUI()
        {
            btnChoice1.Text = "";
            btnChoice2.Text = "";
            btnChoice3.Text = "";
            btnChoice4.Text = "";
        }
        #endregion

        #region Game Logic
        // method to check if the users selected answer is correct to progress to the next round
        private void CheckAnswer(String text)
        {
            // extract the description from the concatenated call number in the button component
            string[] split = text.Split("\n");
            string newSplit = split[0];

            // declare temp bool
            bool isAnswerCorrect;

            // check the level the user is on
            if (lvl1)
            {
                // check if the user has selected the correct answer from the filtered tree nodes to progress through
                isAnswerCorrect = treeGameLevel.Level1Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                // if the answer is correct
                if (isAnswerCorrect)
                {
                    // populated the choices for the next round
                    PopulateChoice(2);
                    lvl1 = false;
                    lvl2 = true;
                }
                else
                {
                    // end game
                    RefreshUI();
                    ScoreAndDetails details = new ScoreAndDetails("You Loose");
                    this.Hide();
                    details.ShowDialog();
                }
            }
            else if (lvl2)
            {
                // check if the user has selected the correct answer from the filtered tree nodes to progress through
                isAnswerCorrect = treeGameLevel.Level2Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                // if the answer is correct
                if (isAnswerCorrect)
                {
                    // populated the choices for the next round
                    RefreshUI();
                    PopulateChoice(3);
                    lvl2 = false;
                    lvl3 = true;
                }
                else
                {
                    // end game
                    RefreshUI();
                    ScoreAndDetails details = new ScoreAndDetails("You Loose");
                    this.Hide();
                    details.ShowDialog();
                }


            }
            else if (lvl3)
            {
                // check if the user has selected the correct answer from the filtered tree nodes to progress through
                isAnswerCorrect = treeGameLevel.Level3Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                // if the answer is correct
                if (isAnswerCorrect)
                {
                    //game won !!
                    MessageBox.Show("You Win");
                    
                    // for next game to be played
                    lvl1 = true;
                    lvl2 = false;
                    lvl3 = false;
                    RefreshUI();

                    // winner winner chicken dinner
                    ScoreAndDetails details = new ScoreAndDetails("Congratulations, You win");
                    this.Hide();
                    details.ShowDialog();
                }
                else
                {
                    // end game
                    RefreshUI();
                    ScoreAndDetails details = new ScoreAndDetails("You Loose");
                    this.Hide();
                    details.ShowDialog();
                }
            }
        }
        #endregion
    }
}
