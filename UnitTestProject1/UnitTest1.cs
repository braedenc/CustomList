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
            Assert.AreEqual(list.Count ,expectedLength);
        }

        [TestMethod]
        public void Remove_From_List()
        {
            //Arrange
            customList<int> list = new customList<int>() { 3, 4};
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
            int[] numbers;
            //Act
            list.GetEnumerator();
            //Assert
            
        }
    }
}
