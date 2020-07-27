using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TomsDataOnionSolutions.Tests
{
    [TestClass()]
    public class DisplayHelperTests
    {
        private DisplayHelper dh = new DisplayHelper();
        [TestMethod()]
        public void ChangeToBinaryTest()
        {
            string source = "Das ist ein Test!";
            IList<string> expected = new List<string>() { "01000100", "01100001", "01110011", "00100000", "01101001", "01110011", "01110100", "00100000", "01100101", "01101001", "01101110", "00100000", "01010100", "01100101", "01110011", "01110100", "00100001" };
            IList<string> result = DisplayHelper.ChangeToBinary(source);
            CollectionAssert.AreEqual((List<string>) expected, (List<string>) result);

            string source2 = "Das ist ein\nTest!";
            IList<string> expected2 = new List<string>() { "01000100", "01100001", "01110011", "00100000", "01101001", "01110011", "01110100", "00100000", "01100101", "01101001", "01101110", "\n", "01010100", "01100101", "01110011", "01110100", "00100001" };
            IList<string> result2 = DisplayHelper.ChangeToBinary(source2);
            CollectionAssert.AreEqual((List<string>)expected2, (List<string>)result2);
        }
    }
}