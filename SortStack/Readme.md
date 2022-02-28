
# Sort Stack

Given a stack, the task is to sort it such that the top of the stack has the greatest element.
Input:
Stack: 11 2 32 3 41
Output: 41 32 11 3 2

## How to Solve
- Firstly, create new sorted stack.
- pop an element from input stack and push it to sorted stack (if there are no elements in sorted stack)
- if there are some elements in sorted stack
	* sorted > input --> switch last elements
	* sorted < input --> push input last elemnt to sorted stack