namespace Dewey_Decimal_System
{
    partial class IdentifyingAreas
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lstboxDescription = new System.Windows.Forms.ListBox();
            this.lstboxCallNo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(305, 19);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(94, 40);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "label1";
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(170, 377);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(466, 45);
            this.btnCheckAnswer.TabIndex = 6;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // lstboxDescription
            // 
            this.lstboxDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstboxDescription.FormattingEnabled = true;
            this.lstboxDescription.ItemHeight = 25;
            this.lstboxDescription.Location = new System.Drawing.Point(316, 92);
            this.lstboxDescription.Name = "lstboxDescription";
            this.lstboxDescription.Size = new System.Drawing.Size(320, 279);
            this.lstboxDescription.TabIndex = 5;
            this.lstboxDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstboxDescription_MouseDown);
            // 
            // lstboxCallNo
            // 
            this.lstboxCallNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstboxCallNo.FormattingEnabled = true;
            this.lstboxCallNo.ItemHeight = 30;
            this.lstboxCallNo.Location = new System.Drawing.Point(167, 94);
            this.lstboxCallNo.Name = "lstboxCallNo";
            this.lstboxCallNo.Size = new System.Drawing.Size(143, 274);
            this.lstboxCallNo.TabIndex = 4;
            this.lstboxCallNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstboxCallNo_MouseDown);
            // 
            // IdentifyingAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.lstboxDescription);
            this.Controls.Add(this.lstboxCallNo);
            this.Name = "IdentifyingAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdentifyingAreas";
            this.Load += new System.EventHandler(this.IdentifyingAreas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTimer;
        private Button btnCheckAnswer;
        private ListBox lstboxDescription;
        private ListBox lstboxCallNo;
    }
}