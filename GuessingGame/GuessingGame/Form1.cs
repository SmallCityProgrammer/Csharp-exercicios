using System;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        Random randomNumber = new Random();
        int number = 0;
        int guesses = 0;
        int wins = 0;
        int totalGames = 0;
        const int maxAttempts = 3; // Maximum attempts allowed

        public Form1()
        {
            InitializeComponent();
            SetNumber();
        }

        private void CheckNumber(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(TxtGuess.Text, out i))
            {
                MessageBox.Show("Por favor, insira um número válido.");
                return;
            }

            guesses++;
            lblGuess.Text = "Você tentou " + guesses + " vezes";

            if (i == number)
            {
                MessageBox.Show("Você acertou!");
                wins++; // Increment wins when the player guesses correctly
                totalGames++; // Increment totalGames for each game played
                CalculateWinRate(); // Update the win rate label
                SetNumber();
                TxtGuess.Text = "";
                guesses = 0;
            }
            else if (guesses >= maxAttempts)
            {
                MessageBox.Show("Suas tentativas acabaram. O número correto era " + number);
                totalGames++; // Increment totalGames for each game played
                CalculateWinRate(); // Update the win rate label
                SetNumber();
                TxtGuess.Text = "";
                guesses = 0;
            }
            else if (i < number)
            {
                MessageBox.Show("Escolha um número maior!");
            }
            else
            {
                MessageBox.Show("Escolha um número menor!");
            }
        }

        private void SetNumber()
        {
            number = randomNumber.Next(0, 10);
            numberQuestion.Text = "Escolha um número de 0 a 9";
        }

        private void CalculateWinRate()
        {
            if (totalGames > 0)
            {
                double winRate = (double)wins / totalGames * 100;
                labelWinRate.Text = "Win Rate: " + winRate.ToString("0.00") + "%";
            }
            else
            {
                labelWinRate.Text = "Win Rate: 0.00%";
            }
        }
    }
}
