using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomsDataOnionSolutions
{
    public class Encoder
    {
        public String decodeAll(string encryptedText)
        {
            encryptedText = prePreparation(encryptedText);
            int textLength = encryptedText.Length;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < textLength; i=i+5) {
                int nextChars = 5;
                if (textLength < i+5)
                {
                    nextChars = encryptedText.Length - i;
                }
                string nextTupel = encryptedText.Substring(i, nextChars);
                //Console.WriteLine($"Iteration: {i}, length: {nextChars}, tupel: {nextTupel}");
                sb.Append(decodeTuble(nextTupel));
            }

            int ignore = charsToIgnore(encryptedText);
            if (ignore != 0) {
                sb.Remove(sb.Length - 1 - ignore, ignore+1);
            }

            return sb.ToString();
        }

        public String decodeTuble(String encryptedTupel)
        {
            if (encryptedTupel.Length < 5)
            {
                encryptedTupel = fillTupelWithHighValue(encryptedTupel);
            }
            const byte offset = 33;

            uint decryptedNumber = 0;
            char[] encryptedChar = encryptedTupel.ToCharArray();
            for (int i = 0; i < encryptedChar.Length; i++)
            {
                encryptedChar[i] -= (char) offset;
                decryptedNumber += (uint) (((int) encryptedChar[i]) * Math.Pow(85, (4 - i)));
            }
            Console.WriteLine($"DecryptedNumber: {decryptedNumber}");

            char[] resultArray = new char[4];
            for (int i = 0; i < resultArray.Length; i++)
            {
                uint b = (decryptedNumber >> (32 - (8 * (i + 1)))) & 255;
                resultArray[i] = (char) b;
            }

            return new string(resultArray);
        }

        public string fillTupelWithHighValue(string input)
        {
            string result = input;
            int missing = 5 - result.Length;
            for (int i = 0; i < missing; i++)
            {
                result += "u";
            }

            return result;
        }

        public int charsToIgnore(string encoded)
        {
            return encoded.Length % 5;   
        }

        public string prePreparation(string encryptedText)
        {
            return removeLineBreaks(enlargeCompressChar(removeAdobeDelemiter(encryptedText)));
        }

        public string removeAdobeDelemiter(string encodedText)
        {
            return encodedText.Replace("<~", "").Replace("~>", "");
        }

        public string enlargeCompressChar(string encodedText)
        {
            return encodedText.Replace("z", "!!!!!");        
        }

        public string removeLineBreaks(string encodedText) {

            return encodedText.Replace("\r", "").Replace("\n", "");
        }
    }
}
