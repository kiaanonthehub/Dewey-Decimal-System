using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Models;
using System.Data;

namespace Dewey_Decimal_System
{
    public partial class SortingCallNoLeaderboard : Form
    {
        public SortingCallNoLeaderboard()
        {
            InitializeComponent();
        }

        private void frmLeaderboard_Load(object sender, EventArgs e)
        {
            bool Game1 = true, Game2 = false, Game3 = false;

            // check if the json file exists
            if (!JsonFileUtility.FileExists(JsonFileUtility.SortingCallNosFile))
            {
                // create the json file
                JsonFileUtility.CreateJsonFile(JsonFileUtility.SortingCallNosFile);
            }

            if (Game1)
            {
                lvLeaderboard.Items.Clear();

                // retrieve data from json file
                List<ModelHighScore> lstModelHightScore = JsonFileUtility.GetAllScores(JsonFileUtility.SortingCallNosFile);

                // populate list view
                lstModelHightScore.OrderByDescending(x => x.Score)
                    .ToList()
                    .ForEach(x => lvLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));
            }
            else if (Game2)
            {
                lvLeaderboard.Items.Clear();

                // retrieve data from json file
                List<ModelHighScore> lstModelHightScore = JsonFileUtility.GetAllScores(JsonFileUtility.IdentifyingAreasFile);

                // populate list view
                lstModelHightScore.OrderByDescending(x => x.Score)
                    .ToList()
                    .ForEach(x => lvLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));
            }
            else if (Game3)
            {
                lvLeaderboard.Items.Clear();

                // retrieve data from json file
                List<ModelHighScore> lstModelHightScore = JsonFileUtility.GetAllScores(JsonFileUtility.FindingCallNosFile);

                // populate list view
                lstModelHightScore.OrderByDescending(x => x.Score)
                    .ToList()
                    .ForEach(x => lvLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));
            }
        }

        private void frmLeaderboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // navigate back to the homescreen
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
/*
    Author  : Gen Grievous [Youtube]
    Topic   : Windows Forms -ListView add items and read selected
    Resource: [https://www.youtube.com/watch?v=OAvMTu-LFgs] 
    Date    : Jun 23, 2017
 */

/*
    Author  : Arkadiusz Raszeja [Stackoverflow]
    Topic   : How to add list items to a ListView in C#winform?
    Resource: [https://stackoverflow.com/questions/43841962/how-to-add-list-items-to-a-listview-in-cwinform]
    Date    : May 8, 2017
 */