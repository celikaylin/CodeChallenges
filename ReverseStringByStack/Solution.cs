using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseStringByStack
{
    public class Solution
    {
        public static String Reverse(String S)
        {
            Stack<char> reversed = new Stack<char>();
            string reversedString = "";
            for (int i = 0; i < S.Length; i++)
            {
                reversed.Push(S[i]);
            }

            while(reversed.Count> 0)
            {
                reversedString += reversed.Pop();
            }

            return reversedString;


        }
    }
}
