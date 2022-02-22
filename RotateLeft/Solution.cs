using System.Collections.Generic;

namespace RotateLeft
{
    public class Solution
    {
        public static List<int> RotLeft(List<int> a, int d)
        {
            int n = a.Count;

            int[] newArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                newArr[(i - d) < 0 ? n + (i - d) : (i - d)] = a[i];
            }

            a.Clear();

            for (int i = 0; i < n; i++)
            {
                a.Add(newArr[i]);
            }

            return a;

        }
    }
}
