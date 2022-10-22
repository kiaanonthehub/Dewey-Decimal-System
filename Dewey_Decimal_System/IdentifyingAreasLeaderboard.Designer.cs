namespace Dewey_Decimal_System
{
    partial class IdentifyingAreasLeaderboard
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
            this.lvIdentifyingAreasLeaderboard = new System.Windows.Forms.ListView();
            this.ch_username = new System.Windows.Forms.ColumnHeader();
            this.ch_score = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvIdentifyingAreasLeaderboard
            // 
            this.lvIdentifyingAreasLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_username,
            this.ch_score});
            this.lvIdentifyingAreasLeaderboard.Location = new System.Drawing.Point(158, 108);
            this.lvIdentifyingAreasLeaderboard.Name = "lvIdentifyingAreasLeaderboard";
            this.lvIdentifyingAreasLeaderboard.Size = new System.Drawing.Size(484, 235);
            this.lvIdentifyingAreasLeaderboard.TabIndex = 1;
            this.lvIdentifyingAreasLeaderboard.UseCompatibleStateImageBehavior = false;
            this.lvIdentifyingAreasLeaderboard.View = System.Windows.Forms.View.Details;
            // 
            // ch_username
            // 
            this.ch_username.Text = "Username";
            this.ch_username.Width = 240;
            // 
            // ch_score
            // 
            this.ch_score.Text = "Score";
            this.ch_score.Width = 240;
            // 
            // IdentifyingAreasLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvIdentifyingAreasLeaderboard);
            this.Name = "IdentifyingAreasLeaderboard";
            this.Text = "IdentifyingAreasLeaderboard";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvIdentifyingAreasLeaderboard;
        private ColumnHeader ch_username;
        private ColumnHeader ch_score;
    }
}