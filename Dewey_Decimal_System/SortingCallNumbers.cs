using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Logic;
using DeweyDecimalLibrary.Models;
using DeweyDecimalLibrary.Other;

namespace Dewey_Decimal_System
{
    public partial class frmSortingCallNumbers : Form
    {
        // declaring lists of type string
        List<String> sortedList;
        List<String> shuffleList;
        List<String> userList;

        // instantiate timer object
        CountDownTimer timer = new CountDownTimer();

        // properties
        public bool gameBegin { get; set; } = false;
        public bool gameEnd { get; set; } = false;

        public frmSortingCallNumbers()
        {
            InitializeComponent();
            lstboxRandom.AllowDrop = true;
            lstboxSorted.AllowDrop = true;

            LoadCallNos();
        }

        #region Load Call Numbers 
        // method to populate list box with randomly generated call numbers
        public void LoadCallNos()
        {
            lstboxRandom.Items.Clear();

            ReplacingTheBooks r = new ReplacingTheBooks();
            sortedList = r.GenerateCallNos();
            shuffleList = r.ShuffleList(sortedList);

            foreach (var callNo in shuffleList)
            {
                lstboxRandom.Items.Add(callNo);
            }
        }
        #endregion

        #region Drag and Drop 
        private void lstboxRandom_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                lstboxSorted.DoDragDrop(lstboxRandom.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Please select a call number from the list");
            }

            if (StartGame())
            {
                StartTimer();
                gameBegin = false;
            }

            if (EndGame())
            {
                MessageBox.Show("Game Completed");


                // instantiate high score model 
                ModelHighScore modelHighScore = new ModelHighScore();

                // score
                modelHighScore.Score = ScoreSystem.CalculateScore(Convert.ToInt32(timer.TimeLeft.Seconds));

                modelHighScore.Username = "Player2022";

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
        }

        private void lstboxSorted_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lstboxSorted_DragDrop(object sender, DragEventArgs e)
        {
            lstboxSorted.Items.Add(e.Data.GetData(DataFormats.Text));
            lstboxRandom.Items.Remove(e.Data.GetData(DataFormats.Text));
        }
        #endregion

        #region Start Game
        public bool StartGame()
        {
            if (lstboxSorted.Items.Count == 1)
            {
                gameBegin = true;
            }
            else
            {
                gameBegin = false;
            }
            return gameBegin;
        }
        #endregion

        #region Start Timer
        public void StartTimer()
        {
            //set time dependent on difficulty 
            timer.SetTime(0, Global.CountdownTime);

            timer.Start();

            //update label text
            timer.TimeChanged += () => lblCountdownEdit.Text = timer.TimeLeftMsStr;

            //timer step. By default is 1 second
            timer.StepMs = 77;
        }
        #endregion

        #region End Game
        public bool EndGame()
        {
            if (lstboxSorted.Items.Count == 10 || timer.TimeLeft.Seconds.Equals(0))
            {
                gameEnd = true;

                timer.Pause();
                lblCountdownEdit.Text = timer.TimeLeftStr;
            }
            else
            {
                gameEnd = false;
            }
            return gameEnd;
        }
        #endregion

        private void frmSortingCallNumbers_Load(object sender, EventArgs e)
        {
            // set time on ui
            lblCountdownEdit.Text = Global.CountdownTime.ToString();
        }
    }
}
