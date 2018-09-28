using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotInterface.Bot;
using BotInterface.Game;

namespace RPSBot
{
    public class SimpleBot : IBot
    {
        public Move MakeMove(Gamestate gamestate)
        {
            Random random = new Random();
            int randomnumber = random.Next(0, 3);

            Move move = Move.S;
            switch (randomnumber)
                {
                    case 1:
                       move = Move.R;
                        break;
                    case 2:
                        move = Move.P;
                        break;
                    default:
                        move = Move.S;
                        break;
                }
            
            return move;
        }
    }
}
