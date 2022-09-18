namespace Dewey_Decimal_System
{
    partial class frmDifficultyLevel
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
            this.components = new System.ComponentModel.Container();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipMode1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMode2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMode3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEasy.ForeColor = System.Drawing.Color.Transparent;
            this.btnEasy.Location = new System.Drawing.Point(280, 191);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(329, 48);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Take It Easy On Me 😊";
            this.toolTipMode1.SetToolTip(this.btnEasy, "Double click on the button to select the easy difficulty mode.");
            this.btnEasy.UseVisualStyleBackColor = false;
            // 
            // btnMed
            // 
            this.btnMed.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMed.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMed.ForeColor = System.Drawing.Color.Transparent;
            this.btnMed.Location = new System.Drawing.Point(280, 244);
            this.btnMed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(329, 48);
            this.btnMed.TabIndex = 1;
            this.btnMed.Text = "I Think I Got This  😮‍💨";
            this.toolTipMode2.SetToolTip(this.btnMed, "Double click on the button to select the medium difficulty mode.");
            this.btnMed.UseVisualStyleBackColor = false;
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHard.ForeColor = System.Drawing.Color.Transparent;
            this.btnHard.Location = new System.Drawing.Point(280, 297);
            this.btnHard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(329, 48);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Challenge Me, I Dare You  😱";
            this.toolTipMode3.SetToolTip(this.btnHard, "Double click on the button to select the hard difficulty mode.");
            this.btnHard.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Select Your Difficulty:";
            // 
            // toolTipMode1
            // 
            this.toolTipMode1.IsBalloon = true;
            this.toolTipMode1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMode1.ToolTipTitle = "Easy Mode";
            // 
            // toolTipMode2
            // 
            this.toolTipMode2.IsBalloon = true;
            this.toolTipMode2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMode2.ToolTipTitle = "Medium Mode";
            // 
            // toolTipMode3
            // 
            this.toolTipMode3.IsBalloon = true;
            this.toolTipMode3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMode3.ToolTipTitle = "Mard Mode";
            // 
            // frmDifficultyLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnEasy);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDifficultyLevel";
            this.Text = "DifficultyLevel";
            this.Load += new System.EventHandler(this.DifficultyLevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEasy;
        private Button btnMed;
        private Button btnHard;
        private Label label1;
        private ToolTip toolTipMode1;
        private ToolTip toolTipMode2;
        private ToolTip toolTipMode3;
    }
}