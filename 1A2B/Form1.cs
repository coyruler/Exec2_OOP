using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B
{
    public partial class Form1 : Form
    {
        private GuessNumber game;
        public Form1()
        {
            InitializeComponent();
            game = new GuessNumber();
            txtGuess.Text = "Guess     Result";
            game.NewGame();
            lnlAnswer.Visible = false;
        }



        private void btnNewGame_Click(object sender, EventArgs e)
        {
            game.NewGame();
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            int? guessNumber = GetGuessNumber();

            if (guessNumber.HasValue == false)
            {
                MessageBox.Show("請輸入4個不一樣的數字");
                return;
            }

            GuessResult result = game.Guess(guessNumber.Value);
            if (result.IsSuccess == true)
            {
                MessageBox.Show("您答對了");

            }
            else
            {
                //lnlAnswer.Text = answer;
                txtGuess.Text += result.Hint;
            }


        }
        private int? GetGuessNumber()
        {
            TextBox txt = this.txtInput;
            string input = txt.Text;
            bool repeat = false;
            if (string.IsNullOrEmpty(input)) return null;
            
            bool isInt = int.TryParse(input, out int number);

           
            if(input.Length == 4)
            {
                if (input[0] == input[1] || input[0] == input[2] ||
                    input[0] == input[3] || input[1] == input[2] ||
                    input[1] == input[3] || input[2] == input[3])
                {
                    repeat = true;
                }
            }
            
            return (isInt && input.Length ==4 && !repeat ) ? number : (int?)null;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int? guessNumber = GetGuessNumber();

            GuessNumber result = game;
            lnlAnswer.Text = result.Answer;
            lnlAnswer.Visible = true;
        }
    }

    public class GuessNumber
    {
        String[] answerAr = new string[4];
        String[] guessNumberAr = new string[4];
        int a = 0, b = 0;
        int guessNumber = 0;
        string answer;

        public string Answer { get; set; }
        public void NewGame()
        {
            
            int seed = Guid.NewGuid().GetHashCode();
            var random = new Random(seed);
            int number1 = random.Next(0, 9);
            int number2 = random.Next(0, 9);
            int number3 = random.Next(0, 9);
            int number4 = random.Next(0, 9);

            
            
            while (number2 == number1)
            {
                number2 = random.Next(0, 9);
            }                    
            while (number3 == number1 || number3 == number2)
            {
                number3 = random.Next(0, 9);
            }
            while (number4 == number1 || number4 == number2 || number4 == number3)
            {
                number4 = random.Next(0, 9);
            }
            string ans1 = number1.ToString();
            string ans2 = number2.ToString();
            string ans3 = number3.ToString();
            string ans4 = number4.ToString();
            answer = ($"{ans1}{ans2}{ans3}{ans4}");
            Answer = answer;
        }

        public GuessResult Guess(int inputGuessNumber)
        {
            guessNumber = inputGuessNumber;
            string inputGuessNumberString = inputGuessNumber.ToString();

            
            if (inputGuessNumberString[0] == inputGuessNumberString[1] || inputGuessNumberString[0] == inputGuessNumberString[2] ||
                inputGuessNumberString[0] == inputGuessNumberString[3] || inputGuessNumberString[1] == inputGuessNumberString[2] ||
                inputGuessNumberString[1] == inputGuessNumberString[3] || inputGuessNumberString[2] == inputGuessNumberString[3] )
            {
                return GuessResult.RepeatNum();
            }
            
            for (int k = 0; k <= 3; k++)
            {
                answerAr[k] = answer.Substring(k, 1);
            }
            a = 0;
            b = 0;
            for (int m = 0; m < 4; m++)
            {
                for (int p = 0; p < 4; p++)
                {
                    if(inputGuessNumberString[m].ToString() == answerAr[p])
                    {
                        if(m == p)
                        {
                            a++;
                        }
                        else
                        {
                            b++;
                        }
                    }
                }
                if(a == 4 && b == 0)
                {
                    return GuessResult.Success();
                }                        
            }
            return GuessResult.Failed(this.Hint);
        }

        public string Hint
        {
            get
            {
                return $"\r\n {guessNumber}       {a}A{b}B";
            }
        }
    }

    public class GuessResult
    {
        public static GuessResult Success()
        {
            return new GuessResult { IsSuccess = true, Hint = String.Empty };
        }
        public static GuessResult Failed(string errMessage)
        {
            return new GuessResult { IsSuccess = false, Hint = errMessage };
        }
        public static GuessResult RepeatNum()
        {
            return new GuessResult { IsSuccess = false, Hint = String.Empty };
        }

        public bool IsSuccess { get; set; }

        public string Hint { get; set; }

    }
}
