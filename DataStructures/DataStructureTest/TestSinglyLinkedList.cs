using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;
namespace DataStructureTest
{
    [TestClass]
    public class TestSinglyLinkedList
    {
        [TestMethod]
        public void SimpleTestCase()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.Insert(5);
            list.Insert(6);
            list.Insert(8);
            list.Insert(1);
            list.Insert(67);
            list.Insert(89);

            Assert.AreEqual(list.Find(89), true);
            

            Assert.AreEqual(list.Remove(89), true);
            Assert.AreEqual(list.Find(89), false);

            Assert.AreEqual(list.Find(77), false);
            Assert.AreEqual(list.Remove(77), false);
        }


        [TestMethod]
        public void TestSortedLinkedList()
        {
            SortedLinkedList<int> list = new SortedLinkedList<int>();
            list.Insert(999);
            list.Insert(5);
            list.Insert(6);
            list.Insert(8);
            list.Insert(1);
            list.Insert(67);
            list.Insert(89);
            list.Insert(99);

            Assert.AreEqual(list.Find(89), 6);


            Assert.AreEqual(list.Remove(89), true);
            Assert.AreEqual(list.Find(89), 0);

            Assert.AreEqual(list.Find(77), 0);
            Assert.AreEqual(list.Remove(77), false);
        }
    }
}
