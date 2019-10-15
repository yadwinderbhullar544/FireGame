using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FireGameUnitTest
{
    [TestClass]
    public class UnitTest1     //below code for test method
    {


        [TestMethod]
        public void TestMethod1()
        {
            FireGame.FireGameClass FGClass = new FireGame.FireGameClass();
            //test code for fire button
            int result = FGClass.FireLogic();

            Assert.IsTrue(result < 5);

        }



        [TestMethod]
        public void TestMethod2()
        {
            FireGame.FireGameClass FGClassaway = new FireGame.FireGameClass();
            //test code for fire away
            int result = FGClassaway.FireAwayLogic();

            Assert.IsTrue(result < 4);

        }
    }
}
