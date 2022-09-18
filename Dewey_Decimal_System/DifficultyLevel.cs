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
    public partial class frmDifficultyLevel : Form
    {
        public frmDifficultyLevel()
        {
            InitializeComponent();
        }

        private void DifficultyLevel_Load(object sender, EventArgs e)
        {

        }

        #region Select Difficulty
        private void btnEasy_Click(object sender, EventArgs e)
        {
            Global.CountdownTime = 60;
            Global.BonusPoints = 0;

            NavigateToGame();
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            Global.CountdownTime = 45;
            Global.BonusPoints = 25;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Global.CountdownTime = 30;
            Global.BonusPoints = 50;
        }
        #endregion

        public void NavigateToGame() 
        {
            if (Global.SortCallingNos)
            {
                frmSortingCallNumbers sortingCallNumbers = new frmSortingCallNumbers();
                this.Hide();
                sortingCallNumbers.ShowDialog();

            }
            else if (Global.IdentifyingAreas) 
            {
                // Game 2
            }
            else if (Global.FindCallingNos)
            {
                // Game 3
            }
        }
    }
}
