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
            this.lblCountdownEdit = new System.Windows.Forms.Label();
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
            this.lblCountdown.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountdown.Location = new System.Drawing.Point(157, 71);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(141, 34);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "Timer : ";
            // 
            // lblCountdownEdit
            // 
            this.lblCountdownEdit.AutoSize = true;
            this.lblCountdownEdit.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountdownEdit.Location = new System.Drawing.Point(457, 71);
            this.lblCountdownEdit.Name = "lblCountdownEdit";
            this.lblCountdownEdit.Size = new System.Drawing.Size(102, 34);
            this.lblCountdownEdit.TabIndex = 4;
            this.lblCountdownEdit.Text = "00:00";
            // 
            // frmSortingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCountdownEdit);
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
        private Label lblCountdownEdit;
    }
}