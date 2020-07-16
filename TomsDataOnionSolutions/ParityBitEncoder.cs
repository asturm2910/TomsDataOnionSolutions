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

        public string DeleteIllegalByte(string illegalEncryptedText)
        {
            IList<int> toDelete = new List<int>();
            char[] illegalEncryptedTextChar = illegalEncryptedText.ToCharArray();
            for (int i = 0; i < illegalEncryptedTextChar.Length; i++)
            {
                if (ParityBitCalculator8Bit((int) illegalEncryptedTextChar[i]) != extractParityBit(illegalEncryptedTextChar[i])) {
                    toDelete.Add(i);
                }
            }

            foreach(int index in toDelete) {
                illegalEncryptedText.Remove(index, 1);
            }
            return illegalEncryptedText;
        }

        public string ShiftText(string legalEncryptedText)
        {
            return "";
        }
        public string decodeAll(string encryptedText)
        {
            string legalEncryptedText = DeleteIllegalByte(encryptedText);
            string decryptedText = ShiftText(legalEncryptedText);
            return decryptedText;
        }
    }
}
