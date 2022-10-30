using Dewey_Decimal_System.Games;
using DeweyDecimalLibrary.Other;

namespace Dewey_Decimal_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSortCallNos_Click(object sender, EventArgs e)
        {
            Global.SortCallingNos = true;

            // initialise game mode
            Global.Game1 = true;
            Global.Game2 = false;
            Global.Game3 = false;


            // form navigation
            frmDifficultyLevel frmDifficultyLevel = new frmDifficultyLevel();
            this.Hide();
            try
            {
                frmDifficultyLevel.ShowDialog();
            }
            catch (System.NullReferenceException) { throw; }
        }

        private void btnSortCallNosLeaderboard_Click(object sender, EventArgs e)
        {
            // initialise game mode
            Global.Game1 = true;
            Global.Game2 = false;
            Global.Game3 = false;

            // form navigation
            Leaderboard frmLeaderboard = new Leaderboard();
            this.Hide();
            frmLeaderboard.ShowDialog();


        }

        private void btnIdentifyingAreas_Click(object sender, EventArgs e)
        {
            // initialise game mode
            Global.Game1 = false;
            Global.Game2 = true;
            Global.Game3 = false;

            frmDifficultyLevel frmDifficultyLevel = new frmDifficultyLevel();
            this.Hide();
            frmDifficultyLevel.ShowDialog();
        }

        private void btnIdentifyingAreaLeaderboard_Click(object sender, EventArgs e)
        {
            // initialise game mode
            Global.Game1 = false;
            Global.Game2 = true;
            Global.Game3 = false;

            // navigation to new form 
            Leaderboard sortingCallNoLeaderboard = new Leaderboard();
            this.Hide();
            sortingCallNoLeaderboard.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // initialise game mode
            Global.Game1 = false;
            Global.Game2 = false;
            Global.Game3 = true;

            // navigation to new form 
            FindingCallNumbers findingCallNumbers = new FindingCallNumbers();
            this.Hide();
            findingCallNumbers.ShowDialog();
        }
    }
}