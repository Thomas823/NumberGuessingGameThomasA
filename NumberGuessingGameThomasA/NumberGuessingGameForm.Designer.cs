namespace NumberGuessingGameThomasA
{
    partial class frmNumberGuessingGame
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
            this.lblGuessNumberPrompt = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtUsersGuess = new System.Windows.Forms.TextBox();
            this.lblAnswerResult = new System.Windows.Forms.Label();
            this.picVisualResults = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVisualResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuessNumberPrompt
            // 
            this.lblGuessNumberPrompt.AutoSize = true;
            this.lblGuessNumberPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessNumberPrompt.Location = new System.Drawing.Point(38, 84);
            this.lblGuessNumberPrompt.Name = "lblGuessNumberPrompt";
            this.lblGuessNumberPrompt.Size = new System.Drawing.Size(266, 20);
            this.lblGuessNumberPrompt.TabIndex = 0;
            this.lblGuessNumberPrompt.Text = "Guess an integer between 1 and 10:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(96, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 41);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtUsersGuess
            // 
            this.txtUsersGuess.Location = new System.Drawing.Point(327, 84);
            this.txtUsersGuess.Name = "txtUsersGuess";
            this.txtUsersGuess.Size = new System.Drawing.Size(100, 20);
            this.txtUsersGuess.TabIndex = 2;
            // 
            // lblAnswerResult
            // 
            this.lblAnswerResult.AutoSize = true;
            this.lblAnswerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerResult.Location = new System.Drawing.Point(258, 167);
            this.lblAnswerResult.Name = "lblAnswerResult";
            this.lblAnswerResult.Size = new System.Drawing.Size(0, 20);
            this.lblAnswerResult.TabIndex = 3;
            // 
            // picVisualResults
            // 
            this.picVisualResults.Location = new System.Drawing.Point(262, 222);
            this.picVisualResults.Name = "picVisualResults";
            this.picVisualResults.Size = new System.Drawing.Size(258, 151);
            this.picVisualResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVisualResults.TabIndex = 4;
            this.picVisualResults.TabStop = false;
            // 
            // frmNumberGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 407);
            this.Controls.Add(this.picVisualResults);
            this.Controls.Add(this.lblAnswerResult);
            this.Controls.Add(this.txtUsersGuess);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGuessNumberPrompt);
            this.Name = "frmNumberGuessingGame";
            this.Text = "Number Guessing Game By Thomas Aubin";
            ((System.ComponentModel.ISupportInitialize)(this.picVisualResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessNumberPrompt;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtUsersGuess;
        private System.Windows.Forms.Label lblAnswerResult;
        private System.Windows.Forms.PictureBox picVisualResults;
    }
}

