using System;
using System.Collections.Generic;

namespace SortStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(1);
            stack.Push(7);
            stack.Push(2);
            stack.Push(10);


            var result = Solution.Sort(stack);

            while (result.Count > 0)
            {
                Console.WriteLine(result.Pop());
            }
            
            Console.ReadLine();
        }
    }
}
