namespace LibraryItems
{
    partial class BookSelectionForm
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
            this.bookSelectCbo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bookSelectLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookSelectCbo
            // 
            this.bookSelectCbo.FormattingEnabled = true;
            this.bookSelectCbo.Location = new System.Drawing.Point(116, 36);
            this.bookSelectCbo.Name = "bookSelectCbo";
            this.bookSelectCbo.Size = new System.Drawing.Size(121, 24);
            this.bookSelectCbo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bookSelectLbl
            // 
            this.bookSelectLbl.AutoSize = true;
            this.bookSelectLbl.Location = new System.Drawing.Point(12, 39);
            this.bookSelectLbl.Name = "bookSelectLbl";
            this.bookSelectLbl.Size = new System.Drawing.Size(87, 17);
            this.bookSelectLbl.TabIndex = 2;
            this.bookSelectLbl.Text = "Select Book:";
            // 
            // BookSelectionForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 146);
            this.Controls.Add(this.bookSelectLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookSelectCbo);
            this.Name = "BookSelectionForm";
            this.Text = "Book Selection Form";
            this.Load += new System.EventHandler(this.BookSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookSelectCbo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label bookSelectLbl;
    }
}