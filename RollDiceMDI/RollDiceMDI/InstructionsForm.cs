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
    //Created by Nimmala
    //4444444444444444444
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void InstructionsForm_Load(object sender, EventArgs e)
        {
            //Shows the rules
            string lineBreak=Environment.NewLine;
            instructionsLabel.Text = $"Players bet on the outcomes of a pair of dice. {lineBreak}" +
                $"Player wins or loses in one of two ways:{lineBreak}" +
          $"On the initial dice throw: if the player's 'come -out roll' i.e., the first roll is 7 or 11, the bet wins. " +
          $"{lineBreak}" +
          $"On the otherhand if the come -out roll is 2, 3 or 12, the bet loses(known as \"crapping out\"). {lineBreak}" +
          $"If the outcome of the come-out roll is NOT 7 or 11 (winning bets), or 2, 3, or 12 (losing bets), " +
          $"that establishes a point(i.e., a target for the next roll).{lineBreak}" +
          $"The second way of winning a bet for a player is to roll the target point by rolling the dice again.{lineBreak}" +
          $"Whatever the target point may be, if on the second and subsequent rolls," +
          $" if the player rolls 7, the player loses(known as \"seven out\").{lineBreak}" +
          $"This version of the game you can bet any number of times till you will or lose.";


        }

        private void closeButtonInstructions_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
