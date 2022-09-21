using DeweyDecimalLibrary.Logic;
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

        public frmSortingCallNumbers()
        {
            // display instructions to the user
            MessageBox.Show(null,
                "SORT IN ASCENDING ORDER (Smallest to Biggest)\n" +
                "----------------------------------------------------------\n" +
                "To start the game, \n\n" +
                "1. Click on any Call number (eg. 222.97 JAM) \n" +
                "   and drag it over to the next list box (blank white box).\n\n" +
                "2. Once the first call number is entered, the timer will begin and\n" +
                "   the game will continue, until all the numbers have been moved.\n" +
                "   The the game will then come to an end.\n\n" +
                "Remember, you're working against the timer.\n\n" +
                "-----------------------------------------------------\n" +
                "GOODLUCK!", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InitializeComponent();
            lstboxRandom.AllowDrop = true;
            lstboxSorted.AllowDrop = true;

            LoadCallNos();
        }

        #region Load Call Numbers 
        // method to populate list box with randomly generated call numbers
        public void LoadCallNos()
        {
            // clear the component
            lstboxRandom.Items.Clear();

            // shuffle the list and store to the updated lists
            ReplacingTheBooks r = new ReplacingTheBooks();
            sortedList = r.GenerateCallNos();
            shuffleList = r.ShuffleList(sortedList);

            // iterate through list and populate the list box
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
                throw ex;
            }

            if (StartGame())
            {
                StartTimer();
                gameBegin = false;
            }

            if (EndGame())
            {
                // get the data of the users from the list box
                userList = lstboxSorted.Items.Cast<String>().ToList();

                bool isCorrectAnswer = userList.SequenceEqual(sortedList);

                if (isCorrectAnswer)
                {
                    // save the score 
                    Global.Points = ScoreSystem.CalculateScore(Convert.ToInt32(timer.TimeLeft.Seconds));

                    Global.UpdateUserControl = true;

                    // show user details and score
                    ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Congratulations! You Solved Correctly 👑 ");
                    this.Hide();
                    scoreAndDetails.Show();
                }
                else
                {
                    // incorrect sorting
                    Global.Points = 0;
                    Global.BonusPoints = 0;

                    Global.UpdateUserControl = true;

                    // show user details and score
                    ScoreAndDetails scoreAndDetails = new ScoreAndDetails("Unlucky! You Solved Incorrectly 😢 ");
                    this.Hide();
                    scoreAndDetails.Show();

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
            if (lstboxSorted.Items.Count > 0 || lstboxRandom.Items.Count < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            if ((lstboxSorted.Items.Count.Equals(10) || lstboxRandom.Items.Count.Equals(0)))
            {
                timer.Pause();
                lblCountdownEdit.Text = timer.TimeLeftStr;

                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void frmSortingCallNumbers_Load(object sender, EventArgs e)
        {
            // set time on ui
            lblCountdownEdit.Text = Global.CountdownTime.ToString();
        }

        private void frmSortingCallNumbers_FormClosed(object sender, FormClosedEventArgs e)
        {
            // navigate back
            this.Hide();
            frmDifficultyLevel difficultyLevel = new frmDifficultyLevel();
            difficultyLevel.Show();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int index = lstboxSorted.SelectedIndex;
            string selected = lstboxSorted.SelectedItem.ToString();

            if (index > 0)
            {
                lstboxSorted.Items.RemoveAt(index);
                lstboxSorted.Items.Insert(index - 1, selected);
                lstboxSorted.SetSelected(index - 1, true);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int index = lstboxSorted.SelectedIndex;
            string selected = lstboxSorted.SelectedItem.ToString();

            if (index < lstboxSorted.Items.Count-1)
            {
                lstboxSorted.Items.RemoveAt(index);
                lstboxSorted.Items.Insert(index + 1, selected);
                lstboxSorted.SetSelected(index + 1, true);
            }
        }
    }
}
