using System;
using System.Collections.Generic;
using System.Text;
using BotInterface.Bot;
using BotInterface.Game;

namespace RPSBot
{
    class SimpleBot : IBot
    {
        public Move MakeMove(Gamestate gamestate)
        {
            return Move.R;
        }
    }
}
