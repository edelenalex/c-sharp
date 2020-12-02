namespace Program_2
{
    partial class Program2
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
            this.lastNameLtrLbl = new System.Windows.Forms.Label();
            this.creditHrsLbl = new System.Windows.Forms.Label();
            this.lastNameLtrTxt = new System.Windows.Forms.TextBox();
            this.creditHrsTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.dateTimeOutputLbl = new System.Windows.Forms.Label();
            this.extraInstructionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameLtrLbl
            // 
            this.lastNameLtrLbl.AutoSize = true;
            this.lastNameLtrLbl.Location = new System.Drawing.Point(12, 25);
            this.lastNameLtrLbl.Name = "lastNameLtrLbl";
            this.lastNameLtrLbl.Size = new System.Drawing.Size(246, 17);
            this.lastNameLtrLbl.TabIndex = 0;
            this.lastNameLtrLbl.Text = "Enter the first letter of your last name:";
            // 
            // creditHrsLbl
            // 
            this.creditHrsLbl.AutoSize = true;
            this.creditHrsLbl.Location = new System.Drawing.Point(38, 120);
            this.creditHrsLbl.Name = "creditHrsLbl";
            this.creditHrsLbl.Size = new System.Drawing.Size(194, 17);
            this.creditHrsLbl.TabIndex = 1;
            this.creditHrsLbl.Text = "Enter credit hours completed:";
            // 
            // lastNameLtrTxt
            // 
            this.lastNameLtrTxt.Location = new System.Drawing.Point(85, 85);
            this.lastNameLtrTxt.Name = "lastNameLtrTxt";
            this.lastNameLtrTxt.Size = new System.Drawing.Size(100, 22);
            this.lastNameLtrTxt.TabIndex = 2;
            // 
            // creditHrsTxt
            // 
            this.creditHrsTxt.Location = new System.Drawing.Point(85, 169);
            this.creditHrsTxt.Name = "creditHrsTxt";
            this.creditHrsTxt.Size = new System.Drawing.Size(100, 22);
            this.creditHrsTxt.TabIndex = 3;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(63, 222);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(145, 23);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "When do I register?";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // dateTimeOutputLbl
            // 
            this.dateTimeOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTimeOutputLbl.Location = new System.Drawing.Point(25, 281);
            this.dateTimeOutputLbl.Name = "dateTimeOutputLbl";
            this.dateTimeOutputLbl.Size = new System.Drawing.Size(221, 23);
            this.dateTimeOutputLbl.TabIndex = 5;
            // 
            // extraInstructionLbl
            // 
            this.extraInstructionLbl.AutoSize = true;
            this.extraInstructionLbl.Location = new System.Drawing.Point(70, 53);
            this.extraInstructionLbl.Name = "extraInstructionLbl";
            this.extraInstructionLbl.Size = new System.Drawing.Size(126, 17);
            this.extraInstructionLbl.TabIndex = 6;
            this.extraInstructionLbl.Text = "(Upper Case Only)";
            // 
            // Program2
            // 
            this.AcceptButton = this.registerBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 355);
            this.Controls.Add(this.extraInstructionLbl);
            this.Controls.Add(this.dateTimeOutputLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.creditHrsTxt);
            this.Controls.Add(this.lastNameLtrTxt);
            this.Controls.Add(this.creditHrsLbl);
            this.Controls.Add(this.lastNameLtrLbl);
            this.Name = "Program2";
            this.Text = "2019 Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLtrLbl;
        private System.Windows.Forms.Label creditHrsLbl;
        private System.Windows.Forms.TextBox lastNameLtrTxt;
        private System.Windows.Forms.TextBox creditHrsTxt;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label dateTimeOutputLbl;
        private System.Windows.Forms.Label extraInstructionLbl;
    }
}

