using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalmeND;

namespace PalmeND.test
{
    [TestClass]
    public class UnitTest1
    {
        Palme p1 = new Palme(0,0);
        public void pasirengimas()
        {
            p1.PridetiVienaMenesiAmziaus();
            p1.PridetiVienaMenesiAmziaus();
            p1.PridetiVienaMenesiAmziaus();
            p1.PridetiVienaMenesiAmziaus();
            p1.PridetiVienaMenesiAmziaus();
            p1.PridetiVienaMenesiAmziaus();
        }
        
        
        [TestMethod]
        public void PridetiVienaMenesiAmziaus()
        {
            //Arange
            //sukurtas objektas p1
            //act
            int result = p1.PridetiVienaMenesiAmziaus();
            //Asset
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void GautiNuliVaisiuKieki()
        {
            //Arange
            //sukurtas objektas p1
            //act
            int result = p1.Vaisiai;
            //Asset
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Gauti18Vaisiu()
        {
            //Arange
            //sukurtas objektas p1
            pasirengimas();
            //act
            int result = p1.Vaisiai;
            //Asset
            Assert.AreEqual(result, 18);
        }

        [TestMethod]
        public void Gauti36Vaisiu()
        {
            //Arange
            //sukurtas objektas p1
            pasirengimas();
            pasirengimas();
            //act
            int result = p1.Vaisiai;
            //Asset
            Assert.AreEqual(result, 36);
        }

        [TestMethod]
        public void Gauti0VaisiuPoDaugiauNei12Men()
        {
            //Arange
            //sukurtas objektas p1
            pasirengimas();
            pasirengimas();
            p1.PridetiVienaMenesiAmziaus();
            //act
            int result = p1.Vaisiai;
            //Asset
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Gauti0VaisiuPo4Men()
        {
            //Arange
            //sukurtas objektas p1
            p1.PridetiVienaMenesiAmziaus();
            p1.PridetiVienaMenesiAmziaus();
            p1.PridetiVienaMenesiAmziaus();
            p1.PridetiVienaMenesiAmziaus();
            //act
            int result = p1.Vaisiai;
            //Asset
            Assert.AreEqual(result, 0);
        }

    }
}
