using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //commit: Ho aggiunto ilprogetto Unit Test
        [DataTestMethod]
        [DataRow(20, 200,100)]
        [DataRow(21, 100,50)]

        public void TestMethod1(int eta,int massimo,double minimo)
        {
            int min = 0;
            double max=Cardio_pacini.Class1.FrequenzaCardiaca(eta, ref minimo);
            Assert.AreEqual(massimo, max);
            Assert.AreEqual(minimo, min);
        }
    }
}
