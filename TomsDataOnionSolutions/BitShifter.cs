using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomsDataOnionSolutions
{
    public class BitShifter
    {
        
        private const int EVERY_SECOND_BIT = 85;

        public string TomsOnionShifterDecodeAll(string values)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in values) {
                char newC = (char) TomsOnionShifter((int) c);
                //Console.WriteLine($"{c} --> {newC}");
                sb.Append(newC);
            }

            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        public int TomsOnionShifter(int value)
        {
            return shiftOneRight(flip(value));
        }

        public int flip(int value)
        {
            int result = value ^ EVERY_SECOND_BIT;
            return result;
        }
 
        public int shiftOneRight(int value)
        {
            int buffer = value & 1;
            // ex: 00000001 >> 10000000
            buffer = buffer << 7;
            int newValue = value >> 1;

            // ex: 01001010 -> 1000000 | 01001010 = 11001010
            newValue = buffer | newValue;

            return newValue;
        }
    }
}
