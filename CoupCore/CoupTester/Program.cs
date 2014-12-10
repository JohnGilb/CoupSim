using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoupCore;

namespace CoupTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the board!
            GameBoard board = new GameBoard();

            // Create a mapping of AIs to players
            var roster = new Dictionary<ICoupRobot, CoupPlayer>();
            roster.Add(new ExampleRobot(), new CoupPlayer());

            //Add a few players!
            foreach (CoupPlayer p in roster.Values)
            {                
                board.AddPlayer(p);
            }

            GameRunner runner = new GameRunner(board);
        }
    }
}
