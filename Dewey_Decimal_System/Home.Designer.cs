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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSortCallNos
            // 
            this.btnSortCallNos.Location = new System.Drawing.Point(45, 326);
            this.btnSortCallNos.Name = "btnSortCallNos";
            this.btnSortCallNos.Size = new System.Drawing.Size(205, 50);
            this.btnSortCallNos.TabIndex = 0;
            this.btnSortCallNos.Text = "Sorting Call Numbers";
            this.btnSortCallNos.UseVisualStyleBackColor = true;
            this.btnSortCallNos.Click += new System.EventHandler(this.btnSortCallNos_Click);
            // 
            // btnSortCallNosLeaderboard
            // 
            this.btnSortCallNosLeaderboard.Location = new System.Drawing.Point(45, 383);
            this.btnSortCallNosLeaderboard.Name = "btnSortCallNosLeaderboard";
            this.btnSortCallNosLeaderboard.Size = new System.Drawing.Size(205, 50);
            this.btnSortCallNosLeaderboard.TabIndex = 1;
            this.btnSortCallNosLeaderboard.Text = "Leaderboard";
            this.btnSortCallNosLeaderboard.UseVisualStyleBackColor = true;
            this.btnSortCallNosLeaderboard.Click += new System.EventHandler(this.btnSortCallNosLeaderboard_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Leaderboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Identifying Areas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Leaderboard";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(534, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Finding Call Numbers";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 205);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(289, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 205);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(534, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 205);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(226, 36);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(347, 36);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Dewey Decimal Game📚";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSortCallNosLeaderboard);
            this.Controls.Add(this.btnSortCallNos);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSortCallNos;
        private Button btnSortCallNosLeaderboard;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblHeader;
    }
}