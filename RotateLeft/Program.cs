using System;
using System.Collections.Generic;

namespace RotateLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            var rotatedList = Solution.RotLeft(list, 1);

            foreach (var item in rotatedList)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
