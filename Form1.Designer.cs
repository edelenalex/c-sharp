namespace Program1
{
    partial class Program1
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
            this.wallLengthLbl = new System.Windows.Forms.Label();
            this.wallHeightLbl = new System.Windows.Forms.Label();
            this.doorNumLbl = new System.Windows.Forms.Label();
            this.numWindowsLbl = new System.Windows.Forms.Label();
            this.numCoatsLbl = new System.Windows.Forms.Label();
            this.wallLengthTxt = new System.Windows.Forms.TextBox();
            this.wallHeightTxt = new System.Windows.Forms.TextBox();
            this.numDoorsTxt = new System.Windows.Forms.TextBox();
            this.numWindowsTxt = new System.Windows.Forms.TextBox();
            this.numCoatsTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.minGallonsLbl = new System.Windows.Forms.Label();
            this.minGallonsOutputLbl = new System.Windows.Forms.Label();
            this.gallonsToBuyLbl = new System.Windows.Forms.Label();
            this.gallonsToBuyOutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wallLengthLbl
            // 
            this.wallLengthLbl.AutoSize = true;
            this.wallLengthLbl.Location = new System.Drawing.Point(12, 48);
            this.wallLengthLbl.Name = "wallLengthLbl";
            this.wallLengthLbl.Size = new System.Drawing.Size(195, 17);
            this.wallLengthLbl.TabIndex = 0;
            this.wallLengthLbl.Text = "Total Length of walls (in feet):";
            // 
            // wallHeightLbl
            // 
            this.wallHeightLbl.AutoSize = true;
            this.wallHeightLbl.Location = new System.Drawing.Point(12, 96);
            this.wallHeightLbl.Name = "wallHeightLbl";
            this.wallHeightLbl.Size = new System.Drawing.Size(180, 17);
            this.wallHeightLbl.TabIndex = 1;
            this.wallHeightLbl.Text = "Height of the walls (in feet):";
            // 
            // doorNumLbl
            // 
            this.doorNumLbl.AutoSize = true;
            this.doorNumLbl.Location = new System.Drawing.Point(12, 144);
            this.doorNumLbl.Name = "doorNumLbl";
            this.doorNumLbl.Size = new System.Drawing.Size(256, 17);
            this.doorNumLbl.TabIndex = 2;
            this.doorNumLbl.Text = "Number of door (non-negative integer):";
            // 
            // numWindowsLbl
            // 
            this.numWindowsLbl.AutoSize = true;
            this.numWindowsLbl.Location = new System.Drawing.Point(12, 192);
            this.numWindowsLbl.Name = "numWindowsLbl";
            this.numWindowsLbl.Size = new System.Drawing.Size(279, 17);
            this.numWindowsLbl.TabIndex = 3;
            this.numWindowsLbl.Text = "Number of windows (non-negative integer):";
            // 
            // numCoatsLbl
            // 
            this.numCoatsLbl.AutoSize = true;
            this.numCoatsLbl.Location = new System.Drawing.Point(12, 240);
            this.numCoatsLbl.Name = "numCoatsLbl";
            this.numCoatsLbl.Size = new System.Drawing.Size(245, 17);
            this.numCoatsLbl.TabIndex = 4;
            this.numCoatsLbl.Text = "Coats of Paint (non-negative integer):";
            // 
            // wallLengthTxt
            // 
            this.wallLengthTxt.Location = new System.Drawing.Point(331, 45);
            this.wallLengthTxt.Name = "wallLengthTxt";
            this.wallLengthTxt.Size = new System.Drawing.Size(100, 22);
            this.wallLengthTxt.TabIndex = 5;
            // 
            // wallHeightTxt
            // 
            this.wallHeightTxt.Location = new System.Drawing.Point(331, 92);
            this.wallHeightTxt.Name = "wallHeightTxt";
            this.wallHeightTxt.Size = new System.Drawing.Size(100, 22);
            this.wallHeightTxt.TabIndex = 6;
            // 
            // numDoorsTxt
            // 
            this.numDoorsTxt.Location = new System.Drawing.Point(331, 139);
            this.numDoorsTxt.Name = "numDoorsTxt";
            this.numDoorsTxt.Size = new System.Drawing.Size(100, 22);
            this.numDoorsTxt.TabIndex = 7;
            // 
            // numWindowsTxt
            // 
            this.numWindowsTxt.Location = new System.Drawing.Point(331, 186);
            this.numWindowsTxt.Name = "numWindowsTxt";
            this.numWindowsTxt.Size = new System.Drawing.Size(100, 22);
            this.numWindowsTxt.TabIndex = 8;
            // 
            // numCoatsTxt
            // 
            this.numCoatsTxt.Location = new System.Drawing.Point(331, 233);
            this.numCoatsTxt.Name = "numCoatsTxt";
            this.numCoatsTxt.Size = new System.Drawing.Size(100, 22);
            this.numCoatsTxt.TabIndex = 9;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(120, 323);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(136, 26);
            this.calcBtn.TabIndex = 10;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // minGallonsLbl
            // 
            this.minGallonsLbl.AutoSize = true;
            this.minGallonsLbl.Location = new System.Drawing.Point(539, 48);
            this.minGallonsLbl.Name = "minGallonsLbl";
            this.minGallonsLbl.Size = new System.Drawing.Size(168, 17);
            this.minGallonsLbl.TabIndex = 11;
            this.minGallonsLbl.Text = "Minimum gallons needed:";
            // 
            // minGallonsOutputLbl
            // 
            this.minGallonsOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minGallonsOutputLbl.Location = new System.Drawing.Point(574, 90);
            this.minGallonsOutputLbl.Name = "minGallonsOutputLbl";
            this.minGallonsOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.minGallonsOutputLbl.TabIndex = 12;
            // 
            // gallonsToBuyLbl
            // 
            this.gallonsToBuyLbl.AutoSize = true;
            this.gallonsToBuyLbl.Location = new System.Drawing.Point(529, 186);
            this.gallonsToBuyLbl.Name = "gallonsToBuyLbl";
            this.gallonsToBuyLbl.Size = new System.Drawing.Size(207, 17);
            this.gallonsToBuyLbl.TabIndex = 13;
            this.gallonsToBuyLbl.Text = "Number of gallons to Purchase:";
            // 
            // gallonsToBuyOutputLbl
            // 
            this.gallonsToBuyOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsToBuyOutputLbl.Location = new System.Drawing.Point(574, 233);
            this.gallonsToBuyOutputLbl.Name = "gallonsToBuyOutputLbl";
            this.gallonsToBuyOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.gallonsToBuyOutputLbl.TabIndex = 14;
            // 
            // Program1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gallonsToBuyOutputLbl);
            this.Controls.Add(this.gallonsToBuyLbl);
            this.Controls.Add(this.minGallonsOutputLbl);
            this.Controls.Add(this.minGallonsLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.numCoatsTxt);
            this.Controls.Add(this.numWindowsTxt);
            this.Controls.Add(this.numDoorsTxt);
            this.Controls.Add(this.wallHeightTxt);
            this.Controls.Add(this.wallLengthTxt);
            this.Controls.Add(this.numCoatsLbl);
            this.Controls.Add(this.numWindowsLbl);
            this.Controls.Add(this.doorNumLbl);
            this.Controls.Add(this.wallHeightLbl);
            this.Controls.Add(this.wallLengthLbl);
            this.Name = "Program1";
            this.Text = "Handy-Dandy Paint Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wallLengthLbl;
        private System.Windows.Forms.Label wallHeightLbl;
        private System.Windows.Forms.Label doorNumLbl;
        private System.Windows.Forms.Label numWindowsLbl;
        private System.Windows.Forms.Label numCoatsLbl;
        private System.Windows.Forms.TextBox wallLengthTxt;
        private System.Windows.Forms.TextBox wallHeightTxt;
        private System.Windows.Forms.TextBox numDoorsTxt;
        private System.Windows.Forms.TextBox numWindowsTxt;
        private System.Windows.Forms.TextBox numCoatsTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label minGallonsLbl;
        private System.Windows.Forms.Label minGallonsOutputLbl;
        private System.Windows.Forms.Label gallonsToBuyLbl;
        private System.Windows.Forms.Label gallonsToBuyOutputLbl;
    }
}

