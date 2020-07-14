using TomsDataOnionSolutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TomsDataOnionSolutions.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void decodeTubleTest()
        {
            Encoder enc = new Encoder();
            string result = enc.decodeTuble("9jqo^");
            Assert.AreEqual<string>("Man ", result);
        }

        [TestMethod()]
        public void decodeTubleTest2()
        {
            Encoder enc = new Encoder();
            string result = enc.decodeTuble("F*2M7");
            Assert.AreEqual<string>("sure", result);
        }

        [TestMethod()]
        public void fillHigValueTest1()
        {
            Encoder enc = new Encoder();
            string result = enc.fillTupelWithHighValue(@"c\");
            Assert.AreEqual<string>(@"c\uuu", result);
        }

        [TestMethod()]
        public void decodeTubleTestIncomplete()
        {
            string expected = ".";
            expected += (char)3;
            expected += (char)25;
            expected += (char)180;
            Encoder enc = new Encoder();
            string result = enc.decodeTuble("/c");
            Assert.AreEqual<string>(expected, result);

        }

        [TestMethod()]
        public void adobeDelemiterTest()
        {
            string testString = "<~TestPayLoad>HasTobeUnch~nged<!!~>";
            string expected = "TestPayLoad>HasTobeUnch~nged<!!";
            Encoder enc = new Encoder();
            string result = enc.removeAdobeDelemiter(testString);
            Assert.AreEqual<string>(expected, result);
        }


        [TestMethod()]
        public void decrompressTest()
        {
            string testString = "<~zTestPayLoad>HasTobeUnch~nged<z~>";
            string expected = "<~!!!!!TestPayLoad>HasTobeUnch~nged<!!!!!~>";
            Encoder enc = new Encoder();
            string result = enc.enlargeCompressChar(testString);
            Assert.AreEqual<string>(expected, result);
        }

        [TestMethod()]
        public void removeLineBreaksTest()
        {
            string testString = "<~z\nTestPayLoad>\n\rHasTobeUnch~nged\r<z~>";
            string expected = "<~zTestPayLoad>HasTobeUnch~nged<z~>";
            Encoder enc = new Encoder();
            string result = enc.removeLineBreaks(testString);
            Assert.AreEqual<string>(expected, result);
        }

        [TestMethod()]
        public void preparationTestCompl()
        {
            string testString = "<~z\nTestPayLoad>\n\rHasTobeUnch~nged\r<z~>";
            string expected = "!!!!!TestPayLoad>HasTobeUnch~nged<!!!!!";
            Encoder enc = new Encoder();
            string result = enc.prePreparation(testString);
            Assert.AreEqual<string>(expected, result);
        }

        [TestMethod()]
        public void fullIntegratinTest()
        {
            string expected = "Man is distinguished, not only by his reason, but by this singular passion from other animals, which is a lust of the mind, that by a perseverance of delight in the continued and indefatigable generation of knowledge, exceeds the short vehemence of any carnal pleasure.";
            string encoded = "9jqo^BlbD-BleB1DJ+*+F(f,q/0JhKF<GL>Cj@.4Gp$d7F!,L7@<6@)/0JDEF<G%<+EV:2F!,O<DJ+*.@<*K0@<6L(Df-\\0Ec5e;DffZ(EZee.Bl.9pF\"AGXBPCsi+DGm>@3BB/F*&OCAfu2/AKYi(DIb:@FD,*)+C]U=@3BN#EcYf8ATD3s@q?d$AftVqCh[NqF<G:8+EV:.+Cf>-FD5W8ARlolDIal(DId<j@<?3r@:F%a+D58'ATD4$Bl@l3De:,-DJs`8ARoFb/0JMK@qB4^F!,R<AKZ&-DfTqBG%G>uD.RTpAKYo'+CT/5+Cei#DII?(E,9)oF*2M7/c";

            Encoder enc = new Encoder();
            string result = enc.decodeAll(encoded);
            Assert.AreEqual<string>(expected, result);
        }
    }
}
