namespace Dewey_Decimal_System.Games
{
    partial class FindingCallNumbers
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
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice4 = new System.Windows.Forms.Button();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.Color.Moccasin;
            this.btnChoice1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnChoice1.Location = new System.Drawing.Point(59, 311);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(170, 139);
            this.btnChoice1.TabIndex = 0;
            this.btnChoice1.Text = "button1";
            this.btnChoice1.UseVisualStyleBackColor = false;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnChoice2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnChoice2.Location = new System.Drawing.Point(271, 311);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(170, 139);
            this.btnChoice2.TabIndex = 1;
            this.btnChoice2.Text = "button2";
            this.btnChoice2.UseVisualStyleBackColor = false;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.BackColor = System.Drawing.Color.Bisque;
            this.btnChoice3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnChoice3.Location = new System.Drawing.Point(484, 311);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(170, 139);
            this.btnChoice3.TabIndex = 2;
            this.btnChoice3.Text = "button3";
            this.btnChoice3.UseVisualStyleBackColor = false;
            this.btnChoice3.Click += new System.EventHandler(this.btnChoice3_Click);
            // 
            // btnChoice4
            // 
            this.btnChoice4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnChoice4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnChoice4.Location = new System.Drawing.Point(710, 311);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Size = new System.Drawing.Size(170, 139);
            this.btnChoice4.TabIndex = 3;
            this.btnChoice4.Text = "button4";
            this.btnChoice4.UseVisualStyleBackColor = false;
            this.btnChoice4.Click += new System.EventHandler(this.btnChoice4_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.BackColor = System.Drawing.Color.White;
            this.txbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txbDescription.Location = new System.Drawing.Point(176, 186);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.ReadOnly = true;
            this.txbDescription.Size = new System.Drawing.Size(572, 40);
            this.txbDescription.TabIndex = 4;
            this.txbDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Timer :";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(489, 40);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(87, 40);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "00:00";
            // 
            // FindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dewey_Decimal_System.Properties.Resources._1ddf1f1334afb0767824a62552d0fadb__backgrounds_free_black_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Name = "FindingCallNumbers";
            this.Text = "FindingCallNumbers";
            this.Load += new System.EventHandler(this.FindingCallNumbers_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FindingCallNumbers_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChoice1;
        private Button btnChoice2;
        private Button btnChoice3;
        private Button btnChoice4;
        private TextBox txbDescription;
        private Label label1;
        private Label lblTimer;
    }
}