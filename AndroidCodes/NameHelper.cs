using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidCodes
{
    public static class NameHelper
    {
        public static string Replace_xWithX(string input)
        {
            input = input.Trim();
            input = input.Replace("_a", "A");
            input = input.Replace("_b", "B");
            input = input.Replace("_c", "C");
            input = input.Replace("_d", "D");
            input = input.Replace("_e", "E");
            input = input.Replace("_f", "F");
            input = input.Replace("_g", "G");
            input = input.Replace("_h", "H");
            input = input.Replace("_i", "I");
            input = input.Replace("_j", "J");
            input = input.Replace("_k", "K");
            input = input.Replace("_l", "L");
            input = input.Replace("_m", "M");
            input = input.Replace("_n", "N");
            input = input.Replace("_o", "O");
            input = input.Replace("_p", "P");
            input = input.Replace("_q", "Q");
            input = input.Replace("_r", "R");
            input = input.Replace("_s", "S");
            input = input.Replace("_t", "T");
            input = input.Replace("_u", "U");
            input = input.Replace("_v", "V");
            input = input.Replace("_w", "W");
            input = input.Replace("_x", "X");
            input = input.Replace("_y", "Y");
            input = input.Replace("_z", "Z");
            input = input.Replace("_0", "0");
            input = input.Replace("_1", "1");
            input = input.Replace("_2", "2");
            input = input.Replace("_3", "3");
            input = input.Replace("_4", "4");
            input = input.Replace("_5", "5");
            input = input.Replace("_6", "6");
            input = input.Replace("_7", "7");
            input = input.Replace("_8", "8");
            input = input.Replace("_9", "9");
            return input;
        }

        public static string XiaoTuoFeng(string input)
        {
            if (input.Length > 0)
            {
                string startChar = input[0].ToString().ToLower();
                string subString = Replace_xWithX(input.Substring(1));
                return startChar + subString;
            }
            return "";
        }

        public static string DaTuoFeng(string input)
        {
            if (input.Length > 0)
            {
                string startChar = input[0].ToString().ToUpper();
                string subString = Replace_xWithX(input.Substring(1));
                return startChar + subString;
            }
            return "";
        }

        public static string SimpleClassName(string fullName)
        {
            int index = fullName.LastIndexOf('.');
            if (index >= 0)
                return fullName.Substring(index + 1);
            else
                return fullName;
        }
    }
}
