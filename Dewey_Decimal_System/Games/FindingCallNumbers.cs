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

        private void RefreshUI()
        {
            btnChoice1.Text = "";
            btnChoice2.Text = "";
            btnChoice3.Text = "";
            btnChoice4.Text = "";
        }

        private void CheckAnswer(String text)
        {
            string[] split = text.Split("\n");
            string newSplit = split[0];

            bool isAnswerCorrect;

            if (lvl1)
            {
                isAnswerCorrect = treeGameLevel.Level1Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                if (isAnswerCorrect)
                {
                    PopulateChoice(2);
                    lvl1 = false;
                    lvl2 = true;
                }
                else
                {
                    RefreshUI();
                    ScoreAndDetails details = new ScoreAndDetails("You Loose");
                    this.Hide();
                    details.ShowDialog();
                }
            }
            else if (lvl2)
            {
                isAnswerCorrect = treeGameLevel.Level2Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();
                if (isAnswerCorrect)
                {
                    RefreshUI();
                    PopulateChoice(3);
                    lvl2 = false;
                    lvl3 = true;
                }
                else
                {
                    RefreshUI();
                    ScoreAndDetails details = new ScoreAndDetails("You Loose");
                    this.Hide();
                    details.ShowDialog();
                }


            }
            else if (lvl3)
            {
                isAnswerCorrect = treeGameLevel.Level3Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();
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
                    RefreshUI();
                    ScoreAndDetails details = new ScoreAndDetails("You Loose");
                    this.Hide();
                    details.ShowDialog();
                }
            }
        }
    }
}
