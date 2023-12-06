namespace GuessingGame
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
            btnGuess = new Button();
            TxtGuess = new TextBox();
            numberQuestion = new Label();
            lblGuess = new Label();
            labelWinRate = new Label();
            SuspendLayout();
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(280, 325);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(399, 97);
            btnGuess.TabIndex = 0;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += CheckNumber;
            // 
            // TxtGuess
            // 
            TxtGuess.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TxtGuess.Location = new Point(351, 245);
            TxtGuess.Name = "TxtGuess";
            TxtGuess.Size = new Size(282, 47);
            TxtGuess.TabIndex = 1;
            // 
            // numberQuestion
            // 
            numberQuestion.AutoSize = true;
            numberQuestion.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            numberQuestion.ImageAlign = ContentAlignment.TopCenter;
            numberQuestion.Location = new Point(280, 105);
            numberQuestion.Name = "numberQuestion";
            numberQuestion.Size = new Size(307, 46);
            numberQuestion.TabIndex = 2;
            numberQuestion.Text = "Numero entre 1-10";
            numberQuestion.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblGuess
            // 
            lblGuess.AutoSize = true;
            lblGuess.Location = new Point(12, 29);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(82, 20);
            lblGuess.TabIndex = 3;
            lblGuess.Text = "Tentativas: ";
            // 
            // labelWinRate
            // 
            labelWinRate.AutoSize = true;
            labelWinRate.Location = new Point(862, 19);
            labelWinRate.Name = "labelWinRate";
            labelWinRate.Size = new Size(64, 20);
            labelWinRate.TabIndex = 0;
            labelWinRate.Text = "Winrate:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 583);
            Controls.Add(labelWinRate);
            Controls.Add(lblGuess);
            Controls.Add(numberQuestion);
            Controls.Add(TxtGuess);
            Controls.Add(btnGuess);
            Name = "Form1";
            Text = "Guessing Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuess;
        private TextBox TxtGuess;
        private Label numberQuestion;
        private Label lblGuess;
        private Label labelWinRate;
    }
}