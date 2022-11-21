using Dewey_Decimal_System.Games;
using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Models;
using DeweyDecimalLibrary.Other;

namespace Dewey_Decimal_System
{
    public partial class ScoreAndDetails : Form
    {
        public ScoreAndDetails(string info)
        {
            InitializeComponent();

            lblUserMessage.Text = info;
        }

        private void ScoreAndDetails_Load(object sender, EventArgs e)
        {
            RefreshUI();

            if (Global.UpdateUserControl)
            {
                // update ui values
                txbScore.Text = Global.Points.ToString();
                txbBonus.Text = Global.BonusPoints.ToString();
                txbFinalScore.Text = (Global.BonusPoints + Global.Points).ToString();

            }
        }


        public void RefreshUI()
        {
            // clear componenets
            txbUsername.Clear();
            txbScore.Clear();
            txbFinalScore.Clear();
            txbBonus.Clear();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            if (Global.Game1)
            {
                // Game 1
                frmSortingCallNumbers sortingCallNumbers = new frmSortingCallNumbers();
                this.Hide();
                sortingCallNumbers.ShowDialog();

            }
            else if (Global.Game2)
            {
                Global.countAlt = Global.countAlt + 1;

                // Game 2
                IdentifyingAreas identifyingAreas = new IdentifyingAreas();
                this.Hide();
                identifyingAreas.ShowDialog();


            }
            else if (Global.Game3)
            {
                // Game 3
                FindingCallNumbers findingCallNumbers = new FindingCallNumbers();
                this.Hide();
                findingCallNumbers.ShowDialog();
            }

        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            // error handling
            if (txbUsername.Text == null)
            {
                MessageBox.Show("Please enter a valid name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // instantiate high score model 
                ModelHighScore modelHighScore = new ModelHighScore();

                // score
                modelHighScore.Score = Global.Points + Global.BonusPoints;

                Global.Username = txbUsername.Text;

                modelHighScore.Username = Global.Username;

                if (Global.Game1)
                {
                    // Game 1
                    // check if the json file exists
                    if (!JsonFileUtility.FileExists(JsonFileUtility.SortingCallNosFile))
                    {
                        // create the json file
                        JsonFileUtility.CreateJsonFile(JsonFileUtility.SortingCallNosFile);

                        // write data to the file
                        JsonFileUtility.AppendScores(modelHighScore, JsonFileUtility.SortingCallNosFile);
                    }
                    else
                    {
                        // write to json
                        JsonFileUtility.AppendScores(modelHighScore, JsonFileUtility.SortingCallNosFile);
                    }
                }
                else if (Global.Game2)
                {
                    Global.countAlt = Global.countAlt + 1;

                    // Game 2
                    // check if the json file exists
                    if (!JsonFileUtility.FileExists(JsonFileUtility.IdentifyingAreasFile))
                    {
                        // create the json file
                        JsonFileUtility.CreateJsonFile(JsonFileUtility.IdentifyingAreasFile);

                        // write data to the file
                        JsonFileUtility.AppendScores(modelHighScore, JsonFileUtility.IdentifyingAreasFile);

                    }
                    else
                    {
                        // write to json
                        JsonFileUtility.AppendScores(modelHighScore, JsonFileUtility.IdentifyingAreasFile);
                    }

                }
                else if (Global.Game3)
                {
                    // Game 3
                    // check if the json file exists
                    if (!JsonFileUtility.FileExists(JsonFileUtility.TreeHighScoreFile))
                    {
                        // create the json file
                        JsonFileUtility.CreateJsonFile(JsonFileUtility.TreeHighScoreFile);

                        // write data to the file
                        JsonFileUtility.AppendScores(modelHighScore, JsonFileUtility.TreeHighScoreFile);
                    }
                    else
                    {
                        // write to json
                        JsonFileUtility.AppendScores(modelHighScore, JsonFileUtility.TreeHighScoreFile);
                    }
                }


                // message to the user
                MessageBox.Show(txbUsername.Text + "score of : " + txbFinalScore.Text + " has been saved successfully", "Score Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // navigate back to the home screen
                RefreshUI();

                // back to home page
                Home home = new Home();
                this.Hide();
                home.Show();
            }
        }

        private void ScoreAndDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            // navigate back to the homescreen
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
