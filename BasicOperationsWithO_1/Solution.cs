using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicOperationsWithO_1
{
    public class Solution
    {
        private Dictionary<int, int> dict = new Dictionary<int, int>();
        private ArrayList arrayList = new ArrayList();
        private readonly Random random = new Random();


        public void Add(int item)
        {
            if(dict.ContainsKey(item))
            {
                return;
            }

            dict.Add(item, dict.Count);
            
            arrayList.Add(item);
        }

        public void Delete(int item)
        {
            if (!dict.ContainsKey(item))
            {
                return;
            }

            var index = dict[item];

            dict[(int)arrayList[arrayList.Count - 1]] = index;
            dict.Remove(item);

            arrayList[index] = arrayList[arrayList.Count - 1];
            arrayList.RemoveAt(arrayList.Count -1);

        }

        public int GetRandom()
        {
            int index = random.Next(arrayList.Count);
            int value = (int)arrayList[index];

            return value;
        }
    }
}
