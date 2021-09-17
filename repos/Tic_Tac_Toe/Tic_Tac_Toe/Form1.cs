using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        bool turn = true; // true is X , false O turn 
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) // created with a double click on button
        {
            MessageBox.Show("Tic Tac Toe by Liene Reiburna-Gibsone");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // built in method 
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender; // cast(convert) the sender obj into button obj
            if (turn) // if turn is true
                button.Text = "X";
            else
                button.Text = "O";

            turn = !turn; // switch the turns between X and O
            button.Enabled = false; // disable button after its clicked
            turnCount++; // count the turns made

            CheckWinner();  // check if there is a winner
        }

        private void CheckWinner()
        {

            bool winnerFound = false; 


            // rows A B C and columns 1,2,3 

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
                DisableButton(); // once winner found all buttons disabled

                String winnerName = "";
                if (turn)
                    winnerName = "O";
                else
                    winnerName = "X";

                MessageBox.Show("Player " + winnerName + " wins", "Game Over!");
            } 
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("It's a DRAW!", "Game Over");
            }
        }

        private void DisableButton()
        {
            try
            {
                foreach (Control c in Controls) // turn a generic Control obj into a Button obj
                {

                    Button button = (Button)c; // downcasting 
                    button.Enabled = false;
                }
            }
            catch { } // try catch to avoid casting error c to button
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true; // reset to first turn which is always X 
            turnCount = 0;  //reset the turncount to 0

            // reset all buttons
            try  
            {
                foreach (Control c in Controls) 
                {

                    Button button = (Button)c; // casting 
                    button.Enabled = true;
                    button.Text = "";
                }
            }
            catch { }

        }

        private void ButtonEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender; // cast sender into button obj
            if (button.Enabled)
            {
                if (turn)
                    button.Text = "X";
                else
                    button.Text = "O";
            }

        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender; // cast sender into button obj
            if (button.Enabled)
            {
                button.Text = "";
            }
        }
    }
}
