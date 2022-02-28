
# Decoding String

An encoded string (s) is given, the task is to decode it. The pattern in which the strings were encoded were as follows
original string: abbbababbbababbbab 
encoded string : 3[a3[b]1[ab]]

## How to Solve
- Create two stacks. First for repeated counts, second for characters.
- If you detected '[' , pop the value from repeated stack and repeat the string in your hand.
- When you finish your stack, then reverse your string an return. (You can add this string in a new stack and pop values when you return it.)