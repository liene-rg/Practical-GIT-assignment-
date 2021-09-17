using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form


    {

        bool playerTurn = true; // true means X player plays, false means Y
        int countTurns = 0; // count how many turns played
        public Form1()
        {
            InitializeComponent(); // automatically generated metod
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe game, .NET final project. By Liene Reiburna-Gibsone");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender; // cast the sender object into a button obj
            if (playerTurn)
                button.Text = "X"; // if true then write X into the box // button object add built in method Text
            else
                button.Text = "O"; // else O in the box

            playerTurn = !playerTurn; // flip the turn between players
            button.Enabled = false; // disable the button once it is clicked

            countTurns++;

            CheckWinner();
        }

        private void CheckWinner()
        {
            bool winnerFound= false; // turn to true when winner found

            // check if buttons equal HORIZONTALLY
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) // (!A1.Enabled) if this is clicked then can check if all clicked and find winner 
                winnerFound = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winnerFound = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winnerFound = true;

            // check if buttons equal VERTICALLY
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winnerFound = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winnerFound = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winnerFound = true;

            // check if buttons equal DIAGONALLY
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winnerFound = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                winnerFound = true;



            if (winnerFound)
            {
                DisableButtons(); // if there is a winner disable all buttons

                String winner = "";
                if (playerTurn)

                    winner = "O";
                else

                    winner = "X";

                MessageBox.Show("Player " + winner + " wins", "Game Over!");
            }


            else
            {
                if (countTurns == 9) // if there are 9 moves and no winner, it's a draw 
                
                MessageBox.Show("Draw!", "Game Over!");
            }

        }

        private void DisableButtons() // disable buttons so the game stops
        {
            try
            {
                foreach (Control c in Controls) // turn a generic Control obj into a Button obj
                {

                    Button button = (Button)c; // casting 
                    button.Enabled = false;
                }
            }
            catch { } // try catch to avoid casting error c to button
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) // reset game/ generated from windows form,new game double click
        {
            playerTurn = true;
            countTurns = 0;

            //loop over all buttons
            foreach (Control c in Controls) // turn a generic Control obj into a Button obj
            {
                try
                {
                    Button button = (Button)c; // casting 
                    button.Enabled = true;
                    button.Text = "";
                }
                catch { }
            }


        }

        private void ButtonEnter(object sender, EventArgs e) //when hover mouse over the buttons
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                if (playerTurn)

                    button.Text = "X";
                else
                    button.Text = "O";
            }


        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.Text = ""; // once mouse removed the button is back to blank if not enabled
            }
        }

        
    }
}
