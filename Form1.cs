namespace Guesser__C__2
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int guessCount;
        private const int MaxGuesses = 10;
        private int previousGuess; // Add this line to declare previousGuess

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 1001);
            guessCount = 0;
            previousGuess = -1;
            statusLabel.Text = "Guess a number between 1 and 1000.";
        }

        private void guessButton_Click(object sender, EventArgs e)
        {

        }

        private void guessButton_Click_1(object sender, EventArgs e)
        {
            int userGuess;

            if (int.TryParse(guessTextBox.Text, out userGuess))
            {
                guessCount++;
                if (userGuess == targetNumber)
                {
                    if (guessCount < MaxGuesses)
                    {
                        MessageBox.Show("Either you know the secret or you got lucky!");
                    }
                    else
                    {
                       MessageBox.Show( "You know the secret!\n");
                    }
                   MessageBox.Show ("Congratulations! You've guessed the number.");
                    StartNewGame();
                }
                else if (guessCount >= MaxGuesses)
                {
                    MessageBox.Show("You should be able to do better!\n");
                     MessageBox.Show ($"Sorry, you've used all {MaxGuesses} guesses. The number was {targetNumber}.");
                    StartNewGame();
                }
                else
                {
                    Random random = new Random();
                    int range = Math.Max(1, 100 - guessCount * 10); // Reduce range as guesses increase
                    int before = targetNumber - random.Next(1, range);
                    int after = targetNumber + random.Next(1, range);

                    if (before < 1) before = 1;
                    if (after > 1000) after = 1000;

                    if (userGuess < targetNumber)
                    {
                        statusLabel.Text = $"Too Low, Try Again. Numbers close to target is: {before} and , {after}\n.";
                    }
                    else
                    {
                        statusLabel.Text = $"Too High, Try Again. Numbers close to target is: {before} and , {after}\n.";
                    }

                    if (previousGuess != -1)
                    {
                        int previousDifference = Math.Abs(previousGuess - targetNumber);
                        int currentDifference = Math.Abs(userGuess - targetNumber);

                        if (currentDifference < previousDifference)
                        {
                            statusLabel.Text += " You're getting warmer.";
                        }
                        else
                        {
                            statusLabel.Text += " You're getting colder.";
                        }
                    }

                    previousGuess = userGuess;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
        
