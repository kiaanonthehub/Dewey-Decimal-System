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

                        // check if the game has been completed
                        if (matching.isGameFinished(lstboxCallNo.Items.Count))
                        {
                            // stop timer
                            timer.Stop();

                            // write score to the json file 

                            // prompt the user with a display message
                            MessageBox.Show("Congratulations , Game Completed!");
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
        }

        private void lstboxDescription_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gameBegin)
            {
                StartTimer();
                gameBegin = true;
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
            timer.SetTime(0, 30); // 30s

            timer.Start();

            //update label text
            timer.TimeChanged += () => lblTimer.Text = timer.TimeLeftMsStr;

            //timer step. By default is 1 second
            timer.StepMs = 77;
        }
        #endregion
    }
}
