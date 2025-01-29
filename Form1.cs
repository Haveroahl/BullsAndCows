using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private string secretNumber;
        private int attempts;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            secretNumber = GenerateSecretNumber();
            attempts = 0;
            listBoxResults.Items.Clear();
            labelMessage.Text = "Thử đoán 1 số có đủ 4 chữ số nào.";
            buttonGuess.Enabled = true;
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            string guess = textBoxGuess.Text;
            attempts++;

            if (guess.Length != 4 || !IsAllDigits(guess))
            {
                labelMessage.Text = "Nhập sai. Vui lòng nhập số có đủ 4 chữ số: ";
                return;
            }

            (int bulls, int cows) = GetBullsAndCows(secretNumber, guess);

            if (bulls == 4)
            {
                labelMessage.Text = $"Chúc mừng! Bạn đã đoán đúng con số {secretNumber} trong {attempts} lượt đoán.";
                buttonGuess.Enabled = false;
            }
            else
            {
                listBoxResults.Items.Add($"{guess}: {bulls} Bulls và {cows} Cows");
                labelMessage.Text = "Thử lại!";
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private string GenerateSecretNumber()
        {
            Random random = new Random();
            char[] digits = new char[4];
            int i = 0;

            while (i < 4)
            {
                char digit = (char)('0' + random.Next(0, 10));
                if (!ArrayContains(digits, digit))
                {
                    digits[i] = digit;
                    i++;
                }
            }

            return new string(digits);
        }

        private bool ArrayContains(char[] array, char value)
        {
            foreach (char item in array)
            {
                if (item == value)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsAllDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        private (int bulls, int cows) GetBullsAndCows(string secret, string guess)
        {
            int bulls = 0;
            int cows = 0;

            for (int i = 0; i < 4; i++)
            {
                if (secret[i] == guess[i])
                {
                    bulls++;
                }
                else if (CharArrayContains(secret, guess[i]))
                {
                    cows++;
                }
            }

            return (bulls, cows);
        }

        private bool CharArrayContains(string str, char value)
        {
            foreach (char c in str)
            {
                if (c == value)
                {
                    return true;
                }
            }
            return false;
        }

        private void textBoxGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric characters and control characters (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
