using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class PlayerRollDies
    {
        public static void snake()
        {
            int position = 0;
            Console.WriteLine("Player is at position : " + position);

            // Roll dies get number between 1 - 6
            Random random = new Random();
            int droll = 0;
            while (true)
            {
                droll = random.Next(7);
                if (droll != 0) break;

            }
            Console.WriteLine(droll);
        }
    }
}
