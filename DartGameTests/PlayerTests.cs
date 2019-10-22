using Microsoft.VisualStudio.TestTools.UnitTesting;
using DartGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void ThrowDartTest()
        {
            Player player = new Player();

            Boolean boardPosition = player.SetBoard(6);
            Boolean dartPosition = player.SetDart(-1);
            player.ThrowDart();
            Assert.IsTrue(boardPosition == false, "Random number not between 0 - 5");
            Assert.IsTrue(dartPosition == false, "Random number not between 0 - 5");
        }
    }
}