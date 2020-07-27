using Microsoft.VisualStudio.TestTools.UnitTesting;
using TomsDataOnionSolutions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

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

        [TestMethod()]
        public void ParityBitCalculator8BitTest()
        {
            int result = 0;
            result = pbe.ParityBitCalculator8Bit(199);
            Assert.AreEqual<int>(result, 0);
            result = pbe.ParityBitCalculator8Bit(53);
            Assert.AreEqual<int>(result, 1);
            result = pbe.ParityBitCalculator8Bit(142);
            Assert.AreEqual<int>(result, 0);
            result = pbe.ParityBitCalculator8Bit(255);
            Assert.AreEqual<int>(result, 1);
            result = pbe.ParityBitCalculator8Bit(238);
            Assert.AreEqual<int>(result, 0);
            result = pbe.ParityBitCalculator8Bit(201);
            Assert.AreEqual<int>(result, 1);
            result = pbe.ParityBitCalculator8Bit(178);
            Assert.AreEqual<int>(result, 0);

        }

        [TestMethod()]
        public void DeleteIllealByteTest()
        {
            char[] testSequence = { (char)77, (char)76, (char)80, (char)83, (char)84, (char)88 };
            string result = pbe.DeleteIllegalBytes(new string(testSequence));
            Assert.AreEqual<string>("MPS", result);
        }

        [TestMethod()]
        public void ShiftTextTest()
        {
            // 72 101 108 108 111 33
            // 01001000 01100101 01101100 01101100 01101111 00100001
            String text = "Hello";
            // 00100100 00110010 00110110 00110110 00110111 00010000
            // 36 50 54 54 55 16
            // $ 2 6 6 7 
            String expected = "$2667";
            Assert.AreEqual<string>(pbe.ShiftText(text), expected);
        }
    }
}