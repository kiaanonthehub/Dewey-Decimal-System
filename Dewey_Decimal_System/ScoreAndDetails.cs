﻿using DeweyDecimalLibrary.Json;
using DeweyDecimalLibrary.Models;
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

            // load screen again 
            this.Hide();
            frmSortingCallNumbers frmSortingCallNumbers = new frmSortingCallNumbers();
            frmSortingCallNumbers.ShowDialog();
            this.Hide();
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            Global.Username = txbUsername.Text;

            // instantiate high score model 
            ModelHighScore modelHighScore = new ModelHighScore();

            // score
            modelHighScore.Score = Global.Points + Global.BonusPoints;

            modelHighScore.Username = Global.Username;

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

            // message to the user
            MessageBox.Show("Score has been saved successfully");

            // navigate back to the home screen
            RefreshUI();

            // back to home page
            Home home = new Home();
            this.Hide();
            home.Show();
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
