using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NamuDarbaiIkiSestadienio;

namespace MedisTest
{
    [TestClass]
    public class UnitTest1
    {
        Miskas m1 = new Miskas("Obeliu MIskas");
        public void Pasiruosimas()
        {
            m1.PasodintiMedi();
            m1.PasodintiMedi();
            m1.PasodintiMedi();
            m1.PasodintiMedi();
        }


        [TestMethod]
        public void TaskTuretuButSiektiekDaugiaunei40000()
        {
            //Arange
            Pasiruosimas();
            //act
            int result = m1.Medis;
            //Asset
            Assert.AreEqual(result, 4);
        }

    }
}
