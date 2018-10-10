using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BotInterface.Bot;
using BotInterface.Game;
using RPSBot;

namespace RPSBotTest
{
    [TestClass]
    public class SimpleBotTest
    {
        Gamestate game = new Gamestate();

        [TestMethod]
        public void BotPlaysRandomMove()
        {
            SimpleBot simplebot = new SimpleBot();
            int random = simplebot.GenerateRandomNumber(0, 5);

            Assert.AreNotEqual(random, 6);
        }

        [TestMethod]
        public void BotPlaysLessThan100Dynamites()
        {
            SimpleBot simplebot = new SimpleBot();


            bool fail = true;
            for (int i = 0; i < 1000; i++)
            {
                simplebot.MakeMove(game);
            }
            if (simplebot.DynamiteCount > 100)
            {
                fail = true;
            }
            else
            {
                fail = false;
            }
            Assert.IsFalse(fail);
        }
    }
}
