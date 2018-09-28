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
            Enum move1 = simplebot.MakeMove(game);
            Enum move2 = simplebot.MakeMove(game);

            Assert.AreNotEqual(move1, move2);
        }
    }
}
