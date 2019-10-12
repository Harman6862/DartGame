using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GhostBowling.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void BowlTest()
        {
            Player player = new Player();

            Boolean ballPosition = player.SetTheBall(6);
            Boolean luckValue = player.TryLuck(-1);
            player.Bowl();
            Assert.IsTrue(ballPosition == false, "Random number not between 0 - 5");
            Assert.IsTrue(luckValue == false, "Random number not between 0 - 5");
        }
    }
}