using System;
using System.Collections.Generic;
using System.Text;

namespace Top.Schema.Util
{
    public class StringUtil
    {
        public static bool IsEmpty(string str)
        {
            if (str == null || str.Trim().Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetByteLenth(string tempvalue)
        {
            int sum = 0;
            for (int i = 0; i < tempvalue.Length; i++)
            {
                char[] tempchars = tempvalue.ToCharArray();
                if ((tempchars[i] >= 0) && (tempchars[i] <= 255))
                    sum = sum + 1;
                else
                    sum = sum + 2;
            }
            return sum;
        }
    }
}
