using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Oct22
{
    static class TitleCase
    {
        public static string ToTitleCase(this string str)
        {
            string lowerCase = str.ToLower();
            char ch = ' ';
            string result = "";

            for (int i = 0; i < lowerCase.Length; i++)
            {
                if (ch == ' ' && lowerCase[i] != ' ')
                {
                    result = string.Concat(result, char.ToUpper(lowerCase[i]));
                }
                else
                    result = string.Concat(result, lowerCase[i]);
                ch = lowerCase[i];
            }

            return result.Trim();
        }
    }
}
