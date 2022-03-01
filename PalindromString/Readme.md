
# Palindrom String

Given a string S, check if it is palindrome or not
Input: S = "abba"
Output: 1

Input: S = "abc" 
Output: 0

## How to Solve
- Create stack and add every character of the string. 
- If will be added char is same top of stack pop it, else push it.
- End of the program if stack is empty it means it is a palindrom, else not a palindrom