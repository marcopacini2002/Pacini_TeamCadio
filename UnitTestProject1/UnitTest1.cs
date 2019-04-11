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

        //3 UOMO TEST

        [TestMethod]
        [DataTestMethod]
        [DataRow(30, 90, 190, 25, 530)]
        [DataRow(0, 0, 0, 0, 0)]
        [DataRow(-30, -90, -165, -30, 0)]

        public void TestMethodCalorieBruciateUomo(int età, double peso, double frequenza, double durata, double CalorieBruciate)
        {
            double risposta_attesa = CalorieBruciate;
            double risposta=Cardio_pacini.Class1.CalorieBruciateUomo(età, peso, frequenza, durata);
            Assert.AreEqual(risposta_attesa, risposta);
        }

        //3 DONNA TEST
        [TestMethod]
        [DataTestMethod]
        [DataRow(30, 90, 190, 25, 467)]
        [DataRow(0, 0, 0, 0, 0)]
        [DataRow(-30, -90, -165, -30, 0)]

        public void TestMethodCalorieBruciateDonna(int età, double peso, double frequenza, double durata, double CalorieBruciate)
        {
            double risposta_attesa = CalorieBruciate;
            double risposta = Cardio_pacini.Class1.CalorieBruciateDonna(età, peso, frequenza, durata);
            Assert.AreEqual(risposta_attesa, risposta);
        }

        //4 CORSA
        [TestMethod]
        [DataTestMethod]
        [DataRow(30,80,2160)]
        [DataRow(0, 0, 0)]
        [DataRow(-30, -80, 0)]

        public void TestMethodSpesaEnergeticaCorsa(int km, int peso, double risposta_at)
        {
            double risposta_attesa = risposta_at;
            double risposta = Cardio_pacini.Class1.SpesaEnergeticaCorsa(km,peso);
            Assert.AreEqual(risposta_attesa, risposta);
        }


        //4 CAMMINATA
        [TestMethod]
        [DataTestMethod]
        [DataRow(30, 80, 1200)]
        [DataRow(0, 0, 0)]
        [DataRow(-30, -80, 0)]

        public void TestMethodSpesaEnergeticaCamminata(int km, int peso, double risposta_at)
        {
            double risposta_attesa = risposta_at;
            double risposta = Cardio_pacini.Class1.SpesaEnergeticaCamminata(km, peso);
            Assert.AreEqual(risposta_attesa, risposta);
        }
    }
}
