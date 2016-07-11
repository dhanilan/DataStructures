using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructureTest
{
    [TestClass]
    public class TestDoublyLinkedList
    {
        [TestMethod]
        public void SimpleTest()
        {

            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.Insert(5);
            list.Insert(6);
            list.Insert(8);
            list.Insert(1);
            list.Insert(67);
            list.Insert(89);

            Assert.AreEqual(list.Find(8).Value, 8);
            Assert.AreEqual(list.Find(8).Previous.Value, 6);
            Assert.AreEqual(list.Find(8).Next.Value, 1);


            Assert.AreEqual(list.Remove(89), true);
            Assert.AreEqual(list.Find(89), null);

            Assert.AreEqual(list.Find(77), null);
            Assert.AreEqual(list.Remove(77), false);



        }
    }
}
