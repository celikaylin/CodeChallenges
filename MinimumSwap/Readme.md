
# Minimum Swap

You are given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates. You are allowed to swap any two elements. Find the minimum number of swaps required to sort the array in ascending order.

## How to Solve
- Create a key (array value), value (array index) list.
- Sort this list 
- Check if pairs' value is same with it is in. If it is not same increment swap count and replace with the correct index pair. If it is same skip another pair.
