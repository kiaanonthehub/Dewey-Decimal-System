namespace Dewey_Decimal_System
{
    partial class frmLeaderboard
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
            this.lvLeaderboard = new System.Windows.Forms.ListView();
            this.ch_username = new System.Windows.Forms.ColumnHeader();
            this.ch_score = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvLeaderboard
            // 
            this.lvLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_username,
            this.ch_score});
            this.lvLeaderboard.Location = new System.Drawing.Point(149, 72);
            this.lvLeaderboard.Name = "lvLeaderboard";
            this.lvLeaderboard.Size = new System.Drawing.Size(484, 235);
            this.lvLeaderboard.TabIndex = 0;
            this.lvLeaderboard.UseCompatibleStateImageBehavior = false;
            this.lvLeaderboard.View = System.Windows.Forms.View.Details;
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
            // frmLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvLeaderboard);
            this.Name = "frmLeaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.frmLeaderboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvLeaderboard;
        private ColumnHeader ch_username;
        private ColumnHeader ch_score;
    }
}