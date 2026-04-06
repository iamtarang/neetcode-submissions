public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s) {
            if (stack.Count != 0) {
                if (c == ']' && stack.Peek() == '[') {
                    stack.Pop();
                }
                else if (c == '}' && stack.Peek() == '{') {
                    stack.Pop();
                }
                else if (c == ')' && stack.Peek() == '(') {
                    stack.Pop();
                }
                else {
                    stack.Push(c);
                }
            } 
            else {
                stack.Push(c);
            }
        }

        if(stack.Count != 0){
            return false;
        }

        return true;
    }
}
