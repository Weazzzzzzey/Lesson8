using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStruct;

namespace BookStruct.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ArLocalIDgrazinaTaiKaTuriGrazint()
        {
            //Arange
            Book knyga = new Book();
            knyga.Name = "Black-Hawk";
            knyga.ID = "0001";
            //act
            string result = knyga.LocalID;
            //Asset
            Assert.AreEqual(result, "Black-Hawk_0001");
        }

        [TestMethod]
        public void ArLocalIDgrazinaTusciaID()
        {
            //Arange
            Book knyga = new Book();
            knyga.Name = "";
            knyga.ID = "0001";
            //act
            string result = knyga.LocalID;
            //Asset
            Assert.AreEqual(result, "_0001");
        }

        [TestMethod]
        public void ArLocalIDgrazina1000()
        {
            //Arange
            Book knyga = new Book();
            knyga.Name = "Black-Hawk";
            knyga.ID = "";
            //act
            string result = knyga.LocalID;
            //Asset
            Assert.AreEqual(result, "Black-Hawk_1000");
        }
    }
}
