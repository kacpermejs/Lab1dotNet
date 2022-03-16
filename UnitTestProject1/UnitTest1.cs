using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab1dotNet;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Item_tet()
        {
            Generator g = new Generator(10, 10);

            var result = g.items.Count;

            Assert.AreEqual(10, result);
        }





    }
}
