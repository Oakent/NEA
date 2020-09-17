namespace NEA
{
    partial class Form1
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
            this.btTimer = new System.Windows.Forms.Button();
            this.btStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTimer
            // 
            this.btTimer.Location = new System.Drawing.Point(339, 160);
            this.btTimer.Name = "btTimer";
            this.btTimer.Size = new System.Drawing.Size(87, 34);
            this.btTimer.TabIndex = 0;
            this.btTimer.Text = "Timer";
            this.btTimer.UseVisualStyleBackColor = true;
            this.btTimer.Click += new System.EventHandler(this.btTimer_Click);
            // 
            // btStats
            // 
            this.btStats.Location = new System.Drawing.Point(339, 239);
            this.btStats.Name = "btStats";
            this.btStats.Size = new System.Drawing.Size(86, 37);
            this.btStats.TabIndex = 1;
            this.btStats.Text = "Stats";
            this.btStats.UseVisualStyleBackColor = true;
            this.btStats.Click += new System.EventHandler(this.btStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStats);
            this.Controls.Add(this.btTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTimer;
        private System.Windows.Forms.Button btStats;
    }
}

