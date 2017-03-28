using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_To_List()
        {
            //Arrange
            customList<int> list = new customList<int>();
            int expectedLength = 1;
            //Act
            list.Add(15);
            //Assert
            Assert.AreEqual(list.Count, expectedLength);
        }

        [TestMethod]
        public void Remove_From_List()
        {
            //Arrange
            customList<int> list = new customList<int>() { 3, 4 };
            int expectedLength = 1;
            //Act
            list.Remove(3);
            //Assert
            Assert.AreEqual(expectedLength, list.Count);
        }

        [TestMethod]
        public void Iterate()
        {
            //Arrange
            customList<int> list = new customList<int>();
            //Act
            for (int i = 0; i < 2; i++)
            {
                list.Add(i);
            }
            //Assert
            Assert.AreEqual(2, list.Count);

        }

        [TestMethod]
        public void ToString()
        {
            //Arrange
            customList<int> list = new customList<int>();
            //Act
            for (int i = 0; i < 2; i++)
            {
                list.Add(i);
            }
            var strings = list.ToString();
            //Assert
            Assert.AreEqual("0, 1, 0, 0, 0", strings);
        }

        [TestMethod]
        public void OverloadPlus()
        {
            //Arrange
            customList<int> list1 = new customList<int>() { 1, 2 };
            customList<int> list2 = new customList<int>() { 3, 4 };
            customList<int> test = new customList<int>() { 1, 2, 3, 4 };
            //Act
            var addedLists = list1 + list2;
            //Assert
            Assert.AreEqual(addedLists[3], test[3]);
        }

        [TestMethod]
        public void OverloadMinus()
        {
            //Arrange
            customList<int> list1 = new customList<int>() { 1, 2, 5, 3, 4 };
            customList<int> list2 = new customList<int>() { 5, 5, 5, 5, 5 };
            //Act
            var subtractedLists = list1 - list2;
            //Assert
            Assert.AreNotEqual(subtractedLists[2], 5);
        }

        [TestMethod]
        public void Zip()
        {
            //Arrange
            customList<int> list1 = new customList<int>();
            customList<int> list2 = new customList<int>();
            customList<int> test = new customList<int>() { 1, 2, 3, 4, 5 };
            //Act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            var zippedList = list1.Zip(list2);
            //Assert
            Assert.AreEqual(zippedList[0], test[0]);
            Assert.AreEqual(zippedList[1], test[1]);
            Assert.AreEqual(zippedList[2], test[2]);
            Assert.AreEqual(zippedList[3], test[3]);
            Assert.AreEqual(zippedList[4], test[4]);
        }
    }
}

