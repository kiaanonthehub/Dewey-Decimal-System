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
    }
}
