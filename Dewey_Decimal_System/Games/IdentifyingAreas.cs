using DeweyDecimalLibrary;
using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Logic;
using DeweyDecimalLibrary.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewey_Decimal_System
{
    public partial class IdentifyingAreas : Form
    {
        static int count = 0;

        // instantiate object
        MatchingCallNosDescription matching = new MatchingCallNosDescription();

        // instantiate timer object
        CountDownTimer timer = new CountDownTimer();


        // flag bool for testing if the game has started
        bool gameBegin = false;
        public IdentifyingAreas()
        {
            InitializeComponent();
        }

        #region Button Check Answer
        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            // declare variables 
            string callNumber = null, description = null;


            // check ff the user has selected an item from the listbox
            if (lstboxCallNo.SelectedItem != null)
            {
                // get the user input from the list box
                callNumber = lstboxCallNo.SelectedItem.ToString();

                if (lstboxDescription.SelectedItem != null)
                {
                    // get the user input from the list box
                    description = lstboxDescription.SelectedItem.ToString();

                    // check ff the user has selected an item from the listbox
                    if (matching.CheckAnswer(callNumber, description))
                    {
                        // if the matching pair is correct remove it from the listbox 
                        lstboxCallNo.Items.RemoveAt(lstboxCallNo.SelectedIndex);
                        lstboxDescription.Items.RemoveAt(lstboxDescription.SelectedIndex);

                        // increment count 
                        count++;

                        // check if the game has been completed
                        if (matching.isGameFinished(lstboxCallNo.Items.Count))
                        {
                            updatedScore();
                        }
                    }
                    else
                    {
                        ClearSelectedItems();
                        MessageBox.Show("Whoops! Incorrect match. Have another go!\n Press 'enter' on your keyboard or select 'OK' to continue", "Invalid Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                { MessageBox.Show("Please select a description", "Invalid Responce", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("Please select a call number", "Invalid Responce", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Mouse down
        private void lstboxCallNo_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gameBegin)
            {
                StartTimer();
                gameBegin = true;
            }

            // check if the game has been completed
            if (matching.isGameFinished(lstboxCallNo.Items.Count))
            {
                updatedScore();
            }


        }

        private void lstboxDescription_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gameBegin)
            {
                StartTimer();
                gameBegin = true;
            }
            // check if the game has been completed
            if (matching.isGameFinished(lstboxCallNo.Items.Count))
            {
                updatedScore();
            }
        }
        #endregion

        #region Form Load
        private void IdentifyingAreas_Load(object sender, EventArgs e)
        {
            // clear lists
            Global.lstDescription.Clear();
            Global.lstCallNos.Clear();
            Global.dictCallNoDescription.Clear();

            // clear list view
            lstboxCallNo.Items.Clear();
            lstboxDescription.Items.Clear();

            // check if json file exists - if !true create json file 
            if (!JsonFileUtility.CallNumFileExists()) { JsonFileUtility.CreateCallNumFile(); }

            // get list values
            Global.lstDescription = matching.GetDescription();
            Global.lstCallNos = matching.GetCallNos();

            // instantiate random object
            Random rnd = new Random();

            // populate list view
            Global.lstCallNos.ToList().ForEach(x => lstboxCallNo.Items.Add(x));

            // shuffled list again
            Global.lstDescription.ToList().OrderBy(x => rnd.Next()).ToList().ForEach(x => lstboxDescription.Items.Add(x.Value));

            // initialise game start to false
            gameBegin = false;

            // initialise game mode
            Global.Game1 = false;
            Global.Game2 = true;
            Global.Game3 = false;

            // initialise counter 
            count = 0;

            // game instructions
            MessageBox.Show("When the call numbers (left) and the descriptions (right) loads\n" +
                "the users is required to guess and select one call number and one description " +
                "from each listbox and then select 'Check Answer' to see if the answer is correct.\n\n" +
                "Upon guessing the correct answer, the items will be removed from the list box." +
                "The user is required to guess all correct matching pairs before the time runs out.\n\n Goodluck!!","Identify Areas - Instructions");
        }
        #endregion

        #region Other
        // method to un select the item selected by the user in the listbox
        private void ClearSelectedItems()
        {
            lstboxCallNo.ClearSelected();
            lstboxDescription.ClearSelected();
        }
        #endregion

        #region Start Timer

        // method that sets the time on the timer and starts the count down
        public void StartTimer()
        {
            //set time dependent on difficulty 
            timer.SetTime(0, Global.CountdownTime); // 30s

            timer.Start();

            //update label text
            timer.TimeChanged += () => lblTimer.Text = timer.TimeLeftMsStr;

            //timer step. By default is 1 second
            timer.StepMs = 77;
        }
        #endregion

        #region Updated the score
        private void updatedScore()
        {
            // stop timer
            timer.Pause();

            // save the score 
            Global.Points = ScoreSystem.CalculateScore(Convert.ToInt32(timer.TimeLeft.Seconds) , count);

            Global.UpdateUserControl = true;

            // show user details and score
            ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Congratulations! You Solved Correctly 👑 ");
            this.Hide();
            scoreAndDetails.Show();
        }
        #endregion
        private void IdentifyingAreas_FormClosed(object sender, FormClosedEventArgs e)
        {
            // form navigation
            frmDifficultyLevel frmDifficultyLevel = new frmDifficultyLevel();
            this.Hide();
            frmDifficultyLevel.ShowDialog();
        }

        private void IdentifyingAreas_MouseHover(object sender, EventArgs e)
        {
            // check if the game has been completed
            if (Convert.ToInt32(timer.TimeLeft.Seconds) == 0)
            {
                // incorrect sorting
                Global.BonusPoints = 0;
                Global.Points = ScoreSystem.CalculateScore(0, count);

                Global.UpdateUserControl = true;

                // show user details and score
                ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Unlucky! You Solved Incorrectly 😢 ");
                this.Hide();
                scoreAndDetails.Show();
            }
        }
    }
}
