namespace Dewey_Decimal_System
{
    partial class frmSortingCallNumbers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstboxRandom = new System.Windows.Forms.ListBox();
            this.lstboxSorted = new System.Windows.Forms.ListBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCountdownEdit = new System.Windows.Forms.Label();
            this.lblScoreEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstboxRandom
            // 
            this.lstboxRandom.FormattingEnabled = true;
            this.lstboxRandom.ItemHeight = 19;
            this.lstboxRandom.Location = new System.Drawing.Point(151, 130);
            this.lstboxRandom.Name = "lstboxRandom";
            this.lstboxRandom.Size = new System.Drawing.Size(240, 308);
            this.lstboxRandom.TabIndex = 0;
            this.lstboxRandom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstboxRandom_MouseDown);
            // 
            // lstboxSorted
            // 
            this.lstboxSorted.FormattingEnabled = true;
            this.lstboxSorted.ItemHeight = 19;
            this.lstboxSorted.Location = new System.Drawing.Point(418, 130);
            this.lstboxSorted.Name = "lstboxSorted";
            this.lstboxSorted.Size = new System.Drawing.Size(242, 308);
            this.lstboxSorted.TabIndex = 1;
            this.lstboxSorted.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstboxSorted_DragDrop);
            this.lstboxSorted.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstboxSorted_DragEnter);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(232, 81);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(81, 19);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "Countdown";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(418, 81);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(42, 19);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score";
            // 
            // lblCountdownEdit
            // 
            this.lblCountdownEdit.AutoSize = true;
            this.lblCountdownEdit.Location = new System.Drawing.Point(319, 81);
            this.lblCountdownEdit.Name = "lblCountdownEdit";
            this.lblCountdownEdit.Size = new System.Drawing.Size(44, 19);
            this.lblCountdownEdit.TabIndex = 4;
            this.lblCountdownEdit.Text = "00:00";
            // 
            // lblScoreEdit
            // 
            this.lblScoreEdit.AutoSize = true;
            this.lblScoreEdit.Location = new System.Drawing.Point(466, 81);
            this.lblScoreEdit.Name = "lblScoreEdit";
            this.lblScoreEdit.Size = new System.Drawing.Size(17, 19);
            this.lblScoreEdit.TabIndex = 5;
            this.lblScoreEdit.Text = "0";
            // 
            // frmSortingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScoreEdit);
            this.Controls.Add(this.lblCountdownEdit);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lstboxSorted);
            this.Controls.Add(this.lstboxRandom);
            this.Name = "frmSortingCallNumbers";
            this.Text = "SortingCallNumbers";
            this.Load += new System.EventHandler(this.frmSortingCallNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstboxRandom;
        private ListBox lstboxSorted;
        private Label lblCountdown;
        private Label lblScore;
        private Label lblCountdownEdit;
        private Label lblScoreEdit;
    }
}