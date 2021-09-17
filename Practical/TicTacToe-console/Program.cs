using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace TicTacToe
{
    class Program
    {
        static int[] gameBoard = new int[9];
        static void Main(string[] args)
        {
            //initialize the board   
            for (int i = 0; i < 9; i++)
            {
                gameBoard[i] = 0;
            }

            int userGameTurn = -1;
            int compGameTurn = -1;
            Random randomNum = new Random();

            while (checkWinner() == 0)
            {
                // don't allow human to choose already occupied spot
                while (userGameTurn == -1 || gameBoard[userGameTurn] != 0)
                {
                    Console.WriteLine("Please enter a number from 0 to 8");
                    userGameTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine("You typed " + userGameTurn);
                }


                gameBoard[userGameTurn] = 1;

                //don't let the computer pick already occupied spot
                while (compGameTurn == -1 || gameBoard[compGameTurn] != 0)
                {
                    compGameTurn = randomNum.Next(8); // pick a random num 0-8

                    Console.WriteLine("Computer chose " + compGameTurn);
                }
                gameBoard[compGameTurn] = 2;

                printGameBoard();


            }
            Console.WriteLine("Player " + checkWinner() + " won the game");


        }

        private static int checkWinner()
        {
            //return a 0 if nobody won.  return player num if they won 
            // top row
            if (gameBoard[0] == gameBoard[1] && gameBoard[1] == gameBoard[2])
            {
                return gameBoard[0];
            }
            // second row
            if (gameBoard[3] == gameBoard[4] && gameBoard[4] == gameBoard[5])
            {
                return gameBoard[3];
            }
            // third row 
            if (gameBoard[6] == gameBoard[7] && gameBoard[7] == gameBoard[8])
            {
                return gameBoard[6];
            }
            // first  column 
            if (gameBoard[0] == gameBoard[3] && gameBoard[3] == gameBoard[6])
            {
                return gameBoard[0];
            }

            // second  column 
            if (gameBoard[1] == gameBoard[4] && gameBoard[4] == gameBoard[7])
            {
                return gameBoard[1];
            }

            // third  column 
            if (gameBoard[2] == gameBoard[5] && gameBoard[5] == gameBoard[8])
            {
                return gameBoard[2];
            }
            // first  diagonal 
            if (gameBoard[0] == gameBoard[4] && gameBoard[4] == gameBoard[8])
            {
                return gameBoard[0];
            }
            // second  diagonal 
            if (gameBoard[2] == gameBoard[4] && gameBoard[4] == gameBoard[6])
            {
                return gameBoard[2];
            }

            return 0;
        }
        private static void printGameBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                //Console.WriteLine("Square " + i + " contains " + gameBoard[i]);

                //print X or O for each square
                // O means occupied, 1 means player 1(x) 2 means player (O)

                if (gameBoard[i] == 0)
                {
                    Console.Write(".");
                }
                if (gameBoard[i] == 1)
                {
                    Console.Write("X");
                }
                if (gameBoard[i] == 2)
                {
                    Console.Write("O");
                }
                //print a new line every 3d char
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
            }


        }
    }
}