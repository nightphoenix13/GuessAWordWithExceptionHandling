using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessAWordWithExceptionHandling
{
    public partial class Form1 : Form
    {
        // form variables/arrays
        string[] words = { "apricot", "elephant", "tigress", "fortunate", "impossible", "historical", "colorful", "science" };
        string word,
               guessWord = "";
        bool wordIsValid = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // button variables
            char letter = ' ',
                 tempChar;
            bool letterInWord = false;

            // input validation to ensure there is a current word to guess with
            if (!(wordIsValid))
            {
                resultsLabel.Text = "You must get a new word first.";
                resultsLabel.Visible = true;
            }
            else
            {
                try
                {
                    letter = Convert.ToChar(letterTextBox.Text.Substring(0, 1));
                    if (!Char.IsLetter(letter))
                    {
                        throw new NonLetterException(letter);
                    } // end if
                    else
                    {
                        for (int x = 0; x < word.Length; ++x)
                        {
                            tempChar = Convert.ToChar(word.Substring(x, 1));
                            if (tempChar == letter)
                            {
                                guessWord = guessWord.Substring(0, x) + letter + guessWord.Substring(x + 1, (guessWord.Length - 1 - x));
                                word = word.Substring(0, x) + "?" + word.Substring(x + 1, (guessWord.Length - 1 - x));
                                wordLabel.Text = "Word: " + guessWord;
                                letterInWord = true;
                            }
                        }
                        if (word == guessWord)
                        {
                            resultsLabel.Text = "You guessed the word!";
                            resultsLabel.Visible = true;
                            wordIsValid = false; // sets boolean to false when word is guessed correctly: makes user submit new word button to keep playing.
                        }
                        else if (letterInWord)
                        {
                            resultsLabel.Text = string.Format("The letter '{0}' is in the word.", letter);
                            resultsLabel.Visible = true;
                        }
                        else
                        {
                            resultsLabel.Text = string.Format("The letter '{0}' is not in the word.", letter);
                            resultsLabel.Visible = true;
                        }
                    } // end else
                } // end try
                catch (NonLetterException nle)
                {
                    MessageBox.Show(nle.Message, "Not A Letter",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    } // end catch
            }

        }

        private void newWordButton_Click(object sender, EventArgs e)
        {
            // button variables
            int randomNumber;
            Random ranNumberGenerator = new Random();

            // generates random number
            randomNumber = ranNumberGenerator.Next(0, words.Length - 1);

            // selects word from the array and sets up 
            word = words[randomNumber];
            for (int x = 0; x < word.Length; ++x)
                guessWord += "*";
            wordLabel.Text = "Word: " + guessWord;
            wordIsValid = true;
        }
    }
}
