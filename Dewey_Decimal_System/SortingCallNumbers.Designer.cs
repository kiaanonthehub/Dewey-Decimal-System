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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSortingCallNumbers));
            this.lstboxRandom = new System.Windows.Forms.ListBox();
            this.lstboxSorted = new System.Windows.Forms.ListBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblCountdownEdit = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.toolTipUp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDown = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLbox1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lstboxRandom
            // 
            this.lstboxRandom.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstboxRandom.FormattingEnabled = true;
            this.lstboxRandom.ItemHeight = 28;
            this.lstboxRandom.Location = new System.Drawing.Point(151, 130);
            this.lstboxRandom.Name = "lstboxRandom";
            this.lstboxRandom.Size = new System.Drawing.Size(240, 284);
            this.lstboxRandom.TabIndex = 0;
            this.toolTipLbox1.SetToolTip(this.lstboxRandom, "Drag the item from this list box to the other to play the game. Sort the Items in" +
        " ascending order.");
            this.lstboxRandom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstboxRandom_MouseDown);
            // 
            // lstboxSorted
            // 
            this.lstboxSorted.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstboxSorted.FormattingEnabled = true;
            this.lstboxSorted.ItemHeight = 28;
            this.lstboxSorted.Location = new System.Drawing.Point(418, 130);
            this.lstboxSorted.Name = "lstboxSorted";
            this.lstboxSorted.Size = new System.Drawing.Size(242, 284);
            this.lstboxSorted.TabIndex = 1;
            this.lstboxSorted.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstboxSorted_DragDrop);
            this.lstboxSorted.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstboxSorted_DragEnter);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Black;
            this.lblCountdown.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountdown.ForeColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Location = new System.Drawing.Point(157, 71);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(141, 34);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "Timer : ";
            // 
            // lblCountdownEdit
            // 
            this.lblCountdownEdit.AutoSize = true;
            this.lblCountdownEdit.BackColor = System.Drawing.Color.Black;
            this.lblCountdownEdit.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountdownEdit.ForeColor = System.Drawing.Color.Transparent;
            this.lblCountdownEdit.Location = new System.Drawing.Point(457, 71);
            this.lblCountdownEdit.Name = "lblCountdownEdit";
            this.lblCountdownEdit.Size = new System.Drawing.Size(102, 34);
            this.lblCountdownEdit.TabIndex = 4;
            this.lblCountdownEdit.Text = "00:00";
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUp.BackgroundImage")));
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUp.Location = new System.Drawing.Point(695, 174);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(71, 65);
            this.btnUp.TabIndex = 5;
            this.toolTipUp.SetToolTip(this.btnUp, "Select a call number and then press this button to move the call number up in the" +
        " listbox.");
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDown.BackgroundImage")));
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDown.Location = new System.Drawing.Point(695, 309);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(71, 65);
            this.btnDown.TabIndex = 6;
            this.toolTipDown.SetToolTip(this.btnDown, "Select a call number and then press this button to move the call number down in t" +
        "he listbox.");
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // toolTipUp
            // 
            this.toolTipUp.IsBalloon = true;
            this.toolTipUp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipUp.ToolTipTitle = "Move Item Up";
            // 
            // toolTipDown
            // 
            this.toolTipDown.IsBalloon = true;
            this.toolTipDown.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDown.ToolTipTitle = "Move Item Down";
            // 
            // toolTipLbox1
            // 
            this.toolTipLbox1.IsBalloon = true;
            this.toolTipLbox1.ToolTipTitle = "Drag Items";
            // 
            // frmSortingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblCountdownEdit);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lstboxSorted);
            this.Controls.Add(this.lstboxRandom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSortingCallNumbers";
            this.Text = "SortingCallNumbers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSortingCallNumbers_FormClosed);
            this.Load += new System.EventHandler(this.frmSortingCallNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstboxRandom;
        private ListBox lstboxSorted;
        private Label lblCountdown;
        private Label lblCountdownEdit;
        private Button btnUp;
        private Button btnDown;
        private ToolTip toolTipUp;
        private ToolTip toolTipDown;
        private ToolTip toolTipLbox1;
    }
}