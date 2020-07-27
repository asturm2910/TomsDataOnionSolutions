using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomsDataOnionSolutions
{
    public class DisplayHelper
    {
        public static int[] POWER_OF_TWO = { 128, 64, 32, 16, 8, 4, 2, 1 };
        public static IList<string> ChangeToBinary(string origin)
        {
            IList<string> result = new List<string>();
           
            foreach(char c in origin) 
            //for (int counter = origin.Length - 1; counter >= 0; counter--)
            {
                //char c = origin[counter];
                StringBuilder sb = new StringBuilder();
                if (c == '\r' || c == '\n')
                {
                    sb.Append(c);
                }
                else
                {
                    int i = (int)c;
                    foreach (int power in POWER_OF_TWO)
                    {
                        if ((i & power) == power)
                        {
                            sb.Append("1");
                        }
                        else
                        {
                            sb.Append("0");
                        }
                    }
                }
                    result.Add(sb.ToString());
            }
            return result;
        }

        public static string ChangeToBinaryString(string origin)
        {
            IList<string> list = DisplayHelper.ChangeToBinary(origin);
            StringBuilder sb = new StringBuilder();
            foreach (string s in list)
            {
                sb.Append(s);
                sb.Append(" ");
            }

            return sb.ToString().Trim();
        }
    }

}

