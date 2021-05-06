using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        //create random generator
        Random randGen = new Random();

        //variables
        int actualNumber;
        int userGuess;

        public Form1()
        {
            InitializeComponent();
            actualNumber = randGen.Next(1, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            //get guess
            userGuess = Convert.ToInt32(guessInput.Text);

            //clear and display guess
            guessInput.Clear();
            guessDisplayOuput.Text = $"Last Guess: {userGuess}";

            //compare to actualNumber
            if (userGuess > actualNumber)
            {
                rangeOutput.Text = "Too High";
            }
            else if (userGuess < actualNumber)
            {
                rangeOutput.Text = "Too Low";
            }
            else
            {
                rangeOutput.Text = "You Got It!";
            }

            //hint
            int difference = actualNumber - userGuess;
            int diffAbsolute = Math.Abs(difference);

            if(diffAbsolute >= 50)
            {
                hintOutput.Text = "Freezing";
            }
            else if (diffAbsolute >= 25 && diffAbsolute < 50)
            {
                hintOutput.Text = "Cold";
            }
            else if (diffAbsolute >= 15 && diffAbsolute < 25)
            {
                hintOutput.Text = "Cool";
            }
            else if (diffAbsolute >= 10 && diffAbsolute < 15)
            {
                hintOutput.Text = "Warm";
            }
            else if (diffAbsolute >= 5 && diffAbsolute < 10)
            {
                hintOutput.Text = "Hot";
            }
            else
            {
                hintOutput.Text = "Boiling";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            actualNumber = randGen.Next(1, 101);
        }
    }
}
