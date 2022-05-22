using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonage_test
{
    public class Piece
    {
        public static string direction = "N";
        public Dictionary<string, string> position = new Dictionary<string, string>()
        {
            {"coordX", "0" },
            {"coordY", "0" },
            {"direction", "N" }
        };
        public Piece()
        {
          
        }
    }
}
