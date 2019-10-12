using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ZombieKill.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        public void ThrowKnifeTest()
        {
            Player player = new Player();

            Boolean knifePosition = player.SetKnife(6);
            Boolean luckValue = player.TryLuck(-1);
            player.ThrowKnife();
            Assert.IsTrue(knifePosition == false, "Random number not between 0 - 5");
            Assert.IsTrue(luckValue == false, "Random number not between 0 - 5");
        }
    }
}