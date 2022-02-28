using System;
using System.Collections.Generic;

namespace DecodeString
{
    public class Solution
    {
        public static string DecodedString(string s)
        {

            Stack<int> numberStack = new Stack<int>();
            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]))
                {
                    numberStack.Push((int)Char.GetNumericValue(s[i]));
                }
                else if (s[i] != ']')
                {
                    charStack.Push(s[i]);
                }
                else
                {
                    continue;
                }
            }

            string tempString = string.Empty;
            string repeatedString = string.Empty;
            int repeatedCount = 0;
            while (true)
            {
                if (repeatedCount > 1)
                {
                    tempString += repeatedString;
                    repeatedCount--;
                }
                else if (charStack.Count > 0)
                {
                    var item = charStack.Pop();
                    if (item == '[')
                    {
                        if (numberStack.Count > 0)
                        {
                            repeatedCount = numberStack.Pop();
                            repeatedString = tempString;
                        }
                        else
                        {
                            repeatedCount = 1;
                        }
                    }
                    else
                    {
                        tempString += item;
                    }
                }
                else
                {
                    char[] charArray = tempString.ToCharArray();
                    Array.Reverse(charArray);
                    return new string(charArray);
                }

            }
        }

    }
}
