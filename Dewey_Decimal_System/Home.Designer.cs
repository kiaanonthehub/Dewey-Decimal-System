namespace Dewey_Decimal_System
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSortCallNos = new System.Windows.Forms.Button();
            this.btnSortCallNosLeaderboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSortCallNos
            // 
            this.btnSortCallNos.Location = new System.Drawing.Point(85, 229);
            this.btnSortCallNos.Name = "btnSortCallNos";
            this.btnSortCallNos.Size = new System.Drawing.Size(137, 51);
            this.btnSortCallNos.TabIndex = 0;
            this.btnSortCallNos.Text = "Sorting Call Numbers";
            this.btnSortCallNos.UseVisualStyleBackColor = true;
            this.btnSortCallNos.Click += new System.EventHandler(this.btnSortCallNos_Click);
            // 
            // btnSortCallNosLeaderboard
            // 
            this.btnSortCallNosLeaderboard.Location = new System.Drawing.Point(85, 286);
            this.btnSortCallNosLeaderboard.Name = "btnSortCallNosLeaderboard";
            this.btnSortCallNosLeaderboard.Size = new System.Drawing.Size(137, 40);
            this.btnSortCallNosLeaderboard.TabIndex = 1;
            this.btnSortCallNosLeaderboard.Text = "Leaderboard";
            this.btnSortCallNosLeaderboard.UseVisualStyleBackColor = true;
            this.btnSortCallNosLeaderboard.Click += new System.EventHandler(this.btnSortCallNosLeaderboard_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortCallNosLeaderboard);
            this.Controls.Add(this.btnSortCallNos);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSortCallNos;
        private Button btnSortCallNosLeaderboard;
    }
}