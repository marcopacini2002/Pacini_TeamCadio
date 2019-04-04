using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //commit: Ho aggiunto ilprogetto Unit Test
        [DataTestMethod]
        [DataRow(200, 20)]
        [DataRow(215, 5)]

        public void TestMethod1(int y,int eta)
        {
            int fconsigliata=Cardio_pacini.Class1.FrequenzaCardiaca(eta);
            Assert.AreEqual(y, fconsigliata);
        }
    }
}
