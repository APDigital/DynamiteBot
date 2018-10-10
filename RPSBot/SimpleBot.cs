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
        public int DynamiteCount { get; set; }
        public Move MakeMove(Gamestate gamestate)
        {
            int random = GenerateRandomNumber(1, 4);
            Move move = Move.S;

            if (CanPlayDynamite(gamestate) == true && random == 4)
            {
                move = Move.D;
            }

            switch (random)
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

        private bool CanPlayDynamite(Gamestate gamestate)
        {
            foreach (Round round in gamestate.GetRounds())
            {
                if (round.GetP1() == Move.D)
                {
                    DynamiteCount++;
                }
            }

            if (DynamiteCount < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GenerateRandomNumber(int fromInt, int toInt)
        {
            Random random = new Random();
            int randomnumber = random.Next(fromInt, toInt);
            return randomnumber;
        }
    }
}
