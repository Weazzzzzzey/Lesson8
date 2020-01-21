using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KlasesDarbas;
using System.Collections.Generic;

namespace KlasesDarbasTestU
{
    [TestClass]
    public class KlasesDarbasTestU
    {

        //SarasoAprasymas
        List<int> pirmas = new List<int>();
        List<int> antras = new List<int>();
        List<int> trecias = new List<int>();

        public void uzpildymas()
        {
            pirmas.Add(10);
            pirmas.Add(10);
            pirmas.Add(10);
            antras.Add(5);
            antras.Add(5);
            antras.Add(5);
            trecias.Add(6);
            trecias.Add(6);
            trecias.Add(6);
        }



        [TestMethod]
        public void ArGeraiAtspausdinsPirmoTrimestoVidurki()
        {
            //SarasoAprasymas
            uzpildymas();

            //Arange
            Mokinys Tomas = new Mokinys(pirmas, antras, trecias);
            //act
            double result = Tomas.pirmoTrimestoVidurkis();
            //Asset
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void ArGeraiAtspausdinsAntroTrimestoVidurki()
        {
            //SarasoAprasymas
            uzpildymas();

            //Arange
            Mokinys Tomas = new Mokinys(pirmas, antras, trecias);
            //act
            double result = Tomas.antroTrimestoVidurkis();
            //Asset
            Assert.AreEqual(result, 5);
        }
        [TestMethod]
        public void ArGeraiAtspausdinsTrecioTrimestoVidurki()
        {
            //SarasoAprasymas
            uzpildymas();

            //Arange
            Mokinys Tomas = new Mokinys(pirmas, antras, trecias);
            //act
            double result = Tomas.trecioTrimestoVidurkis();
            //Asset
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void ArGeraiAtspausdinsMetiniVidurki()
        {
            //SarasoAprasymas
            uzpildymas();

            //Arange
            Mokinys Tomas = new Mokinys(pirmas, antras, trecias);
            //act
            double result = Tomas.metinisPazimys();
            //Asset
            Assert.AreEqual(result, 7);
        }

        [TestMethod]
        public void ArGrazinsNullReiksmia()
        {

            trecias.Clear();
            //Arange
            Mokinys Tomas = new Mokinys(pirmas, antras, trecias);
            //act
            double result = Tomas.trecioTrimestoVidurkis();
            //Asset
            Assert.AreEqual(result, 0);

        }

    }
}
