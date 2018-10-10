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
        public bool TestValue { get; set; }
        public Move MakeMove(Gamestate gamestate)
        {
            int random = 0;
            if (TestValue == false)
            {
                random = GenerateRandomNumber(1, 5);
            }
            else
            {
                random = 4;
            }

            Move move = Move.S;
            Round round = new Round();

            switch (random)
            {
                case 1:
                    move = Move.R;
                    round.SetP1(move);
                    break;
                case 2:
                    move = Move.P;
                    round.SetP1(move);
                    break;
                case 3:
                    move = Move.S;
                    round.SetP1(move);
                    break;
                case 4:
                    move = PlayDynamite(round);
                    round.SetP1(move);
                    break;
                case 5:
                    move = PlayDynamite(round);
                    round.SetP1(move);
                    break;
                default:
                    move = Move.P;
                    round.SetP1(move);
                    break;
            }

            return move;
        }

        public bool GetTestValue(bool value)
        {
            TestValue = value;
            return TestValue;
        }
        public Move PlayDynamite(Round round)
        {
            Move move = Move.D;
            if (CanPlayDynamite() == true)
            {
                DynamiteCount++;
            }
            else
            {
                move = Move.W;
            }
            return move;
        }

        private bool CanPlayDynamite()
        {
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
