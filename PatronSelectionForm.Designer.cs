namespace LibraryItems
{
    partial class PatronSelectionForm
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
            this.patronSelectCbo = new System.Windows.Forms.ComboBox();
            this.chooseLbl = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patronSelectCbo
            // 
            this.patronSelectCbo.FormattingEnabled = true;
            this.patronSelectCbo.Location = new System.Drawing.Point(129, 34);
            this.patronSelectCbo.Name = "patronSelectCbo";
            this.patronSelectCbo.Size = new System.Drawing.Size(121, 24);
            this.patronSelectCbo.TabIndex = 0;
            // 
            // chooseLbl
            // 
            this.chooseLbl.AutoSize = true;
            this.chooseLbl.Location = new System.Drawing.Point(12, 37);
            this.chooseLbl.Name = "chooseLbl";
            this.chooseLbl.Size = new System.Drawing.Size(97, 17);
            this.chooseLbl.TabIndex = 1;
            this.chooseLbl.Text = "Select Patron:";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(74, 111);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(129, 23);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // PatronSelectionForm
            // 
            this.AcceptButton = this.selectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 173);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.chooseLbl);
            this.Controls.Add(this.patronSelectCbo);
            this.Name = "PatronSelectionForm";
            this.Text = "PatronSelectionForm";
            this.Load += new System.EventHandler(this.PatronSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patronSelectCbo;
        private System.Windows.Forms.Label chooseLbl;
        private System.Windows.Forms.Button selectBtn;
    }
}