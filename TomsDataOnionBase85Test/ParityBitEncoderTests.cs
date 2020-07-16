using Microsoft.VisualStudio.TestTools.UnitTesting;
using TomsDataOnionSolutions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TomsDataOnionSolutions.Tests
{
    [TestClass()]
    public class ParityBitEncoderTests
    {
        ParityBitEncoder pbe = new ParityBitEncoder();

        [TestMethod()]
        public void BinaryActiveBitCounterTest()
        {
            int result = 0;
            result = pbe.BinaryActiveBitCounter(77);
            Assert.AreEqual<int>(result, 4);
            result = pbe.BinaryActiveBitCounter(49);
            Assert.AreEqual<int>(result, 3);
            result = pbe.BinaryActiveBitCounter(115);
            Assert.AreEqual<int>(result, 5);
            result = pbe.BinaryActiveBitCounter(9);
            Assert.AreEqual<int>(result, 2);
            result = pbe.BinaryActiveBitCounter(1);
            Assert.AreEqual<int>(result, 1);
            result = pbe.BinaryActiveBitCounter(2);
            Assert.AreEqual<int>(result, 1);
            result = pbe.BinaryActiveBitCounter(4);
            Assert.AreEqual<int>(result, 1);
            result = pbe.BinaryActiveBitCounter(8);
            Assert.AreEqual<int>(result, 1);
            result = pbe.BinaryActiveBitCounter(16);
            Assert.AreEqual<int>(result, 1);
            result = pbe.BinaryActiveBitCounter(32);
            Assert.AreEqual<int>(result, 1);
            result = pbe.BinaryActiveBitCounter(64);
            Assert.AreEqual<int>(result, 1);
            result = pbe.BinaryActiveBitCounter(0);
            Assert.AreEqual<int>(result, 0);
            result = pbe.BinaryActiveBitCounter(127);
            Assert.AreEqual<int>(result, 7);
        }

        [TestMethod()]
        public void ParityBitCalculatorTest()
        {
            int result = 0;
            result = pbe.ParityBitCalculator(127);
            Assert.AreEqual<int>(result, 1);
            result = pbe.ParityBitCalculator(0);
            Assert.AreEqual<int>(result, 0);
            result = pbe.ParityBitCalculator(1);
            Assert.AreEqual<int>(result, 1);
            result = pbe.ParityBitCalculator(2);
            Assert.AreEqual<int>(result, 1);
            result = pbe.ParityBitCalculator(3);
            Assert.AreEqual<int>(result, 0);
            result = pbe.ParityBitCalculator(4);
            Assert.AreEqual<int>(result, 1);
            result = pbe.ParityBitCalculator(99);
            Assert.AreEqual<int>(result, 0);
            result = pbe.ParityBitCalculator(103);
            Assert.AreEqual<int>(result, 1);
            result = pbe.ParityBitCalculator(23);
            Assert.AreEqual<int>(result, 0);
            result = pbe.ParityBitCalculator(39);
            Assert.AreEqual<int>(result, 0);
            result = pbe.ParityBitCalculator(5);
            Assert.AreEqual<int>(result, 0);
        }
    }
}