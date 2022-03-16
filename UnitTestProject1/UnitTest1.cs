using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab1dotNet;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Item_test_count()
        {
            Generator g = new Generator(10, 10);

            var result = g.items.Count;

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Backpack_test_count()
        {
            Backpack b = new Backpack();
            Generator g = new Generator(10, 10);

            for(int i = 0; i < 10; i++)
            {
                b.AddItem(g.items[i]);
            }
            var result = b.contents.Count;

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void Test3()
        {
            int itemValue = 10;
            int itemWeight = 10;
            Item item = new Item(itemValue, itemWeight);
            var result1 = item.Value;
            var result2 = item.Weight;
            
            Assert.AreEqual(itemValue, result1);
            Assert.AreEqual(itemWeight, result2);
            Assert.IsTrue(result1 == result2);
        }





    }
}
