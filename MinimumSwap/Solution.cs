using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinimumSwap
{
    public class Solution
    {
        public static int MinimumSwaps(int[] arr)
        {
            int swapCount = 0;

            List<KeyValuePair<int, int>> sortedList = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                sortedList.Add(new KeyValuePair<int,int>(arr[i],i));
            }

            sortedList = sortedList.OrderBy(x => x.Key).ToList();

            KeyValuePair<int,int> temp;
            int verticeIndex = 0;

            for (int i = 0; i < sortedList.Count; )
            {
                verticeIndex = sortedList[i].Value;

                if(verticeIndex != i)
                {
                    temp = sortedList[i];
                    sortedList[i] = sortedList[verticeIndex];
                    sortedList[verticeIndex] = temp;
                    swapCount++;
                }

                if(sortedList[i].Value == i)
                {
                    i++;
                }
            }

            return swapCount;


        }
    }
}
