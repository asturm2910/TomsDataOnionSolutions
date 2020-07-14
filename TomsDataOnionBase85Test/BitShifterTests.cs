using Microsoft.VisualStudio.TestTools.UnitTesting;
using TomsDataOnionSolutions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TomsDataOnionSolutions.Tests
{
    [TestClass()]
    public class BitShifterTests
    {

        private BitShifter bs = new BitShifter();

        [TestMethod()]
        public void flipTest()
        {
            //1100 0111
            int baseLine = 199;
            //1001 0010
            int expectedResult = 146;

            int result = bs.flip(baseLine);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void flipTestMaxExample()
        {
            //1011 0100
            int baseLine = 180;
            //1110 0001
            int expectedResult = 225;

            int result = bs.flip(baseLine);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void flipTestExtremeZero()
        {
            //0000 0000
            int baseLine = 0;
            //01010101
            int expectedResult = 85;

            int result = bs.flip(baseLine);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void flipTestExtremeOne()
        {
            //1111 1111
            int baseLine = 255;
            //10101010
            int expectedResult = 170;

            int result = bs.flip(baseLine);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void processTest()
        {
            //11100001
            int baseLine = 180;
            //1111 0000
            int expected = 240;
            int result = bs.TomsOnionShifter(baseLine);
            Assert.AreEqual<int>(result, expected);
        }

        [TestMethod()]
        public void shiftTestWithWithdraw()
        {
            //11100001
            int baseLine = 225;
            //1111 0000
            int expected = 240;
            int result = bs.shiftOneRight(baseLine);
            Assert.AreEqual<int>(result, expected);
        }
    }
}