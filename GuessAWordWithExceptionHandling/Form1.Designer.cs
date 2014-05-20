namespace GuessAWordWithExceptionHandling
{
    partial class Form1
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.newWordButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(70, 30);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(130, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Guess a letter in the word:";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(57, 93);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(39, 13);
            this.wordLabel.TabIndex = 1;
            this.wordLabel.Text = "Word: ";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(70, 181);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(113, 13);
            this.resultsLabel.TabIndex = 2;
            this.resultsLabel.Text = "Results displayed here";
            this.resultsLabel.Visible = false;
            // 
            // letterTextBox
            // 
            this.letterTextBox.Location = new System.Drawing.Point(160, 90);
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(40, 20);
            this.letterTextBox.TabIndex = 3;
            // 
            // newWordButton
            // 
            this.newWordButton.Location = new System.Drawing.Point(50, 130);
            this.newWordButton.Name = "newWordButton";
            this.newWordButton.Size = new System.Drawing.Size(75, 23);
            this.newWordButton.TabIndex = 4;
            this.newWordButton.Text = "New Word";
            this.newWordButton.UseVisualStyleBackColor = true;
            this.newWordButton.Click += new System.EventHandler(this.newWordButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(148, 130);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(80, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit Letter";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newWordButton);
            this.Controls.Add(this.letterTextBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form1";
            this.Text = "Guess A Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TextBox letterTextBox;
        private System.Windows.Forms.Button newWordButton;
        private System.Windows.Forms.Button submitButton;
    }
}

