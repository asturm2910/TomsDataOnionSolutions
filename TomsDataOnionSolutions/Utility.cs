using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomsDataOnionSolutions
{
    public class Utility
    {
        public static string addSystemNewLine(string decodedText)
        {
            return decodedText.Replace("\n", Environment.NewLine);
        }
    }
}
