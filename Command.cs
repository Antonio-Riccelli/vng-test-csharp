using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonage_test
{
    public class Command : Piece
    {
        private int coordX;
        private int coordY;
        private string command;
        private string direction;

        public Command()
        {
            coordX = 0;
            coordY = 0;
            direction = "N";
            Invalid = false;
        }

        public bool Invalid { get; set; }
    }
}
