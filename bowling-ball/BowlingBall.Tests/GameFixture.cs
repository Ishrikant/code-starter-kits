using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();

            Frame frame = new Frame()
            {
                totalFrames = 10,
                listpins = Roll(game, 0, 20)
            };

            Assert.AreEqual(0, game.GetScore(frame));
        }

        private List<int> Roll(Game game, int pins, int times)
        {
            List<int> lstpins = new List<int>();

            for (int i = 0; i < times; i++)
            {
                lstpins.Add(pins);               
            }

            return lstpins;
        }

        [TestMethod]
        public void StandardFlow()
        {
            var game = new Game();

            Frame frame = new Frame()
            {
                totalFrames = 10,
                listpins = new List<int> { 2, 1, 2, 1, 1, 9, 1, 1, 2, 9, 5, 1, 1, 7, 1, 1, 9, 1, 1, 1 }
            };           
            Assert.AreEqual(59, game.GetScore(frame));
        }


        [TestMethod]
        public void HighestPossibleScore()
        {
            var game = new Game();

            Frame frame = new Frame()
            {
                totalFrames = 10,
                listpins = new List<int> { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }
            };
            Assert.AreEqual(300, game.GetScore(frame));
        }

        [TestMethod]
        public void LowestPossibleScore()
        {
            var game = new Game();

            Frame frame = new Frame()
            {
                totalFrames = 10,
                listpins = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            Assert.AreEqual(0, game.GetScore(frame));
        }


        [TestMethod]
        public void IsASpare()
        {

            //A spare is when the player knocks down all 10 pins in two tries. 
            //The bonus for that frame is the number of pins knocked down by the next roll.
            var game = new Game();

            Frame frame = new Frame()
            {
                totalFrames = 10,
                listpins = new List<int> { 6, 4, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            Assert.AreEqual(14, game.GetScore(frame));
        }


        [TestMethod]
        public void IsAStrike()
        {
            // A strike is when the player knocks down all 10 pins on his first try. 
            //The bonus for that frame is the value of the next two balls rolled.
             var game = new Game();

            Frame frame = new Frame()
            {
                totalFrames = 10,
                listpins = new List<int> { 10, 4, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            Assert.AreEqual(22, game.GetScore(frame));
        }

        

        [TestMethod]
        public void LastFrameSpare()
        {
            //In the tenth frame a player who rolls a spare or strike is allowed to roll the extra balls to complete the frame.
            //However no more than three balls can be rolled in tenth frame.
            var game = new Game();

            Frame frame = new Frame()
            {
                totalFrames = 10,
                listpins = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 4, 9 }
            };
            Assert.AreEqual(19, game.GetScore(frame));
        }

        [TestMethod]
        public void LastFrameStrike()
        {
            //In the tenth frame a player who rolls a spare or strike is allowed to roll the extra balls to complete the frame.
            //However no more than three balls can be rolled in tenth frame.
            var game = new Game();

            Frame frame = new Frame()
            {
                totalFrames = 10,
                listpins = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 1 }
            };
            Assert.AreEqual(11, game.GetScore(frame));
        }
    }
}
