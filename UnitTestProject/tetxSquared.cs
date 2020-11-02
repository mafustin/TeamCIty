using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Pood.TeamCity.Test
{
    [TestClass]
    public class testSquaredDouble
    {
        [TestMethod]
        public void SquaredReturns4forArguments2()
        {
            Assert.AreEqual(4, MyMath.Squared(2.0));
        }
        public void SquaredReturns0forArguments0()
        {
            Assert.AreEqual(0, MyMath.Squared(0.0));
        }
        public void SquaredReturns4forArgumentMinus2()
        {
            Assert.AreEqual(4, MyMath.Squared(-2.0));
        }

        public class TestSquaredInt
        {
            public void SquaredReturns4forArguments2()
            {
                Assert.AreEqual(4, MyMath.Squared(2));
            }
            public void SquaredReturns0forArguments0()
            {
                Assert.AreEqual(0, MyMath.Squared(0));
            }
            public void SquaredReturns4forArgumentMinus2()
            {
                Assert.AreEqual(4, MyMath.Squared(-2));
            }
        }
        
    }
}
