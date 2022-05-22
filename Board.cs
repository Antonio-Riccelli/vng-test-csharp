using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonage_test
{
    public class Board
    {
        private string[,] board;
        public const int DIMENSION = 5; // 5x5 board


        private Command command;

        public Board()
        {
            command = new Command();
            board = new string[DIMENSION, DIMENSION];
        }

        public string movePiece() 
        {
            string newCoordinates = "";
            return newCoordinates;
        }

    }
}
