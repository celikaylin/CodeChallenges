using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromString
{
    public class Solution
    {
        public static int IsPalindrome(String S)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var item in S)
            {
                if(stack.Count > 0)
                {
                    if(item == stack.Peek())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(item);
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }

            if(stack.Count > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
