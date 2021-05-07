using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataStructure;

namespace UnitTestDataStructure
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow(30, true)]
        [DataRow(45, false)]
        public void Search_PassANodeValue_ReturnTrueOrFalse(int data, bool flag)
        {
            LinkedList list = new LinkedList();
            list.InsertFront(56);
            list.InsertFront(30);
            list.InsertFront(70);
            bool flagReturned = list.Search(data);
            Assert.AreEqual(flag, flagReturned);
        }
        [TestMethod] /*TC9*/
        [DataRow(70)]
        public void DeletingSpecificElementFromList(int data)
        {
            list.DeleteElement(data);
            int expected = 0;
            int actual = list.Search(70);
            Assert.AreEqual(expected, actual);
        }
    }
}
