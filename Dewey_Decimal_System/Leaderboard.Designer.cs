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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaderboard));
            this.lvLeaderboard = new System.Windows.Forms.ListView();
            this.ch_username = new System.Windows.Forms.ColumnHeader();
            this.ch_score = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvLeaderboard
            // 
            this.lvLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_username,
            this.ch_score});
            this.lvLeaderboard.Location = new System.Drawing.Point(158, 172);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(259, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Leaderboard";
            // 
            // frmLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvLeaderboard);
            this.Name = "frmLeaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLeaderboard_FormClosed);
            this.Load += new System.EventHandler(this.frmLeaderboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvLeaderboard;
        private ColumnHeader ch_username;
        private ColumnHeader ch_score;
        private Label label1;
    }
}