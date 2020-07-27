using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomsDataOnionSolutions
{
    public class ParityBitEncoder
    {
        public int[] BIT_MASK_ARRAY = {1,2,4,8,16,32,64,128};
        public int BinaryActiveBitCounter(int num)
        {
            int counter = 0;
            foreach(int i in BIT_MASK_ARRAY) {
                if ((i & num) > 0) {
                    counter++;
                }
            }
            return counter;
        }

        public int ParityBitCalculator(int num)
        {
            int counter = BinaryActiveBitCounter(num);
            return counter % 2;
        }

        public int ParityBitCalculator8Bit(int num)
        {
            return ParityBitCalculator(deleteParity(num));
        }

        public int extractParityBit(int num)
        {
            return (num & 1);
        }

        public int deleteParity(int num)
        {
            return num >> 1;
        }

        public string DeleteIllegalBytes(string illegalEncryptedText)
        {
            StringBuilder result = new StringBuilder();
            var legalCharEnumeration = illegalEncryptedText.Where<char>(c => compareParity((int)c));
            foreach (char c in legalCharEnumeration)
            {
                result.Append(c);
            }

            return result.ToString();
        }

        public bool compareParity(int i)
        {
            return ParityBitCalculator8Bit(i) == extractParityBit(i);
        }

        public string ShiftText(string legalEncryptedText)
        {
            StringBuilder result = new StringBuilder();
            foreach(char c in legalEncryptedText) {
                result.Append((char)deleteParity((int)c));
            }
            return result.ToString();
        }
        public string decodeAll(string encryptedText)
        {
            return ShiftText(DeleteIllegalBytes(encryptedText));
        }
    }
}
