using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestSorting
{
    [TestClass]
    public class StringSortTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringToSort.StringToSort stringToSort = new StringToSort.StringToSort();

            int[] asciiArray = stringToSort.GetAsciiArray("Contrary to popular belief, the pink unicorn flies east");

            string strSorted = stringToSort.ArrayToSort(asciiArray, asciiArray.Length, 97, 122);

            Assert.AreEqual(strSorted, "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy");
        }
    }
}
