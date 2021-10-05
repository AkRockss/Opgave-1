using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootBall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall.Tests
{
    [TestClass()]
    public class FootBallPlayerTests
    {
        private FootBallPlayer badFootBallPlayer = new FootBallPlayer(22, "Ib", -22.22, shirtnumber: 22);

       [TestMethod()]
        public void TestConstructor()
        {
            FootBallPlayer badFootBallPlayer2 = new FootBallPlayer(22, "Ib", -22.22, 1);

            Assert.AreEqual(22, badFootBallPlayer2.Id);
            Assert.AreEqual("Ib", badFootBallPlayer2.Name);
            Assert.AreEqual(-22.22, badFootBallPlayer2.Price);
            Assert.AreEqual(1, badFootBallPlayer2.ShirtNumber);
        }


        [TestMethod()]
        public void TestId()
        {
           
            badFootBallPlayer.Id = 2;
            Assert.AreEqual(2, badFootBallPlayer.Id);

            

        }

        [TestMethod()]
        public void TestName()
        {
            badFootBallPlayer.Name = "Aleksander";
            Assert.AreEqual("Aleksander", badFootBallPlayer.Name);

            Assert.ThrowsException<ArgumentException>(() => badFootBallPlayer.Name = "Bo");

        }

        [TestMethod()]
        public void TestPrice()
        {
            badFootBallPlayer.Price = 22.22;
            Assert.AreEqual(22.22, badFootBallPlayer.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => badFootBallPlayer.Price = 0);
        }

        [TestMethod()]
        public void TestShirtNumber()
        {

            badFootBallPlayer.ShirtNumber = 22;
            Assert.AreEqual(22, badFootBallPlayer.ShirtNumber);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => badFootBallPlayer.ShirtNumber = -222);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => badFootBallPlayer.ShirtNumber = 222);

        }


    }       
}
