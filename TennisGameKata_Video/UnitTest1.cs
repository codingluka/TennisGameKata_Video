﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameKata_Video
{
    [TestClass]
    public class TennisGameTests
    {
        private TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void love_all()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        private void ScoreShouldBe(string expected)
        {
            string score = tennisGame.Score();
            Assert.AreEqual(expected, score);
        }
    }
}