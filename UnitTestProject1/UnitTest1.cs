using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //commit: Ho aggiunto ilprogetto Unit Test
        [DataTestMethod]
        [DataRow(20, 180,140)]
        [DataRow(-20,0,0)]
        [DataRow(0,0,0)]

        public void TestMethod1(int eta,int massimo,double minimo)
        {
            double min = 0;
            double max=Cardio_pacini.Class1.FrequenzaCardiaca(eta,ref min);
            Assert.AreEqual(massimo, max);
            Assert.AreEqual(minimo, min);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(20, 72, 180, 15, 275)]
        [DataRow(0, 0, 0, 0, 0)]
        [DataRow(-20, -78, -170, -15, 0)]

        public void TestMethodCalorieBruciateUomo(int età, double peso, double frequenza, double durata, double CalorieBruciate)
        {
            double risposta_attesa = CalorieBruciate;
            double risposta=Cardio_pacini.Class1.CalorieBruciateUomo(età, peso, frequenza, durata);
            Assert.AreEqual(risposta_attesa, risposta);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(20, 72, 180, 15, 253)]
        [DataRow(0, 0, 0, 0, 0)]
        [DataRow(-20, -78, -170, -15, 0)]

        public void TestMethodCalorieBruciateDonna(int età, double peso, double frequenza, double durata, double CalorieBruciate)
        {
            double risposta_attesa = CalorieBruciate;
            double risposta = Cardio_pacini.Class1.CalorieBruciateDonna(età, peso, frequenza, durata);
            Assert.AreEqual(risposta_attesa, risposta);
        }
    }
}
