using System;
using System.Collections.Generic;
using System.Text;

namespace SortStack
{
    public class Solution
    {
        public static Stack<int> Sort(Stack<int> s)
        {
            Stack<int> sortedStack = new Stack<int>();
            int item = 0;
            int sortedMaxValue = 0;
            bool continueCheck = false;

            while(s.Count > 0)
            {
                if(!continueCheck)
                {
                    item = s.Pop();
                }

                if (sortedStack.Count > 0)
                {
                    sortedMaxValue = sortedStack.Peek();

                    if(sortedMaxValue > item)
                    {
                        s.Push(sortedStack.Pop());
                        continueCheck = true;
                    }
                    else
                    {
                        continueCheck = false;
                        sortedStack.Push(item);
                    }
                }
                else
                {
                    sortedStack.Push(item);
                    continueCheck = false;

                }
            }

            return sortedStack;
        }
    }
}
