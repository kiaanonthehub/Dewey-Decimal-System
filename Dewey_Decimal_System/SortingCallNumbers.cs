using DeweyDecimalLibrary.Logic;
using System.Reflection.Emit;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

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
            lstboxSorted.DoDragDrop(lstboxRandom.SelectedItem.ToString(), DragDropEffects.Copy);

            if (StartGame())
            {
                StartTimer();
                gameBegin = false;
            }

            if (EndGame())
            {
                MessageBox.Show("Game Completed");
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
            //set to 30 seconds
            timer.SetTime(0, 30);

            timer.Start();

            //update label text
            timer.TimeChanged += () => lblCountdownEdit.Text = timer.TimeLeftMsStr;

            // show messageBox on timer = 00:00.000
            timer.CountDownFinished += () => MessageBox.Show("Your time is up!");

            //timer step. By default is 1 second
            timer.StepMs = 77; 
        }
        #endregion

        #region End Game
        public bool EndGame() 
        {
            if (lstboxSorted.Items.Count == 10)
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

    }
}
