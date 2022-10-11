using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Models;
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
            // form navigation
            frmLeaderboard frmLeaderboard = new frmLeaderboard();
            this.Hide();
            frmLeaderboard.ShowDialog();
        }
    }
}