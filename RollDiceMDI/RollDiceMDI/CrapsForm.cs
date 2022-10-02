using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollDiceMDI
{
    // Created by Nimmala
    //55555555555555555555555
    public partial class CrapsForm : Form
    {
        private RollDiceClass rollDiceInstance = new RollDiceClass();

        //enum for game staus
        private enum Status { Start, Continue, Won, Lost };

        // Enum for common rules of dice
        /*
        * Enum is a way of creating a Type of your own alias for integers.
        * An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying 
        * integral numeric type. 
        * By default, the associated constant values of enum members are of type int; 
        * they start with zero and increase by one following the definition text order. 
        * You can explicitly specify any other integral numeric type as an underlying type of an enumeration type.
        * To define an enumeration type, use the enum keyword and specify the names of enum members:
        * If you call a specific enum member, it returns the underlying integer. Pizza.NewYorkStyle returns 2.
        * If you convert an integer to an enum, it returns the name of the integer such as: (Pizza)Chicago will return 1
        */
        private enum DiceNames
        {
            SnakeEyes = 2,
            Trey = 3,
            LittleJoe = 4,
            Fever = 5,
            JimmieHicks = 6,
            Seven = 7,
            SquarePair = 8,
            Nina = 9,
            PuppyPaws = 10,
            YoLeven = 11,
            BoxCars = 12
        }//enum

        //Set initial point
        private int myPoint = 0;
        private Status gameStatus = Status.Start;
        public CrapsForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int sumOfDice;
            int die1;
            int die2;
            //observe that the die variables have not been initialized.
            //They are being passed to the rollDice method by reference.

            //check  what the first roll status is
            if (gameStatus == Status.Start)
            {
                sumOfDice = rollDiceInstance.RollDice(out die1, out die2);// first roll of dice
                die1Label.Text = die1.ToString();
                die2Label.Text = die2.ToString();
                // able to access the die variable values now after the method has made changes
                switch ((DiceNames)sumOfDice)
                {
                    //If the sum is 2, 3 or 12 on the first throw (called “craps”), you lose (i.e., “the house” wins).
                    case DiceNames.SnakeEyes: //2
                    case DiceNames.Trey: //3
                    case DiceNames.BoxCars: //12
                        //set gane status
                        gameStatus = Status.Lost;
                        resultListBox.Items.Add($"Yoy rolled{die1}+{die2}={sumOfDice}:{(DiceNames)sumOfDice}" +
                            $"{Environment.NewLine}");
                        break;

                    // 7 or 11 on first roll, you Win

                    case DiceNames.Seven:
                    case DiceNames.YoLeven:
                        gameStatus = Status.Won;
                        resultListBox.Items.Add($"Yoy rolled{die1}+{die2}={sumOfDice}:{(DiceNames)sumOfDice}" +
                          $"{Environment.NewLine}");
                        break;
                    default:
                        gameStatus = Status.Continue;
                        myPoint = sumOfDice;
                        pointLabel.Text = $"Point is {myPoint}:{(DiceNames)myPoint}";
                        //Set the button txt to "Continue Game"
                        rollButton.Text = "&Continue Game";
                        break;
                }
            }//Switch
            else if (gameStatus == Status.Continue)
            {

                sumOfDice = rollDiceInstance.RollDice(out die1, out die2); //user rolls again. Display it in the label.
                die1Label.Text = die1.ToString();
                die2Label.Text = die2.ToString();
                resultListBox.Items.Add($"Sum of Dice is {sumOfDice} : {(DiceNames)sumOfDice}{Environment.NewLine}");

                //check game myPoint roll

                if (sumOfDice == myPoint)
                {
                    //user wins by "making a point"
                    gameStatus = Status.Won;
                }
                else if (sumOfDice == 7)
                {
                    //loses by rolling 7
                    gameStatus = Status.Lost;
                }//end if/else if
            }
            else
            {
                MessageBox.Show("Game over!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rollButton.Enabled = false;
            }//end start status check


            //check game status
            if (gameStatus == Status.Won)
            {
                resultListBox.Items.Add("You Won!");
                rollButton.Enabled = false;
            }
            else if (gameStatus == Status.Lost)
            {
                resultListBox.Items.Add("You Lose");
                rollButton.Enabled = false;

            }//end if/else




        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            gameStatus = Status.Start;
            die1Label.Text = "";
            die2Label.Text = "";
            myPoint = 0;
            rollButton.Enabled = true;
            resultListBox.Items.Clear();
            pointLabel.Text = "";

        }// end restart
    }//end form class
}//end namespace

