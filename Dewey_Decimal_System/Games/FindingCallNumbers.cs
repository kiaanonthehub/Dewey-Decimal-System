using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Logic;
using DeweyDecimalLibrary.Models;
using DeweyDecimalLibrary.Tree_Structure;

namespace Dewey_Decimal_System.Games
{
    public partial class FindingCallNumbers : Form
    {
        private TreeGameLevel treeGameLevel;
        private bool lvl1 = false, lvl2 = false, lvl3 = false;

        public FindingCallNumbers()
        {
            InitializeComponent();
        }

        private void FindingCallNumbers_Load(object sender, EventArgs e)
        {

            // call method to check if files exist
            CheckFiles();

            // instantiate object
            FindingCallNos findingCallNumbers = new FindingCallNos();

            // save method call to instance
            treeGameLevel = findingCallNumbers.GetLevel();

            // write description to the user
            txbDescription.Text = treeGameLevel.AnswerPath[2].Description;

            RefreshUI();

          //  btnChoice1.Text = treeGameLevel.Level1Options[0].Description; 
         //  btnChoice2.Text = treeGameLevel.Level1Options[1].Description;   


        }

        private void btnChoice1_Click(object sender, EventArgs e)
        {

        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {

        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {

        }

        private void btnChoice4_Click(object sender, EventArgs e)
        {

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
                btnChoice1.Text = treeGameLevel.Level1Options[0].Description + " " +treeGameLevel.Level1Options[0].Number;
                btnChoice1.Text = treeGameLevel.Level1Options[1].Description;
                btnChoice1.Text = treeGameLevel.Level1Options[2].Description;
                btnChoice1.Text = treeGameLevel.Level1Options[3].Description;
            }
            else if (i == 2)
            {
                btnChoice1.Text = treeGameLevel.Level1Options[0].Description;
                btnChoice1.Text = treeGameLevel.Level1Options[1].Description;
                btnChoice1.Text = treeGameLevel.Level1Options[2].Description;
                btnChoice1.Text = treeGameLevel.Level1Options[3].Description;
            }
            else if (i == 3)
            {
                btnChoice1.Text = treeGameLevel.Level1Options[0].Description;
                btnChoice1.Text = treeGameLevel.Level1Options[1].Description;
                btnChoice1.Text = treeGameLevel.Level1Options[2].Description;
                btnChoice1.Text = treeGameLevel.Level1Options[3].Description;
            }
            else
            {
                Console.WriteLine("Populate Choice not found");
            }

        }

        private void PlayGame()
        {
            //if (lvl1)
            //{
            //    btnChoice1.va
            //}
        }

        private void RefreshUI()
        {
            btnChoice1.Text = "";
            btnChoice2.Text = "";
            btnChoice3.Text = "";
            btnChoice4.Text = "";
        }
    }
}
