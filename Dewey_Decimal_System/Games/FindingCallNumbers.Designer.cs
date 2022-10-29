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
            this.btnChoice1.Location = new System.Drawing.Point(59, 311);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(170, 139);
            this.btnChoice1.TabIndex = 0;
            this.btnChoice1.Text = "button1";
            this.btnChoice1.UseVisualStyleBackColor = true;
            // 
            // btnChoice2
            // 
            this.btnChoice2.Location = new System.Drawing.Point(271, 311);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(170, 139);
            this.btnChoice2.TabIndex = 1;
            this.btnChoice2.Text = "button2";
            this.btnChoice2.UseVisualStyleBackColor = true;
            // 
            // btnChoice3
            // 
            this.btnChoice3.Location = new System.Drawing.Point(484, 311);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(170, 139);
            this.btnChoice3.TabIndex = 2;
            this.btnChoice3.Text = "button3";
            this.btnChoice3.UseVisualStyleBackColor = true;
            // 
            // btnChoice4
            // 
            this.btnChoice4.Location = new System.Drawing.Point(710, 311);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Size = new System.Drawing.Size(170, 139);
            this.btnChoice4.TabIndex = 3;
            this.btnChoice4.Text = "button4";
            this.btnChoice4.UseVisualStyleBackColor = true;
            // 
            // txbDescription
            // 
            this.txbDescription.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDescription.Location = new System.Drawing.Point(313, 180);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(284, 39);
            this.txbDescription.TabIndex = 4;
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