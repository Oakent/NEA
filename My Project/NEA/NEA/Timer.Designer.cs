namespace NEA
{
    partial class Timer
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
            this.GenerateScramble = new System.Windows.Forms.Button();
            this.scrambleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateScramble
            // 
            this.GenerateScramble.Location = new System.Drawing.Point(280, 104);
            this.GenerateScramble.Name = "GenerateScramble";
            this.GenerateScramble.Size = new System.Drawing.Size(172, 23);
            this.GenerateScramble.TabIndex = 1;
            this.GenerateScramble.Text = "Generate Scramble ";
            this.GenerateScramble.UseVisualStyleBackColor = true;
            this.GenerateScramble.Click += new System.EventHandler(this.button1_Click);
            // 
            // scrambleLabel
            // 
            this.scrambleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scrambleLabel.AutoSize = true;
            this.scrambleLabel.Location = new System.Drawing.Point(340, 184);
            this.scrambleLabel.Name = "scrambleLabel";
            this.scrambleLabel.Size = new System.Drawing.Size(35, 15);
            this.scrambleLabel.TabIndex = 2;
            this.scrambleLabel.Text = "Label";
            this.scrambleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scrambleLabel.Click += new System.EventHandler(this.scrambleLabel_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scrambleLabel);
            this.Controls.Add(this.GenerateScramble);
            this.Name = "Timer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GenerateScramble;
        private System.Windows.Forms.Label scrambleLabel;
    }
}