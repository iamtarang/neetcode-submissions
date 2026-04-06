public class Solution {
    public bool IsValid(string s) {
        char[] stackS = s.ToCharArray();
        Stack<char> stack = new Stack<char>();

        foreach(var c in stackS) {
            if (stack.Count != 0) {
                if (c.ToString() == "]" && stack.Peek().ToString() == "[") {
                    stack.Pop();
                }
                else if (c.ToString() == "}" && stack.Peek().ToString() == "{") {
                    stack.Pop();
                }
                else if (c.ToString() == ")" && stack.Peek().ToString() == "(") {
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
